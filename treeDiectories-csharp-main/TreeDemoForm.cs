using System;
using System.Windows.Forms;
using System.IO;

namespace TreesDemo
{
    public partial class TreeDemoForm : Form
    {
        TreeView tree = new TreeView();
        public TreeDemoForm()
        {
            InitializeComponent();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady)
                {
                    TreeNode root = new TreeNode();
                    root.Text = drive.Name;
                    tree.Nodes.Add(root);
                }
            }
            tree.SetBounds(0, 0, 200, 700);
            tree.Scrollable = true;
            tree.AfterSelect += tree_AfterSelect;
            this.Controls.Add(tree);
        }

        void tree_AfterSelect(object sender, EventArgs e)
        {
            if (tree.SelectedNode.Nodes.Count != 0) return;
            string[] directories = Directory.GetDirectories(tree.SelectedNode.Text);
            foreach (string dir in directories)
            {
                TreeNode treeNode = new TreeNode();
                treeNode.Text = dir;
                tree.SelectedNode.Nodes.Add(treeNode);
            }


        }
    }
}
