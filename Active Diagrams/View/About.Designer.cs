namespace Active_Diagrams.View
{
    partial class About
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
            this.ehAbouy = new System.Windows.Forms.Integration.ElementHost();
            this.ucAbout = new Active_Diagrams.ucAbout();
            this.SuspendLayout();
            // 
            // ehAbouy
            // 
            this.ehAbouy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ehAbouy.Location = new System.Drawing.Point(0, 0);
            this.ehAbouy.Name = "ehAbouy";
            this.ehAbouy.Size = new System.Drawing.Size(406, 471);
            this.ehAbouy.TabIndex = 0;
            this.ehAbouy.Text = "elementHost1";
            this.ehAbouy.Child = this.ucAbout;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 471);
            this.Controls.Add(this.ehAbouy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Active Diagrams";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost ehAbouy;
        private ucAbout ucAbout;
    }
}