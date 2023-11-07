using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView.View = View.Details; 
            listView.HeaderStyle = ColumnHeaderStyle.None;
            listView.Columns.Add("Details",-2, HorizontalAlignment.Left); 
        }
        private void loadButton_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Clear(); 
            string targetPath = directoryTextbox.Text; 
            if (!Directory.Exists(targetPath))
            {
                targetPath = @"C:\";
            }

            TreeNode rootNode = new TreeNode(targetPath);
            rootNode.Tag = targetPath; 
            rootNode.Nodes.Add(new TreeNode()); 
            treeView.Nodes.Add(rootNode);
        }
        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count == 1 && e.Node.Nodes[0].Text == "")
            {
                e.Node.Nodes.Clear();
                string path = (string)e.Node.Tag;
                string[] directories = Directory.GetDirectories(path);
                foreach (string directory in directories)
                {
                    TreeNode directoryNode = new TreeNode(Path.GetFileName(directory));
                    directoryNode.Tag = directory; 
                    directoryNode.Nodes.Add(new TreeNode()); 
                    e.Node.Nodes.Add(directoryNode);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        
        }
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView.Items.Clear();
            DirectoryInfo directoryInfo = new DirectoryInfo(e.Node.FullPath);
            //listView.LargeImageList = imageList1;
            foreach (DirectoryInfo dir in directoryInfo.GetDirectories())
            {
                ListViewItem item = new ListViewItem(dir.Name, 0);
                listView.Items.Add(item);
            }
            foreach (FileInfo file in directoryInfo.GetFiles())
            { 
                ListViewItem item = new ListViewItem(file.Name, 1);
                listView.Items.Add(item);
            }
        }

        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            string path = treeView.SelectedNode.FullPath + "\\" + listView.SelectedItems[0].Text;

            if (Directory.Exists(path)) // 如果是文件夹
            {
                TreeNode selectedNode = treeView.SelectedNode.Nodes.Cast<TreeNode>().FirstOrDefault(node => node.Text == listView.SelectedItems[0].Text);
                if (selectedNode != null)
                {
                    treeView.SelectedNode = selectedNode;
                    treeView.SelectedNode.Expand();
                }
            }
            else if (File.Exists(path)) // 如果是文件
            {
                if (Path.GetExtension(path) == ".exe" || Path.GetExtension(path) == ".txt")
                {
                    System.Diagnostics.Process.Start(path);
                }
                else
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = "explorer.exe",
                        Arguments = path,
                        UseShellExecute = true
                    });
                }
            }
        }

    }
}
