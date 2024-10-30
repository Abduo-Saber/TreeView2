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
    public partial class formobject : Form
    {
         DataTable table1 = new DataTable();
        public formobject()
        {
            InitializeComponent();
           
        }

        private void formobject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'treeViewtestDataSet.Objects' table. You can move, or remove it, as needed.
            this.objectsTableAdapter.Fill(this.treeViewtestDataSet.Objects);
            //  take data from DatagridView , and save it in a variable
            table1 = treeViewtestDataSet.Objects;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create columns in the database
            objectsBindingSource.AddNew();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            // modify data and save it in the database
            objectsBindingSource.EndEdit();
            objectsTableAdapter.Update(treeViewtestDataSet.Objects);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Delete data and save it in the database
            objectsBindingSource.RemoveCurrent();
            objectsBindingSource.EndEdit();
            objectsTableAdapter.Update(treeViewtestDataSet.Objects);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Export data to file XML
            table1.WriteXml(@"E:\trrview\TreeView2\TreeView2\XMLFile1.xml", XmlWriteMode.WriteSchema);
            MessageBox.Show("Data Exported");
        }
    }
}
