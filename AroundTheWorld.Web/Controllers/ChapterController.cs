using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AroundTheWorld.BusinessLogic.IRepositories;
using AroundTheWorld.Web.ViewModels.ChapterRelated;
using Microsoft.AspNetCore.Mvc;

namespace AroundTheWorld.Web.Controllers
{
    public class ChapterController : Controller
    {
        private readonly IChapterRepository _chapterRepository;

        public ChapterController(IChapterRepository chapterRepository)
        {
            _chapterRepository = chapterRepository;
        }

        public IActionResult EditChapter()
        {
            return View();
        }

        public IActionResult DeleteChapter()
        {
            return View();
        }

        public IActionResult ViewPublicChapter(int id)
        {
            var chapter = _chapterRepository.GetById(id);
            var viewModel = new ChapterViewModel(chapter);
            return PartialView(viewModel);
        }
    }
}