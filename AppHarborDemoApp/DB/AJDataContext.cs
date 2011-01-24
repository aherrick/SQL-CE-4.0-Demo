using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AppHarborDemoApp.Models;

namespace AppHarborDemoApp.DB
{
    public class AJDataContext : DbContext
    {
        public DbSet<Comment> Comments { get; set; }
    }
}