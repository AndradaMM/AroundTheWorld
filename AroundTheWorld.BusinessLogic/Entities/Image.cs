using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace AroundTheWorld.BusinessLogic.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public byte[] Content { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public ICollection<Chapter> Chapters { get; set; }
        public ICollection<Diary> Diaries { get; set; }

    }
}
