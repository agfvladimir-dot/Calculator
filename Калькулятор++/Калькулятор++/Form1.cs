using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор__
{
    public partial class Form1 : Form
    {
        bool firstNum = true;
        string sumAll;
        string sumAll2;
        string pher;

        

        public void Main()
        {
            label1.Text = sumAll;
            label2.Text = sumAll2;
        }
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (firstNum == true)
            {
                label1.Text += "1";
                sumAll = label1.Text;

            }
            else if (firstNum == false)
            {
                label2.Text += "1";
                sumAll2 = label2.Text;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (firstNum == true)
            {
                label1.Text += "2";
                sumAll = label1.Text;

            }
            else if (firstNum == false)
            {
                label2.Text += "2";
                sumAll2 = label2.Text;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (firstNum == true)
            {
                label1.Text += "3";
                sumAll = label1.Text;

            }
            else if (firstNum == false)
            {
                label2.Text += "3";
                sumAll2 = label2.Text;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (firstNum == true)
            {
                label1.Text += "4";
                sumAll = label1.Text;

            }
            else if (firstNum == false)
            {
                label2.Text += "4";
                sumAll2 = label2.Text;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (firstNum == true)
            {
                label1.Text += "5";
                sumAll = label1.Text;

            }
            else if (firstNum == false)
            {
                label2.Text += "5";
                sumAll2 = label2.Text;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (firstNum == true)
            {
                label1.Text += "6";
                sumAll = label1.Text;

            }
            else if (firstNum == false)
            {
                label2.Text += "6";
                sumAll2 = label2.Text;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(firstNum == true)
            {
                label1.Text += "7";
                sumAll = label1.Text; 

            }
            else if(firstNum == false) 
            {
                label2.Text += "7";
                sumAll2 = label2.Text; 

            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (firstNum == true)
            {
                label1.Text += "8";
                sumAll = label1.Text;

            }
            else if (firstNum == false)
            {
                label2.Text += "8";
                sumAll2 = label2.Text;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (firstNum == true)
            {
                label1.Text += "9";
                sumAll = label1.Text;

            }
            else if (firstNum == false)
            {
                label2.Text += "9";
                sumAll2 = label2.Text;

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(sumAll != "" && firstNum == true)
            {
                firstNum = false;
                label1.Visible = false;
                label2.Visible = true;
                pher = "+";
            }
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (sumAll != "" && firstNum == true)
            {
                firstNum = false;
                label1.Visible = false;
                label2.Visible = true;
                pher = "-";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
            
                if (sumAll != "" && sumAll2 != "" && firstNum == false && pher == "+")
                {

                    int num1 = Convert.ToInt32(sumAll);
                    int num2 = Convert.ToInt32(sumAll2);
                    int otvet = num1 + num2;
                    label1.Text = otvet.ToString();
                    label1.Visible = true;
                    label2.Visible = false;
                    


                }
                else
                {
                    int num1 = Convert.ToInt32(sumAll);
                    int num2 = Convert.ToInt32(sumAll2);
                    int otvet = num1 - num2;
                    label1.Text = otvet.ToString();
                    label1.Visible = true;
                    label2.Visible = false;

                }
            
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = false;
            firstNum = true;
            sumAll = "";
            sumAll2 = "";
            pher = "";
            label1.Text = "";
            label2.Text = "";
            
        
        }
    }
}
