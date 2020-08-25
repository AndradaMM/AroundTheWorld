using AroundTheWorld.BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AroundTheWorld.Web.ViewModels.ChapterRelated
{
    public class ChapterViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public byte[] Image { get; set; }

        public ChapterViewModel(Chapter chapter)
        {
            Id = chapter.Id;
            Name = chapter.Name;
            Location = chapter.Location;
            Date = chapter.Date;
            Content = chapter.Content;
            Image = chapter.Image.Content;
        }

        public ChapterViewModel()
        {
        }
    }
}
