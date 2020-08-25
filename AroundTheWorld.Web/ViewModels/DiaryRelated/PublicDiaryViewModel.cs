using AroundTheWorld.BusinessLogic.Entities;
using AroundTheWorld.Web.ViewModels.ChapterRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AroundTheWorld.Web.ViewModels.DiaryRelated
{
    public class PublicDiaryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public bool IsPublic { get; set; }
        public byte[] Image { get; set; }
        public ICollection<ChapterViewModel> Chapters { get; set; }

        public PublicDiaryViewModel(Diary diary)
        {
            Id = diary.Id;
            Name = diary.Name;
            Location = diary.Location;
            Image = diary.Image.Content;
        }
    }
}
