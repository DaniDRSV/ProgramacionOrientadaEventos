using Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Number2CheckText_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* Declaramos la validacion para que solo puedan ingresar numero
             * En la condicional if declaramos que si el caracter ingresado es diferente a un digito y
             * si el caracter ingresado es distinto a "." 
             * y tambien si es distinto a una tecla de control 
             * Entonces este no dejara al usuario digitar y aparecera un mensaje en pantalla
             */
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se pueden ingresar numeros positivos, tampoco no puedes ingresar letras");
            }

            // Si el caracter el usuario ingreso "." y la textBox contiene ".", entonces, ya no se dejara digitar al usuario el caracter "."
            if (e.KeyChar == '.' && (Number2CheckText.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }

        private void CalculateAreaButton_Click(object sender, EventArgs e)
        {
            //llamamos a la libreria de clase CalcOperations y le asignamos el nombre de operacion
            CalcOperations operacion = new CalcOperations();
            
            // traemos el numero
            double numero = double.Parse(Number2CheckText.Text);

            // ahora calculamos el resultado con la funcion CalcularArea que creamos en la libreria de clases
            double resultado = operacion.CalcularArea(numero);


            //ahora se muestra una ventana con el resultado del area
            MessageBox.Show($"El area es: {resultado}cm");

        }

        private void CalculatePerimeterButton_Click(object sender, EventArgs e)
        {
            //llamamos a la libreria de clase CalcOperations y le asignamos el nombre de operacion
            CalcOperations operacion = new CalcOperations();
            double numero = double.Parse(Number2CheckText.Text);


            // ahora calculamos el resultado con la funcion CalcularArea que creamos en la libreria de clases
            double resultado = operacion.CalcularPerimetro(numero);


            //ahora se muestra una ventana con el resultado del perimetro
            MessageBox.Show($"El perimetro es: {resultado}cm");
        }
    }
}
