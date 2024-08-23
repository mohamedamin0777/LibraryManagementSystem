using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    public class Book
    {


            [Key]
            public int Id { get; set; }
            [Required(ErrorMessage ="BookTitle Is Required") , MaxLength(25) ]  
            public string BookTitle { set; get; }
            [Required(ErrorMessage = "Author Is Required"), MaxLength(25)]
            public string Author { set; get; }
  
            public DateTime Published { set; get; } =DateTime.Now;  

            public string image { set; get; }
            public  int  Count { get; set; }

    }
}
