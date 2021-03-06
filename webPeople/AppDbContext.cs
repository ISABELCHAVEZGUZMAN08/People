using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webPeople.Models;

namespace webPeople
{
    public class AppDbContext:DbContext
    {
        public DbSet<Person> People { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
    }
}
