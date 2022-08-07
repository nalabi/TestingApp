using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace API.Data
{
    public class Seed
    {
        public static async Task SeedUsers(DataContext context)
        {
            if (await context.Users.AnyAsync()) return;

            var userData = await System.IO.File.ReadAllTextAsync("Data/UserSeedData.json");
            var users= JsonSerializer.Deserialize<List<AppUser>>(userData);
            foreach(var user in users)
            {
                using var hmac = new HMACSHA512();

                user.UserName = user.UserName.ToLower(), 
                user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("TestApp"));
                user.PasswordSalt = hmac.Key;

                context.Users.Add(user);
            }

            await context.SaveChangesAsync();
        }
    }
}