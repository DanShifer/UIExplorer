using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using UIExplorer.Helper;
using UIExplorer.Properties;

namespace UIExplorer
{
    public partial class UIFExplorer : Form
    {
        public UIFExplorer() => InitializeComponent();

        private void UIFExplorer_Load(object sender, EventArgs e)
        {
            for (int Drives = Components.GetDrives.Length - 1; Drives > -1; Drives--)
            {
                ExplorerPage.Controls.Add(CreateDriveGroupBox(Components.GetDrives[Drives].Name, Components.GetDrives[Drives].TotalSize, Components.GetDrives[Drives].TotalFreeSpace));
            }
        }

        #region DriveControl
        private GroupBox CreateDriveGroupBox(string Name, long AllSize, long FreeSize)
        {
            Components.GroupBox = new GroupBox();

            Components.GroupBox.Name = Components.GroupBox.Text = Name;
            Components.GroupBox.Dock = DockStyle.Top;

            Components.GroupBox.Controls.Add(CreateDriveProgressBar(AllSize, FreeSize));
            Components.GroupBox.Controls.Add(CreateDriveLabel(AllSize, FreeSize));
            Components.GroupBox.Controls.Add(CreateDrivePictureBox());

            Components.GroupBox.MouseEnter += GroupBox_MouseEnter;
            Components.GroupBox.MouseLeave += GroupBox_MouseLeave;
            Components.GroupBox.DoubleClick += DriveGroupBox_DoubleClick;
        
            return Components.GroupBox;
        }       

