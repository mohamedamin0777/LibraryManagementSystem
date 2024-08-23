using LibraryManagementSystem.Model;
using System.Data.Entity;

namespace LibraryManagementSystem.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(): base("name=MyConnection")
        {
            
        }

        public  DbSet<User> Users { get; set; }
        public  DbSet<Person> Persons { get; set; }
        public  DbSet<BorrowedBook> BorrowedBooks { get; set; }
        public  DbSet<Book> Books { get; set; }
        
    }
}
