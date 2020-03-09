using AroundTheWorld.BusinessLogic.Entities;
using AroundTheWorld.DataAccess.TypeConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AroundTheWorld.DataAccess
{
    public class AtwDbContext : DbContext
    {
        public AtwDbContext(DbContextOptions options) :base(options)
        {
        }

        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Diary> Diaries { get; set; }
        public DbSet<AtwImage> AtwImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ChapterTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DiaryTypeConfiguration());
            modelBuilder.ApplyConfiguration(new AtwImageTypeConfiguration());
        }
    }
}
