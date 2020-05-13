using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SecurityExplorer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UpdateFileTree();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            var fd = new FolderBrowserDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                FolderPath.Text = fd.SelectedPath;
                UpdateFileTree();
            }
        }

        private void TopLevelOnly_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFileTree();
        }

        // Update the hierarchy on the left with the files and folders from the selected path, along with security info
        private void UpdateFileTree()
        {
            StatusLabel.Text = "";
            FileTree.Nodes.Clear();
            if ((FolderPath.Text.Trim() != "") && (Directory.Exists(FolderPath.Text)))
            {
                LoadDirectory(FolderPath.Text);
                FileTree.ExpandAll();
                StatusLabel.Text = "Ready.";
            }
            else
                StatusLabel.Text = "Invalid path.";
        }

        private void LoadDirectory(string Dir)
        {
            var di = new DirectoryInfo(Dir);
            //             progressBar1.Maximum = Directory.GetFiles(Dir, "*.*", SearchOption.AllDirectories).Length + Directory.GetDirectories(Dir, "**", SearchOption.AllDirectories).Length;  
            var tds = FileTree.Nodes.Add(di.Name);
            tds.Tag = di.FullName;
            tds.StateImageIndex = 0;
            LoadFiles(Dir, tds);
            LoadSubDirectories(Dir, tds);
        }

        private void LoadFiles(string Dir, TreeNode td)
        {
            try
            {
                var Files = Directory.GetFiles(Dir, "*.*");
                // var Files = Directory.EnumerateFiles(Dir, "*.*", SearchOption.TopDirectoryOnly);
                foreach (string file in Files)
                {
                    var fi = new FileInfo(file);
                    StatusLabel.Text = fi.FullName;
                    Application.DoEvents();
                    var tds = td.Nodes.Add(fi.Name);
                    tds.StateImageIndex = 1;
                    tds.Tag = fi.FullName;
                }
            }
            catch (Exception e)
            {
                // TODO: handle in some way
            }
        }

        private void LoadSubDirectories(string dir, TreeNode td)
        {
            try
            {
                var subdirectoryEntries = Directory.GetDirectories(dir);
                foreach (string subdirectory in subdirectoryEntries)
                {
                    var di = new DirectoryInfo(subdirectory);
                    StatusLabel.Text = di.FullName;
                    Application.DoEvents();
                    var tds = td.Nodes.Add(di.Name);
                    tds.StateImageIndex = 0;
                    tds.Tag = di.FullName;
                    if (!TopLevelOnly.Checked)
                    {
                        LoadFiles(subdirectory, tds);
                        LoadSubDirectories(subdirectory, tds);
                    }
                }
            }
            catch (Exception e)
            {
                // TODO: handle in some way
            }
        }

        // Set a tool tip if the mouse is over a valid node
        private void FileTree_MouseMove(object sender, MouseEventArgs e)
        {
            var theNode = FileTree.GetNodeAt(e.X, e.Y);
            if (theNode != null && theNode.Tag != null)
            {
                if (theNode.Tag.ToString() != ToolTip.GetToolTip(FileTree))
                    ToolTip.SetToolTip(FileTree, theNode.Tag.ToString());
            }
            else
                ToolTip.SetToolTip(FileTree, "");
        }
    }
}
