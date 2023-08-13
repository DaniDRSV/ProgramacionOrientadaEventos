namespace Ejercicio1.Forms
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.IngresarNumeroLabel = new System.Windows.Forms.Label();
            this.CalculateAreaButton = new System.Windows.Forms.Button();
            this.CalculatePerimeterButton = new System.Windows.Forms.Button();
            this.Number2CheckText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(93, 27);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(505, 30);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Calculadora de area y perimetro de un cuadrado";
            // 
            // IngresarNumeroLabel
            // 
            this.IngresarNumeroLabel.AutoSize = true;
            this.IngresarNumeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IngresarNumeroLabel.Location = new System.Drawing.Point(259, 101);
            this.IngresarNumeroLabel.Name = "IngresarNumeroLabel";
            this.IngresarNumeroLabel.Size = new System.Drawing.Size(160, 16);
            this.IngresarNumeroLabel.TabIndex = 1;
            this.IngresarNumeroLabel.Text = "Ingrese la cantidad en cm";
            // 
            // CalculateAreaButton
            // 
            this.CalculateAreaButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalculateAreaButton.Location = new System.Drawing.Point(169, 263);
            this.CalculateAreaButton.Name = "CalculateAreaButton";
            this.CalculateAreaButton.Size = new System.Drawing.Size(111, 23);
            this.CalculateAreaButton.TabIndex = 2;
            this.CalculateAreaButton.Text = "Calcular area";
            this.CalculateAreaButton.UseVisualStyleBackColor = true;
            this.CalculateAreaButton.Click += new System.EventHandler(this.CalculateAreaButton_Click);
            // 
            // CalculatePerimeterButton
            // 
            this.CalculatePerimeterButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalculatePerimeterButton.Location = new System.Drawing.Point(387, 263);
            this.CalculatePerimeterButton.Name = "CalculatePerimeterButton";
            this.CalculatePerimeterButton.Size = new System.Drawing.Size(123, 23);
            this.CalculatePerimeterButton.TabIndex = 3;
            this.CalculatePerimeterButton.Text = "Calcular perimetro";
            this.CalculatePerimeterButton.UseVisualStyleBackColor = true;
            this.CalculatePerimeterButton.Click += new System.EventHandler(this.CalculatePerimeterButton_Click);
            // 
            // Number2CheckText
            // 
            this.Number2CheckText.Location = new System.Drawing.Point(289, 144);
            this.Number2CheckText.Name = "Number2CheckText";
            this.Number2CheckText.Size = new System.Drawing.Size(100, 23);
            this.Number2CheckText.TabIndex = 4;
            this.Number2CheckText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number2CheckText_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 319);
            this.Controls.Add(this.Number2CheckText);
            this.Controls.Add(this.CalculatePerimeterButton);
            this.Controls.Add(this.CalculateAreaButton);
            this.Controls.Add(this.IngresarNumeroLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TitleLabel;
        private Label IngresarNumeroLabel;
        private Button CalculateAreaButton;
        private Button CalculatePerimeterButton;
        private TextBox Number2CheckText;
    }
}