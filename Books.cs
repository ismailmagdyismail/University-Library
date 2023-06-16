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
    public partial class Books : UserControl
    {
        
        public Books()
        {
            InitializeComponent();
            ShowBooks();
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
            form.ShowBorrowedBooksWindow();
        }

        public void ShowBooks()
        {
            dataGridView1.DataSource = BookDataAccess.getBooksDataTable();
        }

        
        private Form1 form;

        private void BorrowBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ReservationDataAccess.createReservation(bookId, form.getEmail());
                MessageBox.Show("book has been added");
            }
            catch(Exception ex)
            {
                MessageBox.Show("book is borrowed before");
            }
        }

        private int bookId;
    }
}
