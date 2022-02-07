using iikoBOS_prealpha_API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iikoBOS_OlejaEdition_v0._1
{
    public partial class Form1 : Form
    {
        private string mLogin = String.Empty;
        private string mPasswd = String.Empty;
        private string mUrl = string.Empty;
        private string mPath = string.Empty;
        private string filterstring = string.Empty;
        public string serverCustomName;
        Authorization auth = new Authorization();
        BackClient backClient = new BackClient();
        DataBase db = new DataBase();
        public Form1()
        {
            InitializeComponent();

            tb_Path.Text = Properties.Settings.Default.Path;
            tb_Passwd.Text = Properties.Settings.Default.Passwd;
            tb_Login.Text = Properties.Settings.Default.Login;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.CreateTable();
            RefreshListView(db.GetServers());
        }

        private void RefreshListView(List<string[]> list)
        {
            lv_Servers.Items.Clear();
            foreach (string[] s in list)
            {
                lv_Servers.Items.Add(new ListViewItem(s));
            }
        }
        //thisiscomment
        private void tb_Url_TextChanged(object sender, EventArgs e)
        {

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
            RefreshListView(db.GetServers());
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            mUrl = lv_Servers.SelectedItems[0].Text;
            backClient.BackClientConfigEdit(mUrl, mLogin);
            backClient.OpenBackOffice(mUrl, mPath);
            auth.AuthorizationMetod(mPasswd);
        }

        private void btn_CloseAll_Click(object sender, EventArgs e)
        {
            backClient.CloseBackOffice();
        }

        private void tb_Login_TextChanged(object sender, EventArgs e)
        {
            mLogin = tb_Login.Text;
            Properties.Settings.Default.Login = tb_Login.Text;
           
            Properties.Settings.Default.Save();
        }

        private void tb_Passwd_TextChanged(object sender, EventArgs e)
        {
            mPasswd = tb_Passwd.Text;
            Properties.Settings.Default.Passwd = tb_Passwd.Text;
            Properties.Settings.Default.Save();

        }

        private void tb_path_TextChanged(object sender, EventArgs e)
        {
            mPath = tb_Path.Text;
        }

        private void btn_Path_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog_Path.ShowDialog() == DialogResult.OK)
            {
                string rootDir = folderBrowserDialog_Path.SelectedPath;
                tb_Path.Text = rootDir;
                Properties.Settings.Default.Path = tb_Path.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            filterstring = tb_Search.Text;
            RefreshListView(db.GetFiltredServers(filterstring));
        }

        private void lv_Servers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            mUrl = lv_Servers.FocusedItem.Text;

            backClient.BackClientConfigEdit(mUrl, mLogin);
            backClient.OpenBackOffice(mUrl, mPath);
            auth.AuthorizationMetod(mPasswd);
        }

        private void lv_Servers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
