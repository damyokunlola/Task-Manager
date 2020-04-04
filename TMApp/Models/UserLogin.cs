﻿using System;
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
        public int Id { get; set; }
        [Required(ErrorMessage = "Fill this feild")]
        public Register Username { get; set; }

        [Required(ErrorMessage ="Fill this feild")]
        public string Password { get; set; }
    }
}