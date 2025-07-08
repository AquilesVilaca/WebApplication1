using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication1.Contexto;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IActionResult Index()
        {
            var drinkItemViewModel = new DrinkItemViewModel();
            drinkItemViewModel.drinksPreparoEImagem = _context.DrinksPreparoEImagem;
            //drinkItemViewModel.ingredientes = _context.Ingredientes;
            drinkItemViewModel.ItensDrink = _context.ItensDrink;
            return View(drinkItemViewModel);
        }
        [HttpGet]
        public IActionResult Drink(int IdDrink)
        {
            var drinkItemViewModel = new DrinkItemViewModel();
            var drinkBuscado = new DrinkPreparoEImagem();
            drinkItemViewModel.ItensDrink = _context.ItensDrink.Include(c => c.DrinkPreparoEImagem);
            drinkItemViewModel.drinksPreparoEImagem = _context.DrinksPreparoEImagem.Include(c=> c.ItensDrink);
            //drinkItemViewModel.ingredientes = _context.Ingredientes;
            //var drinkBuscado1 = new List<ItemDrink>();
            //drinkBuscado1.AddRange(drinkItemViewModel.ItensDrink.Where(p => p.DrinkPreparoEImagem.Id == IdDrink));


            drinkBuscado = drinkItemViewModel.drinksPreparoEImagem.FirstOrDefault(p => p.Id == IdDrink);
            //ViewBag.IdDrink = IdDrink;
            return View(drinkBuscado);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}