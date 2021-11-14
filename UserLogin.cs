using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLogInApplication
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
            lbl_message.Visible = false;
            if (!File.Exists("details.txt"))
            {
                File.Create("details.txt").Close();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            string username = txt_username.Text.Trim();
            string password = txt_password.Text.Trim();


            StreamReader sr = new StreamReader("details.txt");
            string s = null;
            bool hasNoUser = true; ;
            while((s = sr.ReadLine()) != null)
            {
                if(s.Split(':')[1].Trim() == username && s.Split(':')[2].Trim() == password)
                {
                    lbl_message.Text = "Username and password are correct!";
                    lbl_message.Visible = true;
                    lbl_message.ForeColor = Color.Green;
                    hasNoUser = false;
                    (new Dashboard(this, 0)).Show();
                    break;
                }
            }

            if (hasNoUser)
            {
                lbl_message.Text = "Username or password is incorrect!";
                lbl_message.Visible = true;
                lbl_message.ForeColor = Color.Red;
                MessageBox.Show("Could't find an account with such credentials!");

            }
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {

        }

        private void lbl_username_Click(object sender, EventArgs e)
        {

        }

        private void lbl_password_Click(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_register_hint_Click(object sender, EventArgs e)
        {

        }

        private void bl_register_Click(object sender, EventArgs e)
        {
            (new UserRegister(this)).Show();
            Hide();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            lbl_message.Visible = false;
        }
    }
}
