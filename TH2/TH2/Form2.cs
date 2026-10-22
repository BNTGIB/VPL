using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;


namespace TH2
{
    public partial class Form2 : Form
    {
        // For History of Path
        Stack<string> path_back = new Stack<string> { }; 
        Stack<string> path_next = new Stack<string> { };
        bool isButton = false;
        // For read drives
        DriveInfo[] drives = DriveInfo.GetDrives();

        // For cut - copy - paste
        List<string> sourcePath = new List<string>();
        bool isCut = false;


        private bool driveExists(string path)
        {
            foreach (DriveInfo drive in drives)
            {
                if (path == drive.Name) return true;
            }
            return false;
        }
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


        private void expandHome(TreeNode thisPC)
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
            if (node == null)
                return;

            if (node.Tag.ToString() == "ThisPC")
            {
                expandHome(node);
                return;
            }
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

        private void FindNode(string path)
        {
            if (Directory.Exists(path))
            {
                string[] folders = path.Split('\\');
                folders[0] += '\\';
                TreeNode node = treeView1.Nodes[0];

                foreach (string folder in folders)
                {
                    node.Expand();
                    foreach (TreeNode child in node.Nodes)
                    {
                        if (child.Text == folder)
                        {
                            node = child;
                            break;
                        }
                    }
                }
                treeView1.SelectedNode = node;
                node.Expand();
            }
            else if (path == "ThisPC")
            {
                treeView1.SelectedNode = treeView1.Nodes[0];
            }
            else
            {
                MessageBox.Show("Not Found");
            }
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
            if (!isButton)
            {
                TB_addressBar.Text = "This PC";
                if (path_back.Count != 0 && path_back.Peek() != "ThisPC")
                    path_back.Push("ThisPC");

                if (path_next.Count != 0 && path_next.Peek() != "ThisPC")
                    path_next.Clear();
            }

        }
        private void openItem(string path)
        {
            TB_addressBar.Text = path;

            if (!isButton)
            {
                if (path_back.Count != 0 && path_back.Peek() != path)
                {
                    path_back.Push(path);
                }



                if (path_next.Count != 0 && path_next.Peek() != path)
                {
                    path_next.Clear();
                }

            }

            if (path == "ThisPC")
            {
                openHome();
                return;
            }


            if (path == null || !Directory.Exists(path))
                return;

            DirectoryInfo[] folders;
            FileInfo[] files;

            DirectoryInfo dir = new DirectoryInfo(path);
            listView1.Items.Clear();
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
        }

        private void refresh()
        {
            FindNode(path_back.Peek());
            openItem(path_back.Peek());
        }
        ///////////////////////////////////FORM LOAD/////////////////////////////

        private void Form2_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;

            listView1.Columns.Add("Name", 200);
            listView1.Columns.Add("Type", 100);
            listView1.Columns.Add("Size", 100);

            TreeNode thisPC = treeView1.Nodes.Add("This PC");
            thisPC.Tag = "ThisPC";
            thisPC.ImageKey = "thisPC.png";
            thisPC.SelectedImageKey = "thisPC.png";

            expandHome(thisPC);
            path_back.Push("ThisPC");
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
            if (node == null)
            {
                return;
            }

            if (node.Tag.ToString() != "ThisPC")
            {
                node.Nodes.Clear();
                expandNode(node);
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 && Directory.Exists(listView1.SelectedItems[0].Tag.ToString()))
            {
                FindNode(listView1.SelectedItems[0].Tag.ToString());
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

                DialogResult dia = MessageBox.Show("Xác nhận xoá: " + listView1.SelectedItems[0].Text,
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
                        refresh();
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
                    FindNode(path);
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
            isButton = true;
            if (path_back.Count > 1)
            {
                path_next.Push(path_back.Pop());
                string path = path_back.Peek();
                if (path != "")
                {
                    FindNode(path);
                    openItem(path);
                }
            }
            isButton = false;
        }

        private void BTN_next_Click(object sender, EventArgs e)
        {
            isButton = true;
            if (path_next.Count != 0)
            {
                string path = path_next.Pop();
                path_back.Push(path);
                //MessageBox.Show("Button push_back" + path);
                if (path != "")
                {
                    FindNode(path);
                    openItem(path);
                }
            }
            isButton = false;
        }

        private void BTN_reload_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            refresh();
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
            refresh();
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
            refresh();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
            refresh();
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string newFileName = Microsoft.VisualBasic.Interaction.InputBox("File Name", "Create New File", "Newfile.txt");

            if (newFileName == "")
                return;

            DirectoryInfo dir = new DirectoryInfo(path_back.Peek());
            string newPath = dir.FullName + "/" + newFileName;
            if (!File.Exists(newPath))
            {
                File.Create(newPath);
            }
            else
            {
                MessageBox.Show("Tên thư mục đã tồn tại");
            }

            refresh();
        }

