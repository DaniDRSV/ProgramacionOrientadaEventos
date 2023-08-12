using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FirstNumberText_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* Declaramos la validacion para que solo puedan ingresar numero
             * En la condicional if declaramos que si el caracter ingresado es diferente a un digito y
             * si el caracter ingresado es distinto a "-" y "." 
             * y tambien si es distinto a una tecla de control 
             * Entonces este no dejara al usuario digitar y aparecera un mensaje en pantalla
             */
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se pueden ingresar numeros");
            }


            /* 
             * En las siguientes condicionales if se declaran las limitaciones de uso para los caracteres "-" y "."
             */

            // Si el caracter el usuario ingreso "-" y la textBox contiene "-", entonces, ya no se dejara digitar al usuario el caracter "-"
            if (e.KeyChar == '-' && (FirstNumberText.Text.Contains("-")))
            {
                e.Handled = true;
            }

            // Si el caracter el usuario ingreso "." y la textBox contiene ".", entonces, ya no se dejara digitar al usuario el caracter "."
            if (e.KeyChar == '.' && (FirstNumberText.Text.Contains(".")))
            {
                e.Handled = true;
            }



        }

        private void SecondNumberText_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* Declaramos la validacion para que solo puedan ingresar numero
             * En la condicional if declaramos que si el caracter ingresado es diferente a un digito y
             * si el caracter ingresado es distinto a "-" y "." 
             * y tambien si es distinto a una tecla de control 
             * Entonces este no dejara al usuario digitar y aparecera un mensaje en pantalla
             */
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se pueden ingresar numeros");
            }


            /* 
             * En las siguientes condicionales if se declaran las limitaciones de uso para los caracteres "-" y "."
             */

            // Si el caracter el usuario ingreso "-" y la textBox contiene "-", entonces, ya no se dejara digitar al usuario el caracter "-"
            if (e.KeyChar == '-' && (SecondNumberText.Text.Contains("-")))
            {
                e.Handled = true;
            }

            // Si el caracter el usuario ingreso "." y la textBox contiene ".", entonces, ya no se dejara digitar al usuario el caracter "."
            if (e.KeyChar == '.' && (SecondNumberText.Text.Contains(".")))
            {
                e.Handled = true;
            }

        }




        //Instrucciones para el boton de comprobar
        private void CheckButton_Click(object sender, EventArgs e)
        {
            //declaramos las variables como double para que el usuario introduzca los numeros que desee
            double firstNumber = double.Parse(FirstNumberText.Text);
            double secondNumber = double.Parse(SecondNumberText.Text);


            /*
             
            En las siguientes condicionales if anidadas evaluamos que el primer y el segundo numero sean positivos, negativos, cero o si no cumplen la condicion
             
             */

            //Se evalua si el primer y el segundo numero es mayor o igual a 1, entonces son positivos 
            if (firstNumber >= 1 && secondNumber >= 1)
            {
                numbersLabel.Text = $"{firstNumber} y {secondNumber} son: ";
                ResultLabel.ForeColor = Color.Green;
                ResultLabel.Text = "Positivos!";
            }

            //Se evalua si el primer y el segundo numero es menor a 0, entonces son negativos
            else if (firstNumber < 0 && secondNumber < 0)
            {
                numbersLabel.Text = $"{firstNumber} y {secondNumber} son: ";
                ResultLabel.ForeColor = Color.Red;
                ResultLabel.Text = "Negativos!";
            }

            //Se evalua si el primer y el segundo numero es igual a 0, entonces son ambos cero
            else if (firstNumber == 0 && secondNumber == 0)
            {
                numbersLabel.Text = $"{firstNumber} y {secondNumber} son: ";
                ResultLabel.ForeColor = Color.Gray;
                ResultLabel.Text = "Cero!";
            }

            //Si ningunan de las anteriores condiciones se cumplen, entonces los numeros no cumplen los requisitos
            else
            {
                numbersLabel.Text = $"{firstNumber} y {secondNumber} son: ";
                ResultLabel.ForeColor = Color.DarkGoldenrod;
                ResultLabel.Text = "No cumplen con los requisitos :(";
            }
        }
    }
}
