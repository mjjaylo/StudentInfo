using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using StudentInfo.Models;
namespace StudentInfo.Models
{
    public class AppContext : DbContext
    {

        public AppContext() : base("DefaultConnection")
        { }

        public DbSet<Students> Students { get; set; }
    }
}