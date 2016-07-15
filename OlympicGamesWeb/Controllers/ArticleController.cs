using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OlympicGames.DataAccess;

namespace OlympicGamesWeb.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            var test = new ArticleDataService();
            var test2 = test.Get(2);

            return View(test2);
        }
    }
}