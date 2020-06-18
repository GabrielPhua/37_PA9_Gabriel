using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public double userInput;
        public double convertedAmount;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_Converted_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            try
            {
                userInput = double.Parse(txt_Amount.Text);
                if(userInput < 0)
                {
                    txt_Amount.Text = "please enter a valid amount";
                }
                else
                {
                    if (rb_US.Checked)
                    {
                        convertedAmount = userInput * 0.74;
                        txt_Converted.Text = convertedAmount.ToString();
                    }
                    else if (rb_Yen.Checked)
                    {
                        convertedAmount = userInput * 81.87;
                        txt_Converted.Text = convertedAmount.ToString();
                    }
                }
            }
            catch (Exception)
            {
                txt_Amount.Text = "Please enter a valid amount";
            }
        }

        private void txt_Amount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rb_US_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Amount.Clear();
            txt_Converted.Clear();
            rb_US.Checked = false;
            rb_Yen.Checked = false;
        }
    }
}
