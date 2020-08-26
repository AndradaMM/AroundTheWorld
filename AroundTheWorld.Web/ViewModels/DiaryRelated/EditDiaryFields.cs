using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AroundTheWorld.Web.ViewModels.DiaryRelated
{
    public class EditDiaryFields
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Date { get; set; }
        public byte[] Image { get; set; }
    }
}
