using AroundTheWorld.BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AroundTheWorld.Web.ViewModels.DiaryRelated
{
    public class DiaryListItemViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Image { get; set; }

        public DiaryListItemViewModel(Diary diary)
        {
            Id = diary.Id;
            Date = diary.Date;
            Name = diary.Name;
            Location = diary.Location;
            Image = "data:image/png;base64," + Convert.ToBase64String(diary.Image.Content);
        }
    }
}
