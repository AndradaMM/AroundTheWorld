using AroundTheWorld.BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;


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
                    Content=File.ReadAllBytes(Path.Combine(projectPath, "DataSeed/black-panther-background.jpg")),
                    CreatedOn=new DateTime(2020,4,3)
                }
             );

        }
    }
}
