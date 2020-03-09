using AroundTheWorld.BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AroundTheWorld.DataAccess.TypeConfigurations
{
    public class DiaryTypeConfiguration : IEntityTypeConfiguration<Diary>
    {
        public void Configure(EntityTypeBuilder<Diary> builder)
        {
            builder.ToTable("tblDiary");
            builder.HasKey(diary => diary.Id);
            builder.Property(diary => diary.Id).ValueGeneratedNever();
            builder.HasOne(diary => diary.Image).WithMany(image => image.Diaries);

            builder.HasData
                (
                    new Diary
                    {
                        Id=1,
                        Name="DiaryTest",
                        Location="DiaryLocation",
                        IsPublic=true,
                        CreatedOn=new DateTime(2020,7,7)
                    }


                );
            
        }
    }
}
