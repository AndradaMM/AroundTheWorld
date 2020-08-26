using AroundTheWorld.BusinessLogic.Entities;
using AroundTheWorld.Web.ViewModels.ChapterRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AroundTheWorld.Web.ViewModels.DiaryRelated
{
    public class PublicDiaryWithChapters
    {
        public string DiaryName { get; set; }
        public List<ChapterViewModel> Chapters { get; set; }

        public PublicDiaryWithChapters()
        {
            Chapters = new List<ChapterViewModel>();
        }

        public PublicDiaryWithChapters(Diary diary)
        {
            DiaryName = diary.Name;
            Chapters = new List<ChapterViewModel>();
            foreach (var chapter in diary.Chapters.Where(c => c.IsPublic))
            {
                Chapters.Add(new ChapterViewModel(chapter));
            }
        }
    }
}
