using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LibraryWebApp.Models
{
    public class AuthorModel
    {
        [Required]
        public int AuthorID { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "FirstName can not be more than 100 characters long.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please.")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "LastName can not be more than 100 characters long.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please.")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage = "Bio can not be more than 500 characters long.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please.")]
        public string Bio { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "LastName can not be more than 100 characters long.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please.")]
        public string BirthLocation { get; set; }
        public DateTime DateOfBirth { get; set; }



        

        //public string FirstName {get; set;}




    }
}