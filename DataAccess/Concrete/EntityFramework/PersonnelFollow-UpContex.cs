using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class PersonnelFollow_UpContex:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=PersonnelFollow-UpProject;Trusted_Connection=true");
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Assigment> Assigments  { get; set; }
        public DbSet<Assigment_Personnel> Assigments_Personnels  { get; set; }
        public DbSet<Branch> Branches  { get; set; }
        public DbSet<Branch_Department> Branches_Departments { get; set; }
        public DbSet<Department> Departments  { get; set; }
        public DbSet<ContactNumber> ContactNumbers  { get; set; }
        public DbSet<Personnel> Personnels  { get; set; }
        public DbSet<Unit> Units  { get; set; }
        public DbSet<Unit_Assigment> Units_Assigments  { get; set; }
        public DbSet<Unit_Personnel> Units_Personnels  { get; set; }

}
}
