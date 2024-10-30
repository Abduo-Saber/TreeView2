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
    public partial class formlinks : Form
    {
        DataTable table3 = new DataTable();
        public formlinks()
        {
            InitializeComponent();
        }

        private void formlinks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'treeViewtestDataSet.Links' table. You can move, or remove it, as needed.
            this.linksTableAdapter.Fill(this.treeViewtestDataSet.Links);
            //  take data from DatagridView , and save it in a variable
            table3 = treeViewtestDataSet.Links;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create columns in the database
            linksBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // modify data and save it in the database
            linksBindingSource.EndEdit();
            linksTableAdapter.Update(treeViewtestDataSet.Links);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Delete data and save it in the database
            linksBindingSource.RemoveCurrent();
            linksBindingSource.EndEdit();
            linksTableAdapter.Update(treeViewtestDataSet.Links);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Export data to file XML
            table3.WriteXml(@"E:\trrview\TreeView2\TreeView2\XMLFile3.xml", XmlWriteMode.WriteSchema);
            MessageBox.Show("Data Exported");
        }
    }
}
