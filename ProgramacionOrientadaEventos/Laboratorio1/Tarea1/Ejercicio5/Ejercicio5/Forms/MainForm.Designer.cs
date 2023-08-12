namespace Ejercicio5.Forms
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
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNumberText = new System.Windows.Forms.TextBox();
            this.FirstNumberLabel = new System.Windows.Forms.Label();
            this.SecondNumberText = new System.Windows.Forms.TextBox();
            this.SecondNumberLabel = new System.Windows.Forms.Label();
            this.CheckButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.numbersLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(220, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Determinar condicion de numeros";
            // 
            // FirstNumberText
            // 
            this.FirstNumberText.Location = new System.Drawing.Point(336, 153);
            this.FirstNumberText.Name = "FirstNumberText";
            this.FirstNumberText.Size = new System.Drawing.Size(100, 23);
            this.FirstNumberText.TabIndex = 1;
            this.FirstNumberText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstNumberText_KeyPress);
            // 
            // FirstNumberLabel
            // 
            this.FirstNumberLabel.AutoSize = true;
            this.FirstNumberLabel.Location = new System.Drawing.Point(314, 135);
            this.FirstNumberLabel.Name = "FirstNumberLabel";
            this.FirstNumberLabel.Size = new System.Drawing.Size(140, 15);
            this.FirstNumberLabel.TabIndex = 2;
            this.FirstNumberLabel.Text = "Ingrese el primer numero";
            // 
            // SecondNumberText
            // 
            this.SecondNumberText.Location = new System.Drawing.Point(336, 233);
            this.SecondNumberText.Name = "SecondNumberText";
            this.SecondNumberText.Size = new System.Drawing.Size(100, 23);
            this.SecondNumberText.TabIndex = 1;
            this.SecondNumberText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecondNumberText_KeyPress);
            // 
            // SecondNumberLabel
            // 
            this.SecondNumberLabel.AutoSize = true;
            this.SecondNumberLabel.Location = new System.Drawing.Point(313, 215);
            this.SecondNumberLabel.Name = "SecondNumberLabel";
            this.SecondNumberLabel.Size = new System.Drawing.Size(151, 15);
            this.SecondNumberLabel.TabIndex = 2;
            this.SecondNumberLabel.Text = "Ingrese el segundo numero";
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(336, 291);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(100, 23);
            this.CheckButton.TabIndex = 3;
            this.CheckButton.Text = "Comprobar";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(314, 370);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(38, 15);
            this.ResultLabel.TabIndex = 4;
            this.ResultLabel.Text = "label2";
            // 
            // numbersLabel
            // 
            this.numbersLabel.AutoSize = true;
            this.numbersLabel.Location = new System.Drawing.Point(315, 350);
            this.numbersLabel.Name = "numbersLabel";
            this.numbersLabel.Size = new System.Drawing.Size(0, 15);
            this.numbersLabel.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numbersLabel);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.SecondNumberLabel);
            this.Controls.Add(this.FirstNumberLabel);
            this.Controls.Add(this.SecondNumberText);
            this.Controls.Add(this.FirstNumberText);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox FirstNumberText;
        private Label FirstNumberLabel;
        private TextBox SecondNumberText;
        private Label SecondNumberLabel;
        private Button CheckButton;
        private Label ResultLabel;
        private Label numbersLabel;
    }
}