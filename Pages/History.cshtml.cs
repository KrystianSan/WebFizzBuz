using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace WebFizzBuzz.Pages
{
    public class Index1Model : PageModel
    {

        public int Liczba { get; set; }
        public void OnGet()
        {
            int liczba = (int)HttpContext.Session.GetInt32("Number"); //?

            Liczba = liczba;
        }
    }
}
