﻿using Aduaba.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aduaba.Constants;

namespace Aduaba.Data
{
    public class ApplicationDbContextSeed
    {
        public static async Task SeedEssentialsAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(Authorization.Roles.Administrator.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Authorization.Roles.User.ToString()));

            //Seed Default User
            var defaultUser = new ApplicationUser
            {
                UserName = Authorization.default_username,
                Email = Authorization.default_username,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                await userManager.CreateAsync(defaultUser, Authorization.default_password);
                await userManager.AddToRoleAsync(defaultUser, Authorization.default_role.ToString());
            }

        }
    }
}
