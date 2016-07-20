using System.Linq;
using System.Web.Mvc;
using OlympicGames.DataAccess;
using OlympicGames.Domain;
using OlympicGamesWeb.Models;

namespace OlympicGamesWeb.Controllers
{
    public class SportspersonController : Controller
    {
        // GET: Sportsperson
        public ActionResult Index()
        {
            var sportspersons = new SportspersonDataService();
            var sportspersonsList = sportspersons.GetAll();

            return View(sportspersonsList);
        }

        public ActionResult AddSportsperson()
        {
            var countryService = new CountryDataService();
            var countryList = countryService.GetAll();
            var countryNameList = countryList.Select(t => t.Name).ToList();
            ViewBag.Country = countryNameList;

            return View();
        }

        [HttpPost]
        public ActionResult AddSportsperson(SportspersonViewModel newSportsperson)
        {
            if (ModelState.IsValid)
            {
                var sportspersonService = new SportspersonDataService();
                var sportsperson = new Sportsperson
                {
                    Id = newSportsperson.Id,
                    Name = newSportsperson.Person.Name,
                    Surname = newSportsperson.Person.Name,
                    Height = newSportsperson.Height,
                    Weight = newSportsperson.Weight,
                    Gender = newSportsperson.Person.Gender,
                    Country = new Country
                    {
                        Name = newSportsperson.Person.Country.Name
                    }
                };
                sportspersonService.Add(sportsperson);

                return RedirectToAction("Index");
            }

            return View(newSportsperson);
        }

        public ActionResult Details(int id)
        {
            var sportspersonService = new SportspersonDataService();
            var model = sportspersonService.Get(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var sportspersonService = new SportspersonDataService();
            var sportsperson = sportspersonService.Get(id);
            var model = SportspersonViewModel.MapFrom(sportsperson);

            var countryService = new CountryDataService();
            var countryList = countryService.GetAll();
            var countryNameList = countryList.Select(t => t.Name).ToList();
            ViewBag.Country = countryNameList;

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(SportspersonViewModel updatedSportsperson)
        {
            if (ModelState.IsValid)
            {
                var sportspersonService = new SportspersonDataService();
                var sportsperson = new Sportsperson
                {
                    Id = updatedSportsperson.Id,
                    Name = updatedSportsperson.Person.Name,
                    Surname = updatedSportsperson.Person.Name,
                    Height = updatedSportsperson.Height,
                    Weight = updatedSportsperson.Weight,
                    Gender = updatedSportsperson.Person.Gender,
                    Country = new Country
                    {
                        Name = updatedSportsperson.Person.Country.Name
                    }
                };
                sportspersonService.Update(sportsperson);

                return RedirectToAction("Index");
            }

            return View(updatedSportsperson);
        }
    }
}