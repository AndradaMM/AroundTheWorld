using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AroundTheWorld.BusinessLogic.Entities;
using AroundTheWorld.BusinessLogic.IRepositories;
using AroundTheWorld.Web.ViewModels.ChapterRelated;
using AroundTheWorld.Web.ViewModels.DiaryRelated;
using Microsoft.AspNetCore.Mvc;

namespace AroundTheWorld.Web.Controllers
{
    public class DiaryController : Controller
    {
        private readonly IDiaryRepository _diaryRepository;
        private readonly IChapterRepository _chapterRepository;

        public DiaryController(IDiaryRepository diaryRepository, IChapterRepository chapterRepository)
        {
            _diaryRepository = diaryRepository;
            _chapterRepository = chapterRepository;
        }

        public IActionResult StartANewDiary()
        {
            return View();
        }

        [HttpPost]
        public IActionResult StartANewDiary(NewDiaryViewModel model)
        {
            var isDateValid = DateTime.TryParse(model.Date, out var parsedDate);
            if (!isDateValid)
            {
                ModelState.AddModelError(nameof(NewDiaryViewModel.Date), "Invalid date");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userId = Guid.Parse(User.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier").Value);
            var diary = new Diary
            {
                Name = model.Name,
                Date = parsedDate,
                Location = model.Location,
                UserId = userId
            };

            _diaryRepository.Add(diary);
            _diaryRepository.SaveChanges();

            return RedirectToAction("EditDiary");
        }

        public IActionResult PublicDiaries()
        {
            var diaries = _diaryRepository.GetAllPulbic();
            var diariesViewModels = new List<DiaryListItemViewModel>();

            foreach (var diary in diaries.OrderByDescending(d => d.Date))
            {
                var diaryListItem = new DiaryListItemViewModel(diary);
                diariesViewModels.Add(diaryListItem);
            }

            return View(diariesViewModels);
        }

        public IActionResult EditDiary(int id)
        {
            var diary = _diaryRepository.GetById(id);
            foreach (var chapter in diary.Chapters)
            {
                if (chapter.Content.Length > 80)
                {
                    chapter.Content = chapter.Content.Substring(0, 80) + "...";
                }
            }
            var editDiaryWithChapters = new EditDiaryWithChapters(diary);
            return View(editDiaryWithChapters);
        }

        [HttpPost]
        public IActionResult SaveDiary(EditDiaryWithChapters model)
        {
            if (!DateTime.TryParse(model.DiaryFields.Date, out var date))
            {
                ModelState.AddModelError("Date", "Date is invalid");
            }
            if (!ModelState.IsValid)
            {
                model.Chapters = new List<ChapterViewModel>();
                var chapters = _chapterRepository.GetAllByDiaryId(model.DiaryFields.Id);

                foreach (var chapter in chapters)
                {
                    model.Chapters.Add(new ChapterViewModel(chapter));
                }

                return View("~/Views/Diary/EditDiary.cshtml", model);
            }
            var diary = _diaryRepository.GetById(model.DiaryFields.Id);

            diary.Name = model.DiaryFields.Name;
            diary.Location = model.DiaryFields.Location;
            diary.Date = date;
            if (model.DiaryFields.Image != null)
            {
                using var stream = model.DiaryFields.Image.OpenReadStream();
                var imageBytes = new byte[stream.Length];
                stream.Read(imageBytes);
                if (diary.Image != null)
                {
                    diary.Image.Content = imageBytes;
                }
                else
                {
                    diary.Image = new AtwImage()
                    {
                        Content = imageBytes
                    };
                }
            }

            _diaryRepository.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        [HttpDelete]
        public IActionResult DeleteDiary(int id)
        {
            var diary = _diaryRepository.GetById(id);
            _diaryRepository.Remove(diary);
            _diaryRepository.SaveChanges();
            return View();
        }

        public IActionResult ViewPublicDiary(int id)
        {
            var diary = _diaryRepository.GetById(id);

            var model = new PublicDiaryWithChapters(diary);

            return View(model);
        }
    }
}