using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
 //   public class AppDbContext: IdentityDbContext<IdentityUser>
    public class AppDbContext: IdentityDbContext<IdentityUser>

    {
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
            
        }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<Cake> Cakes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<StockItem> stockItems { get; set; }

        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            
            
            var role = new IdentityRole {
                Name = "SuperUser",
                NormalizedName = "SUPERUSER"
            };


            builder.Entity<IdentityRole>().HasData(role);
            // var roleResult = _roleManager.CreateAsync(role);
            PasswordHasher<IdentityUser> passwordHasher = new PasswordHasher<IdentityUser>();
            
            var user = new IdentityUser 
            { 
                Email = "moemad.admin@admin.com", 
                NormalizedEmail = "MOEMAD.ADMIN@ADMIN.COM", 
                UserName = "moemad.admin@admin.com", 
                NormalizedUserName = "MOEMAD.ADMIN@ADMIN.COM" 
            };
            
            var passwordHash = passwordHasher.HashPassword(user, "Moemad@admin123");
            user.PasswordHash = passwordHash;
            //var result =  _userManager.CreateAsync(user, "Moemad@admin123");
            //var addRole = _userManager.AddToRoleAsync(user, "SuperUser");

            builder.Entity<IdentityUser>().HasData(user);
            IdentityUserRole<String> identityUserRole = new IdentityUserRole<String> 
            { 
                UserId = user.Id,
                RoleId = role.Id
            };

            builder.Entity<IdentityUserRole<String>>().HasData(identityUserRole);
            

        }
    }
}
