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
    public partial class FormAttributes : Form
    {
        DataTable table2 = new DataTable();
        public FormAttributes()
        {
            InitializeComponent();
        }

        private void FormAttributes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'treeViewtestDataSet.Attributes' table. You can move, or remove it, as needed.
            this.attributesTableAdapter.Fill(this.treeViewtestDataSet.Attributes);
            //  take data from DatagridView , and save it in a variable
            table2 = treeViewtestDataSet.Attributes;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create columns in the database 
            attributesBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // modify data and save it in the database 
            attributesBindingSource.EndEdit();
            attributesTableAdapter.Update(treeViewtestDataSet.Attributes);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Delete data and save it in the database
            attributesBindingSource.RemoveCurrent();
            attributesBindingSource.EndEdit();
            attributesTableAdapter.Update(treeViewtestDataSet.Attributes);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Export data to file XML
            table2.WriteXml(@"E:\trrview\TreeView2\TreeView2\XMLFile2.xml", XmlWriteMode.WriteSchema);
            MessageBox.Show("Data Exported");
        }
    }
}
