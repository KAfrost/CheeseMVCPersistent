﻿using CheeseMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CheeseMVC.Data
{
    public class CheeseDbContext : DbContext
    {
        public DbSet<Cheese> Cheeses { get; set; }

        public DbSet<CheeseCategory> Categories { get; set; }

        public DbSet<Menu> Menu { get; set; }
        public DbSet<CheeseMenu> CheeseMenu { get; set; }
<<<<<<< HEAD
        public object Menus { get; internal set; }
        public object CheeseMenus { get; internal set; }
        public CheeseDbContext(DbContextOptions<CheeseDbContext> options)
            : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CheeseMenu>().HasKey(c => new { c.CheeseID, c.MenuID });
=======
/*        public object Menus { get; internal set; }
        public object CheeseMenus { get; internal set; }*/
        public CheeseDbContext(DbContextOptions<CheeseDbContext> options) 
            : base(options)
        {  }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CheeseMenu>().HasKey(c => new { c.CheeseID, c.MenuID});
>>>>>>> 4cc2b86d14f3582b54ec9081835a975de360afd4
        }

    }
}
