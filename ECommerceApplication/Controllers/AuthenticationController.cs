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
    IShoppingCartService _cartsrv;
    IProductService _productsrv;

    public AuthenticationController(ILogger<AuthenticationController> logger, IShoppingCartService cartsrv, IProductService productsrv)
    {
        _logger = logger;
        _cartsrv = cartsrv;
        _productsrv = productsrv;
    }

    public IActionResult Index()
    {
        List<Item> items = _cartsrv.getAllItem();
        ViewData["allItems"] = items;
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
