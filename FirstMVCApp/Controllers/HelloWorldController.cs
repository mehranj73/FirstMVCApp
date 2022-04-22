using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers;

public class HelloWorldController : Controller
{

    private static List<DogViewModel> dogs = new List<DogViewModel>();
    // GET
    public IActionResult Index()
    {
        
        return View(dogs);
    }

    public IActionResult Create()
    {
        var dogVm = new DogViewModel();
        return View(dogVm);
    }

    public IActionResult CreateDog(DogViewModel dogViewModel)
    {
        dogs.Add(dogViewModel);
        return RedirectToAction(nameof(Index));
        //  return View("Index");
    }

    public string Hello()
    {
        return "Who let the dogs out?";
    }
}