        private void folderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newFolderName = Microsoft.VisualBasic.Interaction.InputBox("Folder Name", "Create New Folder", "New Folder");

            if (newFolderName == "")
                return;

            DirectoryInfo dir = new DirectoryInfo(path_back.Peek());
            string newPath = dir.FullName + "/" + newFolderName;
            DirectoryInfo newfolder = new DirectoryInfo(newPath);
            if (!dir.Exists)
            {
                dir.Create();
            }
            else
            {
                MessageBox.Show("Tên thư mục đã tồn tại");
            }

            refresh();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Cut-Copy-Paste-Delete
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sourcePath.Clear();
            if(listView1.SelectedItems.Count == 0) 
                return;

            foreach (ListViewItem item in listView1.SelectedItems)
            {
                sourcePath.Add(item.Tag.ToString());
            }
            isCut = false;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sourcePath.Clear();
            if (listView1.SelectedItems.Count == 0)
                return;

            foreach (var item in listView1.SelectedItems)
            {
                sourcePath.Add(item.ToString());
            }
            isCut = true;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool CompleteCut = true;
            if (sourcePath.Count == 0)
                return;

            string destfolder = path_back.Peek();
            foreach (var item in sourcePath)
            {
                try
                {
                    string desPath = path_back.Peek() + "/" + Path.GetFileName(item);
                    if (File.Exists(item))
                    {
                        if (!File.Exists(desPath))
                        {
                            if (isCut)

                                File.Move(item, desPath);
                            else
                                File.Copy(item, desPath);
                        }
                        else
                        {
                            DialogResult dia = MessageBox.Show("Lỗi: Tên file " + Path.GetFileName(item) + " đã tồn tại. Bạn có muốn bỏ qua file/folde này?",
                                                        "Cảnh báo",
                                                         MessageBoxButtons.OKCancel,
                                                         MessageBoxIcon.Warning);
                            if (dia == DialogResult.Cancel)
                            {
                                CompleteCut = false;
                                break;
                            }
                            else
                                continue;
                        }
                    }
                    
                    else if (Directory.Exists(item))
                    {
                        if (!Directory.Exists(desPath))
                        {
                            if (isCut)

                                Directory.Move(item, desPath);
                            //else
                                 //CopyDirectory(item, desPath);
                        }
                        else
                        {
                            DialogResult dia = MessageBox.Show("Lỗi: Tên thư mục " + Path.GetFileName(item) + " Đã tồn tại. Bạn có muốn bỏ qua file/folde này?",
                                                        "Cảnh báo",
                                                         MessageBoxButtons.OKCancel,
                                                         MessageBoxIcon.Warning);
                            if (dia == DialogResult.Cancel)
                            {
                                CompleteCut = false;
                                break;
                            }
                            else
                                continue;
                        }
                    }
                }
                catch (Exception ex)
                {
                    DialogResult dia = MessageBox.Show("Lỗi: " + ex.Message + " khi xử lý " + Path.GetFileName(item) + ". Bạn có muốn bỏ qua file/folde này?",
                                                    "Cảnh báo",
                                                     MessageBoxButtons.OKCancel,
                                                     MessageBoxIcon.Warning);
                    if (dia == DialogResult.Cancel)
                    {
                        CompleteCut = false;
                        break;
                    }
                    else
                        continue;
                }
            }
            if (isCut && CompleteCut)
            {
                sourcePath.Clear();
            }
            refresh();
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTN_delete_Click(sender, e);
        }
    }
}
