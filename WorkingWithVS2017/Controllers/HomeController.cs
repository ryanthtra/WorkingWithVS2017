using Microsoft.AspNetCore.Mvc;
using WorkingWithVS2017.Models;
using System.Linq;

namespace WorkingWithVS2017.Controllers
{


  public class HomeController : Controller
  {
    public IActionResult Index()
      => View(SimpleRepository.SharedRepository.Products
              .Where(p => p.Price < 50));
  }
}
