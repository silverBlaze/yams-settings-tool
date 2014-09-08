using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace YAMSDatabaseSettings {
    public partial class MainForm : Form {

        private Dictionary<string, string> toEdit;
        private Dictionary<string, int> toRemove;
        private DataTable dtSettings = null;
        private YamsData Data { get; set; }

        public MainForm() {
            InitializeComponent();
            gvSettings.AllowUserToAddRows = false; //v1 won't support adding records, only updating them
            toEdit = new Dictionary<string,string>();
            toRemove = new Dictionary<string, int>();
            this.Disposed += new EventHandler(MainForm_Disposed);
        }

        void MainForm_Disposed(object sender, EventArgs e) {
            if (dtSettings != null)
                dtSettings.Dispose();
            if (Data != null)
                Data.Dispose();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            dtSettings = new DataTable();
            dtSettings.Columns.AddRange(new DataColumn[] { 
                new DataColumn("SettingName"), 
                new DataColumn("SettingValue") 
            });
            try {
                Data = new YamsData(ConfigurationManager.ConnectionStrings["YAMSDatabaseFile"].ConnectionString);
                Data.LoadServerList(ddlServer);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                this.Close();
            }
            ddlTable.SelectedIndex = 0;
            RefreshSettingsView();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (pnlBtns.Enabled) {
                var msg = MessageBox.Show("You will lose all configuration changes you haven't saved. Are you sure?", "Close Editor?", MessageBoxButtons.YesNo);
                e.Cancel = (msg == DialogResult.No);
            }
        }

        private void gvSettings_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) {
            string key = e.Row.Cells[0].Value.ToString();
            if(!toRemove.ContainsKey(key)) {
                bool yamsSettings = (ddlTable.SelectedIndex == 0);
                if (yamsSettings) {
                    toRemove.Add(key, 0);
                } else {
                    int serverId = (ddlServer.SelectedItem as ServerListItem).ID;
                    toRemove.Add(key, serverId);
                }
            }
            pnlBtns.Enabled = true;
        }

        private void gvSettings_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            gvSettings.Columns[0].ReadOnly = true; //turn off first column's editing
            gvSettings.Columns[0].Width = 120;
            gvSettings.Columns[1].Width = 135;
        }

        private void gvSettings_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            var myRow = gvSettings.Rows[e.RowIndex];
            string key = myRow.Cells[0].Value.ToString();
            string value = myRow.Cells[1].Value.ToString();
            bool yamsSettings = (ddlTable.SelectedIndex == 0);
            if (yamsSettings) {
                toEdit[key] = value;
            } else {
                int serverId = (ddlServer.SelectedItem as ServerListItem).ID;
                toEdit[key] = string.Format("{0}`{1}", value, serverId);
            }
            pnlBtns.Enabled = true;
        }

        private void btnUndo_Click(object sender, EventArgs e) {
            RefreshSettingsView();
            toEdit.Clear();
            toRemove.Clear();
            pnlBtns.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            bool yamsSettings = (ddlTable.SelectedIndex == 0);
            try {
                foreach (var edit in toEdit) {
                    if (yamsSettings) {
                        Data.UpdateYamsSetting(edit.Key, edit.Value);
                    } else {
                        var split = edit.Value.Split(new char[] { '`' });
                        string value = split[0];
                        int serverId = 0;
                        int.TryParse(split[1], out serverId);
                        Data.UpdateServerSetting(edit.Key, value, serverId);
                    }
                }

                foreach (var remove in toRemove) {
                    if (yamsSettings) {
                        Data.DeleteYamsSetting(remove.Key);
                    } else {
                        Data.DeleteServerSetting(remove.Key, remove.Value);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            RefreshSettingsView();
            toEdit.Clear();
            toRemove.Clear();
            pnlBtns.Enabled = false;
        }

        private void ddlTable_SelectedIndexChanged(object sender, EventArgs e) {
            ddlServer.SelectedIndex = 0;
            RefreshSettingsView();
            toEdit.Clear();
            toRemove.Clear();
            pnlBtns.Enabled = false;
        }

        private void ddlServer_SelectedIndexChanged(object sender, EventArgs e) {
            RefreshSettingsView();
            toEdit.Clear();
            toRemove.Clear();
            pnlBtns.Enabled = false;
        }

        private void btnTableSettings_Click(object sender, EventArgs e) {
            TableSettingsForm form = new TableSettingsForm();
            form.ServerId = (ddlServer.SelectedItem as ServerListItem).ID;
            form.ShowDialog();
        }

        private void RefreshSettingsView() {
            bool yamsSettings = (ddlTable.SelectedIndex == 0);
            try {
                if (yamsSettings) {
                    Data.GetYamsSettingsData(dtSettings);
                } else {
                    int serverId = (ddlServer.SelectedItem as ServerListItem).ID;
                    Data.GetServerSettingsData(dtSettings, serverId);
                }
                gvSettings.DataSource = dtSettings;
                pnlServer.Visible = !yamsSettings;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
