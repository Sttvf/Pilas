using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appPilas
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            string datos = txtEntrada.Text.ToString();
            double res = RPN(datos);
            lblRes.Text = "Resultado: " + res;
        }

        static double RPN(string datos)
        {
            Stack<double> rpn = new Stack<double>();

            string[] elementos = datos.Split(' ');

            foreach (string elemento in elementos)
            {
                double num;
                if (double.TryParse(elemento, out num))
                {
                    rpn.Push(num);
                }
                else
                {
                    double n2 = rpn.Pop();
                    double n1 = rpn.Peek();
                    rpn.Pop();

                    switch (elemento)
                    {
                        case "+":
                            rpn.Push(n1 + n2);
                            break;
                        case "-":
                            rpn.Push(n1 - n2);
                            break;
                        case "*":
                            rpn.Push(n1 * n2);
                            break;
                        case "/":
                            rpn.Push(n1 / n2);
                            break;
                        case "^":
                            rpn.Push(Math.Pow(n1, n2));
                            break;
                        default:
                            MessageBox.Show("Elemento invalido");
                            break;
                    }
                }
            }
            return rpn.Pop();
        }
    }
}
