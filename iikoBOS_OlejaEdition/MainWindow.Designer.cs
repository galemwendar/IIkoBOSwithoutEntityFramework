
namespace iikoBOS
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.lv_Servers = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Имя = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripServerlist = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemRemoveServer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRemoveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditName = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_Url = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tb_Path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MessageBoxShow = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog_path = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_Path = new System.Windows.Forms.Button();
            this.tb_Passwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.btn_Open = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_CloseBackOffice = new System.Windows.Forms.Button();
            this.contextMenuStripServerlist.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_Servers
            // 
            this.lv_Servers.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lv_Servers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_Servers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader1,
            this.Имя});
            this.lv_Servers.ContextMenuStrip = this.contextMenuStripServerlist;
            this.lv_Servers.FullRowSelect = true;
            this.lv_Servers.GridLines = true;
            this.lv_Servers.HideSelection = false;
            this.lv_Servers.LabelWrap = false;
            this.lv_Servers.Location = new System.Drawing.Point(0, 0);
            this.lv_Servers.MultiSelect = false;
            this.lv_Servers.Name = "lv_Servers";
            this.lv_Servers.Size = new System.Drawing.Size(618, 649);
            this.lv_Servers.TabIndex = 0;
            this.lv_Servers.TabStop = false;
            this.lv_Servers.UseCompatibleStateImageBehavior = false;
            this.lv_Servers.View = System.Windows.Forms.View.Details;
            this.lv_Servers.SelectedIndexChanged += new System.EventHandler(this.lv_Servers_SelectedIndexChanged);
            this.lv_Servers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_Servers_MouseDoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "URL";
            this.columnHeader2.Width = 72;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Server Version";
            this.columnHeader3.Width = 113;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Server Edition";
            this.columnHeader4.Width = 93;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Server Name";
            this.columnHeader1.Width = 99;
            // 
            // Имя
            // 
            this.Имя.Text = "Имя";
            this.Имя.Width = 302;
            // 
            // contextMenuStripServerlist
            // 
            this.contextMenuStripServerlist.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripServerlist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRemoveServer,
            this.toolStripMenuItemRemoveAll,
            this.toolStripMenuItemEditName});
            this.contextMenuStripServerlist.Name = "contextMenuStripServerlist";
            this.contextMenuStripServerlist.Size = new System.Drawing.Size(180, 76);
            // 
            // toolStripMenuItemRemoveServer
            // 
            this.toolStripMenuItemRemoveServer.Name = "toolStripMenuItemRemoveServer";
            this.toolStripMenuItemRemoveServer.Size = new System.Drawing.Size(179, 24);
            this.toolStripMenuItemRemoveServer.Text = "Удалить";
            this.toolStripMenuItemRemoveServer.Click += new System.EventHandler(this.toolStripMenuItemDeleteServer_Click);
            // 
            // toolStripMenuItemRemoveAll
            // 
            this.toolStripMenuItemRemoveAll.Name = "toolStripMenuItemRemoveAll";
            this.toolStripMenuItemRemoveAll.Size = new System.Drawing.Size(179, 24);
            this.toolStripMenuItemRemoveAll.Text = "Удалить все";
            this.toolStripMenuItemRemoveAll.Click += new System.EventHandler(this.toolStripMenuItemRemoveAll_Click);
            // 
            // toolStripMenuItemEditName
            // 
            this.toolStripMenuItemEditName.Name = "toolStripMenuItemEditName";
            this.toolStripMenuItemEditName.Size = new System.Drawing.Size(179, 24);
            this.toolStripMenuItemEditName.Text = "Изменить имя";
            this.toolStripMenuItemEditName.Click += new System.EventHandler(this.toolStripMenuItemEditName_Click);
            // 
            // tb_Url
            // 
            this.tb_Url.Location = new System.Drawing.Point(45, 47);
            this.tb_Url.Name = "tb_Url";
            this.tb_Url.Size = new System.Drawing.Size(293, 22);
            this.tb_Url.TabIndex = 1;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(45, 92);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(124, 51);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tb_Path
            // 
            this.tb_Path.Location = new System.Drawing.Point(11, 126);
            this.tb_Path.Name = "tb_Path";
            this.tb_Path.Size = new System.Drawing.Size(293, 22);
            this.tb_Path.TabIndex = 4;
            this.tb_Path.TextChanged += new System.EventHandler(this.tb_Path_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Адрес сервера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Путь до папки с бэками";
            // 
            // MessageBoxShow
            // 
            this.MessageBoxShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageBoxShow.Location = new System.Drawing.Point(35, 172);
            this.MessageBoxShow.Name = "MessageBoxShow";
            this.MessageBoxShow.Size = new System.Drawing.Size(303, 241);
            this.MessageBoxShow.TabIndex = 7;
            this.MessageBoxShow.Text = "";
            // 
            // btn_Path
            // 
            this.btn_Path.Location = new System.Drawing.Point(391, 119);
            this.btn_Path.Name = "btn_Path";
            this.btn_Path.Size = new System.Drawing.Size(73, 36);
            this.btn_Path.TabIndex = 8;
            this.btn_Path.Text = "Path";
            this.btn_Path.UseVisualStyleBackColor = true;
            this.btn_Path.Click += new System.EventHandler(this.btn_Path_Click);
            // 
            // tb_Passwd
            // 
            this.tb_Passwd.Location = new System.Drawing.Point(11, 76);
            this.tb_Passwd.Name = "tb_Passwd";
            this.tb_Passwd.Size = new System.Drawing.Size(182, 22);
            this.tb_Passwd.TabIndex = 9;
            this.tb_Passwd.TextChanged += new System.EventHandler(this.tb_Passwd_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Логин";
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(11, 31);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(182, 22);
            this.tb_Login.TabIndex = 11;
            this.tb_Login.TextChanged += new System.EventHandler(this.tb_Login_TextChanged);
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(214, 92);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(124, 51);
            this.btn_Open.TabIndex = 13;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.lv_Servers);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 615);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.btn_Open);
            this.panel2.Controls.Add(this.MessageBoxShow);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_Add);
            this.panel2.Controls.Add(this.tb_Url);
            this.panel2.Location = new System.Drawing.Point(624, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 429);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btn_CloseBackOffice);
            this.panel3.Controls.Add(this.btn_Path);
            this.panel3.Controls.Add(this.tb_Path);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tb_Login);
            this.panel3.Controls.Add(this.tb_Passwd);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(624, 438);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(483, 166);
            this.panel3.TabIndex = 16;
            // 
            // btn_CloseBackOffice
            // 
            this.btn_CloseBackOffice.Location = new System.Drawing.Point(330, 31);
            this.btn_CloseBackOffice.Name = "btn_CloseBackOffice";
            this.btn_CloseBackOffice.Size = new System.Drawing.Size(134, 67);
            this.btn_CloseBackOffice.TabIndex = 13;
            this.btn_CloseBackOffice.Text = "Закрыть бэки";
            this.btn_CloseBackOffice.UseVisualStyleBackColor = true;
            this.btn_CloseBackOffice.Click += new System.EventHandler(this.btn_CloseBackOffice_Click);
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 615);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iikoBOS";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.contextMenuStripServerlist.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_Servers;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox tb_Url;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox tb_Path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox MessageBoxShow;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_path;
        private System.Windows.Forms.Button btn_Path;
        private System.Windows.Forms.TextBox tb_Passwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader Имя;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripServerlist;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRemoveServer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRemoveAll;
        private System.Windows.Forms.Button btn_CloseBackOffice;
    }
}

