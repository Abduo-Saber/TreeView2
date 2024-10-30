
namespace TreeView2
{
    partial class TV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TV));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Objects");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Links");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Attributes");
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tvforms = new System.Windows.Forms.TreeView();
            this.objectsTableAdapter = new TreeView2.TreeViewtestDataSetTableAdapters.ObjectsTableAdapter();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "macos_big_sur_wpaper_folder_icon_186058.png");
            // 
            // tvforms
            // 
            this.tvforms.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvforms.ImageIndex = 0;
            this.tvforms.ImageList = this.imageList1;
            this.tvforms.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tvforms.Location = new System.Drawing.Point(0, 0);
            this.tvforms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tvforms.MaximumSize = new System.Drawing.Size(169, 484);
            this.tvforms.MinimumSize = new System.Drawing.Size(169, 484);
            this.tvforms.Name = "tvforms";
            treeNode1.Name = "N0";
            treeNode1.Text = "Objects";
            treeNode2.Name = "N1";
            treeNode2.Text = "Links";
            treeNode3.Name = "N2";
            treeNode3.Text = "Attributes";
            this.tvforms.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.tvforms.SelectedImageIndex = 0;
            this.tvforms.Size = new System.Drawing.Size(169, 484);
            this.tvforms.TabIndex = 0;
            this.tvforms.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // objectsTableAdapter
            // 
            this.objectsTableAdapter.ClearBeforeFill = true;
            // 
            // TV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 487);
            this.Controls.Add(this.tvforms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "TV";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TreeView";
            this.Load += new System.EventHandler(this.TV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView tvforms;
        private TreeViewtestDataSetTableAdapters.ObjectsTableAdapter objectsTableAdapter;
    }
}

