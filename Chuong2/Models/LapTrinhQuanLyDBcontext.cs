using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using Chuong2.Models;

namespace Chuong2.Models
{
    public partial class LapTrinhQuanLyDBcontext : DbContext
    {
        public LapTrinhQuanLyDBcontext()
            : base("name=LapTrinhQuanLyDBcontext2")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
