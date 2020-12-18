using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_app
{
    public partial class calculator_Form : Form
    {
        double fnumber;
        string operation;
        string method;
        public calculator_Form()
        {
            InitializeComponent();
        }

        private void text_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void one_button_Click(object sender, EventArgs e)
        {
            if(text_textBox.Text == "0" && text_textBox.Text !=null)
            {
                text_textBox.Text = "1";
            }
            else
            {
                text_textBox.Text = text_textBox.Text + "1";
            }
        }

        private void two_bvutton_Click(object sender, EventArgs e)
        {
            if(text_textBox.Text=="0" && text_textBox.Text !=null )
            {
                text_textBox.Text = "2";
            }
            else
            {
                text_textBox.Text = text_textBox.Text + "2";
                    
            }
        }

        private void three_button_Click(object sender, EventArgs e)
        {
            if(text_textBox.Text=="0" && text_textBox.Text !=null)
            {
                text_textBox.Text = "3";
            }
            else
            {
                text_textBox.Text = text_textBox.Text + "3";
            }
        }

        private void four_button_Click(object sender, EventArgs e)
        {
            if(text_textBox.Text=="0" && text_textBox.Text!=null)
            {
                text_textBox.Text = "4";
            }
            else
            {
                text_textBox.Text = text_textBox.Text + "4";
            }
        }

        private void five_button_Click(object sender, EventArgs e)
        {
            if(text_textBox.Text=="0" && text_textBox.Text!=null)
            {
                text_textBox.Text = "5";
            }
            else
            {
                text_textBox.Text = text_textBox.Text + "5";
            }
        }

        private void six_button_Click(object sender, EventArgs e)
        {
            if(text_textBox.Text=="0" && text_textBox.Text!=null)
            {
                text_textBox.Text = "6";
            }
            else
            {
                text_textBox.Text = text_textBox.Text + "6";
            }
        }

        private void seven_button_Click(object sender, EventArgs e)
        {
            if (text_textBox.Text == "0" && text_textBox.Text != null)
            {
                text_textBox.Text = "7";
            }
            else
            {
                text_textBox.Text = text_textBox.Text + "7";
            }
        }

        private void eight_button_Click(object sender, EventArgs e)
        {
            if (text_textBox.Text == "0" && text_textBox.Text != null)
            {
                text_textBox.Text = "8";
            }
            else
            {
                text_textBox.Text = text_textBox.Text + "8";
            }
        }

        private void nine_button(object sender, EventArgs e)
        {
            
        }

        private void nine_button1_Click(object sender, EventArgs e)
        {

            if (text_textBox.Text == "0" && text_textBox.Text != null)
            {
                text_textBox.Text = "9";
            }
            else
            {
                text_textBox.Text = text_textBox.Text + "9";
            }
        }

        private void zero_button_Click(object sender, EventArgs e)
        {
            text_textBox.Text = text_textBox.Text + "0";
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            text_textBox.Text = "0";
        }

        private void dot_button_Click(object sender, EventArgs e)
        {
            text_textBox.Text = text_textBox.Text + ".";
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            fnumber = Convert.ToDouble(text_textBox.Text);
            text_textBox.Text = "0";
            operation = "+";

        }

        private void minus_button_Click(object sender, EventArgs e)
        {
            fnumber = Convert.ToDouble(text_textBox.Text);
            text_textBox.Text = "0";
            operation = "-";
        }

        private void mul_button_Click(object sender, EventArgs e)
        {
            fnumber = Convert.ToDouble(text_textBox.Text);
            text_textBox.Text = "0";
            operation = "*";
        }

        private void div_button_Click(object sender, EventArgs e)
        {
            fnumber = Convert.ToDouble(text_textBox.Text);
            text_textBox.Text = "0";
            operation = "/";
        }

        private void equal_button_Click(object sender, EventArgs e)
        {
            double snumber;
            double result;
            snumber = Convert.ToDouble(text_textBox.Text);

          if(operation=="+")
            {
                result = fnumber + snumber;
                text_textBox.Text = Convert.ToString(result);
                fnumber = result;
            }
            if(operation=="-")
            {
                result = fnumber - snumber;
                text_textBox.Text = Convert.ToString(result);
                fnumber = result;
            }
            if (operation == "*")
            {
                result = fnumber * snumber;
                text_textBox.Text = Convert.ToString(result);
                fnumber = result;
            }

            if (operation == "/")
            {
                if (snumber == 0)
                {
                    text_textBox.Text = "cannot divide by zero";
                }
                else
                {
                    result = fnumber / snumber;
                    text_textBox.Text = Convert.ToString(result);
                    fnumber = result;
                }
            }

        }

        private void square_button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (text_textBox.Text != null)
            {
                if(b.Text=="x*x")
                {
                    text_textBox.Text = Math.Sqrt(double.Parse(text_textBox.Text)).ToString();
                    equal_button.PerformClick();
                    operation = text_textBox.Text;
                    
                    
                }
               


               
            }
            
        }

        private void mod_button_Click(object sender, EventArgs e)
        {
            fnumber = Convert.ToDouble(text_textBox.Text);
            text_textBox.Text = "0";
            operation == "%";

        }
    }
}
