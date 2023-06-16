
namespace Data_Base_Project
{
    partial class Form1
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
            this.LoginWindow = new Data_Base_Project.LoginWindow();
            this.mainMenu1 = new Data_Base_Project.MainMenu();
            this.registerWindow1 = new Data_Base_Project.RegisterWindow();
            this.adminBookWindow1 = new Data_Base_Project.AdminBookWindow();
            this.adminStudentWindow1 = new Data_Base_Project.AdminStudentWindow();
            this.books1 = new Data_Base_Project.Books();
            this.borrowedBooks1 = new Data_Base_Project.BorrowedBooks();
            this.studentRservations1 = new Data_Base_Project.StudentRservations();
            this.SuspendLayout();
            // 
            // LoginWindow
            // 
            this.LoginWindow.Location = new System.Drawing.Point(-10, -19);
            this.LoginWindow.Name = "LoginWindow";
            this.LoginWindow.Size = new System.Drawing.Size(816, 489);
            this.LoginWindow.TabIndex = 3;
            this.LoginWindow.Visible = false;
            // 
            // mainMenu1
            // 
            this.mainMenu1.Location = new System.Drawing.Point(-10, -19);
            this.mainMenu1.Name = "mainMenu1";
            this.mainMenu1.Size = new System.Drawing.Size(816, 489);
            this.mainMenu1.TabIndex = 4;
            // 
            // registerWindow1
            // 
            this.registerWindow1.Location = new System.Drawing.Point(-10, -19);
            this.registerWindow1.Name = "registerWindow1";
            this.registerWindow1.Size = new System.Drawing.Size(816, 489);
            this.registerWindow1.TabIndex = 5;
            // 
            // adminBookWindow1
            // 
            this.adminBookWindow1.Location = new System.Drawing.Point(-10, -19);
            this.adminBookWindow1.Name = "adminBookWindow1";
            this.adminBookWindow1.Size = new System.Drawing.Size(816, 489);
            this.adminBookWindow1.TabIndex = 6;
            // 
            // adminStudentWindow1
            // 
            this.adminStudentWindow1.Location = new System.Drawing.Point(-10, -19);
            this.adminStudentWindow1.Name = "adminStudentWindow1";
            this.adminStudentWindow1.Size = new System.Drawing.Size(816, 489);
            this.adminStudentWindow1.TabIndex = 7;
            // 
            // books1
            // 
            this.books1.Location = new System.Drawing.Point(-10, -24);
            this.books1.Name = "books1";
            this.books1.Size = new System.Drawing.Size(816, 489);
            this.books1.TabIndex = 8;
            // 
            // borrowedBooks1
            // 
            this.borrowedBooks1.Location = new System.Drawing.Point(-10, -19);
            this.borrowedBooks1.Name = "borrowedBooks1";
            this.borrowedBooks1.Size = new System.Drawing.Size(816, 489);
            this.borrowedBooks1.TabIndex = 9;
            // 
            // studentRservations1
            // 
            this.studentRservations1.Location = new System.Drawing.Point(-10, -25);
            this.studentRservations1.Name = "studentRservations1";
            this.studentRservations1.Size = new System.Drawing.Size(816, 489);
            this.studentRservations1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studentRservations1);
            this.Controls.Add(this.borrowedBooks1);
            this.Controls.Add(this.mainMenu1);
            this.Controls.Add(this.LoginWindow);
            this.Controls.Add(this.books1);
            this.Controls.Add(this.adminStudentWindow1);
            this.Controls.Add(this.adminBookWindow1);
            this.Controls.Add(this.registerWindow1);
            this.Name = "Form1";
            this.Text = "FCAI Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private LoginWindow LoginWindow;
        private MainMenu mainMenu1;
        private RegisterWindow registerWindow1;
        private AdminBookWindow adminBookWindow1;
        private AdminStudentWindow adminStudentWindow1;
        private Books books1;
        private BorrowedBooks borrowedBooks1;
        private StudentRservations studentRservations1;
    }
}