        private PictureBox CreateDrivePictureBox()
        {
            Components.PictureBox = new PictureBox
            {
                Image = Resources.hard,
                Dock = DockStyle.Left,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            return Components.PictureBox;
        }

        private ProgressBar CreateDriveProgressBar(long AllSize, long FreeSize)
        {
            Components.ProgressBar = new ProgressBar
            {
                Minimum = 0,
                Maximum = (int)((double)AllSize).DivisionOnNumber(1024, 3)
            };

            Components.ProgressBar.Value = (int)(Components.ProgressBar.Maximum - ((double)FreeSize).DivisionOnNumber(1024, 3));
            Components.ProgressBar.Dock = DockStyle.Bottom;

            return Components.ProgressBar;
        }

        private Label CreateDriveLabel(double AllSize, double FreeSize)
        {
            Components.Label = new Label
            {
                Text = $"{System.Math.Round(FreeSize.DivisionOnNumber(1024, 3), 2)} ГБ доступно из {System.Math.Round(AllSize.DivisionOnNumber(1024, 3), 2)} ГБ",
                Dock = DockStyle.Bottom
            };

            return Components.Label;
        }
        #endregion

        #region FolderControl
        private GroupBox CreateFolderGroupBox(string Name, string FullName)
        {
            Components.GroupBox = new GroupBox
            {
                Name = FullName,
                Text = Name,
                ContextMenuStrip = CreateFolderMenu(FullName),
                Height = 25,
                Dock = DockStyle.Top
            };

            Components.GroupBox.MouseEnter += GroupBox_MouseEnter;
            Components.GroupBox.MouseLeave += GroupBox_MouseLeave;
            Components.GroupBox.Click += FolderGroupBox_Click;
            Components.GroupBox.DoubleClick += FolderGroupBox_DoubleClick;

            return Components.GroupBox;
        }
        #endregion

        #region FileControl
        private TextBox CreateTextBox(string FullName)
        {
            Components.TextBox = new TextBox()
            {
                Dock = DockStyle.Fill,
                Multiline = true,
                ScrollBars = ScrollBars.Vertical | ScrollBars.Horizontal,
                ContextMenuStrip = CreateTextMenu(FullName)
            };

            Components.TextBox.TextChanged += TextBox_TextChanged;
        
            using (StreamReader Reader = new StreamReader(FullName))
            {
                Components.TextBox.Text = Reader.ReadToEnd();
                Components.KeyValuePairs.Add(FullName, Reader.ReadToEnd());
            }

            Components.TextBox.Name = FullName;

            return Components.TextBox;
        }
        #endregion

        #region FolderMenu
        private ContextMenuStrip CreateFolderMenu(string FullName)
        {
            Components.ContextMenuStrip = new ContextMenuStrip()
            {
                Name = FullName
            };

            Components.ContextMenuStrip.Items.Add(CreateFolderMenuItem("Открыть",FullName));
            Components.ContextMenuStrip.Items.Add(CreateFolderMenuItem("Редактировать",FullName));

            return Components.ContextMenuStrip;
        }

        private ToolStripMenuItem CreateFolderMenuItem(string Text,string FullName)
        {
            Components.CreateMenuStripItem = new ToolStripMenuItem()
            {
                Text = Text,
                Name = FullName
            };

            Components.CreateMenuStripItem.Click += CreateFolderMenuStripItem_Click;

            return Components.CreateMenuStripItem;
        }
        #endregion

        #region TextMenu
        private ContextMenuStrip CreateTextMenu(string FullName)
        {
            Components.ContextMenuStrip = new ContextMenuStrip()
            {
                Name = FullName
            };

            Components.ContextMenuStrip.Items.Add(CreateTextMenuItem("Сохранить", FullName));
            Components.ContextMenuStrip.Items.Add(CreateTextMenuItem("Закрыть с сохранением", FullName));
            Components.ContextMenuStrip.Items.Add(CreateTextMenuItem("Закрыть без сохранения", FullName));

            return Components.ContextMenuStrip;
        }

        private ToolStripMenuItem CreateTextMenuItem(string Text, string FullName)
        {
            Components.CreateMenuStripItem = new ToolStripMenuItem()
            {
                Text = Text,
                Name = FullName
            };

            Components.CreateMenuStripItem.Click += CreateFileMenuStripItem_Click;

            return Components.CreateMenuStripItem;
        }
        #endregion

        #region Event
        private void GroupBox_MouseEnter(object sender, EventArgs e) => ((GroupBox)sender).BackColor = Color.FromArgb(204, 232, 255);

        private void GroupBox_MouseLeave(object sender, EventArgs e) => ((GroupBox)sender).BackColor = Color.White;

        private void DriveGroupBox_DoubleClick(object sender, EventArgs e)
        {
            if (ExplorerControl.TabPages[((GroupBox)sender).Name] != null)
            {
                ExplorerControl.SelectTab(((GroupBox)sender).Name);
            }
            else
            {
                ExplorerControl.TabPages.Add(((GroupBox)sender).Name, ((GroupBox)sender).Name);
                ExplorerControl.TabPages[((GroupBox)sender).Name].BackColor = Color.White;
                ExplorerControl.TabPages[((GroupBox)sender).Name].AutoScroll = true;

                foreach (var GetFile in new DirectoryInfo(((GroupBox)sender).Name).GetFiles())
                {
                    ExplorerControl.TabPages[((GroupBox)sender).Name].Controls.Add(CreateFolderGroupBox(GetFile.Name, GetFile.FullName));
                }

                foreach (var GetDirectory in new DirectoryInfo(((GroupBox)sender).Name).GetDirectories())
                {
                    ExplorerControl.TabPages[((GroupBox)sender).Name].Controls.Add(CreateFolderGroupBox(GetDirectory.Name, GetDirectory.FullName));
                }

                ExplorerControl.SelectTab(((GroupBox)sender).Name);
            }
        }

        private void FolderGroupBox_Click(object sender, EventArgs e)
        {
            DirectoryInfo GetInfo = new DirectoryInfo(((GroupBox)sender).Name);

            PathLabel.Text = "Расположение:" + GetInfo.FullName;

            SizeLabel.Text = (GetInfo.Attributes & FileAttributes.Directory) == FileAttributes.Directory ? "Размер: Неизвестно" : "Размер:" + System.Math.Round(((double)new FileInfo(((GroupBox)sender).Name).Length).DivisionOnNumber(1024, 2), 2) + " МБ";

            CreatedLabel.Text = "Создан:" + GetInfo.CreationTime.ToString();
            ChangedLabel.Text = "Изменен:" + GetInfo.LastWriteTime.ToString();
            OpenLabel.Text = "Открыт:" + GetInfo.LastAccessTime.ToString();
        }
    
        private void FolderGroupBox_DoubleClick(object sender, EventArgs e)
        {
            DirectoryInfo GetInfo = new DirectoryInfo(((GroupBox)sender).Name);

            if (ExplorerControl.TabPages[((GroupBox)sender).Name] != null)
            {
                ExplorerControl.SelectTab(((GroupBox)sender).Name);
            }
            else
            {
                if ((GetInfo.Attributes & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    try
                    {
                        ExplorerControl.TabPages.Add(((GroupBox)sender).Name, ((GroupBox)sender).Name);
                        ExplorerControl.TabPages[((GroupBox)sender).Name].BackColor = Color.White;
                        ExplorerControl.TabPages[((GroupBox)sender).Name].AutoScroll = true;

                        foreach (var GetFile in GetInfo.GetFiles())
                        {
                            ExplorerControl.TabPages[((GroupBox)sender).Name].Controls.Add(CreateFolderGroupBox(GetFile.Name, GetFile.FullName));
                        }

                        foreach (var GetDirectory in GetInfo.GetDirectories())
                        {
                            ExplorerControl.TabPages[((GroupBox)sender).Name].Controls.Add(CreateFolderGroupBox(GetDirectory.Name, GetDirectory.FullName));
                        }

                        ExplorerControl.SelectTab(((GroupBox)sender).Name);
                    }
                    catch (Exception EX)
                    {
                        MessageBox.Show(EX.Message, "UIExplorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ExplorerControl.TabPages.Remove(ExplorerControl.TabPages[((GroupBox)sender).Name]);
                    }
                }
                else
                {
                    Process.Start(((GroupBox)sender).Name);
                }
            }
        }

        private void CreateFolderMenuStripItem_Click(object sender, EventArgs e)
        {
            DirectoryInfo GetInfo = new DirectoryInfo(((ToolStripMenuItem)sender).Name);

            if (((ToolStripMenuItem)sender).Text == "Открыть")
            {
                if ((GetInfo.Attributes & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    try
                    {
                        ExplorerControl.TabPages.Add(((ToolStripMenuItem)sender).Name, ((ToolStripMenuItem)sender).Name);
                        ExplorerControl.TabPages[((ToolStripMenuItem)sender).Name].BackColor = Color.White;
                        ExplorerControl.TabPages[((ToolStripMenuItem)sender).Name].AutoScroll = true;

                        foreach (var GetFile in GetInfo.GetFiles())
                        {
                            ExplorerControl.TabPages[((ToolStripMenuItem)sender).Name].Controls.Add(CreateFolderGroupBox(GetFile.Name, GetFile.FullName));
                        }

                        foreach (var GetDirectory in GetInfo.GetDirectories())
                        {
                            ExplorerControl.TabPages[((ToolStripMenuItem)sender).Name].Controls.Add(CreateFolderGroupBox(GetDirectory.Name, GetDirectory.FullName));
                        }

                        ExplorerControl.SelectTab(((ToolStripMenuItem)sender).Name);
                    }
                    catch (Exception EX)
                    {
                        MessageBox.Show(EX.Message, "UIExplorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ExplorerControl.TabPages.Remove(ExplorerControl.TabPages[((ToolStripMenuItem)sender).Name]);
                    }
                }
                else
                {
                    Process.Start(((ToolStripMenuItem)sender).Name);
                }
            }
            else
            {
                if ((GetInfo.Attributes & FileAttributes.Directory) != FileAttributes.Directory)
                {
                    ExplorerControl.TabPages.Add(((ToolStripMenuItem)sender).Name, ((ToolStripMenuItem)sender).Name);

                    ExplorerControl.TabPages[((ToolStripMenuItem)sender).Name].BackColor = Color.White;
                    ExplorerControl.TabPages[((ToolStripMenuItem)sender).Name].AutoScroll = true;
                    ExplorerControl.TabPages[((ToolStripMenuItem)sender).Name].Controls.Add(CreateTextBox(((ToolStripMenuItem)sender).Name));

                    ExplorerControl.SelectTab(((ToolStripMenuItem)sender).Name);
                }
            }
        }
    
        private void CreateFileMenuStripItem_Click(object sender, EventArgs e)
        {
            if (((ToolStripMenuItem)sender).Text == "Сохранить")
            {
                File.WriteAllText(((ToolStripMenuItem)sender).Name, Components.KeyValuePairs[((ToolStripMenuItem)sender).Name]);
            }
            else if (((ToolStripMenuItem)sender).Text == "Закрыть с сохранением")
            {
                File.WriteAllText(((ToolStripMenuItem)sender).Name, Components.KeyValuePairs[((ToolStripMenuItem)sender).Name]);
                Components.KeyValuePairs.Remove(((ToolStripMenuItem)sender).Name);

                ExplorerControl.TabPages.Remove(ExplorerControl.TabPages[((ToolStripMenuItem)sender).Name]);
            }
            else
            {
                Components.KeyValuePairs.Remove(((ToolStripMenuItem)sender).Name);
                ExplorerControl.TabPages.Remove(ExplorerControl.TabPages[((ToolStripMenuItem)sender).Name]);
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e) => Components.KeyValuePairs[((TextBox)sender).Name] = ((TextBox)sender).Text;
        #endregion

        #region Menu
        private void UIFExplorer_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;

            Message m = Message.Create(this.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void CollapsePictureBox_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void CollapsePictureBox_MouseEnter(object sender, EventArgs e) => CollapsePictureBox.BackColor = Color.Silver;

        private void CollapsePictureBox_MouseLeave(object sender, EventArgs e) => CollapsePictureBox.BackColor = Color.White;

        private void ExitPictureBox_Click(object sender, EventArgs e) => Environment.Exit(0);

        private void ExitPictureBox_MouseEnter(object sender, EventArgs e) => ExitPictureBox.BackColor = Color.Red;

        private void ExitPictureBox_MouseLeave(object sender, EventArgs e) => ExitPictureBox.BackColor = Color.White;

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e) => ExplorerControl.TabPages.Remove(ExplorerControl.TabPages[ExplorerControl.SelectedIndex]);
        #endregion
    }
}