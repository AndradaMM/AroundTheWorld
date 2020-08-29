using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AroundTheWorld.BusinessLogic.Entities;
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

        public IActionResult EditChapter(int id)
        {
            var chapter = _chapterRepository.GetById(id);
            var viewModel = new EditChapterViewModel()
            {
                Content = chapter.Content,
                Title = chapter.Name,
                Location = chapter.Location,
                Date = chapter.Date.ToShortDateString(),
                IsPublic = chapter.IsPublic,
                Id = chapter.Id

            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult SaveChapter(EditChapterViewModel viewModel)
        {
            if (!DateTime.TryParse(viewModel.Date, out var date))
            {
                ModelState.AddModelError("Date", "Date is invalid");
            }
            if (!ModelState.IsValid)
            {
                return View("EditChapter", viewModel);
            }
            var chapter = _chapterRepository.GetById(viewModel.Id);
            chapter.Name = viewModel.Title;
            chapter.Location = viewModel.Location;
            chapter.Date = date;
            chapter.IsPublic = viewModel.IsPublic;
            chapter.Content = viewModel.Content;
            if (viewModel.Image != null)
            {
                using var stream = viewModel.Image.OpenReadStream();
                var imageBytes = new byte[stream.Length];
                stream.Read(imageBytes);
                if (chapter.Image != null)
                {
                    chapter.Image.Content = imageBytes;
                }
                else
                {
                    chapter.Image = new AtwImage()
                    {
                        Content = imageBytes
                    };
                }
            }
            _chapterRepository.SaveChanges();
            return RedirectToAction("EditDiary", "Diary", new { id = chapter.DiaryId });
        }

        [HttpDelete]
        public IActionResult DeleteChapter(int id)
        {
            var chapter = _chapterRepository.GetById(id);
            _chapterRepository.Remove(chapter);
            _chapterRepository.SaveChanges();
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