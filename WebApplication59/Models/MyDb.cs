using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication59.Models
{
    public class MyDb : DbContext
    {
        public MyDb() : base("name=DefaultConnection")
        {

        }
        public DbSet<WebApplication59.Models.Xueshengxinxi> Xueshengxinxis { get; set; }
        public DbSet<WebApplication59.Models.chengji> chengjis { get; set; }

    }
}