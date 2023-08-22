namespace PracticaTres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private bool img = true;
        private void BucarButton_Click(object sender, EventArgs e)
        {
            var filepath = string.Empty;
            var filecontent = string.Empty;
            // Utilizar la clase openfiledialog para vizualizar la ventana
            OpenFileDialog abrirArchivos = new OpenFileDialog();

            // Filtro para abrir imagenes png
            abrirArchivos.Filter = "png(*.png)|*.png";

            if(abrirArchivos.ShowDialog() == DialogResult.OK)
            {
                string rutaImagen = abrirArchivos.FileName;

                //Se obtiene la ruta de la imagen y se le asigna a picture box
                imageStoragePictureBox.Image = Image.FromFile(rutaImagen);
          
            }

        }

        private bool isImg = true;
        private void changeButton_Click(object sender, EventArgs e)
        {
            //Si es imagen es verdadero entonces se pone la imagen 1 y pasa a ser falso y sino pone la imagen 2 y pasa a ser verdadero
            if (isImg == true)
            {
                pictureBoxChanging.Image = Image.FromFile("C:\\Users\\maste\\Documents\\Practicas de Programacion Orientada a Eventos\\EjerciciosPracticaTres - POE\\PracticaTres\\PracticaTres\\img\\1.png");
                isImg = false;
            }
            else
            {
                pictureBoxChanging.Image = Image.FromFile("C:\\Users\\maste\\Documents\\Practicas de Programacion Orientada a Eventos\\EjerciciosPracticaTres - POE\\PracticaTres\\PracticaTres\\img\\4.png");
                isImg = true;
            }
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Como l timer esta activo cada 2 segundo cambiara de imagen
            if (isImg == true)
            {
                pictureBoxTimer.Image = Image.FromFile("C:\\Users\\maste\\Documents\\Practicas de Programacion Orientada a Eventos\\EjerciciosPracticaTres - POE\\PracticaTres\\PracticaTres\\img\\2.jpg");
                isImg = false;
            }
            else
            {
                pictureBoxTimer.Image = Image.FromFile("C:\\Users\\maste\\Documents\\Practicas de Programacion Orientada a Eventos\\EjerciciosPracticaTres - POE\\PracticaTres\\PracticaTres\\img\\3.jpg");
                isImg = true;
            }
        }
    }
}