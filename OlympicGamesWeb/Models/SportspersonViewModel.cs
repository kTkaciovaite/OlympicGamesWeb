using System.ComponentModel.DataAnnotations;
using OlympicGames.Domain;

namespace OlympicGamesWeb.Models
{
    public class SportspersonViewModel
    {
        public int Id { get; set; }

        [Required]
        public double Height { get; set; }
        
        [Required]
        public double Weight { get; set; }
        
        [Required]
        public PersonViewModel Person { get; set; }

        public static SportspersonViewModel MapFrom(Sportsperson sportsperson)
        {
            var model = new SportspersonViewModel
            {
                Id = sportsperson.Id,
                Height = sportsperson.Height,
                Weight = sportsperson.Weight,
                Person = PersonViewModel.MapFrom(sportsperson)
            };

            return model;
        }
    }
}