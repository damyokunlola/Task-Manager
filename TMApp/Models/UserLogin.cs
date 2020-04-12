using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TMApp.Models
{
    [Table("tblLogin")]
    public class UserLogin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Fill this feild")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Fill this feild")]
        public string Password { get; set; }
        public DateTime LoginDate { get; set; }
    
    }
}