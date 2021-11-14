using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLogInApplication
{
    using System.IO;
    public partial class UserRegister : Form
    {
        UserLogin previousScreen;
        string[] idSet = new string[1000];
        string[] userNameSet = new string [1000];
        string[] passwordSet = new string[1000];
        int numberOfUsers;
        public UserRegister(UserLogin previousScreen)
        {
            this.previousScreen = previousScreen;
            InitializeComponent();

            StreamReader sr = new StreamReader("details.txt");
            string nextLine = "";
            int i = 0;
            while ((nextLine = sr.ReadLine()) != null)
            {
                string[] next = nextLine.Split(':');
                idSet[i] = next[0];
                userNameSet[i] = next[1];
                passwordSet[i] = next[2];
                i++;
               
            }
            sr.Close();
            numberOfUsers = i;

        }
        protected override void OnClosed(EventArgs e)
        {
            previousScreen.Close();
            base.OnClosed(e);

        }

        private void lbl_register_Click(object sender, EventArgs e)
        {
            
            previousScreen.Show();
            Hide();
            
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            bool canRegister = true;

            if (txt_password.Text != txt_password_again.Text)
            {
                errorMessage = "Passwords must match!";
                canRegister = false;
            }

            if (String.IsNullOrEmpty(txt_username.Text))
            {
                errorMessage = "Username cannot be empty!";
                canRegister = false;
            }

            if (String.IsNullOrEmpty(txt_password.Text))
            {
                errorMessage = "Password cannot be empty!";
                canRegister = false;
            }

            if (String.IsNullOrEmpty(txt_fullname.Text))
            {
                errorMessage = "Fullname cannot be empty!";
                canRegister = false;
            }

            if (String.IsNullOrEmpty(txt_email.Text))
            {
                errorMessage = "Email cannot be empty!";
                canRegister = false;
            }

            if (canRegister)
            {
                lbl_message.ForeColor = Color.Green;
                lbl_message.Text = "You're being registered";
                int id = numberOfUsers;
                StreamWriter sr = new StreamWriter("details.txt");
                sr.WriteLine(id + " : " + txt_username.Text + " : " + txt_password.Text + " : " + txt_fullname.Text + " : " + txt_email.Text);
                sr.Close();
            }
            else
            {
                lbl_message.Text = errorMessage;
            }


        }

        private void lbl_password_Click(object sender, EventArgs e)
        {

        }
    }
}
