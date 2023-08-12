using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //Aqui se define el evento que se ejecuta al hacer clic al boton llamado "BotonCalcular"
        private void BotonCalcular_Click(object sender, EventArgs e)
        {
            double numero;
            numero = Convert.ToDouble(numeroIngresado.Text);
            /*Aqui se realiza la logica del calculo opuesto. Si el numero ingresado es mayor que 0
            se calcula el opuesto multiplicador por -1 y se muestra el resultado en un cuadro
            de mensaje*/
            if (numero > 0)
            {
                double numOpuesto = numero * -1;
                MessageBox.Show("El numero opuesto es: " + numOpuesto);
            }
            /* Si el numero es menor que 0, se calcula el valor absoluto y se muestra e un cuadro
             de mensaje*/
            else if (numero < 0)
            {
                double numeroNeg = System.Math.Abs(numero);
                MessageBox.Show("El numero opuesto es: " + numeroNeg);
            }
            /*Si el numero es 0, se muestra un mensaje en un cuadro que es cero*/
            else
            {
                MessageBox.Show("El numero es cero");
            }
        }
        /* Este metodo maneja el evento de presionar una tecla en el campo de texto "numeroIngresaddo"
         Lo que hace es verificar si la tecla presionada es una que no corresponde a un numero*/
        private void numeroIngresado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >=58 && e.KeyChar <=255) || (e.KeyChar >=32 && e.KeyChar <=44) || (e.KeyChar >=46 && e.KeyChar <=47))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numeros");
            }

        }
    }
}
