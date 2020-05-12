using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            // TODO
        }
    }
}
