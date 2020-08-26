using AroundTheWorld.BusinessLogic.IRepositories;
using AroundTheWorld.Web.ViewModels.ChapterRelated;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AroundTheWorld.Web.Views.Chapter
{
    public class ViewPublicChapterComponent: ViewComponent
    {
        private readonly IChapterRepository _chapterRepository;

        public ViewPublicChapterComponent(IChapterRepository chapterRepository)
        {
            _chapterRepository = chapterRepository;
        }

        public IViewComponentResult Invoke(int chapterId)
        {
            var chapter = _chapterRepository.GetById(chapterId);
            var viewModel = new ChapterViewModel(chapter);
            return View("~/Views/Chapter/ViewPublicChapter.cshtml", viewModel);
        }
    }
}
