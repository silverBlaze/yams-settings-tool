namespace YAMSDatabaseSettings {
    partial class TableSettingsForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableSettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServerWrapperMode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServerEnableOptimizations = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtServerAssignedMemory = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtServerAutostart = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtServerType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtServerLogonMode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtServerCustomJAR = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtServerWebBody = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ServerID";
            // 
            // txtServerID
            // 
            this.txtServerID.Location = new System.Drawing.Point(159, 6);
            this.txtServerID.Name = "txtServerID";
            this.txtServerID.ReadOnly = true;
            this.txtServerID.Size = new System.Drawing.Size(176, 20);
            this.txtServerID.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ServerTitle";
            // 
            // txtServerTitle
            // 
            this.txtServerTitle.Location = new System.Drawing.Point(159, 32);
            this.txtServerTitle.Name = "txtServerTitle";
            this.txtServerTitle.Size = new System.Drawing.Size(176, 20);
            this.txtServerTitle.TabIndex = 1;
            this.txtServerTitle.TextChanged += new System.EventHandler(this.AllTextboxes_OnTextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ServerWrapperMode";
            // 
            // txtServerWrapperMode
            // 
            this.txtServerWrapperMode.Location = new System.Drawing.Point(159, 58);
            this.txtServerWrapperMode.Name = "txtServerWrapperMode";
            this.txtServerWrapperMode.Size = new System.Drawing.Size(176, 20);
            this.txtServerWrapperMode.TabIndex = 2;
            this.txtServerWrapperMode.TextChanged += new System.EventHandler(this.AllTextboxes_OnTextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ServerEnableOptimisations";
            // 
            // txtServerEnableOptimizations
            // 
            this.txtServerEnableOptimizations.Location = new System.Drawing.Point(159, 84);
            this.txtServerEnableOptimizations.Name = "txtServerEnableOptimizations";
            this.txtServerEnableOptimizations.Size = new System.Drawing.Size(176, 20);
            this.txtServerEnableOptimizations.TabIndex = 3;
            this.txtServerEnableOptimizations.TextChanged += new System.EventHandler(this.AllTextboxes_OnTextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ServerAssignedMemory";
            // 
            // txtServerAssignedMemory
            // 
            this.txtServerAssignedMemory.Location = new System.Drawing.Point(159, 110);
            this.txtServerAssignedMemory.Name = "txtServerAssignedMemory";
            this.txtServerAssignedMemory.Size = new System.Drawing.Size(176, 20);
            this.txtServerAssignedMemory.TabIndex = 4;
            this.txtServerAssignedMemory.TextChanged += new System.EventHandler(this.AllTextboxes_OnTextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ServerAutostart";
            // 
            // txtServerAutostart
            // 
            this.txtServerAutostart.Location = new System.Drawing.Point(159, 136);
            this.txtServerAutostart.Name = "txtServerAutostart";
            this.txtServerAutostart.Size = new System.Drawing.Size(176, 20);
            this.txtServerAutostart.TabIndex = 5;
            this.txtServerAutostart.TextChanged += new System.EventHandler(this.AllTextboxes_OnTextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "ServerType";
            // 
            // txtServerType
            // 
            this.txtServerType.Location = new System.Drawing.Point(159, 162);
            this.txtServerType.Name = "txtServerType";
            this.txtServerType.Size = new System.Drawing.Size(176, 20);
            this.txtServerType.TabIndex = 6;
            this.txtServerType.TextChanged += new System.EventHandler(this.AllTextboxes_OnTextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "ServerLogonMode";
            // 
            // txtServerLogonMode
            // 
            this.txtServerLogonMode.Location = new System.Drawing.Point(159, 188);
            this.txtServerLogonMode.Name = "txtServerLogonMode";
            this.txtServerLogonMode.Size = new System.Drawing.Size(176, 20);
            this.txtServerLogonMode.TabIndex = 7;
            this.txtServerLogonMode.TextChanged += new System.EventHandler(this.AllTextboxes_OnTextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "ServerCustomJAR";
            // 
            // txtServerCustomJAR
            // 
            this.txtServerCustomJAR.Location = new System.Drawing.Point(159, 214);
            this.txtServerCustomJAR.Name = "txtServerCustomJAR";
            this.txtServerCustomJAR.Size = new System.Drawing.Size(176, 20);
            this.txtServerCustomJAR.TabIndex = 8;
            this.txtServerCustomJAR.TextChanged += new System.EventHandler(this.AllTextboxes_OnTextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(68, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "ServerWebBody";
            // 
            // txtServerWebBody
            // 
            this.txtServerWebBody.Location = new System.Drawing.Point(159, 240);
            this.txtServerWebBody.Name = "txtServerWebBody";
            this.txtServerWebBody.Size = new System.Drawing.Size(176, 20);
            this.txtServerWebBody.TabIndex = 9;
            this.txtServerWebBody.TextChanged += new System.EventHandler(this.AllTextboxes_OnTextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(13, 280);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(267, 280);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TableSettingsForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(354, 319);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtServerWebBody);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtServerCustomJAR);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtServerLogonMode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtServerType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtServerAutostart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtServerAssignedMemory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtServerEnableOptimizations);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtServerWrapperMode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtServerTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServerID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TableSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Server Table Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TableSettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.TableSettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServerTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServerWrapperMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServerEnableOptimizations;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtServerAssignedMemory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtServerAutostart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtServerType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtServerLogonMode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtServerCustomJAR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtServerWebBody;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}