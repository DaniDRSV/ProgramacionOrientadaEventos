namespace Practica2
{
    partial class BackgroundPanel1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackgroundPanel1));
            this.EjercicioUnoLabel = new System.Windows.Forms.Label();
            this.CambiarButton = new System.Windows.Forms.Button();
            this.RegresarButton = new System.Windows.Forms.Button();
            this.BlackModeButton = new System.Windows.Forms.Button();
            this.RandomColorButton = new System.Windows.Forms.Button();
            this.Ejercicio2Panel = new System.Windows.Forms.Panel();
            this.SliderPictureBox1 = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.SliderPictureBox2 = new System.Windows.Forms.PictureBox();
            this.SliderPictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SliderPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // EjercicioUnoLabel
            // 
            this.EjercicioUnoLabel.AutoSize = true;
            this.EjercicioUnoLabel.Location = new System.Drawing.Point(60, 55);
            this.EjercicioUnoLabel.Name = "EjercicioUnoLabel";
            this.EjercicioUnoLabel.Size = new System.Drawing.Size(202, 15);
            this.EjercicioUnoLabel.TabIndex = 0;
            this.EjercicioUnoLabel.Text = "Si tocas el boton me cambias el valor";
            // 
            // CambiarButton
            // 
            this.CambiarButton.Location = new System.Drawing.Point(187, 90);
            this.CambiarButton.Name = "CambiarButton";
            this.CambiarButton.Size = new System.Drawing.Size(75, 23);
            this.CambiarButton.TabIndex = 1;
            this.CambiarButton.Text = "Cambiar";
            this.CambiarButton.UseVisualStyleBackColor = true;
            this.CambiarButton.Click += new System.EventHandler(this.CambiarButton_Click);
            // 
            // RegresarButton
            // 
            this.RegresarButton.Location = new System.Drawing.Point(60, 90);
            this.RegresarButton.Name = "RegresarButton";
            this.RegresarButton.Size = new System.Drawing.Size(75, 23);
            this.RegresarButton.TabIndex = 2;
            this.RegresarButton.Text = "Regresar";
            this.RegresarButton.UseVisualStyleBackColor = true;
            this.RegresarButton.Click += new System.EventHandler(this.RegresarButton_Click);
            // 
            // BlackModeButton
            // 
            this.BlackModeButton.Location = new System.Drawing.Point(525, 177);
            this.BlackModeButton.Name = "BlackModeButton";
            this.BlackModeButton.Size = new System.Drawing.Size(97, 41);
            this.BlackModeButton.TabIndex = 3;
            this.BlackModeButton.Text = "Pasar a modo oscuro";
            this.BlackModeButton.UseVisualStyleBackColor = true;
            this.BlackModeButton.Click += new System.EventHandler(this.BlackModeButton_Click);
            // 
            // RandomColorButton
            // 
            this.RandomColorButton.Location = new System.Drawing.Point(628, 177);
            this.RandomColorButton.Name = "RandomColorButton";
            this.RandomColorButton.Size = new System.Drawing.Size(97, 42);
            this.RandomColorButton.TabIndex = 4;
            this.RandomColorButton.Text = "Cambiar fondo a color random";
            this.RandomColorButton.UseVisualStyleBackColor = true;
            this.RandomColorButton.Click += new System.EventHandler(this.RandomColorButton_Click);
            // 
            // Ejercicio2Panel
            // 
            this.Ejercicio2Panel.Location = new System.Drawing.Point(525, 55);
            this.Ejercicio2Panel.Name = "Ejercicio2Panel";
            this.Ejercicio2Panel.Size = new System.Drawing.Size(200, 100);
            this.Ejercicio2Panel.TabIndex = 5;
            // 
            // SliderPictureBox1
            // 
            this.SliderPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SliderPictureBox1.BackgroundImage")));
            this.SliderPictureBox1.Location = new System.Drawing.Point(155, 241);
            this.SliderPictureBox1.Name = "SliderPictureBox1";
            this.SliderPictureBox1.Size = new System.Drawing.Size(481, 197);
            this.SliderPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SliderPictureBox1.TabIndex = 6;
            this.SliderPictureBox1.TabStop = false;
            this.SliderPictureBox1.Click += new System.EventHandler(this.SliderPictureBox_Click);
            // 
            // BackButton
            // 
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackButton.Location = new System.Drawing.Point(125, 292);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(24, 118);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "<";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NextButton.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NextButton.Location = new System.Drawing.Point(642, 292);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(24, 118);
            this.NextButton.TabIndex = 8;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SliderPictureBox2
            // 
            this.SliderPictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SliderPictureBox2.BackgroundImage")));
            this.SliderPictureBox2.Location = new System.Drawing.Point(155, 241);
            this.SliderPictureBox2.Name = "SliderPictureBox2";
            this.SliderPictureBox2.Size = new System.Drawing.Size(481, 197);
            this.SliderPictureBox2.TabIndex = 9;
            this.SliderPictureBox2.TabStop = false;
            this.SliderPictureBox2.Visible = false;
            // 
            // SliderPictureBox3
            // 
            this.SliderPictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SliderPictureBox3.BackgroundImage")));
            this.SliderPictureBox3.Location = new System.Drawing.Point(155, 241);
            this.SliderPictureBox3.Name = "SliderPictureBox3";
            this.SliderPictureBox3.Size = new System.Drawing.Size(481, 197);
            this.SliderPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SliderPictureBox3.TabIndex = 10;
            this.SliderPictureBox3.TabStop = false;
            this.SliderPictureBox3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ejercicio 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(525, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ejercicio 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(155, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ejercicio 3";
            // 
            // BackgroundPanel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SliderPictureBox3);
            this.Controls.Add(this.SliderPictureBox2);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SliderPictureBox1);
            this.Controls.Add(this.Ejercicio2Panel);
            this.Controls.Add(this.RandomColorButton);
            this.Controls.Add(this.BlackModeButton);
            this.Controls.Add(this.RegresarButton);
            this.Controls.Add(this.CambiarButton);
            this.Controls.Add(this.EjercicioUnoLabel);
            this.Name = "BackgroundPanel1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SliderPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderPictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label EjercicioUnoLabel;
        private Button CambiarButton;
        private Button RegresarButton;
        private Button BlackModeButton;
        private Button RandomColorButton;
        private Panel Ejercicio2Panel;
        private PictureBox SliderPictureBox1;
        private Button BackButton;
        private Button NextButton;
        private PictureBox SliderPictureBox2;
        private PictureBox SliderPictureBox3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}