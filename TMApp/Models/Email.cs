using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TMApp.Models
{
    [Table("tblEmail")]
    public class Email
    {
      [Key]
        public string Sender { get; set; }
        [Required]
        public string Subject { get; set; }
       
        [Required]
        public string Receiver { get; set; }
        [Required]
        public string Body { get; set; }
        public string Status { get; set; }


    }


}