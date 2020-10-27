namespace SecurityExplorer
{
    partial class MainForm
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
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSecurityExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Splitter = new System.Windows.Forms.SplitContainer();
            this.FileTree = new System.Windows.Forms.TreeView();
            this.Options = new System.Windows.Forms.GroupBox();
            this.Browse = new System.Windows.Forms.Button();
            this.FolderPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TopLevelOnly = new System.Windows.Forms.CheckBox();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.rtbSecurityInfo = new System.Windows.Forms.RichTextBox();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Splitter)).BeginInit();
            this.Splitter.Panel1.SuspendLayout();
            this.Splitter.Panel2.SuspendLayout();
            this.Splitter.SuspendLayout();
            this.Options.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.helpToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MenuBar.Size = new System.Drawing.Size(1371, 28);
            this.MenuBar.TabIndex = 1;
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(46, 24);
            this.FileMenu.Text = "File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSecurityExplorerToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutSecurityExplorerToolStripMenuItem
            // 
            this.aboutSecurityExplorerToolStripMenuItem.Name = "aboutSecurityExplorerToolStripMenuItem";
            this.aboutSecurityExplorerToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.aboutSecurityExplorerToolStripMenuItem.Text = "About Security Explorer";
            // 
            // Splitter
            // 
            this.Splitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Splitter.Location = new System.Drawing.Point(0, 28);
            this.Splitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Splitter.Name = "Splitter";
            // 
            // Splitter.Panel1
            // 
            this.Splitter.Panel1.Controls.Add(this.FileTree);
            // 
            // Splitter.Panel2
            // 
            this.Splitter.Panel2.Controls.Add(this.rtbSecurityInfo);
            this.Splitter.Panel2.Controls.Add(this.Options);
            this.Splitter.Size = new System.Drawing.Size(1371, 852);
            this.Splitter.SplitterDistance = 372;
            this.Splitter.SplitterWidth = 5;
            this.Splitter.TabIndex = 2;
            // 
            // FileTree
            // 
            this.FileTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileTree.Location = new System.Drawing.Point(0, 0);
            this.FileTree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FileTree.Name = "FileTree";
            this.FileTree.ShowRootLines = false;
            this.FileTree.Size = new System.Drawing.Size(372, 852);
            this.FileTree.TabIndex = 0;
            this.FileTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FileTree_AfterSelect);
            this.FileTree.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FileTree_MouseMove);
            // 
            // Options
            // 
            this.Options.Controls.Add(this.Browse);
            this.Options.Controls.Add(this.FolderPath);
            this.Options.Controls.Add(this.label1);
            this.Options.Controls.Add(this.TopLevelOnly);
            this.Options.Dock = System.Windows.Forms.DockStyle.Top;
            this.Options.Location = new System.Drawing.Point(0, 0);
            this.Options.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Options.Name = "Options";
            this.Options.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Options.Size = new System.Drawing.Size(994, 91);
            this.Options.TabIndex = 0;
            this.Options.TabStop = false;
            this.Options.Text = "Options";
            // 
            // Browse
            // 
            this.Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Browse.Location = new System.Drawing.Point(605, 22);
            this.Browse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(47, 28);
            this.Browse.TabIndex = 3;
            this.Browse.Text = "...";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // FolderPath
            // 
            this.FolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderPath.Location = new System.Drawing.Point(64, 23);
            this.FolderPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.ReadOnly = true;
            this.FolderPath.Size = new System.Drawing.Size(532, 22);
            this.FolderPath.TabIndex = 2;
            this.FolderPath.Text = "C:\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path";
            // 
            // TopLevelOnly
            // 
            this.TopLevelOnly.AutoSize = true;
            this.TopLevelOnly.Checked = true;
            this.TopLevelOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TopLevelOnly.Location = new System.Drawing.Point(64, 63);
            this.TopLevelOnly.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TopLevelOnly.Name = "TopLevelOnly";
            this.TopLevelOnly.Size = new System.Drawing.Size(119, 21);
            this.TopLevelOnly.TabIndex = 0;
            this.TopLevelOnly.Text = "Top-level only";
            this.TopLevelOnly.UseVisualStyleBackColor = true;
            this.TopLevelOnly.CheckedChanged += new System.EventHandler(this.TopLevelOnly_CheckedChanged);
            // 
            // StatusBar
            // 
            this.StatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusBar.Location = new System.Drawing.Point(0, 854);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StatusBar.Size = new System.Drawing.Size(1371, 26);
            this.StatusBar.TabIndex = 3;
            this.StatusBar.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(53, 20);
            this.StatusLabel.Text = "Ready.";
            // 
            // ImageList
            // 
            this.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // rtbSecurityInfo
            // 
            this.rtbSecurityInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbSecurityInfo.Location = new System.Drawing.Point(0, 91);
            this.rtbSecurityInfo.Name = "rtbSecurityInfo";
            this.rtbSecurityInfo.ReadOnly = true;
            this.rtbSecurityInfo.Size = new System.Drawing.Size(994, 761);
            this.rtbSecurityInfo.TabIndex = 1;
            this.rtbSecurityInfo.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 880);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.Splitter);
            this.Controls.Add(this.MenuBar);
            this.MainMenuStrip = this.MenuBar;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Security Explorer";
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.Splitter.Panel1.ResumeLayout(false);
            this.Splitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Splitter)).EndInit();
            this.Splitter.ResumeLayout(false);
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.SplitContainer Splitter;
        private System.Windows.Forms.TreeView FileTree;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSecurityExplorerToolStripMenuItem;
        private System.Windows.Forms.GroupBox Options;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.TextBox FolderPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox TopLevelOnly;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.RichTextBox rtbSecurityInfo;
    }
}

