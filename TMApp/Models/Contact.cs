using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TMApp.Models
{
    [Table("tblContacts")]
    public class Contact
    {
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage ="Fill this feild")]
        
        public string Name { get; set; }
         [Required(ErrorMessage = "Fill this feild")]
        public string Email { get; set; }
        public string Subject { get; set; }
        [Required(ErrorMessage = "Fill this feild")]
        public string Message { get; set; }

    }
}