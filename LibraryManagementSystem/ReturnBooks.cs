using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LibraryManagementSystem.Data;

namespace LibraryManagementSystem
{
    public partial class ReturnBooks : UserControl
    {
        private readonly ApplicationDbContext context = new ApplicationDbContext();
        public ReturnBooks()
        {
            InitializeComponent();

        }

        private void GetAllBorrowed()
        {
            var Books = context.BorrowedBooks.ToList();

            foreach (var item in Books)
            {

                dataGridView11.Rows.Add(new string[] { item.Person.Name, item.Book.BookTitle, item.Book.Author, item.Person.Address, item.Person.phone, item.EndBoorow.ToString() });
            }
        }

        private void ReturnBooks_Load(object sender, EventArgs e)
        {
            dataGridView11.ColumnCount = 6;
            dataGridView11.Columns[0].Name = "Name";
            dataGridView11.Columns[0].HeaderText = "Name";
            dataGridView11.Columns[1].Name = "BookTitle";
            dataGridView11.Columns[1].HeaderText = "BookTitle";
            dataGridView11.Columns[2].Name = "Author";
            dataGridView11.Columns[2].HeaderText = "Author";
            dataGridView11.Columns[3].Name = "Address";
            dataGridView11.Columns[3].HeaderText = "Address";
            dataGridView11.Columns[4].Name = "Phone";
            dataGridView11.Columns[4].HeaderText = "Phone";
            dataGridView11.Columns[5].Name = "Return";
            dataGridView11.Columns[5].HeaderText = "Return";
            dataGridView11.Rows.Clear();
            GetAllBorrowed();
        }

        int IndexRow;
        private void dataGridView11_Click(object sender, EventArgs e)
        {
            IndexRow = dataGridView11.SelectedCells[0].RowIndex;

            textName.Text = dataGridView11[0, IndexRow].Value.ToString();
            textBook.Text = dataGridView11[1, IndexRow].Value.ToString();
            txtAuthor.Text = dataGridView11[2, IndexRow].Value.ToString();
            borrowed_Address.Text = dataGridView11[3, IndexRow].Value.ToString();
            Borrowed_phone.Text = dataGridView11[4, IndexRow].Value.ToString();
        }

        private void clearBtn_Click(object sender, EventArgs e) => Clear();

        private void Clear()
        {
            textName.Text = "";
            textBook.Text = "";
            txtAuthor.Text = "";
            borrowed_Address.Text = "";
            Borrowed_phone.Text = "";
        }

        private void returnBooks_returnBtn_Click(object sender, EventArgs e)
        {
            var id = dataGridView11[0, IndexRow].Value.ToString();

            var BooksBrowered = context.BorrowedBooks.FirstOrDefault(d => d.Person.Name == id);
            var Result = MessageBox.Show("Are you Sure Return this Book", "Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                if (BooksBrowered != null)
                {
                    var bookId = BooksBrowered.BookId;
                    var book = context.Books.Where(b => b.Id == bookId).FirstOrDefault();
                    book.Count += 1;
                    context.BorrowedBooks.Remove(BooksBrowered);
                    context.SaveChanges();
                    dataGridView11.Rows.Clear();
                    GetAllBorrowed();
                }
                else
                {
                    MessageBox.Show("invaild");
                }
            }

        }
    }
}
