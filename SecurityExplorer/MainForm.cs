using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SecurityExplorer
{
    public partial class MainForm : Form
    {
        // TODO: Make colours configurable
        private Color FileColor = Color.DarkMagenta;
        private Color DirColor = Color.RoyalBlue;


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
            rtbLog.Text = "";
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
            tds.ForeColor = DirColor;
            LoadFiles(Dir, tds);
            LoadSubDirectories(Dir, tds);
        }

        private void Log(string s)
        {
            rtbLog.AppendText (DateTime.Now.ToShortTimeString() + ": " + s + Environment.NewLine);
        }

        private void LoadFiles(string dir, TreeNode td)
        {
            try
            {
                var files = Directory.GetFiles(dir, "*.*");
                // var files = Directory.EnumerateFiles(dir, "*.*", SearchOption.TopDirectoryOnly);
                foreach (string file in files)
                {
                    var fi = new FileInfo(file);
                    StatusLabel.Text = fi.FullName;
                    Application.DoEvents();
                    var tds = td.Nodes.Add(fi.Name);
                    tds.StateImageIndex = 1;
                    tds.ForeColor = FileColor;
                    tds.Tag = fi.FullName;
                }
            }
            catch (Exception ex)
            {
               Log ("Could not load files. " + dir + " " + ex.Message);
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
                    tds.ForeColor = DirColor;
                    if (!TopLevelOnly.Checked)
                    {
                        LoadFiles(subdirectory, tds);
                        LoadSubDirectories(subdirectory, tds);
                    }
                }
            }
            catch (Exception ex)
            {
                Log ("Could not load subdirectory. " + dir + " " + ex.Message);
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

        private void FileTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // TODO: Currently, this displays raw security info to the screen but we want to pretty it up so it clearly shows what the users, groups and permissions are, plus what is inherited or not
            // TODO: Find better way to tag files/folders than colors so we can have these be configurable, maybe a value in the treecontrol

            var FileOrFolder = e.Node.Tag.ToString();
            var SecurityInfo = "";

            var color = e.Node.ForeColor;
            if (color == DirColor)
            {
                try
                {
                    var di = new DirectoryInfo(FileOrFolder).GetAccessControl();
                    SecurityInfo = di.GetSecurityDescriptorSddlForm(System.Security.AccessControl.AccessControlSections.All);
                }
                catch (Exception ex)
                {
                    Log ("Could not access security info. " + ex.Message);
                }
            }
            else if (color == FileColor)
            {
                try
                {
                    var ac = File.GetAccessControl(FileOrFolder);
                    SecurityInfo = ac.GetSecurityDescriptorSddlForm(System.Security.AccessControl.AccessControlSections.All);
                }
                catch (Exception ex)
                {
                    Log ("Could not access security info. " + ex.Message);
                }
            }

            Log(SecurityInfo);
            DisplaySecurityInfo(FileOrFolder, SecurityInfo);
        }

        private void DisplaySecurityInfo(string fName, string sInfo)
        // SDDL format - https://docs.microsoft.com/en-us/windows/win32/secauthz/security-descriptor-string-format
        // Parse SID strings - https://docs.microsoft.com/en-au/windows/win32/secauthz/sid-strings
        {
            txtName.Text = fName;
            // TODO: parse the SDDL string
        }
    }
}
