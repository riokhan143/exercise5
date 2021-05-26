using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exercise5v2.Models;

namespace exercise5v2.DataContext{
    public class DBContext: DbContext{

        public DBContext(DbContextOptions options) : base(options){}
         public DbSet<MushroomModel> Shrooms{get;set;}
    }
}