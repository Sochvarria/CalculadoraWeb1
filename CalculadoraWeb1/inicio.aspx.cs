
using System;

namespace CalculadoraWeb1
{
    public partial class inicio : System.Web.UI.Page
    {
        float n1, n2, resultado;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        void asignarvalores()
        {
            if (!float.TryParse(Num1.Text, out n1) ||
                !float.TryParse(Num2.Text, out n2))
            {
                Lresultado.Text = "Ingrese dos números válidos";
            }
        }

        void asignarvalor()
        {
            if (!float.TryParse(Num1.Text, out n1))
            {
                Lresultado.Text = "Ingrese un número válido";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (float.TryParse(Num1.Text, out n1) &&
                float.TryParse(Num2.Text, out n2))
            {
                resultado = n1 + n2;
                Lresultado.Text = "Resultado: " + resultado;
            }
            else
            {
                Lresultado.Text = "Ingrese dos números válidos";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (float.TryParse(Num1.Text, out n1) &&
                float.TryParse(Num2.Text, out n2))
            {
                resultado = n1 - n2;
                Lresultado.Text = "Resultado: " + resultado;
            }
            else
            {
                Lresultado.Text = "Ingrese dos números válidos";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (float.TryParse(Num1.Text, out n1) &&
                float.TryParse(Num2.Text, out n2))
            {
                resultado = n1 * n2;
                Lresultado.Text = "Resultado: " + resultado;
            }
            else
            {
                Lresultado.Text = "Ingrese dos números válidos";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (float.TryParse(Num1.Text, out n1) &&
                float.TryParse(Num2.Text, out n2))
            {
                if (n2 != 0)
                {
                    resultado = n1 / n2;
                    Lresultado.Text = "Resultado: " + resultado;
                }
                else
                {
                    Lresultado.Text = "No se puede dividir entre cero";
                }
            }
            else
            {
                Lresultado.Text = "Ingrese dos números válidos";
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (float.TryParse(Num1.Text, out n1))
            {
                resultado = n1 * n1;
                Lresultado.Text = "Resultado: " + resultado;
            }
            else
            {
                Lresultado.Text = "Ingrese un número válido";
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (float.TryParse(Num1.Text, out n1))
            {
                resultado = (float)Math.Exp(n1);
                Lresultado.Text = "Resultado: " + resultado;
            }
            else
            {
                Lresultado.Text = "Ingrese un número válido";
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if (float.TryParse(Num1.Text, out n1))
            {
                resultado = (float)Math.Pow(10, n1);
                Lresultado.Text = "Resultado: " + resultado;
            }
            else
            {
                Lresultado.Text = "Ingrese un número válido";
            }
        }
    }
}
