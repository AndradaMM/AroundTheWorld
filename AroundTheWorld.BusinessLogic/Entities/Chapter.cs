using System;
using System.Collections.Generic;
using System.Text;

namespace AroundTheWorld.BusinessLogic.Entities
{
    public class Chapter
    {
        public int Id { get; set; }
        public int DiaryId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public int? ImageId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public Diary Diary { get; set; }
        public AtwImage Image { get; set; }

    }
}
