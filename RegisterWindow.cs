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
    public partial class RegisterWindow : UserControl
    {
        private Form1 form;
        public RegisterWindow()
        {
            InitializeComponent();
        }

        public void SetForm(Form1 form)
        {
            this.form = form;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            form.ShowMainMenu();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if(NameBox.Text == "" || EmailBox.Text == "" || PasswordBox.Text == "")
            {
                MessageBox.Show("please enter your data first", "missing data");
                return;
            }
            if(StudentDataAccess.getStudent(EmailBox.Text) != null)
            {
                MessageBox.Show("email is already exsit", "wrong data");
                return;
            }
            StudentDataAccess.addStudent(NameBox.Text, EmailBox.Text, PasswordBox.Text, Date.Value);
            NameBox.Text = "";
            EmailBox.Text = "";
            PasswordBox.Text = "";
            MessageBox.Show("you have been registerd succssfully now you can login", "done");
            form.ShowMainMenu();
        }
    }
}
