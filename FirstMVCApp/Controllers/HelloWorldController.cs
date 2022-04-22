using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers;

public class HelloWorldController : Controller
{
    // GET
    public IActionResult Index()
    {
        DogViewModel doggo = new DogViewModel() {Name = "Shif", Age = 2};
        return View(doggo);
    }

    public IActionResult Create()
    {
        return View();
    }

    public string Hello()
    {
        return "Who let the dogs out?";
    }
}