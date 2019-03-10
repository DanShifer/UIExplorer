namespace UIExplorer
{
    partial class UIFExplorer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIFExplorer));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.PropertiesBox = new System.Windows.Forms.GroupBox();
            this.OpenLabel = new System.Windows.Forms.Label();
            this.ChangedLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.PathLabel = new System.Windows.Forms.Label();
            this.ExplorerControl = new System.Windows.Forms.TabControl();
            this.TabMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExplorerPage = new System.Windows.Forms.TabPage();
            this.ExitPictureBox = new System.Windows.Forms.PictureBox();
            this.CollapsePictureBox = new System.Windows.Forms.PictureBox();
            this.MenuPanel.SuspendLayout();
            this.PropertiesBox.SuspendLayout();
            this.ExplorerControl.SuspendLayout();
            this.TabMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CollapsePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Black;
            this.MenuPanel.Controls.Add(this.PropertiesBox);
            this.MenuPanel.Controls.Add(this.LogoLabel);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(175, 570);
            this.MenuPanel.TabIndex = 0;
            // 
            // PropertiesBox
            // 
            this.PropertiesBox.BackColor = System.Drawing.Color.Black;
            this.PropertiesBox.Controls.Add(this.OpenLabel);
            this.PropertiesBox.Controls.Add(this.ChangedLabel);
            this.PropertiesBox.Controls.Add(this.CreatedLabel);
            this.PropertiesBox.Controls.Add(this.SizeLabel);
            this.PropertiesBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PropertiesBox.ForeColor = System.Drawing.Color.White;
            this.PropertiesBox.Location = new System.Drawing.Point(0, 465);
            this.PropertiesBox.Name = "PropertiesBox";
            this.PropertiesBox.Size = new System.Drawing.Size(175, 105);
            this.PropertiesBox.TabIndex = 0;
            this.PropertiesBox.TabStop = false;
            this.PropertiesBox.Text = "Свойства";
            // 
            // OpenLabel
            // 
            this.OpenLabel.AutoSize = true;
            this.OpenLabel.ForeColor = System.Drawing.Color.White;
            this.OpenLabel.Location = new System.Drawing.Point(6, 82);
            this.OpenLabel.Name = "OpenLabel";
            this.OpenLabel.Size = new System.Drawing.Size(64, 17);
            this.OpenLabel.TabIndex = 4;
            this.OpenLabel.Text = "Открыт:";
            // 
            // ChangedLabel
            // 
            this.ChangedLabel.AutoSize = true;
            this.ChangedLabel.ForeColor = System.Drawing.Color.White;
            this.ChangedLabel.Location = new System.Drawing.Point(6, 60);
            this.ChangedLabel.Name = "ChangedLabel";
            this.ChangedLabel.Size = new System.Drawing.Size(67, 17);
            this.ChangedLabel.TabIndex = 3;
            this.ChangedLabel.Text = "Изменен:";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.ForeColor = System.Drawing.Color.White;
            this.CreatedLabel.Location = new System.Drawing.Point(6, 38);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(59, 17);
            this.CreatedLabel.TabIndex = 2;
            this.CreatedLabel.Text = "Создан:";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.ForeColor = System.Drawing.Color.White;
            this.SizeLabel.Location = new System.Drawing.Point(6, 16);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(58, 17);
            this.SizeLabel.TabIndex = 1;
            this.SizeLabel.Text = "Размер:";
            // 
            // LogoLabel
            // 
            this.LogoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoLabel.Font = new System.Drawing.Font("Tahoma", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogoLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.LogoLabel.Location = new System.Drawing.Point(0, 0);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LogoLabel.Size = new System.Drawing.Size(175, 125);
            this.LogoLabel.TabIndex = 0;
            this.LogoLabel.Text = "UI";
            this.LogoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PathLabel
            // 
            this.PathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathLabel.AutoSize = true;
            this.PathLabel.ForeColor = System.Drawing.Color.Black;
            this.PathLabel.Location = new System.Drawing.Point(181, 7);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(107, 17);
            this.PathLabel.TabIndex = 0;
            this.PathLabel.Text = "Расположение:";
            // 
            // ExplorerControl
            // 
            this.ExplorerControl.ContextMenuStrip = this.TabMenuStrip;
            this.ExplorerControl.Controls.Add(this.ExplorerPage);
            this.ExplorerControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExplorerControl.Location = new System.Drawing.Point(175, 26);
            this.ExplorerControl.Name = "ExplorerControl";
            this.ExplorerControl.SelectedIndex = 0;
            this.ExplorerControl.Size = new System.Drawing.Size(919, 544);
            this.ExplorerControl.TabIndex = 2;
            // 
            // TabMenuStrip
            // 
            this.TabMenuStrip.BackColor = System.Drawing.Color.White;
            this.TabMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TabMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseToolStripMenuItem});
            this.TabMenuStrip.Name = "TabMenuStrip";
            this.TabMenuStrip.Size = new System.Drawing.Size(211, 56);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.CloseToolStripMenuItem.Text = "Закрыть";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // ExplorerPage
            // 
            this.ExplorerPage.AutoScroll = true;
            this.ExplorerPage.BackColor = System.Drawing.Color.White;
            this.ExplorerPage.Location = new System.Drawing.Point(4, 25);
            this.ExplorerPage.Name = "ExplorerPage";
            this.ExplorerPage.Size = new System.Drawing.Size(911, 515);
            this.ExplorerPage.TabIndex = 0;
            this.ExplorerPage.Text = "Проводник";
            // 
            // ExitPictureBox
            // 
            this.ExitPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitPictureBox.BackColor = System.Drawing.Color.White;
            this.ExitPictureBox.Image = global::UIExplorer.Properties.Resources.close_button;
            this.ExitPictureBox.Location = new System.Drawing.Point(1030, 0);
            this.ExitPictureBox.Name = "ExitPictureBox";
            this.ExitPictureBox.Size = new System.Drawing.Size(64, 20);
            this.ExitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitPictureBox.TabIndex = 0;
            this.ExitPictureBox.TabStop = false;
            this.ExitPictureBox.Click += new System.EventHandler(this.ExitPictureBox_Click);
            this.ExitPictureBox.MouseEnter += new System.EventHandler(this.ExitPictureBox_MouseEnter);
            this.ExitPictureBox.MouseLeave += new System.EventHandler(this.ExitPictureBox_MouseLeave);
            // 
            // CollapsePictureBox
            // 
            this.CollapsePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CollapsePictureBox.BackColor = System.Drawing.Color.White;
            this.CollapsePictureBox.Image = global::UIExplorer.Properties.Resources._134;
            this.CollapsePictureBox.Location = new System.Drawing.Point(965, 0);
            this.CollapsePictureBox.Name = "CollapsePictureBox";
            this.CollapsePictureBox.Size = new System.Drawing.Size(64, 20);
            this.CollapsePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CollapsePictureBox.TabIndex = 1;
            this.CollapsePictureBox.TabStop = false;
            this.CollapsePictureBox.Click += new System.EventHandler(this.CollapsePictureBox_Click);
            this.CollapsePictureBox.MouseEnter += new System.EventHandler(this.CollapsePictureBox_MouseEnter);
            this.CollapsePictureBox.MouseLeave += new System.EventHandler(this.CollapsePictureBox_MouseLeave);
            // 
            // UIFExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1094, 570);
            this.Controls.Add(this.ExitPictureBox);
            this.Controls.Add(this.CollapsePictureBox);
            this.Controls.Add(this.ExplorerControl);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.PathLabel);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UIFExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UIExplorer";
            this.Load += new System.EventHandler(this.UIFExplorer_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UIFExplorer_MouseDown);
            this.MenuPanel.ResumeLayout(false);
            this.PropertiesBox.ResumeLayout(false);
            this.PropertiesBox.PerformLayout();
            this.ExplorerControl.ResumeLayout(false);
            this.TabMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CollapsePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.TabControl ExplorerControl;
        private System.Windows.Forms.TabPage ExplorerPage;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.GroupBox PropertiesBox;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Label OpenLabel;
        private System.Windows.Forms.Label ChangedLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.PictureBox ExitPictureBox;
        private System.Windows.Forms.PictureBox CollapsePictureBox;
        private System.Windows.Forms.ContextMenuStrip TabMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
    }
}

