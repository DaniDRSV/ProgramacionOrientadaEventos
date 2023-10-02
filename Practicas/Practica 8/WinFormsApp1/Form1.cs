using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
//using System.Data.;

namespace WinFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SqlConnection conexion = new SqlConnection("Data Source=SP-PC10;Initial Catalog=Empresa;Integrated Security=True; TrustServerCertificate=True");

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			conexion.Open();


			string consulta = "INSERT INTO Empleados VALUES " + "(" + idTextBox.Text + ", '" + nombreTextBox + "', '" + apellidoTextBox.Text + "', '" + direccionTextBox + "')";

			SqlCommand comando = new SqlCommand(consulta, conexion);

			comando.ExecuteNonQuery();

			MessageBox.Show("Registro agregado");

			

			conexion.Close();
		}
	}
}