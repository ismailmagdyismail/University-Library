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
    public partial class LoginWindow : UserControl
    {
        private Form1 form;
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {

        }

        public void SetForm(Form1 form)
        {
            this.form = form;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            if (EmailBox.Text == "" || PasswordBox.Text == "")
            {
                MessageBox.Show("please enter your data","error");
                return;
            }

            Student student= StudentDataAccess.getStudent(EmailBox.Text);
            Admin admin = AdminDataAccess.getAdmin(EmailBox.Text);
            
            if (student != null && student.Password == PasswordBox.Text)
            {
                form.ShowBooksWindow();
                form.SetEmails(EmailBox.Text);
                clear();
                return;
            }

            if (admin != null && admin.Password == PasswordBox.Text)
            {
                form.ShowAdminBookWindow();
                clear();
                return;
            }

            if (student == null)
            {
                MessageBox.Show("there is no email matches this email", "wrong email");
                return;
            }

            if(student.Password != PasswordBox.Text)
            {
                MessageBox.Show("wrong password");
                return;
            }

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            form.ShowMainMenu();
        }

        private void clear()
        {
            EmailBox.Text = "";
            PasswordBox.Text = "";
        }
    }
}
