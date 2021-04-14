using Microsoft.AspNetCore.Http;
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
        public int Id { get; set; }
        public string Result { get; set; }
        [Display(Name="Liczba")]
        [Range(1, 1000, ErrorMessage = "Podaj liczbę mieszczącą się w podanym zakresie"), Required(ErrorMessage = "Pole obowiązkowe")]
        public int Number { get; set; }
        public DateTime Date { get; set; }

        public void DoResult() {
            Result = "";
            if (Number % 3 == 0)
            {
                Result += "Fizz";
            }
            if (Number % 5 == 0)
            {
                Result += "Buzz";
            }
            else Result = "Liczba " + Number + " nie spełnia kryteriów Fizz/Buzz";
        }
    }
}
