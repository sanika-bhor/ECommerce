using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ECommerceApplication.Models;
using ECommerceApplication.Services.Interfaces;
using ECommerceApplication.Services;
using ECommerceApplication.Repository.Interfaces;

namespace ECommerceApplication.Controllers;

public class ProfileController : Controller
{
    private readonly ILogger<ProfileController> _logger;

    ICustomerService _AuthSrv;

    public ProfileController(ILogger<ProfileController> logger, ICustomerService authsrv)
    {
        _logger = logger;
        _AuthSrv = authsrv;
    }

    public IActionResult Index()
    {
        string? email = HttpContext.Session.GetString("Email");
        string? role = HttpContext.Session.GetString("Role");

        if (string.IsNullOrEmpty(email))
        {
            return RedirectToAction("Login", "Authentication");
        }

        Customer? customer = _AuthSrv.getCustomerByEmail(email);

        // Admin login is currently hardcoded and may not exist in the customer table.
        // Build a safe profile model so the admin profile page can still render.
        if (string.Equals(role, "Admin", StringComparison.OrdinalIgnoreCase) && customer == null)
        {
            customer = new Customer
            {
                CustomerId = 0,
                UserName = "Admin",
                Email = email,
                Address = "N/A",
                Password = "********"
            };
        }

        if (customer == null)
        {
            return RedirectToAction("Login", "Authentication");
        }

        ViewData["CustomerProfile"] = customer;
        ViewData["Role"] = role ?? "Customer";
        return View();
    }

    // public IActionResult Login()
    // {
    //     return View();
    // }

    // [HttpPost]
    // public IActionResult Login(string email, string password)
    // {
    //     Customer customer = _AuthSrv.getCustomerByEmail(email);

    //     if (customer != null && password == "sanika123" && email == "sanika0239@gmail.com")
    //     {
    //         return RedirectToAction("index", "Authentication");
    //     }
    //     else if (customer != null && password == customer.Password)
    //     {
    //         HttpContext.Session.SetString("Email", email);
    //         HttpContext.Session.SetString("Password", password);
    //         return RedirectToAction("index", "Home");
    //     }
    //     else
    //     {
    //         return View();
    //     }
    // }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
