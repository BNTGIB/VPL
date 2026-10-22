namespace TH2
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            treeView1 = new TreeView();
            Detail_icon = new ImageList(components);
            Small_icon = new ImageList(components);
            listView1 = new ListView();
            Large_icon = new ImageList(components);
            toolStrip1 = new ToolStrip();
            BTN_back = new ToolStripButton();
            BTN_Home = new ToolStripButton();
            BTN_next = new ToolStripButton();
            BTN_reload = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            TB_addressBar = new ToolStripTextBox();
            BTN_Search = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            BTN_delete = new ToolStripButton();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            folderToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            detailToolStripMenuItem = new ToolStripMenuItem();
            smallIconToolStripMenuItem = new ToolStripMenuItem();
            largeIconToolStripMenuItem = new ToolStripMenuItem();
            listToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            treeView1.ImageIndex = 0;
            treeView1.ImageList = Detail_icon;
            treeView1.Location = new Point(0, 58);
            treeView1.Name = "treeView1";
            treeView1.SelectedImageIndex = 0;
            treeView1.Size = new Size(292, 461);
            treeView1.TabIndex = 0;
            treeView1.BeforeExpand += treeView1_BeforeExpand;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // Detail_icon
            // 
            Detail_icon.ColorDepth = ColorDepth.Depth32Bit;
            Detail_icon.ImageStream = (ImageListStreamer)resources.GetObject("Detail_icon.ImageStream");
            Detail_icon.TransparentColor = Color.Transparent;
            Detail_icon.Images.SetKeyName(0, "drive.png");
            Detail_icon.Images.SetKeyName(1, "folder.png");
            Detail_icon.Images.SetKeyName(2, "folder2.png");
            Detail_icon.Images.SetKeyName(3, "image.png");
            Detail_icon.Images.SetKeyName(4, "textFile.png");
            Detail_icon.Images.SetKeyName(5, "thisPC.png");
            Detail_icon.Images.SetKeyName(6, "whiteFile.png");
            // 
            // Small_icon
            // 
            Small_icon.ColorDepth = ColorDepth.Depth32Bit;
            Small_icon.ImageStream = (ImageListStreamer)resources.GetObject("Small_icon.ImageStream");
            Small_icon.TransparentColor = Color.Transparent;
            Small_icon.Images.SetKeyName(0, "back.png");
            Small_icon.Images.SetKeyName(1, "next.png");
            Small_icon.Images.SetKeyName(2, "delete.png");
            Small_icon.Images.SetKeyName(3, "drive.png");
            Small_icon.Images.SetKeyName(4, "find.png");
            Small_icon.Images.SetKeyName(5, "folder.png");
            Small_icon.Images.SetKeyName(6, "folder2.png");
            Small_icon.Images.SetKeyName(7, "image.png");
            Small_icon.Images.SetKeyName(8, "home.png");
            Small_icon.Images.SetKeyName(9, "whiteFile.png");
            Small_icon.Images.SetKeyName(10, "textFile.png");
            Small_icon.Images.SetKeyName(11, "thisPC.png");
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.LargeImageList = Large_icon;
            listView1.Location = new Point(298, 58);
            listView1.Name = "listView1";
            listView1.Size = new Size(557, 461);
            listView1.SmallImageList = Small_icon;
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.MouseDoubleClick += listView1_MouseDoubleClick;
            // 
            // Large_icon
            // 
            Large_icon.ColorDepth = ColorDepth.Depth32Bit;
            Large_icon.ImageStream = (ImageListStreamer)resources.GetObject("Large_icon.ImageStream");
            Large_icon.TransparentColor = Color.Transparent;
            Large_icon.Images.SetKeyName(0, "folder.png");
            Large_icon.Images.SetKeyName(1, "folder2.png");
            Large_icon.Images.SetKeyName(2, "image.png");
            Large_icon.Images.SetKeyName(3, "textFile.png");
            Large_icon.Images.SetKeyName(4, "thisPC.png");
            Large_icon.Images.SetKeyName(5, "whiteFile.png");
            Large_icon.Images.SetKeyName(6, "drive.png");
            // 
            // toolStrip1
            // 
            toolStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { BTN_back, BTN_Home, BTN_next, BTN_reload, toolStripSeparator1, TB_addressBar, BTN_Search, toolStripSeparator3, BTN_delete });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(801, 27);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            // 
            // BTN_back
            // 
            BTN_back.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BTN_back.Image = (Image)resources.GetObject("BTN_back.Image");
            BTN_back.ImageTransparentColor = Color.Magenta;
            BTN_back.Name = "BTN_back";
            BTN_back.Size = new Size(29, 24);
            BTN_back.Text = "toolStripButton2";
            BTN_back.Click += BTN_back_Click;
            // 
            // BTN_Home
            // 
            BTN_Home.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BTN_Home.Image = (Image)resources.GetObject("BTN_Home.Image");
            BTN_Home.ImageTransparentColor = Color.Magenta;
            BTN_Home.Name = "BTN_Home";
            BTN_Home.Size = new Size(29, 24);
            BTN_Home.Text = "toolStripButton3";
            BTN_Home.Click += BTN_Home_Click;
            // 
            // BTN_next
            // 
            BTN_next.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BTN_next.Image = (Image)resources.GetObject("BTN_next.Image");
            BTN_next.ImageTransparentColor = Color.Magenta;
            BTN_next.Name = "BTN_next";
            BTN_next.Size = new Size(29, 24);
            BTN_next.Text = "toolStripButton5";
            BTN_next.Click += BTN_next_Click;
            // 
            // BTN_reload
            // 
            BTN_reload.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BTN_reload.Image = (Image)resources.GetObject("BTN_reload.Image");
            BTN_reload.ImageTransparentColor = Color.Magenta;
            BTN_reload.Name = "BTN_reload";
            BTN_reload.Size = new Size(29, 24);
            BTN_reload.Text = "toolStripButton1";
            BTN_reload.Click += BTN_reload_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // TB_addressBar
            // 
            TB_addressBar.Name = "TB_addressBar";
            TB_addressBar.Size = new Size(600, 27);
            // 
            // BTN_Search
            // 
            BTN_Search.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BTN_Search.Image = (Image)resources.GetObject("BTN_Search.Image");
            BTN_Search.ImageTransparentColor = Color.Magenta;
            BTN_Search.Name = "BTN_Search";
            BTN_Search.Size = new Size(29, 24);
            BTN_Search.Text = "toolStripButton4";
            BTN_Search.Click += BTN_Search_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // BTN_delete
            // 
            BTN_delete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BTN_delete.Image = (Image)resources.GetObject("BTN_delete.Image");
            BTN_delete.ImageTransparentColor = Color.Magenta;
            BTN_delete.Name = "BTN_delete";
            BTN_delete.Size = new Size(29, 24);
            BTN_delete.Text = "toolStripButton4";
            BTN_delete.Click += BTN_delete_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(857, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fileToolStripMenuItem1, folderToolStripMenuItem });
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(122, 26);
            newToolStripMenuItem.Text = "New";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(134, 26);
            fileToolStripMenuItem1.Text = "File";
            fileToolStripMenuItem1.Click += fileToolStripMenuItem1_Click;
            // 
            // folderToolStripMenuItem
            // 
            folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            folderToolStripMenuItem.Size = new Size(134, 26);
            folderToolStripMenuItem.Text = "Folder";
            folderToolStripMenuItem.Click += folderToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(122, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyToolStripMenuItem, cutToolStripMenuItem, pasteToolStripMenuItem, deleteToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(136, 26);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(136, 26);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(136, 26);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(136, 26);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { detailToolStripMenuItem, smallIconToolStripMenuItem, largeIconToolStripMenuItem, listToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // detailToolStripMenuItem
            // 
            detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            detailToolStripMenuItem.Size = new Size(224, 26);
            detailToolStripMenuItem.Text = "Detail";
            detailToolStripMenuItem.Click += detailToolStripMenuItem_Click;
            // 
            // smallIconToolStripMenuItem
            // 
            smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem";
            smallIconToolStripMenuItem.Size = new Size(224, 26);
            smallIconToolStripMenuItem.Text = "Small Icon";
            smallIconToolStripMenuItem.Click += smallIconToolStripMenuItem_Click;
            // 
            // largeIconToolStripMenuItem
            // 
            largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            largeIconToolStripMenuItem.Size = new Size(224, 26);
            largeIconToolStripMenuItem.Text = "Large Icon";
            largeIconToolStripMenuItem.Click += largeIconToolStripMenuItem_Click;
            // 
            // listToolStripMenuItem
            // 
            listToolStripMenuItem.Name = "listToolStripMenuItem";
            listToolStripMenuItem.Size = new Size(224, 26);
            listToolStripMenuItem.Text = "List";
            listToolStripMenuItem.Click += listToolStripMenuItem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 519);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(listView1);
            Controls.Add(treeView1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = " ";
            Load += Form2_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private ListView listView1;
        private ToolStripTextBox TB_addressBar;
        private ToolStrip toolStrip1;
        private ToolStripButton BTN_back;
        private ToolStripButton BTN_Home;
        private ToolStripButton BTN_reload;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton BTN_next;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton BTN_delete;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ImageList Small_icon;
        private ToolStripButton BTN_Search;
        private ImageList Detail_icon;
        private ImageList Large_icon;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem folderToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem detailToolStripMenuItem;
        private ToolStripMenuItem smallIconToolStripMenuItem;
        private ToolStripMenuItem largeIconToolStripMenuItem;
        private ToolStripMenuItem listToolStripMenuItem;
    }
}