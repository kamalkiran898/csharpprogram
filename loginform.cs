using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practiceGUIapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {

            string userName = this.usertextBox.Text;
            string password = this.passtextBox.Text;
            if (userName.Equals("kamal") && password.Equals("kiran"))
            {
                 MessageBox.Show("login successful","Important Note",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("invalid credentials", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
