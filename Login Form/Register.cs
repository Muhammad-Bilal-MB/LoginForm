using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Login_Form
{
    public partial class Register : Form
    {
        string email_regex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        public Register()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Home h = new Home();
            h.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            info i = new info();

            try
            {
                i.fname = first_name_textbox.Text;
                i.lname = last_name_textbox.Text;

                Regex r = new Regex(email_regex);
                if (r.IsMatch(reg_email_textbox.Text))
                {
                    i.email = reg_email_textbox.Text;
                }
                
                i.pass = reg_password_textbox.Text;

                Class1.add_user(i);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Invalid Email Format !");
                return;
            }
            first_name_textbox.Clear();
            last_name_textbox.Clear();
            reg_email_textbox.Clear();
            reg_password_textbox.Clear();

            MessageBox.Show("Registeration Successful !");
        }
    }
}
