using Microsoft.EntityFrameworkCore;
using StudentAzure.Models;
using System.Collections.Generic;

namespace StudentAzure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }


}
