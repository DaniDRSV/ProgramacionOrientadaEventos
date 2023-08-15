namespace Practica2
{
    public partial class BackgroundPanel1 : Form
    {
        public BackgroundPanel1()
        {
            InitializeComponent();
        }


        /*
         
        Ejercicio 1
         
         */
        private void CambiarButton_Click(object sender, EventArgs e)
        {
            /* Se toma el label con el nombre de EjercicioUnoLabel y le cambiamos el color a rojo
             * Tambien le cambiamos el texto a otro para difenrecniar el cambio
             * Todo esto pasara al tocar el boton cambiar */
            EjercicioUnoLabel.ForeColor = Color.Red;
            EjercicioUnoLabel.Text = "Aaaaaah me cambiaste";
        }

        private void RegresarButton_Click(object sender, EventArgs e)
        {
            /* Para el boton regresar vamos a tomar el label con el nombre de EjercicioUnoLabel y le cambiamos al color por defecto
             * Tambien le ponemos el texto que tenia anteriormente */
            EjercicioUnoLabel.ForeColor = Color.Black;
            EjercicioUnoLabel.Text = "Si tocas el boton me cambias el valor";
        }




        /*
         
         Ejercicio 2
         
         */
        private void RandomColorButton_Click(object sender, EventArgs e)
        {
            // Creamos una instancia de el metodo Random 
            Random rnd = new Random();

            // Ahora llamamos al panel y le indicamos que los colores seran tomados de manera aleatoria hasta el valor 256
            // con la funcion Color.FromArgb(rnd.Next(256)
            Ejercicio2Panel.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }

        private void BlackModeButton_Click(object sender, EventArgs e)
        {
            Ejercicio2Panel.BackColor=Color.Black;
        }

        private void SliderPictureBox_Click(object sender, EventArgs e)
        {
            
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            // Para el boton de siguiente declaramos las condiciones
            // Si el SliderPictureBox1 es visible pasara a dejar de ser visible
            // Y el SliderPictureBox2 pasara a estar visible

            if (SliderPictureBox1.Visible == true)
            {
                SliderPictureBox1.Visible = false;
                SliderPictureBox2.Visible = true;
            }

            //Si es el SliderPictureBox2 el que esta visible
            // Entonces este pasara a dejar de ser visible 
            // Y el SliderPictureBox3 pasara a estar visible
            else if (SliderPictureBox2.Visible == true)
            {
                SliderPictureBox2.Visible = false;
                SliderPictureBox3.Visible = true;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // Para el boton de atras declaramos las condiciones de manera inversa
            // Si el SliderPictureBox3 es visible pasara a dejar de ser visible
            // Y el SliderPictureBox2 pasara a estar visible
            if (SliderPictureBox3.Visible == true)
            {
                SliderPictureBox3.Visible = false;
                SliderPictureBox2.Visible = true;
            }

            //Si es el SliderPictureBox2 el que esta visible
            // Entonces este pasara a dejar de ser visible 
            // Y el SliderPictureBox1 pasara a estar visible
            else if (SliderPictureBox2.Visible == true)
            {
                SliderPictureBox2.Visible = false;
                SliderPictureBox1.Visible = true;
            }
        }
    }
}