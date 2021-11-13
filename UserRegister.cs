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
    public partial class UserRegister : Form
    {
        UserLogin previousScreen;
        public UserRegister(UserLogin previousScreen)
        {
            this.previousScreen = previousScreen;
            InitializeComponent();
           
        }
        protected override void OnClosed(EventArgs e)
        {
            previousScreen.Close();
            base.OnClosed(e);

        }

        private void lbl_register_Click(object sender, EventArgs e)
        {
            previousScreen.Show();
        }
    }
}
