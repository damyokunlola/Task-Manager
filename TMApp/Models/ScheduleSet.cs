using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace TMApp.Models
{
    [Table("ScheduleSet")]
    public class ScheduleSet
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Description")]
        public string SchName { get; set; }
        public string Categories { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Location { get; set; }
        public Register Username { get; set; }
        public Register Password { get; set; }
    }
    public enum TaskCategory
    {
        Business,
        Career,
        Party,
        Personal,
        Training,
       Others
    }
    public enum Day
    {



    }
}