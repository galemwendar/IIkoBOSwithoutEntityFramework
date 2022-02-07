using iiko_it_getversion_API;
using iikoBOS_prealpha_API;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace iikoBOS
{
    public partial class MainWindow : Form
    {
        
        
        private string mLogin = String.Empty;
        private string mPasswd = String.Empty;
        private string mUrl = string.Empty;
        private string mPath = string.Empty;
        public string serverCustomName;
        Authorization auth = new Authorization();
        BackClient backClient = new BackClient();
        DataBase db = new DataBase();
        //public static string serverCustomName = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
            tb_Path.Text = Properties.Settings.Default.Path;
            tb_Passwd.Text = Properties.Settings.Default.Passwd;
            tb_Login.Text = Properties.Settings.Default.Login;
        }

        private void RefreshListView()
        {
            var list = db.GetServers();
            foreach (string[] s in list)
            {
                lv_Servers.Items.Add(new ListViewItem(s));
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Url.Text))
            { return; }
            mUrl = tb_Url.Text;
            var serverProperties = backClient.GetServerProperties(mUrl);
            //AddServerToList();
            tb_Url.Clear();
            db.InsertServerProperties(mUrl, serverProperties.Version, serverProperties.Edition, serverProperties.ServerName);
            RefreshListView();

        }

        private void lv_Servers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tb_Url.Text = lv_Servers.FocusedItem.Text;
        }

        private void btn_Path_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog_path.ShowDialog() == DialogResult.OK)
            {
                string rootDir = folderBrowserDialog_path.SelectedPath;
                tb_Path.Text = rootDir;
                Properties.Settings.Default.Path = tb_Path.Text;
                Properties.Settings.Default.Save();
            }
        }



        private void tb_Passwd_TextChanged(object sender, EventArgs e)
        {
            mPasswd = tb_Passwd.Text;
            Properties.Settings.Default.Passwd = tb_Passwd.Text;
            Properties.Settings.Default.Save();
        }

       
        private void lv_Servers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            mUrl = lv_Servers.FocusedItem.Text;
            
            backClient.BackClientConfigEdit(mUrl,mLogin);
            backClient.OpenBackOffice(mUrl, mPath);
            auth.AuthorizationMetod(mPasswd);
            
           
        }

        private void tb_Login_TextChanged(object sender, EventArgs e)
        {
            mLogin = tb_Login.Text;
            Properties.Settings.Default.Login = tb_Login.Text;
            Properties.Settings.Default.Save();
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            mUrl = lv_Servers.SelectedItems[0].Text;
            backClient.BackClientConfigEdit(mUrl,mLogin);
            backClient.OpenBackOffice(mUrl, mPath);
            auth.AuthorizationMetod(mPasswd);

        }

        private void toolStripMenuItemDeleteServer_Click(object sender, EventArgs e)
        {
            //lv_Servers.FocusedItem.Remove();
            if (lv_Servers.Items.Count > 0)
            {
                lv_Servers.Items.Remove(lv_Servers.SelectedItems[0]);
            }
        }

        private void toolStripMenuItemRemoveAll_Click(object sender, EventArgs e)
        {
            lv_Servers.Items.Clear();
        }
        private void CustomServerNameShow()
        {
            CustomServerName customServerName = new CustomServerName();
            customServerName.Owner = this;
            customServerName.ShowDialog();
        }

        private void toolStripMenuItemEditName_Click(object sender, EventArgs e)
        {
            CustomServerNameShow();
            lv_Servers.SelectedItems[0].SubItems[4].Text = serverCustomName;
        }

        private void btn_CloseBackOffice_Click(object sender, EventArgs e)
        {
            backClient.CloseBackOffice();
        }

        private void tb_Path_TextChanged(object sender, EventArgs e)
        {
            mPath = tb_Path.Text;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            db.CreateTable();
            RefreshListView();
        }
    }
}
