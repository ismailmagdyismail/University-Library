using Data_Base_Project.DataAccess;
using Data_Base_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Base_Project
{
    public partial class AdminStudentWindow : UserControl
    {
        private Form1 form;
        private string Email = "";
        public AdminStudentWindow()
        {
            InitializeComponent();
            ShowStudents();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row index is clicked
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                EmailBox.Text = row.Cells[0].Value.ToString();
                Email = row.Cells[0].Value.ToString();
                NameBox.Text = row.Cells[1].Value.ToString();
                PasswordBox.Text = row.Cells[2].Value.ToString();
                if (DateTime.TryParse(row.Cells[3].Value.ToString(), out DateTime date))
                {
                    Date.Value = date;
                }
            }
        }

        public void SetForm(Form1 form)
        {
            this.form = form;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void BookstBtn_Click(object sender, EventArgs e)
        {
            form.ShowAdminBookWindow();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            form.ShowMainMenu();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.userTableAdapter.FillBy(this.libraryDataSet.user);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        public void ShowStudents()
        {
            dataGridView1.DataSource = StudentDataAccess.getStudentsDataTable();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (EmailBox.Text == "" || NameBox.Text == "" || PasswordBox.Text == "") {
                MessageBox.Show("Please fill the data first", "error");
                return;
            }

            if(StudentDataAccess.getStudent(EmailBox.Text) != null)
            {
                MessageBox.Show("email is already exsit enter another one", "error");
                return;
            }
            StudentDataAccess.addStudent(NameBox.Text, EmailBox.Text, PasswordBox.Text, Date.Value);

            ShowStudents();
            clear();
            MessageBox.Show("student has been added", "done");

        }

        private void clear()
        {
            NameBox.Clear();
            EmailBox.Clear();
            PasswordBox.Clear();
            dataGridView1.ClearSelection();
            Email = "";
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (EmailBox.Text == "")
            {
                MessageBox.Show("please enter email first", "error");
                return;
            }
            if (StudentDataAccess.getStudent(EmailBox.Text) == null)
            {
                MessageBox.Show("there is no email match this email", "error");
                return;
            }

            StudentDataAccess.removeStudent(EmailBox.Text);
            ShowStudents();
            clear();
            MessageBox.Show("student has been removed", "done");
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (EmailBox.Text == "")
            {
                MessageBox.Show("Please select Student at first", "error");
            }
            else
            {
                Student selectedStudent = StudentDataAccess.getStudent(EmailBox.Text);
                if(selectedStudent == null)
                {
                    MessageBox.Show("there is no email matches this email");
                    return;
                }
                if (NameBox.Text == selectedStudent.Name && PasswordBox.Text == selectedStudent.Password && Date.Value == selectedStudent.GraduationDate)
                {
                    MessageBox.Show("there is no change", "error");
                    return;
                }
                StudentDataAccess.updateStudent(EmailBox.Text, NameBox.Text, PasswordBox.Text, Date.Value);
                clear();
                ShowStudents();
                MessageBox.Show("Student has been updated", "done");
            }
        }

        private void ReservationsBtn_Click(object sender, EventArgs e)
        {
            form.ShowStudentReservations(Email);
            Email = "";
        }
    }
}
