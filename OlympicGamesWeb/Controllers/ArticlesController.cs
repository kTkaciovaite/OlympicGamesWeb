using System.Collections.Generic;
using OlympicGames.Domain;
using System.Web.Http;
using OlympicGames.DataAccess;

namespace OlympicGamesWeb.Controllers
{
    public class ArticlesController : ApiController
    {
        public List<Article> Get()
        {
            var articlesService = new ArticleDataService();
            var articles = articlesService.GetAll();

            return articles;
        }

        public Article Get(int id)
        {
            var articlesService = new ArticleDataService();
            var article = articlesService.Get(id);

            return article;
        }

        [HttpPost]
        public Article Post(Article model)
        {
            return model;
        }
    }
}