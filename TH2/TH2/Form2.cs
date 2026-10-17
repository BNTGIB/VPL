using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;


namespace TH2
{
    public partial class Form2 : Form
    {
        Stack<string> path_back = new Stack<string> { };
        Stack<string> path_next = new Stack<string> { };

        DriveInfo[] drives = DriveInfo.GetDrives();
        public Form2()
        {
            InitializeComponent();

        }
        string[] donvi = { " bytes", " KB", " MB", " GB", " TB" };
        private string quydoi(long size)
        {
            int cs = 0;
            while (size >= 1024)
            {
                size /= 1024;
                cs++;
            }
            return size.ToString() + donvi[cs];
        }

        private void openHome()
        {
            listView1.Items.Clear();
            foreach (DriveInfo drive in drives)
            {

                ListViewItem item = new ListViewItem(drive.Name);
                item.Tag = drive.Name;

                item.SubItems.Add(drive.DriveType.ToString());
                item.SubItems.Add(quydoi(drive.TotalSize));
                item.ImageKey = "drive.png";

                listView1.Items.Add(item);

            }

            TB_addressBar.Text = "This PC";
            path_back.Push("ThisPC");

        }

        private void expandHome( TreeNode thisPC)
        {
            foreach (DriveInfo drive in drives)
            {
                TreeNode node = thisPC.Nodes.Add(drive.Name);
                node.Tag = drive.Name;
                node.Nodes.Add("temp");
                node.ImageKey = "drive.png";
                node.SelectedImageKey = "drive.png";
            }
            thisPC.Expand();
        }
        private void expandNode(TreeNode node)
        {
            string[] folders;

            try
            {
                folders = Directory.GetDirectories(node.Tag.ToString());
            }
            catch (UnauthorizedAccessException)
            {
                return;
            }
            catch (IOException)
            {
                return;
            }

            foreach (string folder in folders)
            {

                TreeNode node_child = node.Nodes.Add(Path.GetFileName(folder));
                node_child.Tag = folder;
                node_child.Nodes.Add("temp");
                node_child.ImageKey = "folder.png";
                node_child.SelectedImageKey = "folder.png";

            }

        }
        private void openItem(string path)
        {
            DirectoryInfo[] folders;
            FileInfo[] files;
            FileSystemInfo[] faf;

            DirectoryInfo dir = new DirectoryInfo(path);

            try
            {
                folders = dir.GetDirectories();
                files = dir.GetFiles();
            }
            catch (UnauthorizedAccessException)
            {
                return;
            }
            catch (IOException)
            {
                return;
            }

            listView1.Items.Clear();
            foreach (var folder in folders)
            {

                ListViewItem item_child = listView1.Items.Add(folder.Name);
                item_child.Tag = folder.FullName;
                item_child.SubItems.Add("File Folder");
                item_child.ImageKey = "folder2.png";
            }
            foreach (FileInfo file in files)
            {

                ListViewItem item_child = listView1.Items.Add(file.Name);
                item_child.Tag = file.FullName;
                item_child.SubItems.Add(file.Extension);
                item_child.SubItems.Add(quydoi(file.Length));
                if (file.Extension == ".txt")
                {
                    item_child.ImageKey = "textFile.png";
                }
                else if (file.Extension == ".png" || file.Extension == ".jpg" || file.Extension == ".jpeg")
                {
                    item_child.ImageKey = "image.png";
                }
                else
                {
                    item_child.ImageKey = "whiteFile.png";
                }
            }

            path_back.Push(path);
        }
        ///////////////////////////////////FORM LOAD/////////////////////////////

        private void Form2_Load(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;

            listView1.Columns.Add("Name", 200);
            listView1.Columns.Add("Type", 100);
            listView1.Columns.Add("Size", 100);

            TreeNode thisPC = treeView1.Nodes.Add("This PC");
            thisPC.Tag = "ThisPC";
            thisPC.ImageKey = "thisPC.png";
            thisPC.SelectedImageKey = "thisPC.png";

            expandHome(thisPC);

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag.ToString() == "ThisPC")
            {
                openHome();
            }
            else
            {
                openItem(e.Node.Tag.ToString());
            }
            TB_addressBar.Text = e.Node.Tag.ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                TB_addressBar.Text = listView1.SelectedItems[0].Tag.ToString();
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            if (node.Tag.ToString() == "ThisPC")
            {
                return;
            }
            node.Nodes.Clear();
            expandNode(node);
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                openItem(listView1.SelectedItems[0].Tag.ToString());
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void BTN_delete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string path = listView1.SelectedItems[0].Tag.ToString();
                DialogResult dia = MessageBox.Show(listView1.SelectedItems[0].Name,
                                                    "Xác nhận xoá",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);
                if (dia == DialogResult.Yes)
                {
                    try
                    {
                        if (File.Exists(path))
                        {
                            File.Delete(path);
                        }
                        else if (Directory.Exists(path))
                        {
                            Directory.Delete(path);
                        }
                        listView1.Items.Remove(listView1.SelectedItems[0]);

                        MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xoá: " + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
        }

        private void TB_addressBar_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Search_Click(object sender, EventArgs e)
        {
            string path = TB_addressBar.Text;
            if (path != "")
            {
                if (Directory.Exists(path))
                {
                    openItem(path);
                }
                else
                {
                    MessageBox.Show("Đường dẫn không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BTN_Home_Click(object sender, EventArgs e)
        {
            openHome();
        }

        private void BTN_back_Click(object sender, EventArgs e)
        {
            if (path_back.Count >1 )
            {
                path_next.Push(path_back.Pop());
                string path = path_back.Pop();
                if (path != "")
                {
                    if (Directory.Exists(path))
                    {
                        openItem(path);
                    }
                }
            }
        }

        private void BTN_next_Click(object sender, EventArgs e)
        {
            if (path_next.Count != 0)
            {
                string path = path_next.Pop();
                if (path != "")
                {
                    if (Directory.Exists(path))
                    {
                        openItem(path);
                    }
                }
            }
        }
    }
}
