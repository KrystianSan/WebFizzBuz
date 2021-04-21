using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebFizzBuzz.Form;
using WebFizzBuzz.Services;

namespace WebFizzBuzz.Pages
{
    public class PobraneZPlikuModel : PageModel
    {
        private readonly ILogger<PobraneZPlikuModel> _logger;
        public JsonFileProductService ProductService;
        public IEnumerable<Address> Data { get; private set; }
        public PobraneZPlikuModel(ILogger<PobraneZPlikuModel> logger, JsonFileProductService productService)
        {
            ProductService = productService;
            _logger = logger;
        }
        public void OnGet()
        {
            Data = ProductService.GetProducts();
        }
    }
}
