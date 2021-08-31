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
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.Options = new System.Windows.Forms.GroupBox();
            this.Browse = new System.Windows.Forms.Button();
            this.FolderPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TopLevelOnly = new System.Windows.Forms.CheckBox();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.gbFileInfo = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblOwner = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.cbReadOnly = new System.Windows.Forms.CheckBox();
            this.cbInherits = new System.Windows.Forms.CheckBox();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Splitter)).BeginInit();
            this.Splitter.Panel1.SuspendLayout();
            this.Splitter.Panel2.SuspendLayout();
            this.Splitter.SuspendLayout();
            this.Options.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.gbFileInfo.SuspendLayout();
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
            this.MenuBar.Size = new System.Drawing.Size(1028, 24);
            this.MenuBar.TabIndex = 1;
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSecurityExplorerToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutSecurityExplorerToolStripMenuItem
            // 
            this.aboutSecurityExplorerToolStripMenuItem.Name = "aboutSecurityExplorerToolStripMenuItem";
            this.aboutSecurityExplorerToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.aboutSecurityExplorerToolStripMenuItem.Text = "About Security Explorer";
            // 
            // Splitter
            // 
            this.Splitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Splitter.Location = new System.Drawing.Point(0, 24);
            this.Splitter.Name = "Splitter";
            // 
            // Splitter.Panel1
            // 
            this.Splitter.Panel1.Controls.Add(this.FileTree);
            // 
            // Splitter.Panel2
            // 
            this.Splitter.Panel2.Controls.Add(this.gbFileInfo);
            this.Splitter.Panel2.Controls.Add(this.rtbLog);
            this.Splitter.Panel2.Controls.Add(this.Options);
            this.Splitter.Size = new System.Drawing.Size(1028, 691);
            this.Splitter.SplitterDistance = 278;
            this.Splitter.TabIndex = 2;
            // 
            // FileTree
            // 
            this.FileTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileTree.Location = new System.Drawing.Point(0, 0);
            this.FileTree.Name = "FileTree";
            this.FileTree.ShowRootLines = false;
            this.FileTree.Size = new System.Drawing.Size(278, 691);
            this.FileTree.TabIndex = 0;
            this.FileTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FileTree_AfterSelect);
            this.FileTree.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FileTree_MouseMove);
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.Location = new System.Drawing.Point(9, 326);
            this.rtbLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(725, 330);
            this.rtbLog.TabIndex = 1;
            this.rtbLog.Text = "";
            // 
            // Options
            // 
            this.Options.Controls.Add(this.Browse);
            this.Options.Controls.Add(this.FolderPath);
            this.Options.Controls.Add(this.label1);
            this.Options.Controls.Add(this.TopLevelOnly);
            this.Options.Dock = System.Windows.Forms.DockStyle.Top;
            this.Options.Location = new System.Drawing.Point(0, 0);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(746, 74);
            this.Options.TabIndex = 0;
            this.Options.TabStop = false;
            this.Options.Text = "Options";
            // 
            // Browse
            // 
            this.Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Browse.Location = new System.Drawing.Point(454, 18);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(35, 23);
            this.Browse.TabIndex = 3;
            this.Browse.Text = "...";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // FolderPath
            // 
            this.FolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderPath.Location = new System.Drawing.Point(48, 19);
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.ReadOnly = true;
            this.FolderPath.Size = new System.Drawing.Size(400, 20);
            this.FolderPath.TabIndex = 2;
            this.FolderPath.Text = "C:\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path";
            // 
            // TopLevelOnly
            // 
            this.TopLevelOnly.AutoSize = true;
            this.TopLevelOnly.Checked = true;
            this.TopLevelOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TopLevelOnly.Location = new System.Drawing.Point(48, 51);
            this.TopLevelOnly.Name = "TopLevelOnly";
            this.TopLevelOnly.Size = new System.Drawing.Size(92, 17);
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
            this.StatusBar.Location = new System.Drawing.Point(0, 693);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(1028, 22);
            this.StatusBar.TabIndex = 3;
            this.StatusBar.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(42, 17);
            this.StatusLabel.Text = "Ready.";
            // 
            // ImageList
            // 
            this.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // gbFileInfo
            // 
            this.gbFileInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFileInfo.Controls.Add(this.cbInherits);
            this.gbFileInfo.Controls.Add(this.cbReadOnly);
            this.gbFileInfo.Controls.Add(this.txtOwner);
            this.gbFileInfo.Controls.Add(this.lblOwner);
            this.gbFileInfo.Controls.Add(this.txtName);
            this.gbFileInfo.Controls.Add(this.lblName);
            this.gbFileInfo.Location = new System.Drawing.Point(9, 81);
            this.gbFileInfo.Name = "gbFileInfo";
            this.gbFileInfo.Size = new System.Drawing.Size(725, 240);
            this.gbFileInfo.TabIndex = 2;
            this.gbFileInfo.TabStop = false;
            this.gbFileInfo.Text = "Security information";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(62, 16);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(657, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(18, 48);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(38, 13);
            this.lblOwner.TabIndex = 2;
            this.lblOwner.Text = "Owner";
            // 
            // txtOwner
            // 
            this.txtOwner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOwner.Location = new System.Drawing.Point(62, 45);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.ReadOnly = true;
            this.txtOwner.Size = new System.Drawing.Size(657, 20);
            this.txtOwner.TabIndex = 3;
            // 
            // cbReadOnly
            // 
            this.cbReadOnly.AutoSize = true;
            this.cbReadOnly.Enabled = false;
            this.cbReadOnly.Location = new System.Drawing.Point(62, 77);
            this.cbReadOnly.Name = "cbReadOnly";
            this.cbReadOnly.Size = new System.Drawing.Size(73, 17);
            this.cbReadOnly.TabIndex = 4;
            this.cbReadOnly.Text = "ReadOnly";
            this.cbReadOnly.UseVisualStyleBackColor = true;
            // 
            // cbInherits
            // 
            this.cbInherits.AutoSize = true;
            this.cbInherits.Enabled = false;
            this.cbInherits.Location = new System.Drawing.Point(152, 77);
            this.cbInherits.Name = "cbInherits";
            this.cbInherits.Size = new System.Drawing.Size(116, 17);
            this.cbInherits.TabIndex = 5;
            this.cbInherits.Text = "Inherits from parent";
            this.cbInherits.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 715);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.Splitter);
            this.Controls.Add(this.MenuBar);
            this.MainMenuStrip = this.MenuBar;
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
            this.gbFileInfo.ResumeLayout(false);
            this.gbFileInfo.PerformLayout();
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
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.GroupBox gbFileInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.CheckBox cbReadOnly;
        private System.Windows.Forms.CheckBox cbInherits;
    }
}

