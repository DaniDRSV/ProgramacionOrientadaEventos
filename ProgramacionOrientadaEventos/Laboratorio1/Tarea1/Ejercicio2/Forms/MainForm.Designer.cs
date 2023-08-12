namespace Ejercicio2.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CalculoOpuestoBoton = new System.Windows.Forms.Label();
            this.numeroIngresado = new System.Windows.Forms.TextBox();
            this.BotonCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CalculoOpuestoBoton
            // 
            this.CalculoOpuestoBoton.AutoSize = true;
            this.CalculoOpuestoBoton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculoOpuestoBoton.Location = new System.Drawing.Point(27, 38);
            this.CalculoOpuestoBoton.Name = "CalculoOpuestoBoton";
            this.CalculoOpuestoBoton.Size = new System.Drawing.Size(252, 26);
            this.CalculoOpuestoBoton.TabIndex = 0;
            this.CalculoOpuestoBoton.Text = "Calcular numero opuesto";
            // 
            // numeroIngresado
            // 
            this.numeroIngresado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroIngresado.Location = new System.Drawing.Point(92, 85);
            this.numeroIngresado.Name = "numeroIngresado";
            this.numeroIngresado.Size = new System.Drawing.Size(126, 22);
            this.numeroIngresado.TabIndex = 1;
            this.numeroIngresado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroIngresado_KeyPress);
            // 
            // BotonCalcular
            // 
            this.BotonCalcular.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCalcular.Location = new System.Drawing.Point(111, 123);
            this.BotonCalcular.Name = "BotonCalcular";
            this.BotonCalcular.Size = new System.Drawing.Size(85, 33);
            this.BotonCalcular.TabIndex = 2;
            this.BotonCalcular.Text = "Calcular";
            this.BotonCalcular.UseVisualStyleBackColor = true;
            this.BotonCalcular.Click += new System.EventHandler(this.BotonCalcular_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 218);
            this.Controls.Add(this.BotonCalcular);
            this.Controls.Add(this.numeroIngresado);
            this.Controls.Add(this.CalculoOpuestoBoton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "k";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CalculoOpuestoBoton;
        private System.Windows.Forms.TextBox numeroIngresado;
        private System.Windows.Forms.Button BotonCalcular;
    }
}