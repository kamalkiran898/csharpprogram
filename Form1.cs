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

namespace mypictureviewer_app
{
    public partial class Form1 : Form
    {
        string dirpath;
         int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dirpath = openFileDialog1.FileName;
                pictureBox1.Load(openFileDialog1.FileName);
                nextbutton.Enabled = true;
            }
            else
            {

            }

        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void setbackgroundbutton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            //Throws exception if the directory contains other than image files.

            FileInfo fInfo = new FileInfo(dirpath);
            DirectoryInfo dInfo = fInfo.Directory;
            FileInfo[] lFiles = dInfo.GetFiles("*.jpg");
            //MessageBox.Show(lFiles.Length.ToString());
            if (i < lFiles.Length)
                pictureBox1.Load(lFiles[i++].FullName);
            else
            {
                i = 0;
                pictureBox1.Load(lFiles[i++].FullName);
            }

        }

        private void stretchcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (stretchcheckBox.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}

