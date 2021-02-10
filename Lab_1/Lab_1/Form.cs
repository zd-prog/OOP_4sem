using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form : System.Windows.Forms.Form
    {
        delegate void Message();
        int operand;
        int count;
        Calculator calculator;
        public Form()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            calculator = new Calculator();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void two_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void null_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void three_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void four_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void five_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void six_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            count = 1;
            try
            {
                if (textBox1.Text == "")
                    throw new Exception("Не может начинаться с знака +");
                else
                {
                    operand = int.Parse(textBox1.Text);
                    textBox1.Text = operand.ToString() + "+";
                }
            }
            catch (Exception ex)
            {
                textBox1.Text = ex.Message;
            }
        }


        private void minus_Click(object sender, EventArgs e)
        {
            count = 2;
                if (textBox1.Text == "")
                    textBox1.Text = textBox1.Text + "-";
                else
                {
                    operand = int.Parse(textBox1.Text);
                    textBox1.Text = operand.ToString() + "-";
                }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            count = 3;
            try
            {
                if (textBox1.Text == "")
                    throw new Exception("Не может начинаться с знака *");
                else
                {
                    operand = int.Parse(textBox1.Text);
                    textBox1.Text = operand.ToString() + "*";
                }
            }
            catch (Exception ex)
            {
                textBox1.Text = ex.Message;
            }
        }

        private void devide_Click(object sender, EventArgs e)
        {
            count = 4;
            try
            {
                if (textBox1.Text == "")
                    throw new Exception("Не может начинаться с знака /");
                else
                {
                    operand = int.Parse(textBox1.Text);
                    textBox1.Text = operand.ToString() + "/";
                }
            }
            catch(Exception ex)
            {
                textBox1.Text = ex.Message;
            }
        }

        private void percent_Click(object sender, EventArgs e)
        {
            count = 5;
            try
            {
                if (textBox1.Text == "")
                    throw new Exception("Не может начинаться с знака %");
                else
                {
                    operand = int.Parse(textBox1.Text);
                    textBox1.Text = operand.ToString() + "%";
                }
            }
            catch (Exception ex)
            {
                textBox1.Text = ex.Message;
            }
        }
        private static void Show_Message(string message)
        {
            MessageBox.Show(message);
        }
        private void is_Click(object sender, EventArgs e)
        {
            string[] numbers;
            if (textBox1.Text == "")
            {
                calculator.RegisterDelegate(new Calculator.DelHandler(Show_Message));
                calculator.Error_is();
            }
            else
            {
                switch (count)
                {
                    case 1:
                        numbers = textBox1.Text.Split('+');
                        string p1 = numbers[0];
                        string p2 = numbers[1];
                        textBox1.Text = (int.Parse(p1) + int.Parse(p2)).ToString();
                        break;
                    case 2:
                        numbers = textBox1.Text.Split('-');
                        string m1 = numbers[0];
                        string m2 = numbers[1];
                        textBox1.Text = (int.Parse(m1) - int.Parse(m2)).ToString();
                        break;
                    case 3:
                        numbers = textBox1.Text.Split('*');
                        string mul1 = numbers[0];
                        string mul2 = numbers[1];
                        textBox1.Text = (int.Parse(mul1) * int.Parse(mul2)).ToString();
                        break;
                    case 4:
                        numbers = textBox1.Text.Split('/');
                        string d1 = numbers[0];
                        string d2 = numbers[1];
                        textBox1.Text = (int.Parse(d1) / int.Parse(d2)).ToString();
                        break;
                    case 5:
                        numbers = textBox1.Text.Split('%');
                        string pr1 = numbers[0];
                        string pr2 = numbers[1];
                        textBox1.Text = (int.Parse(pr1) % int.Parse(pr2)).ToString();
                        break;
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string str = Console.ReadLine();
            textBox1.Text = str;
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            calculator.memory_in(int.Parse(textBox1.Text));
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = calculator.memory.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            calculator.memory_clear();
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void Form_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 37 && number != 42 && number != 43 && number != 45 && number != 47)
            {
                e.Handled = true;
            }
        }
    }
}
