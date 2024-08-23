using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    public  class User
    {
        [Key]
        public  int ID { get; set; }
        [Required(ErrorMessage = "UserName is required."), MaxLength(25)]
        public  string UserName { get; set; }
        [Required(ErrorMessage = "Email is required."), MaxLength(25)]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]

        public string Email { get; set; }
        [Required(ErrorMessage = "PassWord is required."), MaxLength(25) ]
        public string Password { get; set; }
        
        public  DateTime RegisterDate { get; set; }=DateTime.Now;


    }
}
