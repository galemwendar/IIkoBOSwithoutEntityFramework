using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace iikoBOS_OlejaEdition_v0._1
{
    public partial class Name : Form
    {
        public Name()
        {
            InitializeComponent();
        }

        public void btn_Name_Click(object sender, EventArgs e)
        {
            NameSender();
            Close();
            tb_Name.Clear();
        }

        public void NameSender()
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                main.uName = tb_Name.Text;
            }
        }
    }
}
