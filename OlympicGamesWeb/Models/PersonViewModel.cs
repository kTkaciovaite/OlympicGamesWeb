using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using OlympicGames.Domain;

namespace OlympicGamesWeb.Models
{
    public class PersonViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public virtual CountryViewModel Country { get; set; }

        public static PersonViewModel MapFrom(Person person)
        {
            var model = new PersonViewModel
            {
                Name = person.Name,
                Surname = person.Surname,
                Gender = person.Gender,
                Country = CountryViewModel.MapFrom(person.Country)
            };

            return model;
        }
    }
}