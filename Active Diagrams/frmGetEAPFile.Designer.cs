namespace Active_Diagrams
{
    partial class frmGetEAPFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblEnterEARepository = new System.Windows.Forms.Label();
            this.cbEARepository = new System.Windows.Forms.ComboBox();
            this.btnGetFile = new System.Windows.Forms.Button();
            this.ofdEAP = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(316, 83);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(424, 83);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblEnterEARepository
            // 
            this.lblEnterEARepository.AutoSize = true;
            this.lblEnterEARepository.Location = new System.Drawing.Point(45, 11);
            this.lblEnterEARepository.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterEARepository.Name = "lblEnterEARepository";
            this.lblEnterEARepository.Size = new System.Drawing.Size(246, 17);
            this.lblEnterEARepository.TabIndex = 3;
            this.lblEnterEARepository.Text = "Enter Enterprise Architect Repository:";
            // 
            // cbEARepository
            // 
            this.cbEARepository.FormattingEnabled = true;
            this.cbEARepository.Location = new System.Drawing.Point(48, 41);
            this.cbEARepository.Name = "cbEARepository";
            this.cbEARepository.Size = new System.Drawing.Size(438, 24);
            this.cbEARepository.TabIndex = 0;
            this.cbEARepository.TextChanged += new System.EventHandler(this.cbEARepository_TextChanged);
            // 
            // btnGetFile
            // 
            this.btnGetFile.Location = new System.Drawing.Point(492, 40);
            this.btnGetFile.Name = "btnGetFile";
            this.btnGetFile.Size = new System.Drawing.Size(32, 24);
            this.btnGetFile.TabIndex = 1;
            this.btnGetFile.Text = "...";
            this.btnGetFile.UseVisualStyleBackColor = true;
            this.btnGetFile.Click += new System.EventHandler(this.btnGetFile_Click);
            // 
            // ofdEAP
            // 
            this.ofdEAP.DefaultExt = "*.eap";
            this.ofdEAP.Filter = "Sparx EA Repository|*.eap|All files|*.*";
            this.ofdEAP.Title = "Select Sparx Enterprise Architect Repository";
            // 
            // frmGetEAPFile
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(557, 135);
            this.Controls.Add(this.btnGetFile);
            this.Controls.Add(this.cbEARepository);
            this.Controls.Add(this.lblEnterEARepository);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGetEAPFile";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enterprise Architect File";
            this.Load += new System.EventHandler(this.frmGetEAPFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblEnterEARepository;
        private System.Windows.Forms.ComboBox cbEARepository;
        private System.Windows.Forms.Button btnGetFile;
        private System.Windows.Forms.OpenFileDialog ofdEAP;
    }
}