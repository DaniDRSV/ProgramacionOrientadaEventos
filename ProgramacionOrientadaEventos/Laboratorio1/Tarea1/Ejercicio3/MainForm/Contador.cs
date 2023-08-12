using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3.MainForm
{
    public partial class Contador : Form
    {
        public Contador()
        {
            InitializeComponent();
        }
        /*Este metodo maneja el evento de clic en un boton llamado "contadorBoton"
         se declara una variable de cadena llamada "datos" y una variable entera
        llamada "contadorString"*/
        private void contadorBoton_Click(object sender, EventArgs e)
        {
            string datos;
            int contado;
        /*Luego se asigna al contenido del campo de texto "contadorString"
         a la variable "datos"*/
            datos = contadorString.Text;
        /*Aqui se calcula la longitud de la cadena almacenada en la variable "datos"
         que es la cantidad de caracteres en la cadena
        Luego se muestra en un cuadro de mensaje la cantidad de numeros y letras 
        presentes en la cadena*/
            contado = datos.Length;
            MessageBox.Show("La cantidad de letras y numeros es de: " + contado);
        }
        /*Este metodo maneja el evento de presionar una tecla en el campo de texto
         "contadorString*/
        private void contadorString_KeyPress(object sender, KeyPressEventArgs e)
        {
         /*Esta linea verifica si la tecla presionada esta fuera del rango de caracteres
          que corresponden a letras y numeros en el codigo ASCII*/
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <=64))
            {
                /*Si la tecla presionada es uno de los caracteres especiales o simbolos 
                 mostrara un cuadro de mensaje que informara al usuario que solo se permiten
                letras y numeros*/
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras y numeros");
            }
        }
    }
}
