using System;
using System.Collections.Generic;
using System.Text;
using EntityFramework.Data;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
      class VacationContext : DbContext
    {
        public DbSet<Employee> employees { get; set; }
        public DbSet<Vacation> vacations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data source = DESKTOP-95UVNJC;Initial Catalog=EmployeeVacation;Integrated Security = True;");
           
        }
    }
}
