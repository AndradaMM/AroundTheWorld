using AroundTheWorld.BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.IO;
using System.Reflection;


namespace AroundTheWorld.DataAccess.TypeConfigurations
{
    public class AtwImageTypeConfiguration : IEntityTypeConfiguration<AtwImage>
    {
        public void Configure(EntityTypeBuilder<AtwImage> builder)
        {
            builder.ToTable("tblAtwImage");
            builder.HasKey(atwImage => atwImage.Id);
            builder.Property(atwImage => atwImage.Id).ValueGeneratedNever();

            var projectPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            builder.HasData
            (
                new AtwImage
                {
                    Id = 1,
                    Content = File.ReadAllBytes(Path.Combine(projectPath, "DataSeed/beach.jpg")),
                    CreatedOn = new DateTime(2020, 4, 3)
                },
                new AtwImage
                {
                    Id = 2,
                    Content = File.ReadAllBytes(Path.Combine(projectPath, "DataSeed/beach.jpg")),
                    CreatedOn = new DateTime(2020, 4, 3)
                },
                new AtwImage
                {
                    Id = 3,
                    Content = File.ReadAllBytes(Path.Combine(projectPath, "DataSeed/beach.jpg")),
                    CreatedOn = new DateTime(2020, 4, 3)
                },
                new AtwImage
                {
                    Id = 4,
                    Content = File.ReadAllBytes(Path.Combine(projectPath, "DataSeed/beach.jpg")),
                    CreatedOn = new DateTime(2020, 4, 3)
                },
                new AtwImage
                {
                    Id = 5,
                    Content = File.ReadAllBytes(Path.Combine(projectPath, "DataSeed/beach.jpg")),
                    CreatedOn = new DateTime(2020, 4, 3)
                },
                new AtwImage
                {
                    Id = 6,
                    Content = File.ReadAllBytes(Path.Combine(projectPath, "DataSeed/beach.jpg")),
                    CreatedOn = new DateTime(2020, 4, 3)
                },
                new AtwImage
                {
                    Id = 7,
                    Content = File.ReadAllBytes(Path.Combine(projectPath, "DataSeed/beach.jpg")),
                    CreatedOn = new DateTime(2020, 4, 3)
                },
                new AtwImage
                {
                    Id = 8,
                    Content = File.ReadAllBytes(Path.Combine(projectPath, "DataSeed/beach.jpg")),
                    CreatedOn = new DateTime(2020, 4, 3)
                },
                new AtwImage
                {
                    Id = 9,
                    Content = File.ReadAllBytes(Path.Combine(projectPath, "DataSeed/beach.jpg")),
                    CreatedOn = new DateTime(2020, 4, 3)
                },
                new AtwImage
                {
                    Id = 10,
                    Content = File.ReadAllBytes(Path.Combine(projectPath, "DataSeed/beach.jpg")),
                    CreatedOn = new DateTime(2020, 4, 3)
                },
                new AtwImage
                {
                    Id = 11,
                    Content = File.ReadAllBytes(Path.Combine(projectPath, "DataSeed/beach.jpg")),
                    CreatedOn = new DateTime(2020, 4, 3)
                }
             );

        }
    }
}
