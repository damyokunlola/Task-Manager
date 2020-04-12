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
        public string Gender { get; set; }
        [Required(ErrorMessage = "This feild is required")]
        [Key]
        public string Email { get; set; }
        [Required(ErrorMessage = "This feild is required")]
       
        public double PhoneNo { get; set; }

        [Required(ErrorMessage = "This feild is required")]
        public string Country { get; set; }
        [Required(ErrorMessage = "This feild is required")]
        public string State { get; set; }

        [Required(ErrorMessage = "This feild is required")]
        [MaxLength(20)]
        public string Username { get; set; }


        [Required(ErrorMessage = "This feild is required")]
        public string Password { get; set; }

        
    }
    
   
    public enum CountryList
    {
        
        Nigeria,
        Algeria,
        China,
        India,
        Kenya,
        Ghana,
        USA,

    }
    public enum StateList
    {
           Abia,
           Adamawa,
           Anambra,
           Kwara,
           Kano,
        Kaduna,
        Lagos,
        Ogun,
        Osun,
        Abuja,


    }

}
