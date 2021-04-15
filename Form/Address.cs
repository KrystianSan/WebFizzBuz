using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebFizzBuzz.Pages;

namespace WebFizzBuzz.Form
{
    public class Address
    {
        public int Id { get; set; }
        [MaxLength(40)]
        [Column(TypeName = "varchar(40)")]
        public string Result { get; set; }

        [Display(Name="Liczba")]
        [Range(1, 1000, ErrorMessage = "Podaj liczbę mieszczącą się w podanym zakresie"), Required(ErrorMessage = "Pole obowiązkowe")]
        public int Number { get; set; }
        public DateTime Date { get; set; }
    }
}
