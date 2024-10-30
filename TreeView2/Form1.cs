using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView2
{
    public partial class TV : Form
    {
        public TV()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Create array of type form
            Form frm = new Form();
            // This Variable takes its text when clicked
            string struc = tvforms.SelectedNode.Text;
            // I used if to open the form when it equals its text
            if (struc == "Objects") frm = new formobject();
            if (struc == "Links") frm = new formlinks();
            if (struc == "Attributes") frm = new FormAttributes();

            foreach(Form f in Application.OpenForms)
            {
                // When it equals the other text , it only shows it to the user ,and does not add another window
                if(f.Text == frm.Text)
                {
                    f.Activate();
                    f.WindowState = FormWindowState.Maximized;
                    return;
                }
                // Delete other windows
                if (f.Text != frm.Text)
                {
                    f.Close();
                    return;
                }
            }
            
            frm.MdiParent = this;
            frm.Show();
        }
        
        private void TV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'treeViewtestDataSet.Objects' table. You can move, or remove it, as needed.
            

        }
    }
}
