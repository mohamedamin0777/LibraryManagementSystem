using DevExpress.Data.Linq.Helpers;
using LibraryManagementSystem.Data;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Dashboard : UserControl
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public Dashboard()
        {
            InitializeComponent();
            int bookCount = context.Books.Count();
            lblAll.Text = bookCount.ToString();

            int borrowedBookCount = context.BorrowedBooks.Count();
            lblBorrowed.Text = borrowedBookCount.ToString();

            lblAvailable.Text = (bookCount - borrowedBookCount).ToString();
        }

      
    }
}
