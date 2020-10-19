using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySecondGUIAPP
{
    public partial class Home_Screen : Form
    {
        public Home_Screen()
        {
            InitializeComponent();
        }

        private void login_Button_Click(object sender, EventArgs e)
        {
            string userName = this.user_Name_TextBox.Text;
            string password = this.passwd_TextBox.Text;
            if (userName.Equals("sunil") && password.Equals("sunil"))
            {
                Selection mySelection = new Selection();
                this.Hide();
                mySelection.Show();

                //MessageBox.Show("login successful","Important Note",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("invalid credentials", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
