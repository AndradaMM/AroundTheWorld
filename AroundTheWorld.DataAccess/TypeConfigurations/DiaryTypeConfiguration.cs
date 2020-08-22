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
                        Name="London Trip",
                        Location="London",
                        IsPublic=true,
                        Date= new DateTime(2016, 7, 7),
                        CreatedOn =new DateTime(2016, 7,7),
                        ImageId = 1
                    },
                    new Diary
                    {
                        Id=2,
                        Name="Paris Trip",
                        Location="Paris",
                        IsPublic=true,
                        Date = new DateTime(2017, 7, 7),
                        CreatedOn =new DateTime(2017, 7,7),
                        ImageId = 2
                    },
                    new Diary
                    {
                        Id=3,
                        Name="Berlin Trip",
                        Location="Berlin",
                        IsPublic=true,
                        Date = new DateTime(2018, 7, 7),
                        CreatedOn =new DateTime(2018, 7,7),
                        ImageId = 3
                    },
                    new Diary
                    {
                        Id=4,
                        Name="Lisboa Trip",
                        Location="Lisboa",
                        IsPublic=true,
                        Date = new DateTime(2019, 7, 7),
                        CreatedOn =new DateTime(2019, 7,7),
                        ImageId = 4
                    },
                    new Diary
                    {
                        Id=5,
                        Name="Madrid Trip",
                        Location="Madrid",
                        IsPublic=true,
                        Date = new DateTime(2020, 7, 7),
                        CreatedOn =new DateTime(2020,7,7),
                        ImageId = 5
                    }


                );
            
        }
    }
}
