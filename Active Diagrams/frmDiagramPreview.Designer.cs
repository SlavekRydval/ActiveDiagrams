namespace Active_Diagrams
{
    partial class frmDiagramPreview
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
            this.Diagram = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Diagram)).BeginInit();
            this.SuspendLayout();
            // 
            // Diagram
            // 
            this.Diagram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Diagram.Location = new System.Drawing.Point(0, 0);
            this.Diagram.Name = "Diagram";
            this.Diagram.Size = new System.Drawing.Size(282, 253);
            this.Diagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Diagram.TabIndex = 0;
            this.Diagram.TabStop = false;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(191, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(15, 13);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmDiagramPreview
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = global::Active_Diagrams.Properties.Settings.Default.PreviewSize;
            this.Controls.Add(this.Diagram);
            this.Controls.Add(this.button1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Active_Diagrams.Properties.Settings.Default, "PreviewLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ClientSize", global::Active_Diagrams.Properties.Settings.Default, "PreviewSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::Active_Diagrams.Properties.Settings.Default.PreviewLocation;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDiagramPreview";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DiagramPreview";
            ((System.ComponentModel.ISupportInitialize)(this.Diagram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Diagram;
        private System.Windows.Forms.Button button1;
    }
}