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
    public partial class BorrowedBooks : UserControl
    {
        private Form1 form;
        public BorrowedBooks()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row index is clicked
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells[0].Value.ToString() == "")
                    return;
                bookId = int.Parse(row.Cells[0].Value.ToString());
            }
        }

        public void SetForm(Form1 form)
        {
            this.form = form;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            form.ShowMainMenu();
        }

        private void BorrwwedBooksBtn_Click(object sender, EventArgs e)
        {
            form.ShowBooksWindow();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.reservationTableAdapter.FillBy(this.libraryDataSet.reservation);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        public void ShowBorrwedBooks()
        {
            dataGridView1.DataSource = ReservationDataAccess.getStudentReservations(form.getEmail());
        }


        


        private void returnBookBtn_Click(object sender, EventArgs e)
        {
            if(bookId == -1)
            {
                MessageBox.Show("please select book at first", "error");
                return;
            }
            ReservationDataAccess.deleteReservation(bookId, form.getEmail());
            ShowBorrwedBooks();
            bookId = -1;
            MessageBox.Show("book has been returned", "done");
        }

        private int bookId = -1;
    }
}
