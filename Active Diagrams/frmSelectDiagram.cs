using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Active_Diagrams
{
    public partial class frmSelectDiagram : Form
    {
        public frmSelectDiagram()
        {
            InitializeComponent();
            Repository = null;
        }

        public WordEAInterface Repository { get; set; }
        public string SelectedDiagramGUID; 

        public DialogResult SelectDiagram()
        {
            try
            {
                ReadRootNodes();
                return ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot read from EA repository. Error: "+ex.Message, "Active Diagrams", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DialogResult.None;
            }
        }

        private void AddDummyNode(TreeNode Node)
        {
            Node.Nodes.Add("", "Loading, please wait...").Tag = new NodeObject();
        }

        private void ReadRootNodes()
        {
            Repository.OpenEARepository();
            tvEAProjectBrowser.Nodes.Clear();
            foreach (EAPackage model in Repository.Models)
            {
                TreeNode node = tvEAProjectBrowser.Nodes.Add(model.ID.ToString(), model.Name);
                node.Tag = new NodeObject(model);
                node.ImageIndex = 1;
                node.SelectedImageIndex = 1;
                AddDummyNode(node);

            }
        }

        private void tvEAProjectBrowser_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (e.Node.Nodes.Count == 1 && (((NodeObject)(e.Node.Nodes[0].Tag)).ObjectType == NodeObjectType.Dummy))
                {
                    //jde o dummy node, takže ho zrušíme a načteme nové.
                    NodeObject no = (NodeObject)e.Node.Tag;

                    e.Node.Nodes.Clear();
                    Repository.ReadPackages(no.Package);

                    foreach (EADiagram diag in no.Package.OwnedDiagrams)
                    {
                        TreeNode node = e.Node.Nodes.Add(diag.GUID, diag.Name);
                        node.Tag = new NodeObject(diag);
                        node.ImageIndex = 0;
                        node.SelectedImageIndex = 0;
                    }

                    foreach (EAPackage pkg in no.Package.OwnedPackages)
                    {
                        TreeNode node = e.Node.Nodes.Add(pkg.ID.ToString(), pkg.Name);
                        node.Tag = new NodeObject(pkg);
                        node.ImageIndex = 1;
                        node.SelectedImageIndex = 1;
                        AddDummyNode(node);
                    }
                }

            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

        }

        private void frmSelectDiagram_Load(object sender, EventArgs e)
        {
            lblNode.Text = "";
            SetSearchControls();
            SetActiveControl();
        }

        private void tvEAProjectBrowser_AfterSelect(object sender, TreeViewEventArgs e)
        {
            /*
            string s = "? ";
            if (((NodeObject)(e.Node.Tag)).ObjectType == NodeObjectType.Diagram)
                s = "D ";
            if (((NodeObject)(e.Node.Tag)).ObjectType == NodeObjectType.Package)
                s = "P ";
                */
            lblNode.Text = e.Node.FullPath;
        }


        private void PrepareDiagramGUID()
        {
            SelectedDiagramGUID = "";

            //Project Browser
            if (tcDiagram.SelectedTab == tpProjectBrowser)
            {
                if (tvEAProjectBrowser.SelectedNode != null)
                {
                    NodeObject no = (NodeObject)tvEAProjectBrowser.SelectedNode.Tag;
                    if (no.ObjectType == NodeObjectType.Diagram)
                        SelectedDiagramGUID = no.Diagram.GUID;
                }
            }
            else if (tcDiagram.SelectedTab == tpEnteringManualGUID)
            {
                if (isGuid(tbDiagramGUID.Text))
                    SelectedDiagramGUID = tbDiagramGUID.Text;
            }
            else if (tcDiagram.SelectedTab == tpFind)
            {
                if (lvSearchResult.SelectedItems.Count == 1)
                    SelectedDiagramGUID = ((EADiagram)(lvSearchResult.SelectedItems[0].Tag)).GUID;
            }

        }

        private void tvEAProjectBrowser_DoubleClick(object sender, EventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
                ShowPreview();
            else
            {
                PrepareDiagramGUID();
                if (SelectedDiagramGUID != "")
                    DialogResult = DialogResult.OK;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            PrepareDiagramGUID();

            if (SelectedDiagramGUID == "")
            {
                MessageBox.Show("You havn't choosen/entered any diagram yet.", "Active Diagrams", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }

        bool isGuid(string PotentialGuid)
        {
            Guid g;
            return Guid.TryParse(PotentialGuid, out g);
        }


        private void tpEnteringManualGUID_Resize(object sender, EventArgs e)
        {
            //tbDiagramGUID.Top = lblGUIDGuideText.Top + lblGUIDGuideText.Height + 6;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                try
                {
                    lvSearchResult.Items.Clear();
                    List<EADiagram> diags = Repository.SearchDiagrams(tbSearchTerm.Text,
                        cbExactMatch.Checked, cbCaseSensitive.Checked, cbRegEx.Checked);
                    foreach (EADiagram diag in diags)
                    {
                        ListViewItem lvi = lvSearchResult.Items.Add(diag.Name);
                        lvi.SubItems.Add(diag.Type);
                        lvi.SubItems.Add(diag.Author);
                        lvi.SubItems.Add(diag.Stereotype);
                        lvi.Tag = diag;
                    }
                    lblResultCount.Text = $"{diags.Count} diagram(s) found.";
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                lblResultCount.Text = "";
                MessageBox.Show($"Seaching problem: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void tbSearchTerm_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnSearch;
        }

        private void tbSearchTerm_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = btnOK;
        }   

        private void lvSearchResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
                ShowPreview();
            else
            {
                PrepareDiagramGUID();
                if (SelectedDiagramGUID != "")
                    DialogResult = DialogResult.OK;
            }
        }


        private void SetSearchControls()
        {
            cbCaseSensitive.Enabled = !cbRegEx.Checked;
            cbExactMatch.Enabled = !cbRegEx.Checked;
        }

        private void cbRegEx_CheckedChanged(object sender, EventArgs e)
        {
            SetSearchControls();
        }

        private void SetActiveControl()
        {
            if (tcDiagram.SelectedTab == tpProjectBrowser)
            {
            }
            else if (tcDiagram.SelectedTab == tpEnteringManualGUID)
            {
                this.ActiveControl = tbDiagramGUID;
            }
            else if (tcDiagram.SelectedTab == tpFind)
            {
                this.ActiveControl = tbSearchTerm;
            }
        }

        private void tcDiagram_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetActiveControl();
        }

        private void lvSearchResult_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbDiagramPreview_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ShowPreview()
        {
            PrepareDiagramGUID();
            if (SelectedDiagramGUID == "")
                MessageBox.Show("No diagram is selected.");
            else
            {
                try
                {
                    Bitmap DiagramFile;
                    Repository.SaveDiagramIntoFile(SelectedDiagramGUID);
                    DiagramFile = new Bitmap(Repository.GetFileName(SelectedDiagramGUID));
                    frmDiagramPreview f = new frmDiagramPreview();
                    f.InsertImage(DiagramFile);
                    f.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot preview a diagram. Reason: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnPreview_Click(object sender, EventArgs e)
        {
            ShowPreview();
        }

        private void lblGUIDGuideText_Click(object sender, EventArgs e)
        {

        }

        private void frmSelectDiagram_Activated(object sender, EventArgs e)
        {
            
        }
    }

    enum NodeObjectType {Package, Diagram, Dummy}

    class NodeObject
    {
        public NodeObjectType ObjectType { get; }
        public EAPackage Package { get;  }
        public EADiagram Diagram { get; }

        public NodeObject(EAPackage Package)
        {
            this.ObjectType = NodeObjectType.Package;
            this.Package = Package;
            this.Diagram = null;
        }

        public NodeObject(EADiagram Diagram)
        {
            this.ObjectType = NodeObjectType.Diagram;
            this.Diagram = Diagram;
            this.Package = null;
        }

        public NodeObject()
        {
            this.ObjectType = NodeObjectType.Dummy;
            this.Diagram = null;
            this.Package = null;
        }
    }

}
