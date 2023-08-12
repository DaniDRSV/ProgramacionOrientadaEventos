using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Instrucciones para el boton comprobar
        private void CheckButton_Click(object sender, EventArgs e)
        {
            //Se declara la variable como double para que el usuario introduzca el numero que desee
            double firstNumber = double.Parse(FirstNumberText.Text);

            //Se inicia una variable que sera el residuo de firstNumber dividido entre 7
            double numberCheck = firstNumber % 7;

            //Si el resultado de numberCheck es 0 entonces es un numero divisible entre 7
            if (numberCheck == 0)
            {
                ResultLabel.ForeColor = Color.Green;
                ResultLabel.Text = "El numero " + firstNumber + " es divisible entre 7";
            }

            //Sino entonces siginfica que es un numero que no es divisible entre 7
            else
            {
                ResultLabel.ForeColor = Color.Red;
                ResultLabel.Text = "El numero " + firstNumber + " no es divisible entre 7";
            }

        }


        //Instrucciones para la caja de texto del primer numero
        private void FirstNumberText_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
             
            Indicamos en la condicional if que si el caracter ingresado es diferente a un digito y diferente a "-" 
            y diferente a "." y si tambien es diferente a una tecla de control, entonces impedira al usuario seguir digitando
            y le mostrara en pantalla un mensaje de alerta.
             
             */
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros");
            }

            //Se aplica las limitaciones de uso del caracter "-" y "."
            if (e.KeyChar == '-' && FirstNumberText.Text.Contains("-"))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && FirstNumberText.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
