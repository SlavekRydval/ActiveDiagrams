namespace Active_Diagrams
{
    partial class frmSelectDiagram
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectDiagram));
            this.imgDefault = new System.Windows.Forms.ImageList(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.tcDiagram = new System.Windows.Forms.TabControl();
            this.tpProjectBrowser = new System.Windows.Forms.TabPage();
            this.lblNode = new System.Windows.Forms.Label();
            this.tvEAProjectBrowser = new System.Windows.Forms.TreeView();
            this.tpFind = new System.Windows.Forms.TabPage();
            this.scSearch = new System.Windows.Forms.SplitContainer();
            this.lblResultCount = new System.Windows.Forms.Label();
            this.cbRegEx = new System.Windows.Forms.CheckBox();
            this.cbExactMatch = new System.Windows.Forms.CheckBox();
            this.cbCaseSensitive = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearchTerm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lvSearchResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpEnteringManualGUID = new System.Windows.Forms.TabPage();
            this.lblGUIDGuideText = new System.Windows.Forms.Label();
            this.tbDiagramGUID = new System.Windows.Forms.TextBox();
            this.lblEnterDiagramGUID = new System.Windows.Forms.Label();
            this.tcDiagram.SuspendLayout();
            this.tpProjectBrowser.SuspendLayout();
            this.tpFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSearch)).BeginInit();
            this.scSearch.Panel1.SuspendLayout();
            this.scSearch.Panel2.SuspendLayout();
            this.scSearch.SuspendLayout();
            this.tpEnteringManualGUID.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgDefault
            // 
            this.imgDefault.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgDefault.ImageStream")));
            this.imgDefault.TransparentColor = System.Drawing.Color.Transparent;
            this.imgDefault.Images.SetKeyName(0, "Diagram.ico");
            this.imgDefault.Images.SetKeyName(1, "Package.ico");
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(281, 364);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(56, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(342, 364);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPreview.Location = new System.Drawing.Point(9, 364);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(2);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(64, 23);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Text = "Preview...";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // tcDiagram
            // 
            this.tcDiagram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcDiagram.Controls.Add(this.tpProjectBrowser);
            this.tcDiagram.Controls.Add(this.tpFind);
            this.tcDiagram.Controls.Add(this.tpEnteringManualGUID);
            this.tcDiagram.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", global::Active_Diagrams.Properties.Settings.Default, "SelectDiagramActivePage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tcDiagram.ImageList = this.imgDefault;
            this.tcDiagram.Location = new System.Drawing.Point(9, 10);
            this.tcDiagram.Margin = new System.Windows.Forms.Padding(2);
            this.tcDiagram.Name = "tcDiagram";
            this.tcDiagram.SelectedIndex = global::Active_Diagrams.Properties.Settings.Default.SelectDiagramActivePage;
            this.tcDiagram.Size = new System.Drawing.Size(389, 337);
            this.tcDiagram.TabIndex = 0;
            this.tcDiagram.SelectedIndexChanged += new System.EventHandler(this.tcDiagram_SelectedIndexChanged);
            // 
            // tpProjectBrowser
            // 
            this.tpProjectBrowser.Controls.Add(this.lblNode);
            this.tpProjectBrowser.Controls.Add(this.tvEAProjectBrowser);
            this.tpProjectBrowser.Location = new System.Drawing.Point(4, 23);
            this.tpProjectBrowser.Margin = new System.Windows.Forms.Padding(2);
            this.tpProjectBrowser.Name = "tpProjectBrowser";
            this.tpProjectBrowser.Padding = new System.Windows.Forms.Padding(2);
            this.tpProjectBrowser.Size = new System.Drawing.Size(381, 310);
            this.tpProjectBrowser.TabIndex = 0;
            this.tpProjectBrowser.Text = "EA Project Browser";
            this.tpProjectBrowser.UseVisualStyleBackColor = true;
            // 
            // lblNode
            // 
            this.lblNode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNode.AutoSize = true;
            this.lblNode.Location = new System.Drawing.Point(4, 298);
            this.lblNode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNode.Name = "lblNode";
            this.lblNode.Size = new System.Drawing.Size(41, 15);
            this.lblNode.TabIndex = 1;
            this.lblNode.Text = "label1";
            // 
            // tvEAProjectBrowser
            // 
            this.tvEAProjectBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvEAProjectBrowser.HideSelection = false;
            this.tvEAProjectBrowser.ImageIndex = 1;
            this.tvEAProjectBrowser.ImageList = this.imgDefault;
            this.tvEAProjectBrowser.Location = new System.Drawing.Point(4, 5);
            this.tvEAProjectBrowser.Margin = new System.Windows.Forms.Padding(2);
            this.tvEAProjectBrowser.Name = "tvEAProjectBrowser";
            this.tvEAProjectBrowser.SelectedImageIndex = 1;
            this.tvEAProjectBrowser.Size = new System.Drawing.Size(373, 291);
            this.tvEAProjectBrowser.TabIndex = 0;
            this.tvEAProjectBrowser.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvEAProjectBrowser_BeforeExpand);
            this.tvEAProjectBrowser.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvEAProjectBrowser_AfterSelect);
            this.tvEAProjectBrowser.DoubleClick += new System.EventHandler(this.tvEAProjectBrowser_DoubleClick);
            // 
            // tpFind
            // 
            this.tpFind.Controls.Add(this.scSearch);
            this.tpFind.Location = new System.Drawing.Point(4, 23);
            this.tpFind.Margin = new System.Windows.Forms.Padding(2);
            this.tpFind.Name = "tpFind";
            this.tpFind.Padding = new System.Windows.Forms.Padding(2);
            this.tpFind.Size = new System.Drawing.Size(381, 310);
            this.tpFind.TabIndex = 1;
            this.tpFind.Text = "Find a Diagram";
            this.tpFind.UseVisualStyleBackColor = true;
            // 
            // scSearch
            // 
            this.scSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scSearch.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scSearch.IsSplitterFixed = true;
            this.scSearch.Location = new System.Drawing.Point(2, 2);
            this.scSearch.Margin = new System.Windows.Forms.Padding(2);
            this.scSearch.Name = "scSearch";
            this.scSearch.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scSearch.Panel1
            // 
            this.scSearch.Panel1.Controls.Add(this.lblResultCount);
            this.scSearch.Panel1.Controls.Add(this.cbRegEx);
            this.scSearch.Panel1.Controls.Add(this.cbExactMatch);
            this.scSearch.Panel1.Controls.Add(this.cbCaseSensitive);
            this.scSearch.Panel1.Controls.Add(this.btnSearch);
            this.scSearch.Panel1.Controls.Add(this.tbSearchTerm);
            this.scSearch.Panel1.Controls.Add(this.label2);
            // 
            // scSearch.Panel2
            // 
            this.scSearch.Panel2.Controls.Add(this.lvSearchResult);
            this.scSearch.Size = new System.Drawing.Size(377, 306);
            this.scSearch.SplitterDistance = 129;
            this.scSearch.SplitterWidth = 3;
            this.scSearch.TabIndex = 9;
            // 
            // lblResultCount
            // 
            this.lblResultCount.AutoSize = true;
            this.lblResultCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResultCount.Location = new System.Drawing.Point(13, 108);
            this.lblResultCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultCount.Name = "lblResultCount";
            this.lblResultCount.Size = new System.Drawing.Size(242, 17);
            this.lblResultCount.TabIndex = 15;
            this.lblResultCount.Text = "Searching has not been run yet.";
            // 
            // cbRegEx
            // 
            this.cbRegEx.AutoSize = true;
            this.cbRegEx.Checked = global::Active_Diagrams.Properties.Settings.Default.FindRegEx;
            this.cbRegEx.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Active_Diagrams.Properties.Settings.Default, "FindRegEx", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbRegEx.Location = new System.Drawing.Point(124, 55);
            this.cbRegEx.Margin = new System.Windows.Forms.Padding(2);
            this.cbRegEx.Name = "cbRegEx";
            this.cbRegEx.Size = new System.Drawing.Size(162, 19);
            this.cbRegEx.TabIndex = 14;
            this.cbRegEx.Text = "Use Regular Expression";
            this.cbRegEx.UseVisualStyleBackColor = true;
            this.cbRegEx.CheckedChanged += new System.EventHandler(this.cbRegEx_CheckedChanged);
            // 
            // cbExactMatch
            // 
            this.cbExactMatch.AutoSize = true;
            this.cbExactMatch.Checked = global::Active_Diagrams.Properties.Settings.Default.FindExactMatch;
            this.cbExactMatch.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Active_Diagrams.Properties.Settings.Default, "FindExactMatch", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbExactMatch.Location = new System.Drawing.Point(15, 77);
            this.cbExactMatch.Margin = new System.Windows.Forms.Padding(2);
            this.cbExactMatch.Name = "cbExactMatch";
            this.cbExactMatch.Size = new System.Drawing.Size(96, 19);
            this.cbExactMatch.TabIndex = 13;
            this.cbExactMatch.Text = "Exact Match";
            this.cbExactMatch.UseVisualStyleBackColor = true;
            // 
            // cbCaseSensitive
            // 
            this.cbCaseSensitive.AutoSize = true;
            this.cbCaseSensitive.Checked = global::Active_Diagrams.Properties.Settings.Default.FindCaseSensitive;
            this.cbCaseSensitive.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Active_Diagrams.Properties.Settings.Default, "FindCaseSensitive", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbCaseSensitive.Location = new System.Drawing.Point(15, 55);
            this.cbCaseSensitive.Margin = new System.Windows.Forms.Padding(2);
            this.cbCaseSensitive.Name = "cbCaseSensitive";
            this.cbCaseSensitive.Size = new System.Drawing.Size(109, 19);
            this.cbCaseSensitive.TabIndex = 12;
            this.cbCaseSensitive.Text = "Case Sensitive";
            this.cbCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(204, 76);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 25);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearchTerm
            // 
            this.tbSearchTerm.Location = new System.Drawing.Point(15, 28);
            this.tbSearchTerm.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearchTerm.Name = "tbSearchTerm";
            this.tbSearchTerm.Size = new System.Drawing.Size(246, 20);
            this.tbSearchTerm.TabIndex = 10;
            this.tbSearchTerm.Enter += new System.EventHandler(this.tbSearchTerm_Enter);
            this.tbSearchTerm.Leave += new System.EventHandler(this.tbSearchTerm_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter diagram name:";
            // 
            // lvSearchResult
            // 
            this.lvSearchResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSearchResult.FullRowSelect = true;
            this.lvSearchResult.GridLines = true;
            this.lvSearchResult.HideSelection = false;
            this.lvSearchResult.Location = new System.Drawing.Point(0, 0);
            this.lvSearchResult.Margin = new System.Windows.Forms.Padding(2);
            this.lvSearchResult.MultiSelect = false;
            this.lvSearchResult.Name = "lvSearchResult";
            this.lvSearchResult.Size = new System.Drawing.Size(377, 174);
            this.lvSearchResult.TabIndex = 6;
            this.lvSearchResult.UseCompatibleStateImageBehavior = false;
            this.lvSearchResult.View = System.Windows.Forms.View.Details;
            this.lvSearchResult.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvSearchResult_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Diagram Name";
            this.columnHeader1.Width = global::Active_Diagrams.Properties.Settings.Default.SearchResultDiagramNameWidth;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Diagram Type";
            this.columnHeader2.Width = global::Active_Diagrams.Properties.Settings.Default.SearchResultDiagramTypeWidth;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Author";
            this.columnHeader3.Width = global::Active_Diagrams.Properties.Settings.Default.SearchResultDiagramAuthorWidth;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Stereotype";
            this.columnHeader4.Width = global::Active_Diagrams.Properties.Settings.Default.SearchResultDiagramStereotypeWidth;
            // 
            // tpEnteringManualGUID
            // 
            this.tpEnteringManualGUID.Controls.Add(this.lblGUIDGuideText);
            this.tpEnteringManualGUID.Controls.Add(this.tbDiagramGUID);
            this.tpEnteringManualGUID.Controls.Add(this.lblEnterDiagramGUID);
            this.tpEnteringManualGUID.Location = new System.Drawing.Point(4, 23);
            this.tpEnteringManualGUID.Margin = new System.Windows.Forms.Padding(2);
            this.tpEnteringManualGUID.Name = "tpEnteringManualGUID";
            this.tpEnteringManualGUID.Size = new System.Drawing.Size(381, 310);
            this.tpEnteringManualGUID.TabIndex = 2;
            this.tpEnteringManualGUID.Text = "Enter GUID Manually";
            this.tpEnteringManualGUID.UseVisualStyleBackColor = true;
            this.tpEnteringManualGUID.Resize += new System.EventHandler(this.tpEnteringManualGUID_Resize);
            // 
            // lblGUIDGuideText
            // 
            this.lblGUIDGuideText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGUIDGuideText.Location = new System.Drawing.Point(7, 30);
            this.lblGUIDGuideText.Name = "lblGUIDGuideText";
            this.lblGUIDGuideText.Size = new System.Drawing.Size(374, 75);
            this.lblGUIDGuideText.TabIndex = 7;
            this.lblGUIDGuideText.Text = "(Locate diagram in Project Browser in Enterprise Architect, get context menu and " +
    "choose menu item Copy/Paste --> Copy Node GUID to Clipboard)\r\n\r\nExample of GUID:" +
    " {73C1448F-02E8-463f-871A-F7841EA967F0}";
            this.lblGUIDGuideText.Click += new System.EventHandler(this.lblGUIDGuideText_Click);
            // 
            // tbDiagramGUID
            // 
            this.tbDiagramGUID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDiagramGUID.Location = new System.Drawing.Point(7, 117);
            this.tbDiagramGUID.Name = "tbDiagramGUID";
            this.tbDiagramGUID.Size = new System.Drawing.Size(371, 20);
            this.tbDiagramGUID.TabIndex = 5;
            // 
            // lblEnterDiagramGUID
            // 
            this.lblEnterDiagramGUID.AutoSize = true;
            this.lblEnterDiagramGUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEnterDiagramGUID.Location = new System.Drawing.Point(4, 13);
            this.lblEnterDiagramGUID.Name = "lblEnterDiagramGUID";
            this.lblEnterDiagramGUID.Size = new System.Drawing.Size(172, 17);
            this.lblEnterDiagramGUID.TabIndex = 6;
            this.lblEnterDiagramGUID.Text = "Enter Diagram\'s GUID:";
            // 
            // frmSelectDiagram
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(407, 395);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tcDiagram);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(228, 328);
            this.Name = "frmSelectDiagram";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select a Diagram";
            this.Activated += new System.EventHandler(this.frmSelectDiagram_Activated);
            this.Load += new System.EventHandler(this.frmSelectDiagram_Load);
            this.tcDiagram.ResumeLayout(false);
            this.tpProjectBrowser.ResumeLayout(false);
            this.tpProjectBrowser.PerformLayout();
            this.tpFind.ResumeLayout(false);
            this.scSearch.Panel1.ResumeLayout(false);
            this.scSearch.Panel1.PerformLayout();
            this.scSearch.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scSearch)).EndInit();
            this.scSearch.ResumeLayout(false);
            this.tpEnteringManualGUID.ResumeLayout(false);
            this.tpEnteringManualGUID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcDiagram;
        private System.Windows.Forms.TabPage tpProjectBrowser;
        private System.Windows.Forms.TreeView tvEAProjectBrowser;
        private System.Windows.Forms.TabPage tpFind;
        private System.Windows.Forms.TabPage tpEnteringManualGUID;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ImageList imgDefault;
        private System.Windows.Forms.Label lblNode;
        private System.Windows.Forms.Label lblGUIDGuideText;
        private System.Windows.Forms.TextBox tbDiagramGUID;
        private System.Windows.Forms.Label lblEnterDiagramGUID;
        private System.Windows.Forms.SplitContainer scSearch;
        private System.Windows.Forms.Label lblResultCount;
        private System.Windows.Forms.CheckBox cbRegEx;
        private System.Windows.Forms.CheckBox cbExactMatch;
        private System.Windows.Forms.CheckBox cbCaseSensitive;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearchTerm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvSearchResult;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnPreview;
    }
}