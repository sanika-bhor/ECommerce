using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ECommerceApplication.Models;
using ECommerceApplication.Services.Interfaces;
using ECommerceApplication.Services;
using ECommerceApplication.Repository.Interfaces;

namespace ECommerceApplication.Controllers;

public class AuthenticationController : Controller
{
    private readonly ILogger<AuthenticationController> _logger;

    IAuthenticationService _AuthSrv;

    public AuthenticationController(ILogger<AuthenticationController> logger, IAuthenticationService authsrv)
    {
        _logger = logger;
        _AuthSrv = authsrv;
    }

    public IActionResult Index()
    {
        List<Customer> customers = _AuthSrv.getAllCustomers();
        ViewData["allCustomers"] = customers;
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string email, string password)
    {
        Customer customer = _AuthSrv.getCustomerByEmail(email);

        if (customer != null && password == "sanika123" && email == "sanika0239@gmail.com")
        {
            return RedirectToAction("index", "Authentication");
        }
        else if (customer != null && password == customer.Password)
        {
            return RedirectToAction("index", "Home");
        }
        else
        {
            return View("Error");
        }

    }

    // public IActionResult Update(int id)
    // {
    //     Item item = _cartsrv.getItemById(id);
    //     return View(item);
    // }

    // [HttpPost]
    // public IActionResult Update(int id, string title, string img, int unitprice, int quantity)
    // {
    //     Product product = new Product
    //     {
    //         ProductId = id,
    //         ProductTitle = title,
    //         ProductImage = img,
    //         UnitPrice = unitprice
    //     };
    //     Item item = new Item(product, quantity);
    //     bool status = _cartsrv.updateItem(item);
    //     if (status)
    //     {
    //         return RedirectToAction("index", "Catelog");
    //     }
    //     else
    //     {
    //         return RedirectToAction("update", "ShoppingCart");
    //     }
    // }

    // public IActionResult Delete(int id)
    // {
    //     bool status = _cartsrv.deleteItem(id);
    //     if (status)
    //     {
    //         return RedirectToAction("Index", "ShoppingCart");
    //     }
    //     return RedirectToAction("Index");
    // }




    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
