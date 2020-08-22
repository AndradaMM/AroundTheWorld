using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AroundTheWorld.BusinessLogic.Entities
{
    public class Diary
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public int? ImageId { get; set; }
        public bool IsPublic { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public AtwImage Image { get; set; }
        public ICollection<Chapter> Chapters { get; set; }
    }
}
