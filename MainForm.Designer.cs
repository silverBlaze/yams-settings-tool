namespace YAMSDatabaseSettings {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gvSettings = new System.Windows.Forms.DataGridView();
            this.ddlTable = new System.Windows.Forms.ComboBox();
            this.pnlBtns = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.ddlServer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlServer = new System.Windows.Forms.Panel();
            this.btnTableSettings = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvSettings)).BeginInit();
            this.pnlBtns.SuspendLayout();
            this.pnlServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvSettings
            // 
            this.gvSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSettings.Location = new System.Drawing.Point(12, 123);
            this.gvSettings.Name = "gvSettings";
            this.gvSettings.ShowCellErrors = false;
            this.gvSettings.Size = new System.Drawing.Size(316, 507);
            this.gvSettings.TabIndex = 0;
            this.gvSettings.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSettings_CellValueChanged);
            this.gvSettings.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gvSettings_DataBindingComplete);
            this.gvSettings.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.gvSettings_UserDeletingRow);
            // 
            // ddlTable
            // 
            this.ddlTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTable.FormattingEnabled = true;
            this.ddlTable.Items.AddRange(new object[] {
            "YAMS Settings",
            "Server Settings"});
            this.ddlTable.Location = new System.Drawing.Point(12, 31);
            this.ddlTable.Name = "ddlTable";
            this.ddlTable.Size = new System.Drawing.Size(316, 21);
            this.ddlTable.TabIndex = 1;
            this.ddlTable.SelectedIndexChanged += new System.EventHandler(this.ddlTable_SelectedIndexChanged);
            // 
            // pnlBtns
            // 
            this.pnlBtns.Controls.Add(this.btnSave);
            this.pnlBtns.Controls.Add(this.btnUndo);
            this.pnlBtns.Enabled = false;
            this.pnlBtns.Location = new System.Drawing.Point(13, 637);
            this.pnlBtns.Name = "pnlBtns";
            this.pnlBtns.Size = new System.Drawing.Size(315, 54);
            this.pnlBtns.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(112, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(4, 4);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(102, 23);
            this.btnUndo.TabIndex = 0;
            this.btnUndo.Text = "Undo Changes";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // ddlServer
            // 
            this.ddlServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlServer.FormattingEnabled = true;
            this.ddlServer.Location = new System.Drawing.Point(0, 20);
            this.ddlServer.Name = "ddlServer";
            this.ddlServer.Size = new System.Drawing.Size(153, 21);
            this.ddlServer.TabIndex = 3;
            this.ddlServer.SelectedIndexChanged += new System.EventHandler(this.ddlServer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Database Table:";
            // 
            // pnlServer
            // 
            this.pnlServer.Controls.Add(this.btnTableSettings);
            this.pnlServer.Controls.Add(this.ddlServer);
            this.pnlServer.Controls.Add(this.label2);
            this.pnlServer.Location = new System.Drawing.Point(12, 53);
            this.pnlServer.Name = "pnlServer";
            this.pnlServer.Size = new System.Drawing.Size(316, 51);
            this.pnlServer.TabIndex = 5;
            this.pnlServer.Visible = false;
            // 
            // btnTableSettings
            // 
            this.btnTableSettings.Location = new System.Drawing.Point(160, 19);
            this.btnTableSettings.Name = "btnTableSettings";
            this.btnTableSettings.Size = new System.Drawing.Size(156, 23);
            this.btnTableSettings.TabIndex = 5;
            this.btnTableSettings.Text = "Table Settings";
            this.btnTableSettings.UseVisualStyleBackColor = true;
            this.btnTableSettings.Click += new System.EventHandler(this.btnTableSettings_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Server:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Configuration Settings:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 703);
            this.Controls.Add(this.pnlServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlBtns);
            this.Controls.Add(this.ddlTable);
            this.Controls.Add(this.gvSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YAMS Database Settings Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvSettings)).EndInit();
            this.pnlBtns.ResumeLayout(false);
            this.pnlServer.ResumeLayout(false);
            this.pnlServer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvSettings;
        private System.Windows.Forms.ComboBox ddlTable;
        private System.Windows.Forms.Panel pnlBtns;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox ddlServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTableSettings;
        private System.Windows.Forms.Label label3;
    }
}

