using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Base_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mainMenu1.setform(this);
            mainMenu1.BringToFront();
            LoginWindow.SetForm(this);
            registerWindow1.SetForm(this);
            adminBookWindow1.SetForm(this);
            adminStudentWindow1.SetForm(this);
            books1.SetForm(this);
            borrowedBooks1.SetForm(this);
            studentRservations1.SetForm(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void ShowLogin()
        {
            LoginWindow.Show();
            LoginWindow.BringToFront();
        }

        public void ShowMainMenu()
        {
            mainMenu1.Show();
            mainMenu1.BringToFront();

        }

        public void ShowRegister()
        {
            registerWindow1.Show();
            registerWindow1.BringToFront();
        }

        public void ShowAdminBookWindow()
        {
            adminBookWindow1.Show();
            adminBookWindow1.ShowBooks();
            adminBookWindow1.BringToFront();
        }

        public void ShowAdminStudentWindow()
        {
            adminStudentWindow1.Show();
            adminStudentWindow1.ShowStudents();
            adminStudentWindow1.BringToFront();
        }
        
        public void ShowBooksWindow()
        {
            books1.Show();
            books1.ShowBooks();
            books1.BringToFront();
        }

        public void ShowBorrowedBooksWindow()
        {
            borrowedBooks1.Show();
            borrowedBooks1.ShowBorrwedBooks();
            borrowedBooks1.BringToFront();
        }

        public void ShowStudentReservations(string Email)
        {
            studentRservations1.Show();
            studentRservations1.setEmail(Email);
            studentRservations1.ShowReservations();
            studentRservations1.BringToFront();
        }
        public void SetEmails(string email)
        {
            this.email = email;
        }

        public string getEmail()
        {
            return email;
        }

        private string email;
    }
}
