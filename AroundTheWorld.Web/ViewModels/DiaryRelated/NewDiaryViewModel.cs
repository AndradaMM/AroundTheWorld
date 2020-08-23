using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AroundTheWorld.Web.ViewModels.DiaryRelated
{
    public class NewDiaryViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string Location { get; set; }
    }
}
