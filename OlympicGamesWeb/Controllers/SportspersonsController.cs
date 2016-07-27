using System.Collections.Generic;
using System.Web.Http;
using OlympicGames.DataAccess;
using OlympicGames.Domain;

namespace OlympicGamesWeb.Controllers
{
    public class SportspersonsController : ApiController
    {
        public List<Sportsperson> Get()
        {
            var sportspersonsService = new SportspersonDataService();
            var sportspersons = sportspersonsService.GetAll();

            return sportspersons;
        }

        public Sportsperson Get(int id)
        {
            var sportspersonsService = new SportspersonDataService();
            var sportsperson = sportspersonsService.Get(id);

            return sportsperson;
        }

        [HttpPost]
        public Sportsperson Post(Sportsperson model)
        {
            return model;
        }
    }
}
