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
    public partial class Dashboard : Form
    {
        private UserLogin previousScreen;
        private StreamWriter sr;

        public Dashboard(UserLogin ur,int userId)
        {
            previousScreen = ur;
            InitializeComponent();
            String fullname = 
            lbl_greeting.Text = String.Format("Hello, {0} !","User");
            if (!File.Exists("data.txt"))
            {
                sr = new StreamWriter("data.txt");
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            sr.WriteLine(txt_input.Text);
        }

        protected override void OnClosed(EventArgs e)
        {
            previousScreen.Close();
            base.OnClosed(e);
        }
    }
}
