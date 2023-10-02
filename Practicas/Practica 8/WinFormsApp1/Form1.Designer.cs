namespace WinFormsApp1
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.idTextBox = new System.Windows.Forms.TextBox();
			this.nombreTextBox = new System.Windows.Forms.TextBox();
			this.apellidoTextBox = new System.Windows.Forms.TextBox();
			this.direccionTextBox = new System.Windows.Forms.TextBox();
			this.idLabel = new System.Windows.Forms.Label();
			this.nombreLabel = new System.Windows.Forms.Label();
			this.apellidoLabel = new System.Windows.Forms.Label();
			this.direccionLabel = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// idTextBox
			// 
			this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.idTextBox.Location = new System.Drawing.Point(150, 123);
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.Size = new System.Drawing.Size(159, 23);
			this.idTextBox.TabIndex = 0;
			// 
			// nombreTextBox
			// 
			this.nombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.nombreTextBox.Location = new System.Drawing.Point(150, 167);
			this.nombreTextBox.Name = "nombreTextBox";
			this.nombreTextBox.Size = new System.Drawing.Size(159, 23);
			this.nombreTextBox.TabIndex = 1;
			// 
			// apellidoTextBox
			// 
			this.apellidoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.apellidoTextBox.Location = new System.Drawing.Point(150, 207);
			this.apellidoTextBox.Name = "apellidoTextBox";
			this.apellidoTextBox.Size = new System.Drawing.Size(159, 23);
			this.apellidoTextBox.TabIndex = 2;
			// 
			// direccionTextBox
			// 
			this.direccionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.direccionTextBox.Location = new System.Drawing.Point(150, 247);
			this.direccionTextBox.Name = "direccionTextBox";
			this.direccionTextBox.Size = new System.Drawing.Size(159, 23);
			this.direccionTextBox.TabIndex = 3;
			// 
			// idLabel
			// 
			this.idLabel.AutoSize = true;
			this.idLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.idLabel.Location = new System.Drawing.Point(106, 126);
			this.idLabel.Name = "idLabel";
			this.idLabel.Size = new System.Drawing.Size(20, 15);
			this.idLabel.TabIndex = 4;
			this.idLabel.Text = "ID";
			// 
			// nombreLabel
			// 
			this.nombreLabel.AutoSize = true;
			this.nombreLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.nombreLabel.Location = new System.Drawing.Point(93, 170);
			this.nombreLabel.Name = "nombreLabel";
			this.nombreLabel.Size = new System.Drawing.Size(53, 15);
			this.nombreLabel.TabIndex = 5;
			this.nombreLabel.Text = "Nombre";
			// 
			// apellidoLabel
			// 
			this.apellidoLabel.AutoSize = true;
			this.apellidoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.apellidoLabel.Location = new System.Drawing.Point(93, 210);
			this.apellidoLabel.Name = "apellidoLabel";
			this.apellidoLabel.Size = new System.Drawing.Size(52, 15);
			this.apellidoLabel.TabIndex = 6;
			this.apellidoLabel.Text = "Apellido";
			// 
			// direccionLabel
			// 
			this.direccionLabel.AutoSize = true;
			this.direccionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.direccionLabel.Location = new System.Drawing.Point(87, 250);
			this.direccionLabel.Name = "direccionLabel";
			this.direccionLabel.Size = new System.Drawing.Size(60, 15);
			this.direccionLabel.TabIndex = 7;
			this.direccionLabel.Text = "Direccion";
			// 
			// dataGridView1
			// 
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(363, 95);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(410, 244);
			this.dataGridView1.TabIndex = 8;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnAgregar.Location = new System.Drawing.Point(72, 316);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 23);
			this.btnAgregar.TabIndex = 9;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnEditar.Location = new System.Drawing.Point(172, 316);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(75, 23);
			this.btnEditar.TabIndex = 10;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnEliminar.Location = new System.Drawing.Point(266, 316);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 11;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.direccionLabel);
			this.Controls.Add(this.apellidoLabel);
			this.Controls.Add(this.nombreLabel);
			this.Controls.Add(this.idLabel);
			this.Controls.Add(this.direccionTextBox);
			this.Controls.Add(this.apellidoTextBox);
			this.Controls.Add(this.nombreTextBox);
			this.Controls.Add(this.idTextBox);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Conexion a base de datos";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox idTextBox;
		private TextBox nombreTextBox;
		private TextBox apellidoTextBox;
		private TextBox direccionTextBox;
		private Label idLabel;
		private Label nombreLabel;
		private Label apellidoLabel;
		private Label direccionLabel;
		private DataGridView dataGridView1;
		private Button btnAgregar;
		private Button btnEditar;
		private Button btnEliminar;
	}
}