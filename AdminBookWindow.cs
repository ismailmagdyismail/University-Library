using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Data_Base_Project.DataAccess;
using Data_Base_Project.Models;

namespace Data_Base_Project
{
    public partial class AdminBookWindow : UserControl
    {
        private Form1 form;
        private Book book;
        public AdminBookWindow()
        {
            InitializeComponent();
            ShowBooks();
            book = null;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row index is clicked
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                BookIDBox.Text  = row.Cells[0].Value.ToString();
                BookNameBox.Text = row.Cells[1].Value.ToString();
                AuthorBox.Text = row.Cells[2].Value.ToString();
                ISBNBox.Text = row.Cells[3].Value.ToString();
                CategoryBox.Text = row.Cells[4].Value.ToString();
                if (DateTime.TryParse(row.Cells[5].Value.ToString(), out DateTime date))
                {
                    Date.Value = date;
                }
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void SetForm(Form1 form)
        {
            this.form = form;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            form.ShowMainMenu();
        }

        private void StudentBtn_Click(object sender, EventArgs e)
        {
            form.ShowAdminStudentWindow();
        }

        public void ShowBooks()
        {
            dataGridView1.DataSource = BookDataAccess.getBooksDataTable();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (BookIDBox.Text == "")
                MessageBox.Show("please select book first!", "error");

            else if (BookDataAccess.getBookByID( int.Parse(BookIDBox.Text) ) == null)
            {
                MessageBox.Show("wrong id there is no book matches", "error");
            }

            else
            {
                BookDataAccess.removeBook(int.Parse(BookIDBox.Text));
                ShowBooks();
                clear();
                MessageBox.Show("book has been removed", "sucsuess");
            }

        }

        private void clear()
        {
            ISBNBox.Clear();
            BookIDBox.Clear();
            BookNameBox.Clear();
            AuthorBox.Clear();
            CategoryBox.Clear();
            Date.ResetText();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Book selectedBook = null;
            if(BookIDBox.Text != "")
            {
                selectedBook = BookDataAccess.getBookByID(int.Parse(BookIDBox.Text));
            }

            if (BookNameBox.Text == "" || AuthorBox.Text == "" || CategoryBox.Text == "" || ISBNBox.Text == "")
            {
                MessageBox.Show("please fill the data first", "error");
            }

            else if (selectedBook != null && (BookNameBox.Text == selectedBook.Name && AuthorBox.Text == selectedBook.Author && CategoryBox.Text == selectedBook.Category && int.Parse(ISBNBox.Text) == selectedBook.ISBN) )
            {
                MessageBox.Show("book is already exsit", "error");
            }

            else
            {
                book = new Book(-1, BookNameBox.Text, AuthorBox.Text, int.Parse(ISBNBox.Text), CategoryBox.Text, Date.Value);
                BookDataAccess.AddBook(book);
                ShowBooks();
                clear();
                MessageBox.Show("book has been added", "done");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (BookIDBox.Text == "")
            {
                MessageBox.Show("Please select book at first", "error");
            }
            else
            {
                Book selectedBook = BookDataAccess.getBookByID(int.Parse(BookIDBox.Text));
                if (BookNameBox.Text == selectedBook.Name && AuthorBox.Text == selectedBook.Author && CategoryBox.Text == selectedBook.Category && int.Parse(ISBNBox.Text) == selectedBook.ISBN)
                {
                    MessageBox.Show("there is no change", "error");
                    return;
                }
                book = new Book(int.Parse(BookIDBox.Text), BookNameBox.Text, AuthorBox.Text, int.Parse(ISBNBox.Text), CategoryBox.Text, Date.Value);
                BookDataAccess.UpdateBook(book);
                ShowBooks();
                clear();
                MessageBox.Show("book has been updated", "done");
            }
        }
    }
}
