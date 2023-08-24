using employeesLibrary;
using employeesLibrary.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2___Lab1.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeEmployeeTypeComboBox();
            InitializeEmployeeStatusComboBox();
        }

        private void InitializeEmployeeStatusComboBox()
        {
            employeeStatusComboBox.Items.AddRange(Enum.GetNames(typeof(employeeStatusEnum)));
            employeeStatusComboBox.SelectedIndex = 0;
            editEmployeeStatusComboBox.Items.AddRange(Enum.GetNames(typeof(employeeStatusEnum)));
            editEmployeeStatusComboBox.SelectedIndex = 0;
        }

        private void InitializeEmployeeTypeComboBox()
        {
            employeeTypeComboBox.Items.AddRange(Enum.GetNames(typeof(employeeTypeEnum)));
            employeeTypeComboBox.SelectedIndex = 0;
            editEmployeeTypeComboBox.Items.AddRange(Enum.GetNames(typeof(employeeTypeEnum)));
            editEmployeeTypeComboBox.SelectedIndex = 0;
        }


        private List<Employee> employees = new List<Employee>();

        private void MainForm_Load(object sender, EventArgs e)
        {
            employees.Add(new Employee {id = 1, FirstName = "Daniel", LastName="Diaz", Type = 0, Status = 0 });

            listEmployeesComboBox.DisplayMember = "FirstName";
            listEmployeesComboBox.ValueMember = "id";
            listEmployeesComboBox.DataSource = employees;
        }

        private int nextEmployeeID = 2;

        private void saveButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.id = nextEmployeeID;
            employee.FirstName = employeeNameTextBox.Text;
            employee.LastName = employeeLastNameTextBox.Text;
            employee.Type = (employeeTypeEnum)Enum.Parse(typeof(employeeTypeEnum), employeeTypeComboBox.SelectedItem.ToString());
            employee.Status = (employeeStatusEnum)Enum.Parse(typeof(employeeStatusEnum), employeeStatusComboBox.SelectedItem.ToString());

 
            employees.Add(employee);
            nextEmployeeID++;

            // Se ctualiza la fuente de datos del ComboBox con la lista de empleados actualizada
            listEmployeesComboBox.DataSource = null;
            listEmployeesComboBox.DataSource = employees;
            listEmployeesComboBox.DisplayMember = "FirstName";
            listEmployeesComboBox.ValueMember = "id";

            employeeNameTextBox.Text = string.Empty;
            employeeLastNameTextBox.Text = string.Empty;
            MessageBox.Show("El usuario se agregó correctamente");
        }

        private void listEmployeesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee employee = listEmployeesComboBox.SelectedItem as Employee;

            if (employee != null)
            {
                showNameLabel.Text = employee.FirstName;
                showLastNameLabel.Text = employee.LastName;
                showTypeLabel.Text = employee.Type.ToString();
                showStatusLabel.Text = employee.Status.ToString();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            listEmployeesTabControl.SelectTab(addEmployeePage);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (listEmployeesComboBox.TabIndex >= 1)
            {
                listEmployeesTabControl.SelectTab(editEmployeePage);
            }
            else
            {
                string message = "Por favor, selecciona a un empleado para poder editar";
                MessageBox.Show(message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listEmployeesButton_Click(object sender, EventArgs e)
        {
            listEmployeesTabControl.SelectTab(employeeListPage);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que quieres eliminar este empleado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                
            }
            else
            {
                if (listEmployeesComboBox.SelectedIndex >= 0)
                {
                    int selectedIndex = listEmployeesComboBox.SelectedIndex;

                    // Elimina el empleado seleccionado de la lista
                    employees.RemoveAt(selectedIndex);

                    // Refresca la fuente de datos del ComboBox
                    listEmployeesComboBox.DataSource = null;
                    listEmployeesComboBox.DataSource = employees;
                    listEmployeesComboBox.DisplayMember = "FirstName";
                    listEmployeesComboBox.ValueMember = "id";

                    showNameLabel.Text = string.Empty;
                    showLastNameLabel.Text = string.Empty;
                    showTypeLabel.Text = string.Empty;
                    showStatusLabel.Text = string.Empty;

                    MessageBox.Show("Empleado eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("Selecciona un empleado para eliminar.");
                }
            }
            
        }

        private void editSaveButton_Click(object sender, EventArgs e)
        {
            if (listEmployeesComboBox.SelectedIndex >= 0)
            {
                Employee selectedEmployee = listEmployeesComboBox.SelectedItem as Employee;

                // Actualiza los detalles del empleado seleccionado
                selectedEmployee.FirstName = editNameEmployeeTextBox.Text;
                selectedEmployee.LastName = editLastNameEmployeeTextBox.Text;
                selectedEmployee.Type = (employeeTypeEnum)Enum.Parse(typeof(employeeTypeEnum), editEmployeeTypeComboBox.SelectedItem.ToString());
                selectedEmployee.Status = (employeeStatusEnum)Enum.Parse(typeof(employeeStatusEnum), editEmployeeStatusComboBox.SelectedItem.ToString());

                // Refresca la fuente de datos del ComboBox
                listEmployeesComboBox.DataSource = null;
                listEmployeesComboBox.DataSource = employees;
                listEmployeesComboBox.DisplayMember = "FirstName";
                listEmployeesComboBox.ValueMember = "id";

                MessageBox.Show("Empleado editado correctamente.");
            }
            else
            {
                MessageBox.Show("Selecciona un empleado para editar.");
            }
        }

        private void employeeNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se pueden escribir letras");
            }
        }

        private void employeeLastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se pueden escribir letras");
            }
        }

        private void editNameEmployeeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se pueden escribir letras");
            }
        }

        private void editLastNameEmployeeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se pueden escribir letras");
            }
        }
    }
}
