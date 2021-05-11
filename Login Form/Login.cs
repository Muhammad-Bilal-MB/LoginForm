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
    public partial class Login : Form
    {
        bool first_click = true;
        bool first_click2 = true;
        string email_regex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
       
        public Login()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Home h1 = new Home();
            h1.Show();
        }

        private void email_textbox_TextChanged(object sender, EventArgs e)
        {
            email_textbox.BackColor = Color.DarkGray;
        }

        private void email_textbox_Click(object sender, EventArgs e)
        {
            if (first_click)
            {
                email_textbox.Text = string.Empty;
                first_click = false;
            }
            password_textbox.BackColor = Color.LightGray;
        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {
            password_textbox.BackColor = Color.DarkGray;
        }

        private void password_textbox_Click(object sender, EventArgs e)
        {
            if (first_click2)
            {
                password_textbox.Text = string.Empty;
                first_click2 = false;
            }
            email_textbox.BackColor = Color.LightGray;
        }

        private void password_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (password_checkbox.Checked)
            {
                password_textbox.UseSystemPasswordChar = true;
            }
            else
            {
                password_textbox.UseSystemPasswordChar = false;
            }       
        }

        private void email_textbox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(email_textbox.Text) == true)
            {
                errorProvider1.SetError(this.email_textbox, "Please enter e-mail");
            }
            else
            {
                Regex regex = new Regex(email_regex);
                if (regex.IsMatch(email_textbox.Text))
                {
                    errorProvider1.Clear();
                    errorProvider2.SetError(this.email_textbox, "Correct e-mail format");
                }
                else
                {
                    errorProvider1.SetError(this.email_textbox, "Incorrect e-mail format");
                }
            }
        }

        private void password_textbox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(password_textbox.Text) == true)
            {
                errorProvider1.SetError(this.password_textbox, "Please enter e-mail");
            }
        }

        private void login2_button_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(email_regex);
            if (regex.IsMatch(email_textbox.Text))
            {
                var db = new DataClasses1DataContext();
                info i = null;
                try 
                { 
                    i = db.infos.Single(p => p.email == email_textbox.Text && p.pass == password_textbox.Text); 
                }
                
                catch (InvalidOperationException exception)
                { 
                    verify.ForeColor = Color.DarkRed;
                    verify.BackColor = Color.Transparent;
                    verify.Text = "Invalid Credentials !";
                    return;
                }
                if(i != null)
                {
                    verify.ForeColor = Color.LightSeaGreen;
                    verify.BackColor = Color.Transparent;
                    verify.Text = "Login Successful !";
                    email_textbox.Clear();
                    password_textbox.Clear();
                }
                else
                {
                    verify.ForeColor = Color.DarkRed;
                    verify.BackColor = Color.Transparent;
                    verify.Text = "Invalid Credentials !";
                }
            }
            else
            {
                MessageBox.Show("Please Follow correct Format ! ");
            }
            
        }

    }
}
