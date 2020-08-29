using AroundTheWorld.BusinessLogic.Entities;
using AroundTheWorld.Web.ViewModels.ChapterRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AroundTheWorld.Web.ViewModels.DiaryRelated
{
    public class EditDiaryWithChapters
    {
        public EditDiaryFields DiaryFields { get; set; }
        public List<ChapterViewModel> Chapters { get; set; }

        public EditDiaryWithChapters(Diary diary)
        {
            DiaryFields = new EditDiaryFields
            {
                Id = diary.Id,
                Name = diary.Name,
                Location = diary.Location,
                Date = diary.Date.ToShortDateString()
            };

            Chapters = new List<ChapterViewModel>();
            foreach(var chapter in diary.Chapters)
            {
                Chapters.Add(new ChapterViewModel(chapter));
            }
        }

        public EditDiaryWithChapters()
        {

        }
    }
}
