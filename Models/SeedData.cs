using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Models
{
    public class SeedData
    {
        public static void DataEmployee(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employee
                    {
                        ID = 1,
                        Name = "Allan",
                        JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                        Age = 23
                    },

                    new Employee
                    {
                        ID = 2,
                        Name = "Carson",
                        JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                        Age = 45
                    },

                    new Employee
                    {
                        ID = 3,
                        Name = "Carson",
                        JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                        Age = 37
                    },

                    new Employee
                    {
                        ID = 4,
                        Name = "Laura",
                        JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                        Age = 26
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
