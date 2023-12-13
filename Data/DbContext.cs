using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Application.Models;
#nullable disable

namespace Application.Data;

public class ApplicationContext : DbContext
{
    public ApplicationContext (DbContextOptions<ApplicationContext> options) : base(options)
        {
            
        }

        public DbSet<UserData> UserLogs{get;set;}

        public DbSet<Admin> AdminLogs{get;set;} 

}