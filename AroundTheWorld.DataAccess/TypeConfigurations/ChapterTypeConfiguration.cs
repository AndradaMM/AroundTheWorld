using AroundTheWorld.BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AroundTheWorld.DataAccess.TypeConfigurations
{
    public class ChapterTypeConfiguration : IEntityTypeConfiguration<Chapter>
    {
        public void Configure(EntityTypeBuilder<Chapter> builder)
        {
            builder.ToTable("tblChapter");
            builder.HasKey(chapter => chapter.Id);
            builder.HasOne(chapter => chapter.Diary).WithMany(diary => diary.Chapters);
            builder.HasOne(chapter => chapter.Image).WithMany(image => image.Chapters);

            builder.HasData
               (
                   new Chapter
                   {
                       Id = 1,
                       DiaryId = 1,
                       ImageId = 6,
                       IsPublic = true,
                       Name = "Day 1",
                       Location = "London",
                       Date = new DateTime(2020, 7, 6),
                       Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                       CreatedOn = new DateTime(2020, 7, 7)
                   },
                   new Chapter
                   {
                       Id = 2,
                       DiaryId = 1,
                       ImageId = 7,
                       IsPublic = true,
                       Name = "Day 2",
                       Location = "London",
                       Date = new DateTime(2020, 7, 6),
                       Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                       CreatedOn = new DateTime(2020, 7, 7)
                   },
                   new Chapter
                   {
                       Id = 3,
                       DiaryId = 2,
                       ImageId = 8,
                       IsPublic = false,
                       Name = "Day 2",
                       Location = "London",
                       Date = new DateTime(2020, 7, 6),
                       Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                       CreatedOn = new DateTime(2020, 7, 7)
                   },
                   new Chapter
                   {
                       Id = 4,
                       DiaryId = 3,
                       ImageId = 9,
                       IsPublic = false,
                       Name = "Day 2",
                       Location = "London",
                       Date = new DateTime(2020, 7, 6),
                       Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                       CreatedOn = new DateTime(2020, 7, 7)
                   },
                   new Chapter
                   {
                       Id = 5,
                       DiaryId = 3,
                       ImageId = 10,
                       IsPublic = true,
                       Name = "Day 2",
                       Location = "London",
                       Date = new DateTime(2020, 7, 6),
                       Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                       CreatedOn = new DateTime(2020, 7, 7)
                   },
                   new Chapter
                   {
                       Id = 6,
                       DiaryId = 4,
                       ImageId = 11,
                       IsPublic = true,
                       Name = "Day 2",
                       Location = "London",
                       Date = new DateTime(2020, 7, 6),
                       Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                       CreatedOn = new DateTime(2020, 7, 7)
                   }
               );

        }
    }
}
