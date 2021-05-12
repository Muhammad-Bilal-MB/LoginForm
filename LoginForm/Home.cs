using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class Home : Form
    {
        Login l1 = new Login();
        Register r1 = new Register();
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void close_label_Click(object sender, EventArgs e)
        {
            this.Close();
            l1.Close();
            r1.Close();
        }

        private void help_label_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(help_label, "Click LOGIN Button for Log in \nNew User? Click Register to Sign Up");
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            l1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            r1.Show();
            this.Hide();
        }

       
    }
}
