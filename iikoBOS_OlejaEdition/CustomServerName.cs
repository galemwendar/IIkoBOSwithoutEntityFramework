using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iikoBOS
{
    public partial class CustomServerName : Form
    {
        public CustomServerName()
        {
            InitializeComponent();
        }

        public void btn_CustomServerName_Click(object sender, EventArgs e)
        {
            CustomNameSender();
            Close();
            tb_CustomServerName.Clear();
        }
        public void CustomNameSender()
        {
            MainWindow main = this.Owner as MainWindow;
            if (main != null)
            {
                main.serverCustomName = tb_CustomServerName.Text;
            }
        }
    }
}
