using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        String operacion = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            operacion += "7";
            richTextBox1.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operacion += "8";
            richTextBox1.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operacion += "9";
            richTextBox1.Text += "9";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            operacion += "4";
            richTextBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            operacion += "5";
            richTextBox1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operacion += "6";
            richTextBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            operacion += "1";
            richTextBox1.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            operacion += "2";
            richTextBox1.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            operacion += "3";
            richTextBox1.Text += "3";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            operacion += "0";
            richTextBox1.Text += "0";
        }
        private void button16_Click(object sender, EventArgs e)
        {
            operacion += "*";
            richTextBox1.Text += "*";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operacion += "/";
            richTextBox1.Text += "/";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operacion += "+";
            richTextBox1.Text += "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operacion += "-";
            richTextBox1.Text += "-";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            char[] opSep = operacion.ToCharArray();
            String num1 = "";
            String num2 = "";
            double total = 0;

            for (int i = 0; i < opSep.Length; i++)
            {
                if (opSep[i] == '^' || opSep[i] == '√')
                {
                    if (opSep[i] == '√')
                    {
                        i++;
                        while (opSep[i] != '^' && opSep[i] != '√' && opSep[i] != '/' && opSep[i] != '*' && opSep[i] != '+' && opSep[i] != '-')
                        {
                            num2 += opSep[i];
                            i++;

                            if (i == opSep.Length) break;
                        }

                        double raiz = Math.Sqrt(double.Parse(num2));

                        total += raiz;
                    }
                    else
                    {
                        i++;
                        while (opSep[i] != '^' && opSep[i] != '√' && opSep[i] != '/' && opSep[i] != '*' && opSep[i] != '+' && opSep[i] != '-')
                        {
                            num2 += opSep[i];
                            i++;

                            if (i == opSep.Length) break;
                        }

                        double elevado = Math.Pow(double.Parse(num1), double.Parse(num2));
                        total += elevado;
                    }

                    num1 = "";
                }
                else if (opSep[i] == '/' || opSep[i] == '*')
                {
                    if (opSep[i] == '/')
                    {
                        i++;
                        while (opSep[i] != '^' && opSep[i] != '√' && opSep[i] != '/' && opSep[i] != '*' && opSep[i] != '+' && opSep[i] != '-')
                        {
                            num2 += opSep[i];
                            i++;

                            if (i == opSep.Length) break;
                        }

                        if (double.Parse(num2) == 0)
                        {
                            throw new ArgumentException("No se puede dividir por cero");
                        }

                        double dividir = double.Parse(num1) / double.Parse(num2);
                        total += dividir;
                    }
                    else
                    {
                        i++;
                        while (opSep[i] != '^' && opSep[i] != '√' && opSep[i] != '/' && opSep[i] != '*' && opSep[i] != '+' && opSep[i] != '-')
                        {
                            num2 += opSep[i];
                            i++;

                            if (i == opSep.Length) break;
                        }

                        double multiplicar = double.Parse(num1) * double.Parse(num2);
                        total += multiplicar;
                    }

                    num1 = "";
                }
                else if (opSep[i] == '+' || opSep[i] == '-')
                {
                    if (opSep[i] == '+')
                    {
                        i++;
                        while (opSep[i] != '^' && opSep[i] != '√' && opSep[i] != '/' && opSep[i] != '*' && opSep[i] != '+' && opSep[i] != '-')
                        {
                            num2 += opSep[i];
                            i++;

                            if (i == opSep.Length) break;
                        }

                        double sumar = double.Parse(num1) + double.Parse(num2);
                        total += sumar;
                    }
                    else
                    {
                        i++;
                        while (opSep[i] != '^' && opSep[i] != '√' && opSep[i] != '/' && opSep[i] != '*' && opSep[i] != '+' && opSep[i] != '-')
                        {
                            num2 += opSep[i];
                            i++;

                            if (i == opSep.Length) break;
                        }

                        double restar = double.Parse(num1) - double.Parse(num2);
                        total += restar;
                    }

                    num1 = "";
                }
                else
                {
                    num1 += opSep[i];
                }
            }

            richTextBox1.Text = total.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            operacion = "";
            richTextBox1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            operacion += ".";
            richTextBox1.Text += ".";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            operacion += "√";
            richTextBox1.Text += "√";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operacion += "^";
            richTextBox1.Text += "^";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
