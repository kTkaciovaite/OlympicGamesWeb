using System.Web.Mvc;
using OlympicGames.Domain;
using OlympicGames.DataAccess;
using OlympicGamesWeb.Models;

namespace OlympicGamesWeb.Controllers
{
    public class CountriesController : Controller
    {
        // GET: Countries
        public ActionResult Index()
        {
            var countries = new CountryDataService();
            var countriesList = countries.GetAll();

            return View(countriesList);
        }

        public ActionResult AddCountry()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCountry(CountryViewModel newCountry)
        {
            if (ModelState.IsValid)
            {
                var countryService = new CountryDataService();
                var country = new Country
                {
                    Id = newCountry.Id,
                    Name = newCountry.Name,
                    CountryCode = newCountry.CountryCode
                };
                countryService.Add(country);

                return RedirectToAction("Index");
            }

            return View(newCountry);
        }

        public ActionResult Details(int id)
        {
            var countriesService = new CountryDataService();

            return View(countriesService.Get(id));
        }

        public ActionResult Edit(int id)
        {
            var countriesService = new CountryDataService();
            var country = countriesService.Get(id);
            var model = CountryViewModel.MapFrom(country);

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(CountryViewModel updatedCountry)
        {
            if (ModelState.IsValid)
            {
                var countryService = new CountryDataService();
                var country = new Country
                {
                    Id = updatedCountry.Id,
                    Name = updatedCountry.Name,
                    CountryCode = updatedCountry.CountryCode
                };
                countryService.Update(country);

                return RedirectToAction("Index");
            }

            return View(updatedCountry);
        }
    }
}