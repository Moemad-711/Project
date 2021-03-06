﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PieShop.Models;

namespace PieShop
    {
        public class SeedData
        {
        public static async Task InitializeAsync(
            IServiceProvider services)
        {
            var roleManager = services
                .GetRequiredService<RoleManager<IdentityRole>>();
            await EnsureRolesAsync(roleManager);

            var userManager = services
                .GetRequiredService<UserManager<IdentityUser>>();
            await EnsureTestAdminAsync(userManager);


        }

        private static async Task EnsureRolesAsync(RoleManager<IdentityRole> roleManager)
        {
            var alreadyExists = await roleManager
                .RoleExistsAsync(Constants.AdministratorRole);

            if (alreadyExists) return;

            await roleManager.CreateAsync(
                new IdentityRole(Constants.AdministratorRole));
        }


        private static async Task EnsureTestAdminAsync(UserManager<IdentityUser> userManager)
        {
            var testAdmin = await userManager.Users
                .Where(x => x.UserName == "moemad.admin@admin.com")
                .SingleOrDefaultAsync();

            if (testAdmin != null) return;

            testAdmin = new IdentityUser
            {
                UserName = "moemad.admin@admin.com",
                Email = "moemad.admin@admin.com"
            };
            await userManager.CreateAsync(
                testAdmin, "Moemad@admin123");
            await userManager.AddToRoleAsync(
                testAdmin, Constants.AdministratorRole);
        }
    }
    }
