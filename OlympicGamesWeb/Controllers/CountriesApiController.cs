using System.Collections.Generic;
using System.Web.Http;
using OlympicGames.DataAccess;
using OlympicGames.Domain;

namespace OlympicGamesWeb.Controllers
{
    public class CountriesApiController : ApiController
    {
        public List<Country> Get()
        {
            var countriesService = new CountryDataService();
            var countries = countriesService.GetAll();

            return countries;
        }

        public Country Get(int id)
        {
            var countriesService = new CountryDataService();
            var country = countriesService.Get(id);

            return country;
        }

        [HttpPost]
        public Country Post(Country model)
        {
            return model;
        }
    }
}
