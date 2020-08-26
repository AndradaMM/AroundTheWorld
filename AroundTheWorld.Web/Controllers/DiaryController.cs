using System;
using System.Collections.Generic;
using System.Linq;
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

        public DiaryController(IDiaryRepository diaryRepository)
        {
            _diaryRepository = diaryRepository;
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
            var editDiaryWithChapters = new EditDiaryWithChapters(diary);
            return View(editDiaryWithChapters);
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