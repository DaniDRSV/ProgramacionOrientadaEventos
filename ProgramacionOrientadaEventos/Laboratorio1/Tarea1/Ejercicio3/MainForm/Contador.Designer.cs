namespace Ejercicio3.MainForm
{
    partial class Contador
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
            this.label1 = new System.Windows.Forms.Label();
            this.contadorBoton = new System.Windows.Forms.Button();
            this.contadorString = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contador de digitos";
            // 
            // contadorBoton
            // 
            this.contadorBoton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contadorBoton.Location = new System.Drawing.Point(132, 184);
            this.contadorBoton.Name = "contadorBoton";
            this.contadorBoton.Size = new System.Drawing.Size(81, 40);
            this.contadorBoton.TabIndex = 1;
            this.contadorBoton.Text = "Contar";
            this.contadorBoton.UseVisualStyleBackColor = true;
            this.contadorBoton.Click += new System.EventHandler(this.contadorBoton_Click);
            // 
            // contadorString
            // 
            this.contadorString.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contadorString.Location = new System.Drawing.Point(39, 61);
            this.contadorString.Multiline = true;
            this.contadorString.Name = "contadorString";
            this.contadorString.Size = new System.Drawing.Size(269, 117);
            this.contadorString.TabIndex = 2;
            this.contadorString.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contadorString_KeyPress);
            // 
            // Contador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 246);
            this.Controls.Add(this.contadorString);
            this.Controls.Add(this.contadorBoton);
            this.Controls.Add(this.label1);
            this.Name = "Contador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button contadorBoton;
        private System.Windows.Forms.TextBox contadorString;
    }
}