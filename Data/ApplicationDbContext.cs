﻿using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebAppFormMVC.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<ContactMessage> ContactMessages { get; set; }
    }
}