using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matching_game_app
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N","d","d","b","b",
            "j", "j", "h", "h", "a", "a", "l", "l"
        };
        Label firstcliked, secondclicked;
        public Form1()
        {
            InitializeComponent();
            assignmenttosquares();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label_click(object sender, EventArgs e)
        {
            if(firstcliked!=null&&secondclicked!=null)
            {
                return;
            }
            Label clickedlabel = sender as Label;
            if (clickedlabel == null)
                return;
            if (clickedlabel.ForeColor == Color.Black)
                return;
            if(firstcliked==null)
            {
                firstcliked = clickedlabel;
                firstcliked.ForeColor = Color.Black;
                return;
            }
            secondclicked = clickedlabel;
            secondclicked.ForeColor = Color.Black;

            checkforwinner();

            if(firstcliked.Text == secondclicked.Text)
            {
                firstcliked = null;
                secondclicked = null;
            }
            else
            timer1.Start();
        }
        private void checkforwinner()
        {
            Label label;
            for(int i=0;i<tableLayoutPanel1.Controls.Count;i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;
                if (label != null && label.ForeColor == label.BackColor)
                    return;
            }
            MessageBox.Show("WOW !! THATS AMAZING ,U HAVE MATCHED ALL THE ICONS ! CONGRATS !!");
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstcliked.ForeColor = firstcliked.BackColor;
            secondclicked.ForeColor = secondclicked.BackColor;

            firstcliked = null;
            secondclicked = null;

        }

        private void assignmenttosquares()
        {
            Label label;
            int randomNumber;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count;i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                    label = (Label)tableLayoutPanel1.Controls[i];
                else
                    continue;
                randomNumber = random.Next(0, icons.Count);
                label.Text = icons[randomNumber];
                icons.RemoveAt(randomNumber);
            }
        }
    }
}
