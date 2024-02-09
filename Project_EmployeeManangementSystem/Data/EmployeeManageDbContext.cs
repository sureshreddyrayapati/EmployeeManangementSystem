using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_EmployeeManangementSystem.Models;

namespace Project_EmployeeManangementSystem.Data
{
    public class EmployeeManageDbContext : DbContext
    {
        public EmployeeManageDbContext (DbContextOptions<EmployeeManageDbContext> options)
            : base(options)
        {
        }

        public DbSet<Project_EmployeeManangementSystem.Models.EmpProfile> EmpProfile { get; set; } = default!;

        public DbSet<Project_EmployeeManangementSystem.Models.DeptMaster>? DeptMaster { get; set; }
    }
}
