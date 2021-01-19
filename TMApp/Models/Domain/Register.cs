using System; 
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TMApp.Models
{
    [Table("tblRegister")]
    public class Register
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int id { get; set; }
        [Required(ErrorMessage ="This feild is required")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Select your gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "This feild is required")]
        [Key]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "This feild is required")]
       [DataType(DataType.PhoneNumber)]
        public double PhoneNo { get; set; }

        [Required(ErrorMessage = "This feild is required")]
        public string Country { get; set; }

        [Required(ErrorMessage = "This feild is required")]
        public string State { get; set; }

        [Required(ErrorMessage = "This feild is required")]
        [MaxLength(20, ErrorMessage = "Username can not be more than 20 character"),
            MinLength(3, ErrorMessage = "Username must be at least 3 character")]
        public string Username { get; set; }

        [Required(ErrorMessage = "This feild is required")]
        [MaxLength(20,ErrorMessage ="Password can not be more than 20 character"),
            MinLength(3,ErrorMessage ="Password must be at least 3 character")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Date)]
        public   DateTime DateRegistered { get; set; }
        public string ProfilePic { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
        public DateTime LastLogin { get; set; }
        public DateTime LastUpdate { get; set; }

    }
    
   
    //public enum CountryList
    //{
        
    //    Nigeria,
    //    Algeria,
    //    China,
    //    India,
    //    Kenya,
    //    Ghana,
    //    USA,

    //}
    //public enum StateList
    //{
    //       Abia,
    //       Adamawa,
    //       Anambra,
    //       Kwara,
    //       Kano,
    //    Kaduna,
    //    Lagos,
    //    Ogun,
    //    Osun,
    //    Abuja,


    //}

}
