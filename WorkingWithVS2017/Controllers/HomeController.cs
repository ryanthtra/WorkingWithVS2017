using Microsoft.AspNetCore.Mvc;
using WorkingWithVS2017.Models;
using System.Linq;

namespace WorkingWithVS2017.Controllers
{


  public class HomeController : Controller
  {
    public IRepository Repository = SimpleRepository.SharedRepository;

    public IActionResult Index()
      => View(Repository.Products);

    [HttpGet]
    public IActionResult AddProduct() => View(new Product());

    [HttpPost]
    public IActionResult AddProduct(Product p)
    {
      Repository.AddProduct(p);
      return RedirectToAction("Index");
    }
  }
}
