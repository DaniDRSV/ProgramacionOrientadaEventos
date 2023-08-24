namespace Tarea2___Lab1.Forms
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleListEmployeesPageLabel = new System.Windows.Forms.Label();
            this.manageEmployesGroupBox = new System.Windows.Forms.GroupBox();
            this.editButton = new System.Windows.Forms.Button();
            this.listEmployeesButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.listEmployeesTabControl = new System.Windows.Forms.TabControl();
            this.employeeListPage = new System.Windows.Forms.TabPage();
            this.showStatusLabel = new System.Windows.Forms.Label();
            this.showTypeLabel = new System.Windows.Forms.Label();
            this.showLastNameLabel = new System.Windows.Forms.Label();
            this.showNameLabel = new System.Windows.Forms.Label();
            this.employeeStatusTitleLabel = new System.Windows.Forms.Label();
            this.employeeTypeTitleLabel = new System.Windows.Forms.Label();
            this.lastNameTitleLabel = new System.Windows.Forms.Label();
            this.nameTitleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listEmployeesComboBox = new System.Windows.Forms.ComboBox();
            this.addEmployeePage = new System.Windows.Forms.TabPage();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeLastNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.employeeStatusComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editEmployeePage = new System.Windows.Forms.TabPage();
            this.editNameEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.editLastNameEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.editEmployeeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.editEmployeeStatusComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.editSaveButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.manageEmployesGroupBox.SuspendLayout();
            this.listEmployeesTabControl.SuspendLayout();
            this.employeeListPage.SuspendLayout();
            this.addEmployeePage.SuspendLayout();
            this.editEmployeePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(83, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(217, 25);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Control de empleados";
            // 
            // titleListEmployeesPageLabel
            // 
            this.titleListEmployeesPageLabel.AutoSize = true;
            this.titleListEmployeesPageLabel.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleListEmployeesPageLabel.Location = new System.Drawing.Point(87, 15);
            this.titleListEmployeesPageLabel.Name = "titleListEmployeesPageLabel";
            this.titleListEmployeesPageLabel.Size = new System.Drawing.Size(149, 20);
            this.titleListEmployeesPageLabel.TabIndex = 4;
            this.titleListEmployeesPageLabel.Text = "Lista de empleados";
            // 
            // manageEmployesGroupBox
            // 
            this.manageEmployesGroupBox.Controls.Add(this.editButton);
            this.manageEmployesGroupBox.Controls.Add(this.listEmployeesButton);
            this.manageEmployesGroupBox.Controls.Add(this.addButton);
            this.manageEmployesGroupBox.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manageEmployesGroupBox.Location = new System.Drawing.Point(12, 319);
            this.manageEmployesGroupBox.Name = "manageEmployesGroupBox";
            this.manageEmployesGroupBox.Size = new System.Drawing.Size(363, 109);
            this.manageEmployesGroupBox.TabIndex = 6;
            this.manageEmployesGroupBox.TabStop = false;
            this.manageEmployesGroupBox.Text = "Administrar empleado";
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editButton.Location = new System.Drawing.Point(246, 40);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(92, 52);
            this.editButton.TabIndex = 11;
            this.editButton.Text = "Editar empleado";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // listEmployeesButton
            // 
            this.listEmployeesButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listEmployeesButton.Location = new System.Drawing.Point(20, 40);
            this.listEmployeesButton.Name = "listEmployeesButton";
            this.listEmployeesButton.Size = new System.Drawing.Size(94, 52);
            this.listEmployeesButton.TabIndex = 9;
            this.listEmployeesButton.Text = "Lista de empleados";
            this.listEmployeesButton.UseVisualStyleBackColor = true;
            this.listEmployeesButton.Click += new System.EventHandler(this.listEmployeesButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(130, 40);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 52);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Agregar empleado";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(235, 215);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(73, 27);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Eliminar";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // listEmployeesTabControl
            // 
            this.listEmployeesTabControl.Controls.Add(this.employeeListPage);
            this.listEmployeesTabControl.Controls.Add(this.addEmployeePage);
            this.listEmployeesTabControl.Controls.Add(this.editEmployeePage);
            this.listEmployeesTabControl.Location = new System.Drawing.Point(28, 37);
            this.listEmployeesTabControl.Name = "listEmployeesTabControl";
            this.listEmployeesTabControl.SelectedIndex = 0;
            this.listEmployeesTabControl.Size = new System.Drawing.Size(322, 276);
            this.listEmployeesTabControl.TabIndex = 7;
            // 
            // employeeListPage
            // 
            this.employeeListPage.Controls.Add(this.deleteButton);
            this.employeeListPage.Controls.Add(this.showStatusLabel);
            this.employeeListPage.Controls.Add(this.showTypeLabel);
            this.employeeListPage.Controls.Add(this.showLastNameLabel);
            this.employeeListPage.Controls.Add(this.showNameLabel);
            this.employeeListPage.Controls.Add(this.employeeStatusTitleLabel);
            this.employeeListPage.Controls.Add(this.employeeTypeTitleLabel);
            this.employeeListPage.Controls.Add(this.lastNameTitleLabel);
            this.employeeListPage.Controls.Add(this.nameTitleLabel);
            this.employeeListPage.Controls.Add(this.label2);
            this.employeeListPage.Controls.Add(this.listEmployeesComboBox);
            this.employeeListPage.Controls.Add(this.titleListEmployeesPageLabel);
            this.employeeListPage.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeeListPage.Location = new System.Drawing.Point(4, 24);
            this.employeeListPage.Name = "employeeListPage";
            this.employeeListPage.Padding = new System.Windows.Forms.Padding(3);
            this.employeeListPage.Size = new System.Drawing.Size(314, 248);
            this.employeeListPage.TabIndex = 0;
            this.employeeListPage.Text = "Lista de empleados";
            this.employeeListPage.UseVisualStyleBackColor = true;
            // 
            // showStatusLabel
            // 
            this.showStatusLabel.AutoSize = true;
            this.showStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showStatusLabel.Location = new System.Drawing.Point(87, 215);
            this.showStatusLabel.Name = "showStatusLabel";
            this.showStatusLabel.Size = new System.Drawing.Size(22, 15);
            this.showStatusLabel.TabIndex = 15;
            this.showStatusLabel.Text = ". . .";
            // 
            // showTypeLabel
            // 
            this.showTypeLabel.AutoSize = true;
            this.showTypeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showTypeLabel.Location = new System.Drawing.Point(152, 191);
            this.showTypeLabel.Name = "showTypeLabel";
            this.showTypeLabel.Size = new System.Drawing.Size(22, 15);
            this.showTypeLabel.TabIndex = 14;
            this.showTypeLabel.Text = ". . .";
            // 
            // showLastNameLabel
            // 
            this.showLastNameLabel.AutoSize = true;
            this.showLastNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showLastNameLabel.Location = new System.Drawing.Point(95, 163);
            this.showLastNameLabel.Name = "showLastNameLabel";
            this.showLastNameLabel.Size = new System.Drawing.Size(22, 15);
            this.showLastNameLabel.TabIndex = 13;
            this.showLastNameLabel.Text = ". . .";
            // 
            // showNameLabel
            // 
            this.showNameLabel.AutoSize = true;
            this.showNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showNameLabel.Location = new System.Drawing.Point(95, 135);
            this.showNameLabel.Name = "showNameLabel";
            this.showNameLabel.Size = new System.Drawing.Size(22, 15);
            this.showNameLabel.TabIndex = 12;
            this.showNameLabel.Text = ". . .";
            // 
            // employeeStatusTitleLabel
            // 
            this.employeeStatusTitleLabel.AutoSize = true;
            this.employeeStatusTitleLabel.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeeStatusTitleLabel.Location = new System.Drawing.Point(26, 215);
            this.employeeStatusTitleLabel.Name = "employeeStatusTitleLabel";
            this.employeeStatusTitleLabel.Size = new System.Drawing.Size(55, 15);
            this.employeeStatusTitleLabel.TabIndex = 6;
            this.employeeStatusTitleLabel.Text = "Estado: ";
            // 
            // employeeTypeTitleLabel
            // 
            this.employeeTypeTitleLabel.AutoSize = true;
            this.employeeTypeTitleLabel.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeeTypeTitleLabel.Location = new System.Drawing.Point(26, 191);
            this.employeeTypeTitleLabel.Name = "employeeTypeTitleLabel";
            this.employeeTypeTitleLabel.Size = new System.Drawing.Size(120, 15);
            this.employeeTypeTitleLabel.TabIndex = 5;
            this.employeeTypeTitleLabel.Text = "Tipo de empleado:";
            // 
            // lastNameTitleLabel
            // 
            this.lastNameTitleLabel.AutoSize = true;
            this.lastNameTitleLabel.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastNameTitleLabel.Location = new System.Drawing.Point(26, 163);
            this.lastNameTitleLabel.Name = "lastNameTitleLabel";
            this.lastNameTitleLabel.Size = new System.Drawing.Size(63, 15);
            this.lastNameTitleLabel.TabIndex = 4;
            this.lastNameTitleLabel.Text = "Apellido:";
            // 
            // nameTitleLabel
            // 
            this.nameTitleLabel.AutoSize = true;
            this.nameTitleLabel.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameTitleLabel.Location = new System.Drawing.Point(26, 135);
            this.nameTitleLabel.Name = "nameTitleLabel";
            this.nameTitleLabel.Size = new System.Drawing.Size(60, 15);
            this.nameTitleLabel.TabIndex = 3;
            this.nameTitleLabel.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datos del empleado";
            // 
            // listEmployeesComboBox
            // 
            this.listEmployeesComboBox.FormattingEnabled = true;
            this.listEmployeesComboBox.Location = new System.Drawing.Point(87, 47);
            this.listEmployeesComboBox.Name = "listEmployeesComboBox";
            this.listEmployeesComboBox.Size = new System.Drawing.Size(149, 23);
            this.listEmployeesComboBox.TabIndex = 1;
            this.listEmployeesComboBox.SelectedIndexChanged += new System.EventHandler(this.listEmployeesComboBox_SelectedIndexChanged);
            // 
            // addEmployeePage
            // 
            this.addEmployeePage.Controls.Add(this.employeeNameTextBox);
            this.addEmployeePage.Controls.Add(this.employeeLastNameTextBox);
            this.addEmployeePage.Controls.Add(this.employeeTypeComboBox);
            this.addEmployeePage.Controls.Add(this.employeeStatusComboBox);
            this.addEmployeePage.Controls.Add(this.saveButton);
            this.addEmployeePage.Controls.Add(this.statusLabel);
            this.addEmployeePage.Controls.Add(this.typeLabel);
            this.addEmployeePage.Controls.Add(this.lastNameLabel);
            this.addEmployeePage.Controls.Add(this.nameLabel);
            this.addEmployeePage.Controls.Add(this.label1);
            this.addEmployeePage.Location = new System.Drawing.Point(4, 24);
            this.addEmployeePage.Name = "addEmployeePage";
            this.addEmployeePage.Padding = new System.Windows.Forms.Padding(3);
            this.addEmployeePage.Size = new System.Drawing.Size(314, 248);
            this.addEmployeePage.TabIndex = 1;
            this.addEmployeePage.Text = "Añadir empleados";
            this.addEmployeePage.UseVisualStyleBackColor = true;
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(82, 52);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(143, 23);
            this.employeeNameTextBox.TabIndex = 0;
            this.employeeNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.employeeNameTextBox_KeyPress);
            // 
            // employeeLastNameTextBox
            // 
            this.employeeLastNameTextBox.Location = new System.Drawing.Point(82, 84);
            this.employeeLastNameTextBox.Name = "employeeLastNameTextBox";
            this.employeeLastNameTextBox.Size = new System.Drawing.Size(143, 23);
            this.employeeLastNameTextBox.TabIndex = 1;
            this.employeeLastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.employeeLastNameTextBox_KeyPress);
            // 
            // employeeTypeComboBox
            // 
            this.employeeTypeComboBox.FormattingEnabled = true;
            this.employeeTypeComboBox.Location = new System.Drawing.Point(142, 118);
            this.employeeTypeComboBox.Name = "employeeTypeComboBox";
            this.employeeTypeComboBox.Size = new System.Drawing.Size(121, 23);
            this.employeeTypeComboBox.TabIndex = 3;
            // 
            // employeeStatusComboBox
            // 
            this.employeeStatusComboBox.FormattingEnabled = true;
            this.employeeStatusComboBox.Location = new System.Drawing.Point(71, 147);
            this.employeeStatusComboBox.Name = "employeeStatusComboBox";
            this.employeeStatusComboBox.Size = new System.Drawing.Size(121, 23);
            this.employeeStatusComboBox.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(110, 197);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.Location = new System.Drawing.Point(16, 148);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(49, 17);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Estado";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.typeLabel.Location = new System.Drawing.Point(16, 119);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(120, 17);
            this.typeLabel.TabIndex = 3;
            this.typeLabel.Text = "Tipo de empleado";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastNameLabel.Location = new System.Drawing.Point(16, 90);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(60, 17);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Apellido";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(16, 58);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(58, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(96, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Añadir empleado";
            // 
            // editEmployeePage
            // 
            this.editEmployeePage.Controls.Add(this.editNameEmployeeTextBox);
            this.editEmployeePage.Controls.Add(this.label7);
            this.editEmployeePage.Controls.Add(this.editLastNameEmployeeTextBox);
            this.editEmployeePage.Controls.Add(this.label6);
            this.editEmployeePage.Controls.Add(this.editEmployeeTypeComboBox);
            this.editEmployeePage.Controls.Add(this.label5);
            this.editEmployeePage.Controls.Add(this.editEmployeeStatusComboBox);
            this.editEmployeePage.Controls.Add(this.label4);
            this.editEmployeePage.Controls.Add(this.label3);
            this.editEmployeePage.Controls.Add(this.editSaveButton);
            this.editEmployeePage.Location = new System.Drawing.Point(4, 24);
            this.editEmployeePage.Name = "editEmployeePage";
            this.editEmployeePage.Padding = new System.Windows.Forms.Padding(3);
            this.editEmployeePage.Size = new System.Drawing.Size(314, 248);
            this.editEmployeePage.TabIndex = 2;
            this.editEmployeePage.Text = "Editar empleado";
            this.editEmployeePage.UseVisualStyleBackColor = true;
            // 
            // editNameEmployeeTextBox
            // 
            this.editNameEmployeeTextBox.Location = new System.Drawing.Point(85, 52);
            this.editNameEmployeeTextBox.Name = "editNameEmployeeTextBox";
            this.editNameEmployeeTextBox.Size = new System.Drawing.Size(143, 23);
            this.editNameEmployeeTextBox.TabIndex = 1;
            this.editNameEmployeeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editNameEmployeeTextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(99, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Editar empleado";
            // 
            // editLastNameEmployeeTextBox
            // 
            this.editLastNameEmployeeTextBox.Location = new System.Drawing.Point(85, 84);
            this.editLastNameEmployeeTextBox.Name = "editLastNameEmployeeTextBox";
            this.editLastNameEmployeeTextBox.Size = new System.Drawing.Size(143, 23);
            this.editLastNameEmployeeTextBox.TabIndex = 2;
            this.editLastNameEmployeeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editLastNameEmployeeTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(19, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombre";
            // 
            // editEmployeeTypeComboBox
            // 
            this.editEmployeeTypeComboBox.FormattingEnabled = true;
            this.editEmployeeTypeComboBox.Location = new System.Drawing.Point(145, 118);
            this.editEmployeeTypeComboBox.Name = "editEmployeeTypeComboBox";
            this.editEmployeeTypeComboBox.Size = new System.Drawing.Size(121, 23);
            this.editEmployeeTypeComboBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Apellido";
            // 
            // editEmployeeStatusComboBox
            // 
            this.editEmployeeStatusComboBox.FormattingEnabled = true;
            this.editEmployeeStatusComboBox.Location = new System.Drawing.Point(74, 147);
            this.editEmployeeStatusComboBox.Name = "editEmployeeStatusComboBox";
            this.editEmployeeStatusComboBox.Size = new System.Drawing.Size(121, 23);
            this.editEmployeeStatusComboBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tipo de empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Estado";
            // 
            // editSaveButton
            // 
            this.editSaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.editSaveButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editSaveButton.Location = new System.Drawing.Point(113, 197);
            this.editSaveButton.Name = "editSaveButton";
            this.editSaveButton.Size = new System.Drawing.Size(94, 23);
            this.editSaveButton.TabIndex = 5;
            this.editSaveButton.Text = "Guardar";
            this.editSaveButton.UseVisualStyleBackColor = false;
            this.editSaveButton.Click += new System.EventHandler(this.editSaveButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(28, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 25);
            this.panel1.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 440);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listEmployeesTabControl);
            this.Controls.Add(this.manageEmployesGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de empleados";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.manageEmployesGroupBox.ResumeLayout(false);
            this.listEmployeesTabControl.ResumeLayout(false);
            this.employeeListPage.ResumeLayout(false);
            this.employeeListPage.PerformLayout();
            this.addEmployeePage.ResumeLayout(false);
            this.addEmployeePage.PerformLayout();
            this.editEmployeePage.ResumeLayout(false);
            this.editEmployeePage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleLabel;
        private Label titleListEmployeesPageLabel;
        private GroupBox manageEmployesGroupBox;
        private Button deleteButton;
        private Button editButton;
        private Button addButton;
        private TabControl listEmployeesTabControl;
        private TabPage employeeListPage;
        private Label label2;
        private ComboBox listEmployeesComboBox;
        private TabPage addEmployeePage;
        private TabPage editEmployeePage;
        private Label showStatusLabel;
        private Label showTypeLabel;
        private Label showLastNameLabel;
        private Label showNameLabel;
        private Label employeeStatusTitleLabel;
        private Label employeeTypeTitleLabel;
        private Label lastNameTitleLabel;
        private Label nameTitleLabel;
        private Button saveButton;
        private Label statusLabel;
        private Label typeLabel;
        private Label lastNameLabel;
        private Label nameLabel;
        private Label label1;
        private TextBox employeeNameTextBox;
        private TextBox employeeLastNameTextBox;
        private ComboBox employeeTypeComboBox;
        private ComboBox employeeStatusComboBox;
        private TextBox editNameEmployeeTextBox;
        private Label label7;
        private TextBox editLastNameEmployeeTextBox;
        private Label label6;
        private ComboBox editEmployeeTypeComboBox;
        private Label label5;
        private ComboBox editEmployeeStatusComboBox;
        private Label label4;
        private Label label3;
        private Button editSaveButton;
        private Button listEmployeesButton;
        private Panel panel1;
    }
}