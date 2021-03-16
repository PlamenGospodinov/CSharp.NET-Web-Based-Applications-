using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        string operand1, operand2, my_operator;

        private void Calculator_Load(object sender, EventArgs e)
        {
            operand1 = null;
            operand2 = null;
            my_operator = null;
            Display.Text = "0";
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            if(operand2 == null)
            {
                operand2 = Display.Text;
            }
            Display.Text = Convert.ToString(calculate_result());
            operand1 = null;
            operand2 = null;
            my_operator = null;
        }


        double myResult;
        public Calculator()
        {
            InitializeComponent();
        }

        private void C_Click(object sender, EventArgs e)
        {
            operand1 = null;
            operand2 = null;
            my_operator = null;
            Display.Text = "0";
        }


        private void One_Click(object sender, EventArgs e)
        {
            concatenate_display("1");
        }
        private void Two_Click_1(object sender, EventArgs e)
        {
            concatenate_display("2");
        }

        private void Three_Click(object sender, EventArgs e)
        {
            concatenate_display("3");
        }

        private void Four_Click(object sender, EventArgs e)
        {
            concatenate_display("4");
        }

        private void Five_Click(object sender, EventArgs e)
        {
            concatenate_display("5");
        }

        private void Six_Click(object sender, EventArgs e)
        {
            concatenate_display("6");
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            concatenate_display("7");
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            concatenate_display("8");
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            concatenate_display("9");
        }

        public void concatenate_display(string x)
        {
            if(Display.Text != "0" && Display.Text != operand1)
            {
                is_too_long();
                Display.Text = Display.Text + x;
            }
            else
            {
                Display.Text = x;
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            op_click("/");
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            op_click("*");
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            op_click("+");
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            op_click("-");
        }

        

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Display.BackColor = colorDialog1.Color;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void Plus_Minus_Click(object sender, EventArgs e)
        {
            Display.Text = Convert.ToString(-1 * Convert.ToDouble(Display.Text));
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode.ToString() == "D0" || e.KeyCode.ToString() == "NumPad0")
                {
                    concatenate_display("0");
                }
                else if (e.KeyCode.ToString() == "D1" || e.KeyCode.ToString() == "NumPad1")
                {
                    concatenate_display("1");
                }
                else if (e.KeyCode.ToString() == "D2" || e.KeyCode.ToString() == "NumPad2")
                {
                    concatenate_display("2");
                }
                else if (e.KeyCode.ToString() == "D3" || e.KeyCode.ToString() == "NumPad3")
                {
                    concatenate_display("3");
                }
                else if (e.KeyCode.ToString() == "D4" || e.KeyCode.ToString() == "NumPad4")
                {
                    concatenate_display("4");
                }
                else if (e.KeyCode.ToString() == "D5" || e.KeyCode.ToString() == "NumPad5")
                {
                    concatenate_display("5");
                }
                else if (e.KeyCode.ToString() == "D6" || e.KeyCode.ToString() == "NumPad6")
                {
                    concatenate_display("6");
                }
                else if (e.KeyCode.ToString() == "D7" || e.KeyCode.ToString() == "NumPad7")
                {
                    concatenate_display("7");
                }
                else if (e.KeyCode.ToString() == "D8" || e.KeyCode.ToString() == "NumPad8")
                {
                    concatenate_display("8");
                }
                else if (e.KeyCode.ToString() == "D9" || e.KeyCode.ToString() == "NumPad9")
                {
                    concatenate_display("9");
                }
                else if (e.KeyCode.ToString() == "Divide")
                {
                    op_click("/");
                }
                else if (e.KeyCode.ToString() == "Multiply")
                {
                    op_click("x");
                }
                else if (e.KeyCode.ToString() == "Subtract")
                {
                    op_click("-");
                }
                else if (e.KeyCode.ToString() == "Add")
                {
                    op_click("+");
                }
  
        }

        private void CE_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            concatenate_display(".");
        }

        public void op_click(String this_operator)
        {
            if(operand1 == null)
            {
                operand1 = Display.Text;
                operand2 = null;
                Display.Text = "0";
            }
            else if(operand2 == null)
            {
                operand2 = Display.Text;
                operand1 = Convert.ToString(calculate_result());
                Display.Text = operand1;
                operand2 = null;
            }
            my_operator = this_operator;
        }



        public void is_too_long()
        {
            if(Display.Text.Length >= 33)
            {
                Console.Beep();
                MessageBox.Show("Your number is too long", "Too Long");
            }
        }

        public ref double calculate_result()
        {
            if(my_operator == "+")
            {
                myResult = Convert.ToDouble(operand1) + Convert.ToDouble(operand2);
            }
            else if (my_operator == "-")
            {
                myResult = Convert.ToDouble(operand1) - Convert.ToDouble(operand2);
            }
            else if (my_operator == "*")
            {
                myResult = Convert.ToDouble(operand1) * Convert.ToDouble(operand2);
            }
            else if (my_operator == "/")
            {
                myResult = Convert.ToDouble(operand1) / Convert.ToDouble(operand2);
            }
            
            return ref myResult;
        }


    }
}
