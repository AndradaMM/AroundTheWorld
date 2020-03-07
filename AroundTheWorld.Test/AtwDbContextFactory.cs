using AroundTheWorld.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace AroundTheWorld.Test
{
    public class AtwDbContextFactory: IDesignTimeDbContextFactory<AtwDbContext>
    {
        public AtwDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AtwDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AroundTheWorld.Entities;Integrated Security=true;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new AtwDbContext(optionsBuilder.Options);
        }
    }
}
