using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AvalonV3.Models;
using AvalonV3.Repository;
using AvalonV3.Context;

namespace AvalonV3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private CharacterRepo _characterRepo;


        public HomeController(ILogger<HomeController> logger, DataContext dataContext)
        {
            _logger = logger;
            _characterRepo = new CharacterRepo(dataContext);

        }

        public IActionResult Index()
        {

            return View(_characterRepo.GetAllCharacters());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult SelectCharacters(string? id)
        {
            var character = _characterRepo.GetCharacter((string) id);
            return View(character);
        }

        [HttpPost]
        public IActionResult SelectCharacters(Character character)
        {
                _characterRepo.UpdateCharacter(character);

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
