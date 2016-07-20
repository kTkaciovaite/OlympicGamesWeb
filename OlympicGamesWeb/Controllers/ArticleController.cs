using System;
using System.Web.Mvc;
using OlympicGames.DataAccess;
using OlympicGames.Domain;
using OlympicGamesWeb.Models;
using OlympicGamesWeb.Filters;

namespace OlympicGamesWeb.Controllers
{
    [LoggingFilter]
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            var news = new ArticleDataService();
            var newsList = news.GetAll();
            
            return View(newsList);
        }

        public ActionResult CreateNewArticle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateNewArticle(ArticleViewModel newArticle)
        {
            if (ModelState.IsValid)
            {
                var articleService = new ArticleDataService();
                var article = new Article
                {
                    Text = newArticle.Text,
                    Id = newArticle.Id,
                    ArticleName = newArticle.ArticleName,
                    Created = DateTime.Now
                };
                articleService.Add(article);

                return RedirectToAction("Index");
            }

            return View(newArticle);
        }

        public ActionResult ReadMore(int id)
        {
            var articleService = new ArticleDataService();
            
            return View(articleService.Get(id));
        }

        public ActionResult Edit(int id)
        {
            var articleService = new ArticleDataService();
            var article = articleService.Get(id);
            var model = ArticleViewModel.MapFrom(article);

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(ArticleViewModel updatedArticle)
        {
            if (ModelState.IsValid)
            {
                var articleService = new ArticleDataService();
                var article = new Article
                {
                    Id = updatedArticle.Id,
                    ArticleName = updatedArticle.ArticleName,
                    Text = updatedArticle.Text,
                    Created = DateTime.Now
                };

                articleService.Update(article);

                return RedirectToAction("Index");
            }

            return View(updatedArticle);
        }
    }
}