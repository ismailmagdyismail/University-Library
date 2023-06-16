using Data_Base_Project.DataAccess;
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
    public partial class StudentRservations : UserControl
    {
        private Form1 form;
        public StudentRservations()
        {
            InitializeComponent();

        }

        private void StudentRservations_Load(object sender, EventArgs e)
        {

        }

        public void SetForm(Form1 form)
        {
            this.form = form;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            form.ShowAdminStudentWindow();
        }

        public void ShowReservations()
        {
            dataGridView1.DataSource = ReservationDataAccess.getStudentReservations(Email);
            numOfBooks.Text = BookDataAccess.getNumberOfBooks().ToString();
            numOfReservations.Text = ReservationDataAccess.getNumberOfReservations().ToString();
            numOfStudents.Text = StudentDataAccess.getNumberOfStudents().ToString();
        }
        
        public void setEmail(string email)
        {
            this.Email = email;
        }

        private string Email = "";

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
