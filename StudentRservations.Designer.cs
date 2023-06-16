
namespace Data_Base_Project
{
    partial class StudentRservations
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new Data_Base_Project.LibraryDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.reservationTableAdapter = new Data_Base_Project.LibraryDataSetTableAdapters.reservationTableAdapter();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numOfStudents = new System.Windows.Forms.Label();
            this.numOfReservations = new System.Windows.Forms.Label();
            this.numOfBooks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.BookName,
            this.studentEmailDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reservationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 354);
            this.dataGridView1.TabIndex = 47;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "bookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "bookID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "name";
            this.BookName.HeaderText = "BookName";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // studentEmailDataGridViewTextBoxColumn
            // 
            this.studentEmailDataGridViewTextBoxColumn.DataPropertyName = "studentEmail";
            this.studentEmailDataGridViewTextBoxColumn.HeaderText = "studentEmail";
            this.studentEmailDataGridViewTextBoxColumn.Name = "studentEmailDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "startDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "startDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "dueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "dueDate";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataMember = "reservation";
            this.reservationBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(315, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 48;
            this.label1.Text = "Reservations";
            // 
            // reservationTableAdapter
            // 
            this.reservationTableAdapter.ClearBeforeFill = true;
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BackBtn.Location = new System.Drawing.Point(321, 434);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(105, 37);
            this.BackBtn.TabIndex = 49;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(595, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 50);
            this.label2.TabIndex = 50;
            this.label2.Text = "# of students\r\nin the system:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(595, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 50);
            this.label3.TabIndex = 50;
            this.label3.Text = "# of distinct books\r\nin the system:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(595, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 50);
            this.label4.TabIndex = 50;
            this.label4.Text = "# of  reservations\r\nin the system: ";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // numOfStudents
            // 
            this.numOfStudents.AutoSize = true;
            this.numOfStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.numOfStudents.Location = new System.Drawing.Point(730, 172);
            this.numOfStudents.Name = "numOfStudents";
            this.numOfStudents.Size = new System.Drawing.Size(23, 25);
            this.numOfStudents.TabIndex = 51;
            this.numOfStudents.Text = "0";
            this.numOfStudents.Click += new System.EventHandler(this.label5_Click);
            // 
            // numOfReservations
            // 
            this.numOfReservations.AutoSize = true;
            this.numOfReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.numOfReservations.Location = new System.Drawing.Point(732, 345);
            this.numOfReservations.Name = "numOfReservations";
            this.numOfReservations.Size = new System.Drawing.Size(23, 25);
            this.numOfReservations.TabIndex = 51;
            this.numOfReservations.Text = "0";
            // 
            // numOfBooks
            // 
            this.numOfBooks.AutoSize = true;
            this.numOfBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.numOfBooks.Location = new System.Drawing.Point(730, 256);
            this.numOfBooks.Name = "numOfBooks";
            this.numOfBooks.Size = new System.Drawing.Size(23, 25);
            this.numOfBooks.TabIndex = 51;
            this.numOfBooks.Text = "0";
            this.numOfBooks.Click += new System.EventHandler(this.label5_Click);
            // 
            // StudentRservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numOfReservations);
            this.Controls.Add(this.numOfBooks);
            this.Controls.Add(this.numOfStudents);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentRservations";
            this.Size = new System.Drawing.Size(816, 489);
            this.Load += new System.EventHandler(this.StudentRservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private LibraryDataSet libraryDataSet;
        private LibraryDataSetTableAdapters.reservationTableAdapter reservationTableAdapter;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label numOfStudents;
        private System.Windows.Forms.Label numOfReservations;
        private System.Windows.Forms.Label numOfBooks;
    }
}
