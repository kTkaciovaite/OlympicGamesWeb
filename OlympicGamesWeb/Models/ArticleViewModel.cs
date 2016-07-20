using System;
using System.ComponentModel.DataAnnotations;
using OlympicGames.Domain;

namespace OlympicGamesWeb.Models
{
    public class ArticleViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string ArticleName { get; set; }

        [Required]
        [MinLength(100)]
        public string Text { get; set; }

        public DateTime Created { get; set; }

        public static ArticleViewModel MapFrom(Article article)
        {
            var model = new ArticleViewModel
            {
                Id = article.Id,
                ArticleName = article.ArticleName,
                Text = article.Text,
                Created = article.Created
            };

            return model;
        }
    }
}