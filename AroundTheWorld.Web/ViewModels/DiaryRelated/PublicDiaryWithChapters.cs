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
    }
}
