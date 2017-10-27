namespace Active_Diagrams
{
    partial class DiagramInfoTaskPane
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagramInfoTaskPane));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvDiagramInfo = new System.Windows.Forms.DataGridView();
            this.Property = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainerAd = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblURL = new System.Windows.Forms.LinkLabel();
            this.lblQuestion1 = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblQuestion2 = new System.Windows.Forms.Label();
            this.tmrAd = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagramInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAd)).BeginInit();
            this.splitContainerAd.Panel1.SuspendLayout();
            this.splitContainerAd.Panel2.SuspendLayout();
            this.splitContainerAd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvDiagramInfo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainerAd);
            this.splitContainer1.Size = new System.Drawing.Size(439, 336);
            this.splitContainer1.SplitterDistance = 267;
            this.splitContainer1.TabIndex = 5;
            // 
            // dgvDiagramInfo
            // 
            this.dgvDiagramInfo.AllowUserToAddRows = false;
            this.dgvDiagramInfo.AllowUserToDeleteRows = false;
            this.dgvDiagramInfo.AllowUserToResizeRows = false;
            this.dgvDiagramInfo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDiagramInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiagramInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Property,
            this.Value});
            this.dgvDiagramInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiagramInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvDiagramInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDiagramInfo.MultiSelect = false;
            this.dgvDiagramInfo.Name = "dgvDiagramInfo";
            this.dgvDiagramInfo.ReadOnly = true;
            this.dgvDiagramInfo.RowHeadersVisible = false;
            this.dgvDiagramInfo.RowTemplate.Height = 24;
            this.dgvDiagramInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiagramInfo.ShowEditingIcon = false;
            this.dgvDiagramInfo.ShowRowErrors = false;
            this.dgvDiagramInfo.Size = new System.Drawing.Size(439, 267);
            this.dgvDiagramInfo.TabIndex = 5;
            this.dgvDiagramInfo.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvDiagramInfo_ColumnWidthChanged);
            // 
            // Property
            // 
            this.Property.HeaderText = "Property";
            this.Property.Name = "Property";
            this.Property.ReadOnly = true;
            this.Property.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Property.Width = global::Active_Diagrams.Properties.Settings.Default.ADTaskPaneColumnPropertyWidth;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // splitContainerAd
            // 
            this.splitContainerAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerAd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.splitContainerAd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAd.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerAd.IsSplitterFixed = true;
            this.splitContainerAd.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAd.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerAd.Name = "splitContainerAd";
            // 
            // splitContainerAd.Panel1
            // 
            this.splitContainerAd.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainerAd.Panel2
            // 
            this.splitContainerAd.Panel2.Controls.Add(this.lblURL);
            this.splitContainerAd.Panel2.Controls.Add(this.lblQuestion1);
            this.splitContainerAd.Panel2.Controls.Add(this.lblAnswer);
            this.splitContainerAd.Panel2.Controls.Add(this.lblQuestion2);
            this.splitContainerAd.Size = new System.Drawing.Size(439, 65);
            this.splitContainerAd.SplitterDistance = 76;
            this.splitContainerAd.SplitterWidth = 5;
            this.splitContainerAd.TabIndex = 0;
            this.splitContainerAd.Click += new System.EventHandler(this.splitContainerAd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.splitContainerAd_Click);
            // 
            // lblURL
            // 
            this.lblURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(234, 43);
            this.lblURL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(118, 17);
            this.lblURL.TabIndex = 3;
            this.lblURL.TabStop = true;
            this.lblURL.Text = "www.kurzy-uml.cz";
            this.lblURL.Click += new System.EventHandler(this.splitContainerAd_Click);
            // 
            // lblQuestion1
            // 
            this.lblQuestion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestion1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQuestion1.ForeColor = System.Drawing.Color.DarkRed;
            this.lblQuestion1.Location = new System.Drawing.Point(0, 0);
            this.lblQuestion1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestion1.Name = "lblQuestion1";
            this.lblQuestion1.Size = new System.Drawing.Size(356, 63);
            this.lblQuestion1.TabIndex = 0;
            this.lblQuestion1.Text = "Splňuje vložený diagram UML pravidla?";
            this.lblQuestion1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblQuestion1.Click += new System.EventHandler(this.splitContainerAd_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAnswer.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAnswer.Location = new System.Drawing.Point(0, 0);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(356, 63);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "Otestujte se!";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnswer.Click += new System.EventHandler(this.splitContainerAd_Click);
            // 
            // lblQuestion2
            // 
            this.lblQuestion2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestion2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQuestion2.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblQuestion2.Location = new System.Drawing.Point(0, 0);
            this.lblQuestion2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestion2.Name = "lblQuestion2";
            this.lblQuestion2.Size = new System.Drawing.Size(356, 63);
            this.lblQuestion2.TabIndex = 1;
            this.lblQuestion2.Text = "Znáte je?";
            this.lblQuestion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuestion2.Click += new System.EventHandler(this.splitContainerAd_Click);
            // 
            // tmrAd
            // 
            this.tmrAd.Enabled = true;
            this.tmrAd.Interval = 3000;
            this.tmrAd.Tick += new System.EventHandler(this.tmrAd_Tick);
            // 
            // DiagramInfoTaskPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(200, 0);
            this.Name = "DiagramInfoTaskPane";
            this.Size = new System.Drawing.Size(439, 336);
            this.Load += new System.EventHandler(this.DiagramInfoTaskPane_Load);
            this.Resize += new System.EventHandler(this.DiagramInfoTaskPane_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagramInfo)).EndInit();
            this.splitContainerAd.Panel1.ResumeLayout(false);
            this.splitContainerAd.Panel2.ResumeLayout(false);
            this.splitContainerAd.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAd)).EndInit();
            this.splitContainerAd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.DataGridView dgvDiagramInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Property;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.Timer tmrAd;
        private System.Windows.Forms.SplitContainer splitContainerAd;
        private System.Windows.Forms.LinkLabel lblURL;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblQuestion2;
        private System.Windows.Forms.Label lblQuestion1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
