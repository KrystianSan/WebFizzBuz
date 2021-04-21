using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebFizzBuzz.Data;
using WebFizzBuzz.Form;

namespace WebFizzBuzz.Pages
{
    public class Index2Model : PageModel
    {
        private readonly ILogger<Index2Model> _logger;
        private readonly Numbers _context;

        public IList<Address> Numbers { get; set; }
        public Index2Model(ILogger<Index2Model> logger, Numbers context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            Numbers = _context.Address.OrderByDescending(p => p.Id).Take(10).ToList();
        }
    }
}
