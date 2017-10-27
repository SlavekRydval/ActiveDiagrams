namespace Active_Diagrams
{
    partial class EAAddonRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public EAAddonRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EAAddonRibbon));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.rbnEAActiveDiagrams = this.Factory.CreateRibbonGroup();
            this.btnLinkWithEAP = this.Factory.CreateRibbonButton();
            this.btnAddDiagram = this.Factory.CreateRibbonButton();
            this.btnRefresh = this.Factory.CreateRibbonButton();
            this.btnAbout = this.Factory.CreateRibbonButton();
            this.btnOpenRepositoryInEA = this.Factory.CreateRibbonButton();
            this.btnOpenHomepage = this.Factory.CreateRibbonButton();
            this.cbShowTaskPane = this.Factory.CreateRibbonCheckBox();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.tab1.SuspendLayout();
            this.rbnEAActiveDiagrams.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.rbnEAActiveDiagrams);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // rbnEAActiveDiagrams
            // 
            this.rbnEAActiveDiagrams.Items.Add(this.btnLinkWithEAP);
            this.rbnEAActiveDiagrams.Items.Add(this.btnAddDiagram);
            this.rbnEAActiveDiagrams.Items.Add(this.btnRefresh);
            this.rbnEAActiveDiagrams.Items.Add(this.btnAbout);
            this.rbnEAActiveDiagrams.Items.Add(this.separator1);
            this.rbnEAActiveDiagrams.Items.Add(this.btnOpenRepositoryInEA);
            this.rbnEAActiveDiagrams.Items.Add(this.btnOpenHomepage);
            this.rbnEAActiveDiagrams.Items.Add(this.cbShowTaskPane);
            this.rbnEAActiveDiagrams.Label = "EA Active Diagrams";
            this.rbnEAActiveDiagrams.Name = "rbnEAActiveDiagrams";
            // 
            // btnLinkWithEAP
            // 
            this.btnLinkWithEAP.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnLinkWithEAP.Image = ((System.Drawing.Image)(resources.GetObject("btnLinkWithEAP.Image")));
            this.btnLinkWithEAP.Label = "Link with EAP...";
            this.btnLinkWithEAP.Name = "btnLinkWithEAP";
            this.btnLinkWithEAP.ScreenTip = "Link document with EA repository";
            this.btnLinkWithEAP.ShowImage = true;
            this.btnLinkWithEAP.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnLinkWithEAP_Click);
            // 
            // btnAddDiagram
            // 
            this.btnAddDiagram.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnAddDiagram.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDiagram.Image")));
            this.btnAddDiagram.Label = "Add New Diagram...";
            this.btnAddDiagram.Name = "btnAddDiagram";
            this.btnAddDiagram.ScreenTip = "Add new diagram into your document";
            this.btnAddDiagram.ShowImage = true;
            this.btnAddDiagram.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAddDiagram_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Label = "Refresh";
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ScreenTip = "Refresh all diagram in the document";
            this.btnRefresh.ShowImage = true;
            this.btnRefresh.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnRefresh_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.Label = "About...";
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.ScreenTip = "Show information about Active Diagrams add-in";
            this.btnAbout.ShowImage = true;
            this.btnAbout.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAbout_Click);
            // 
            // btnOpenRepositoryInEA
            // 
            this.btnOpenRepositoryInEA.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenRepositoryInEA.Image")));
            this.btnOpenRepositoryInEA.Label = "Open Repository in EA";
            this.btnOpenRepositoryInEA.Name = "btnOpenRepositoryInEA";
            this.btnOpenRepositoryInEA.ScreenTip = "Run Sparx Enterprise Architect (if installed) with repository assigned to current" +
    "ly opened document";
            this.btnOpenRepositoryInEA.ShowImage = true;
            this.btnOpenRepositoryInEA.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnOpenRepositoryInEA_Click);
            // 
            // btnOpenHomepage
            // 
            this.btnOpenHomepage.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenHomepage.Image")));
            this.btnOpenHomepage.Label = "Visit Product Homepage";
            this.btnOpenHomepage.Name = "btnOpenHomepage";
            this.btnOpenHomepage.ScreenTip = "Visit Active Diagrams homepage";
            this.btnOpenHomepage.ShowImage = true;
            this.btnOpenHomepage.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnOpenHomepage_Click);
            // 
            // cbShowTaskPane
            // 
            this.cbShowTaskPane.Checked = global::Active_Diagrams.Properties.Settings.Default.ADTaskPaneVisible;
            this.cbShowTaskPane.Label = "Show Task Pane";
            this.cbShowTaskPane.Name = "cbShowTaskPane";
            this.cbShowTaskPane.ScreenTip = "Show Active Diagrams Task Pane with additional information about a diagram in a d" +
    "ocument";
            this.cbShowTaskPane.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbShowTaskPane_Click);
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // EAAddonRibbon
            // 
            this.Name = "EAAddonRibbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Close += new System.EventHandler(this.EAAddonRibbon_Close);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.EAAddonRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.rbnEAActiveDiagrams.ResumeLayout(false);
            this.rbnEAActiveDiagrams.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup rbnEAActiveDiagrams;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnLinkWithEAP;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAddDiagram;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnRefresh;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAbout;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbShowTaskPane;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnOpenRepositoryInEA;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnOpenHomepage;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
    }

    partial class ThisRibbonCollection
    {
        internal EAAddonRibbon EAAddonRibbon
        {
            get { return this.GetRibbon<EAAddonRibbon>(); }
        }
    }
}
