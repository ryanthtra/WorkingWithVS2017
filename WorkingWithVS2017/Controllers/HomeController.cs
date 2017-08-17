using Microsoft.AspNetCore.Mvc;
using WorkingWithVS2017.Models;

namespace WorkingWithVS2017.Controllers
{


  public class HomeController : Controller
  {
    public IActionResult Index()
      => View(SimpleRepository.SharedRepository.Products);
  }
}
