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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
       
        [Required(ErrorMessage ="This field is required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Categories { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Location { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Email { get; set; }

        //[Required(ErrorMessage = "This field is required")]
        //public string Username { get; set; }
        //[Required(ErrorMessage = "This field is required")]
        //public string Password { get; set; }
        public string Status { get; set; }
    }
    public enum TaskCategory
    {
        Business,
        Career,
        Party,
        Personal,
        Religion,
        Others
    }

}