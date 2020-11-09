using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace contact_searching
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string searchtext = text1.Text;
            if (searchtext == null || searchtext == "")
            {
                MessageBox.Show("search string is empty");
            }
            else
            {
                StreamReader streamReader = new StreamReader("C:\\Users\\NARASIMHARAO\\Desktop\\csharp\\Kiran.txt");
                string temptext = streamReader.ReadLine();
                while (temptext != "")
                {
                    if (searchtext.Equals(temptext))
                    {
                        listBox1.Items.Add(searchtext);
                        listBox1.Items.Add(streamReader.ReadLine());
                        break;
                    }
                    temptext = streamReader.ReadLine();
                }
            }
        }
    }
}