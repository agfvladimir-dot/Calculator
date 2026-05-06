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
        string upSum;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (firstNum == true)
            {
                label1.Text += "1";
                label3.Text += "1";
                sumAll = label1.Text;

            }
            else if (firstNum == false)
            {
                label3.Text += "1";
                label2.Text += "1";
                sumAll2 = label2.Text;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (firstNum == true)
            {
                label3.Text += "2";
                label1.Text += "2";
                sumAll = label1.Text;

            }
            else if (firstNum == false)
            {
                label3.Text += "2";
                label2.Text += "2";
                sumAll2 = label2.Text;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (firstNum == true)
            {
                label3.Text += "3";
                label1.Text += "3";
                sumAll = label1.Text;

            }
            else if (firstNum == false)
            {
                label3.Text += "3";
                label2.Text += "3";
                sumAll2 = label2.Text;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (firstNum == true)
            {
                label3.Text += "4";
                label1.Text += "4";
                sumAll = label1.Text;

            }
            else if (firstNum == false)
            {
                label3.Text += "4";
                label2.Text += "4";
                sumAll2 = label2.Text;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (firstNum == true)
            {
                label3.Text += "5";
                label1.Text += "5";
                sumAll = label1.Text;

            }
            else if (firstNum == false)
            {
                label3.Text += "5";
                label2.Text += "5";
                sumAll2 = label2.Text;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (firstNum == true)
            {
                label3.Text += "6";
                label1.Text += "6";
                sumAll = label1.Text;

            }
            else if (firstNum == false)
            {
                label3.Text += "6";
                label2.Text += "6";
                sumAll2 = label2.Text;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (firstNum == true)
            {
                label3.Text += "7";
                label1.Text += "7";
                sumAll = label1.Text;

            }
            else if (firstNum == false)
            {
                label3.Text += "7";
                label2.Text += "7";
                sumAll2 = label2.Text;

            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (firstNum == true)
            {
                label3.Text += "8";
                label1.Text += "8";
                sumAll = label1.Text;

            }
            else if (firstNum == false)
            {
                label3.Text += "8";
                label2.Text += "8";
                sumAll2 = label2.Text;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (firstNum == true)
            {
                label3.Text += "9";
                label1.Text += "9";
                sumAll = label1.Text;

            }
            else if (firstNum == false)
            {
                label3.Text += "9";
                label2.Text += "9";
                sumAll2 = label2.Text;

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (sumAll != "" && firstNum == true)
            {
                label3.Text += " + ";
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
                label3.Text += " - ";
                firstNum = false;
                label1.Visible = false;
                label2.Visible = true;
                pher = "-";
            }
        }

        private void button10_Click(object sender, EventArgs e) // =
        {


            if (sumAll != "" && sumAll2 != "" && firstNum == false && pher == "+")
            {
                try
                {
                    int num1 = Convert.ToInt32(sumAll);
                    int num2 = Convert.ToInt32(sumAll2);
                    int otvet = num1 + num2;
                    label1.Text = otvet.ToString();
                    label1.Visible = true;
                    label2.Visible = false;
                    label3.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error.1\nFind num of error in settings.");
                }
            }
            else
            {
                try
                {
                    int num1 = Convert.ToInt32(sumAll);
                    int num2 = Convert.ToInt32(sumAll2);
                    int otvet = num1 - num2;
                    label1.Text = otvet.ToString();
                    label1.Visible = true;
                    label2.Visible = false;
                    label3.Text = "";
                }
                catch
                {
                    MessageBox.Show("Error.1\nFind num of error in settings.");
                }
                

            }


        }

        private void button13_Click(object sender, EventArgs e) // C
        {

            label1.Visible = true;
            label2.Visible = false;
            firstNum = true;
            sumAll = "";
            sumAll2 = "";
            pher = "";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";

        }
        int inSettings = 0;
        private void button14_Click(object sender, EventArgs e)
        {
            inSettings++;

            if (inSettings % 2 == 1)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label6.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
                button10.Visible = false;
                button11.Visible = false;
                button12.Visible = false;
                button13.Visible = false;
                button14.Text = "Close";
                button15.Visible = true; 
            }
            else
            { 
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label6.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                button9.Visible = true;
                button10.Visible = true;
                button11.Visible = true;
                button12.Visible = true;
                button13.Visible = true;
                button14.Text = "Settings";
                button15.Visible = false;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by VovaProKiller\nBased on C# Windows Forms\nV 2.0 2026");

        }
    }
}