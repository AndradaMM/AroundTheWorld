using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AroundTheWorld.Web.Models;
using AroundTheWorld.BusinessLogic.IRepositories;
using AroundTheWorld.Web.ViewModels.DiaryRelated;

namespace AroundTheWorld.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDiaryRepository _diaryRepository;

        public HomeController(IDiaryRepository diaryRepository)
        {
            _diaryRepository = diaryRepository;
        }

        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {

                return View("HomePage");
            }

            var userId = Guid.Parse(User.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")
                .Value);

            var diaries = _diaryRepository.GetAllByUserId(userId);
            var diaryViewModels = new List<DiaryListItemViewModel>();

            foreach (var diary in diaries.OrderByDescending(d => d.Date))
            {
                var diaryViewModel = new DiaryListItemViewModel(diary);
                diaryViewModels.Add(diaryViewModel);
            }

            return View(diaryViewModels);
        }

        public IActionResult HomePage()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
