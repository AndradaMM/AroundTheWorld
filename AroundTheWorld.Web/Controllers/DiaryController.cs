using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AroundTheWorld.BusinessLogic.Entities;
using AroundTheWorld.BusinessLogic.IRepositories;
using AroundTheWorld.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AroundTheWorld.Web.Controllers
{
    public class DiaryController : Controller
    {
        private readonly IDiaryRepository _diaryRepository;
        private readonly IAtwImageRepository _atwImageRepository;

        public DiaryController(IDiaryRepository diaryRepository, IAtwImageRepository atwImageRepository)
        {
            _diaryRepository = diaryRepository;
            _atwImageRepository = atwImageRepository;
        }

        public IActionResult StartANewDiary()
        {
            return View();
        }

        public IActionResult PublicDiaries()
        {
            // User.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")
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
            return View();
        }

        public IActionResult SaveDiary(Diary diary)
        {

            throw new NotImplementedException();
            if(diary.Id > 0)
            {
                
            }
        }

        public IActionResult DeleteDiary(int id)
        {
            var diary = _diaryRepository.GetById(id);
            _diaryRepository.Remove(diary);
            _diaryRepository.SaveChanges();
            return View();
        }

        public IActionResult ViewPublicDiary()
        {
            return View();
        }
    }
}