using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LibraryManagementSystem.Model;
using LibraryManagementSystem.Data;

namespace LibraryManagementSystem
{
    public partial class AddBooksForm : UserControl
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public AddBooksForm()
        {
            InitializeComponent();


        }

        private void AddBooksForm_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].Name = "Title";
            dataGridView1.Columns[1].HeaderText = "Title";
            dataGridView1.Columns[2].Name = "Author";
            dataGridView1.Columns[2].HeaderText = "Author";
            dataGridView1.Columns[3].Name = "Published";
            dataGridView1.Columns[3].HeaderText = "Published";
            dataGridView1.Columns[4].Name = "Count";
            dataGridView1.Columns[4].HeaderText = "Count";
            dataGridView1.Rows.Clear();
            GetAllBooks();



        }

        private void GetAllBooks()
        {
            var Books = context.Books.Where(b => b.Count > 0).ToList();

            foreach (var item in Books)
            {

                dataGridView1.Rows.Add(new string[] { item.Id.ToString(), item.BookTitle, item.Author, item.Published.ToString(), item.Count.ToString() });
            }

        }

        private void addBooks_addBtn_Click(object sender, EventArgs e)
        {
            try{
                var Book = new Book()
                {
                    BookTitle = addBooks_bookTitle.Text,
                    Author = addBooks_author.Text,
                    Count = int.Parse(CountTxt.Text),
                    Published = addBooks_published.Value

                };

                context.Books.Add(Book);
                context.SaveChanges();
                dataGridView1.Rows.Clear();
                GetAllBooks();
                Clear();
            }
            catch
            {
                MessageBox.Show("Enter valid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        int IndexRow;

        private void dataGridView1_Click_1(object sender, EventArgs e)
        {
            IndexRow = dataGridView1.SelectedCells[0].RowIndex;

            addBooks_bookTitle.Text = dataGridView1[1, IndexRow].Value.ToString();
            addBooks_author.Text = dataGridView1[2, IndexRow].Value.ToString();
            addBooks_published.Text = dataGridView1[3, IndexRow].Value.ToString();
            CountTxt.Text = dataGridView1[4, IndexRow].Value.ToString();
        }

        private void addBooks_updateBtn_Click(object sender, EventArgs e)
        {
            var id = int.Parse(dataGridView1[0, IndexRow].Value.ToString());
            var OldBook = context.Books.FirstOrDefault(x => x.Id == id);
            try
            {
                if (OldBook != null)
                {
                    OldBook.BookTitle = addBooks_bookTitle.Text;
                    OldBook.Author = addBooks_author.Text;
                    OldBook.Count = int.Parse(CountTxt.Text);
                    OldBook.Published = addBooks_published.Value;

                    context.SaveChanges();
                    dataGridView1.Rows.Clear();
                    GetAllBooks();
                    Clear();
                }
            }
            catch
            {
                MessageBox.Show("Enter valid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addBooks_clearBtn_Click(object sender, EventArgs e)
            => Clear();

        private void addBooks_deleteBtn_Click(object sender, EventArgs e)
        {
            var id = int.Parse(dataGridView1[0, IndexRow].Value.ToString());
            var book = context.Books.FirstOrDefault(x => x.Id == id);
            var Result = MessageBox.Show("Are you Sure Remove this Book", "Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                if (book != null)
                {

                    context.Books.Remove(book);
                    context.SaveChanges();
                    dataGridView1.Rows.Clear();
                    GetAllBooks();
                    Clear();
                }
                else
                {
                    MessageBox.Show("invaild");
                }
            }
          
        }

        private void Clear()
        {
            addBooks_bookTitle.Text = "";
            addBooks_author.Text = "";
            addBooks_published.Text = "";
            CountTxt.Text = "";
        }
    }

}
