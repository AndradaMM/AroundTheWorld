using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AroundTheWorld.Web.ViewModels.ChapterRelated
{
    public class EditChapterViewModel
    {
        public Nullable<int> Id { get; set; }
        public int DiaryId { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Location { get; set; }
        public IFormFile Image { get; set; }
        [Required]
        public string Date { get; set; }
        public bool IsPublic { get; set; }
        
    }
}
