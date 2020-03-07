using AroundTheWorld.BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;


namespace AroundTheWorld.DataAccess.TypeConfigurations
{
    public class AtwImageTypeConfiguration : IEntityTypeConfiguration<AtwImage>
    {
        public void Configure(EntityTypeBuilder<AtwImage> builder)
        {
            builder.ToTable("tblAtwImage");
            builder.HasKey(atwImage => atwImage.Id);
        
        }
    }
}
