
namespace Data_Base_Project
{
    partial class BorrowedBooks
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
            this.label1 = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new Data_Base_Project.LibraryDataSet();
            this.BorrwwedBooksBtn = new System.Windows.Forms.Button();
            this.returnBookBtn = new System.Windows.Forms.Button();
            this.reservationTableAdapter = new Data_Base_Project.LibraryDataSetTableAdapters.reservationTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(251, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 31);
            this.label1.TabIndex = 48;
            this.label1.Text = "Borrowed Books";
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.logoutBtn.Location = new System.Drawing.Point(686, 430);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(87, 32);
            this.logoutBtn.TabIndex = 47;
            this.logoutBtn.Text = "logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.BookName,
            this.studentEmail,
            this.startDateDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reservationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 354);
            this.dataGridView1.TabIndex = 46;
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
            // BorrwwedBooksBtn
            // 
            this.BorrwwedBooksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BorrwwedBooksBtn.Location = new System.Drawing.Point(686, 194);
            this.BorrwwedBooksBtn.Name = "BorrwwedBooksBtn";
            this.BorrwwedBooksBtn.Size = new System.Drawing.Size(106, 88);
            this.BorrwwedBooksBtn.TabIndex = 44;
            this.BorrwwedBooksBtn.Text = "Books";
            this.BorrwwedBooksBtn.UseVisualStyleBackColor = true;
            this.BorrwwedBooksBtn.Click += new System.EventHandler(this.BorrwwedBooksBtn_Click);
            // 
            // returnBookBtn
            // 
            this.returnBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.returnBookBtn.Location = new System.Drawing.Point(267, 430);
            this.returnBookBtn.Name = "returnBookBtn";
            this.returnBookBtn.Size = new System.Drawing.Size(163, 32);
            this.returnBookBtn.TabIndex = 45;
            this.returnBookBtn.Text = "Return Book";
            this.returnBookBtn.UseVisualStyleBackColor = true;
            this.returnBookBtn.Click += new System.EventHandler(this.returnBookBtn_Click);
            // 
            // reservationTableAdapter
            // 
            this.reservationTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(816, 25);
            this.fillByToolStrip.TabIndex = 49;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "bookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "bookID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "name";
            this.BookName.HeaderText = "BookName";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // studentEmail
            // 
            this.studentEmail.DataPropertyName = "studentEmail";
            this.studentEmail.HeaderText = "studentEmail";
            this.studentEmail.Name = "studentEmail";
            this.studentEmail.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "startDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "startDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "dueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "dueDate";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            this.dueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BorrowedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BorrwwedBooksBtn);
            this.Controls.Add(this.returnBookBtn);
            this.Name = "BorrowedBooks";
            this.Size = new System.Drawing.Size(816, 489);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BorrwwedBooksBtn;
        private System.Windows.Forms.Button returnBookBtn;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private LibraryDataSet libraryDataSet;
        private LibraryDataSetTableAdapters.reservationTableAdapter reservationTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
    }
}
