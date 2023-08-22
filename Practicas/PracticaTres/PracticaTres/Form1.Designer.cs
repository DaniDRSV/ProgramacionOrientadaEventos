namespace PracticaTres
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BucarButton = new System.Windows.Forms.Button();
            this.imageStoragePictureBox = new System.Windows.Forms.PictureBox();
            this.TituloUnoLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.pictureBoxChanging = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxTimer = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageStoragePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChanging)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // BucarButton
            // 
            this.BucarButton.Location = new System.Drawing.Point(104, 256);
            this.BucarButton.Name = "BucarButton";
            this.BucarButton.Size = new System.Drawing.Size(138, 49);
            this.BucarButton.TabIndex = 0;
            this.BucarButton.Text = "Buscar";
            this.BucarButton.UseVisualStyleBackColor = true;
            this.BucarButton.Click += new System.EventHandler(this.BucarButton_Click);
            // 
            // imageStoragePictureBox
            // 
            this.imageStoragePictureBox.Location = new System.Drawing.Point(35, 38);
            this.imageStoragePictureBox.Name = "imageStoragePictureBox";
            this.imageStoragePictureBox.Size = new System.Drawing.Size(278, 194);
            this.imageStoragePictureBox.TabIndex = 1;
            this.imageStoragePictureBox.TabStop = false;
            // 
            // TituloUnoLabel
            // 
            this.TituloUnoLabel.AutoSize = true;
            this.TituloUnoLabel.Location = new System.Drawing.Point(38, 15);
            this.TituloUnoLabel.Name = "TituloUnoLabel";
            this.TituloUnoLabel.Size = new System.Drawing.Size(60, 15);
            this.TituloUnoLabel.TabIndex = 2;
            this.TituloUnoLabel.Text = "Ejercicio 1";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(470, 256);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(138, 49);
            this.changeButton.TabIndex = 0;
            this.changeButton.Text = "Cambiar";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // pictureBoxChanging
            // 
            this.pictureBoxChanging.Location = new System.Drawing.Point(401, 38);
            this.pictureBoxChanging.Name = "pictureBoxChanging";
            this.pictureBoxChanging.Size = new System.Drawing.Size(278, 194);
            this.pictureBoxChanging.TabIndex = 1;
            this.pictureBoxChanging.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ejercicio 2";
            // 
            // pictureBoxTimer
            // 
            this.pictureBoxTimer.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTimer.Image")));
            this.pictureBoxTimer.Location = new System.Drawing.Point(764, 38);
            this.pictureBoxTimer.Name = "pictureBoxTimer";
            this.pictureBoxTimer.Size = new System.Drawing.Size(278, 194);
            this.pictureBoxTimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTimer.TabIndex = 1;
            this.pictureBoxTimer.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(767, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ejercicio 3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 347);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TituloUnoLabel);
            this.Controls.Add(this.pictureBoxTimer);
            this.Controls.Add(this.pictureBoxChanging);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.imageStoragePictureBox);
            this.Controls.Add(this.BucarButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageStoragePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChanging)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BucarButton;
        private PictureBox imageStoragePictureBox;
        private Label TituloUnoLabel;
        private Button changeButton;
        private PictureBox pictureBoxChanging;
        private Label label1;
        private PictureBox pictureBoxTimer;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}