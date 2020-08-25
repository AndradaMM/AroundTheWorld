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
            return View();
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
            var model = new PublicDiaryWithChapters
            {
                DiaryName = "My trip to Spain",
                Chapters = new List<ChapterViewModel>()
                {
                    new ChapterViewModel()
                    {
                        Id = 1,
                        Image = new byte[0],
                        Date = new DateTime(2020, 10, 2),
                        Content = "Spain, a country on Europe’s Iberian Peninsula, includes 17 autonomous regions with diverse geography and cultures. Capital city Madrid is home to the Royal Palace and Prado museum, housing works by European masters. Segovia has a medieval castle (the Alcázar) and an intact Roman aqueduct. Catalonia’s capital, Barcelona, is defined by Antoni Gaudí’s whimsical modernist landmarks like the Sagrada Família church.",
                        Location = "Spain",
                        Name = "First day"

                    },
                
                    new ChapterViewModel()
                    {
                        Id =2,
                        Image =new byte[0],
                        Date = new DateTime(2020, 10, 5),
                        Content = "The port city of Valencia lies on Spain’s southeastern coast, where the Turia River meets the Mediterranean Sea. It’s known for its City of Arts and Sciences, with futuristic structures including a planetarium, an oceanarium and an interactive museum. Valencia also has several beaches, including some within nearby Albufera Park, a wetlands reserve with a lake and walking trails.",
                        Location = "Valencia",
                        Name="Valencia chapter"

                    },

                    new ChapterViewModel()
                    {
                        Id =3,
                        Image =new byte[0],
                        Date = new DateTime(2020, 10, 7),
                        Content = "Madrid, Spain's central capital, is a city of elegant boulevards and expansive, manicured parks such as the Buen Retiro. It’s renowned for its rich repositories of European art, including the Prado Museum’s works by Goya, Velázquez and other Spanish masters. The heart of old Hapsburg Madrid is the portico-lined Plaza Mayor, and nearby is the baroque Royal Palace and Armory, displaying historic weaponry.",
                        Location = "Madrid",
                        Name="Lovers in Madrid"

                    },
                    new ChapterViewModel()
                    {
                        Id =4,
                        Image =new byte[0],
                        Date = new DateTime(2020, 10, 7),
                        Content = "Madrid, Spain's central capital, is a city of elegant boulevards and expansive, manicured parks such as the Buen Retiro. It’s renowned for its rich repositories of European art, including the Prado Museum’s works by Goya, Velázquez and other Spanish masters. The heart of old Hapsburg Madrid is the portico-lined Plaza Mayor, and nearby is the baroque Royal Palace and Armory, displaying historic weaponry.",
                        Location = "Test 4",
                        Name="Test 4"

                    },
                    new ChapterViewModel()
                    {
                        Id =5,
                        Image =new byte[0],
                        Date = new DateTime(2020, 10, 7),
                        Content = "Madrid, Spain's central capital, is a city of elegant boulevards and expansive, manicured parks such as the Buen Retiro. It’s renowned for its rich repositories of European art, including the Prado Museum’s works by Goya, Velázquez and other Spanish masters. The heart of old Hapsburg Madrid is the portico-lined Plaza Mayor, and nearby is the baroque Royal Palace and Armory, displaying historic weaponry.",
                        Location = "Madrid",
                        Name="Test 5"

                    },
                    new ChapterViewModel()
                    {
                        Id =6,
                        Image =new byte[0],
                        Date = new DateTime(2020, 10, 7),
                        Content = "Madrid, Spain's central capital, is a city of elegant boulevards and expansive, manicured parks such as the Buen Retiro. It’s renowned for its rich repositories of European art, including the Prado Museum’s works by Goya, Velázquez and other Spanish masters. The heart of old Hapsburg Madrid is the portico-lined Plaza Mayor, and nearby is the baroque Royal Palace and Armory, displaying historic weaponry.",
                        Location = "Madrid",
                        Name="Test 6"

                    },
                    new ChapterViewModel()
                    {
                        Id =7,
                        Image =new byte[0],
                        Date = new DateTime(2020, 10, 7),
                        Content = "Madrid, Spain's central capital, is a city of elegant boulevards and expansive, manicured parks such as the Buen Retiro. It’s renowned for its rich repositories of European art, including the Prado Museum’s works by Goya, Velázquez and other Spanish masters. The heart of old Hapsburg Madrid is the portico-lined Plaza Mayor, and nearby is the baroque Royal Palace and Armory, displaying historic weaponry.",
                        Location = "Madrid",
                        Name="Test 7"

                    }
                }
            };

            return View(model);
        }
    }
}