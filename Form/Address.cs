using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebFizzBuzz.Pages;

namespace WebFizzBuzz.Form
{
    public class Address
    {
        [Display(Name="Liczba")]
        [Range(1, 1000, ErrorMessage = "Podaj liczbę mieszczącą się w podanym zakresie"), Required(ErrorMessage = "Pole obowiązkowe")]
        public int Number { get; set; }
        public DateTime Date = DateTime.Now;
    }
}
