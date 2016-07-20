using System.ComponentModel.DataAnnotations;
using OlympicGames.Domain;

namespace OlympicGamesWeb.Models
{
    public class CountryViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string CountryCode { get; set; }

        public static CountryViewModel MapFrom(Country country)
        {
            var model = new CountryViewModel
            {
                Id = country.Id,
                Name = country.Name,
                CountryCode = country.CountryCode
            };

            return model;
        }
    }
}