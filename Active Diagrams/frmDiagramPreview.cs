using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Active_Diagrams
{
    public partial class frmDiagramPreview : Form
    {
        public frmDiagramPreview()
        {
            InitializeComponent();
        }

        public void InsertImage(Image Image)
        {
            Diagram.Image = Image;
        }

    }
}
