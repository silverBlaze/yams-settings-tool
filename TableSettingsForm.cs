using System;
using System.Configuration;
using System.Windows.Forms;

namespace YAMSDatabaseSettings {
    public partial class TableSettingsForm : Form {

        private bool changed = false;
        private bool loading = false;
        private YamsData Data { get; set; }

        public int ServerId { get; set; }

        public TableSettingsForm() {
            InitializeComponent();
        }

        private void TableSettingsForm_Load(object sender, EventArgs e) {
            Data = new YamsData(ConfigurationManager.ConnectionStrings["YAMSDatabaseFile"].ConnectionString);
            loading = true;
            try {
                PopulateWithData(Data.GetServerTableData(ServerId));
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            loading = false;
        }

        private void PopulateWithData(TableSettingsData tableData) {
            txtServerID.Text = tableData.ServerID.ToString();
            txtServerTitle.Text = tableData.ServerTitle;
            txtServerWrapperMode.Text = tableData.ServerWrapperMode;
            txtServerEnableOptimizations.Text = tableData.ServerEnableOptimisations;
            txtServerAssignedMemory.Text = tableData.ServerAssignedMemory;
            txtServerAutostart.Text = tableData.ServerAutostart;
            txtServerType.Text = tableData.ServerType;
            txtServerLogonMode.Text = tableData.ServerLogonMode;
            txtServerCustomJAR.Text = tableData.ServerCustomJar;
            txtServerWebBody.Text = tableData.ServerWebBody;
        }

        private void TableSettingsForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (changed) {
                var msg = MessageBox.Show("You will lose all Table Settings changes you haven't saved. Are you sure?", "Close Table Settings?", MessageBoxButtons.YesNo);
                e.Cancel = (msg == DialogResult.No);
            }
        }

        private void AllTextboxes_OnTextChanged(object sender, EventArgs e) {
            if (!loading) {
                if (!changed)
                    this.Text = this.Text + " *";
                changed = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (changed) {
                try {
                    Data.UpdateServerTableData(ServerId, new TableSettingsData() {
                        ServerID = ServerId,
                        ServerTitle = !string.IsNullOrEmpty(txtServerTitle.Text) ? txtServerTitle.Text : null,
                        ServerWrapperMode = !string.IsNullOrEmpty(txtServerWrapperMode.Text) ? txtServerWrapperMode.Text : null,
                        ServerEnableOptimisations = !string.IsNullOrEmpty(txtServerEnableOptimizations.Text) ? txtServerEnableOptimizations.Text : null,
                        ServerAssignedMemory = !string.IsNullOrEmpty(txtServerAssignedMemory.Text) ? txtServerAssignedMemory.Text : null,
                        ServerAutostart = !string.IsNullOrEmpty(txtServerAutostart.Text) ? txtServerAutostart.Text : null,
                        ServerType = !string.IsNullOrEmpty(txtServerType.Text) ? txtServerType.Text : null,
                        ServerLogonMode = !string.IsNullOrEmpty(txtServerLogonMode.Text) ? txtServerLogonMode.Text : null,
                        ServerCustomJar = !string.IsNullOrEmpty(txtServerCustomJAR.Text) ? txtServerCustomJAR.Text : null,
                        ServerWebBody = !string.IsNullOrEmpty(txtServerWebBody.Text) ? txtServerWebBody.Text : null
                    });
                    changed = false;
                    this.Close();
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
