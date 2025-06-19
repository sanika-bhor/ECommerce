using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ECommerceApplication.Models;
using ECommerceApplication.Services.Interfaces;
using ECommerceApplication.Services;
using ECommerceApplication.Repository.Interfaces;

namespace ECommerceApplication.Controllers;

public class CategoryController : Controller
{
    private readonly ILogger<CategoryController> _logger;
    ICategoryService _categorysrv;
    IProductService _productsrv;

    public CategoryController(ILogger<CategoryController> logger, ICategoryService categorysrv, IProductService productService)
    {
        _logger = logger;
        _categorysrv = categorysrv;
        _productsrv = productService;
    }

    // public IActionResult AllProductData()
    // {
    //     List<Categories> categories = _srv.getAllCategories();
    //     ViewData["allProducts"] = categories;
    //     return View();
    // }

    public IActionResult Index()
    {
        Categories categories = _categorysrv.getCategoryByName("flowers");
        List<Product> products = _productsrv.getProductByCategoryId(categories.CategoryId);
        ViewData["flowerProducts"] = products;
        return View();
    }

    // public IActionResult DetailsWithId(int id)
    // {
    //     Product product = _srv.getProductById(id);
    //     ViewData["productById"] = product;
    //     return View();
    // }

    // public IActionResult DetailsWithTitle(string title)
    // {
    //     Product product = _srv.getProductByTitle(title);
    //     ViewData["productByTitle"] = product;
    //     return View();
    // }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
