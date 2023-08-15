using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosPracticaUno___POE.Forms
{
    public partial class Ejercicios : Form
    {
        public Ejercicios()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Evaluar si no es una tecla de control o un caracter
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                label1.Text = "Solo se permiten numeros";
            }
            else
            {
                label1.Text = "Solo se permiten numeros";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
            label3.Text = "Ves, te dije!";
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Blue;
            label3.Text = "Si pasas el mouse por encima cambia de color!";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten caracteres");
            }
            else
            {
                label5.Text = "Solo se permiten caracteres";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            string email = textBox3.Text;

            if (!emailValido(email))
            {
                MessageBox.Show("El correo electronico no es valido");
            }
        }

        private bool emailValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
