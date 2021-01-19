using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TMApp.Models
{
    public class TMAppContext:DbContext
    {
        public TMAppContext()
          : base("name=TMConnection")
        {

        }
        public DbSet<Register> RegistersTable { get; set; }
        public DbSet<UserLogin> UserLoginsTable { get; set; }
        public DbSet<ScheduleSet> ScheduleSetsTable { get; set; }
        public DbSet<Contact> ContactsTable { get; set; }
        public DbSet<Email> EmailsTable { get; set; }

    }
}