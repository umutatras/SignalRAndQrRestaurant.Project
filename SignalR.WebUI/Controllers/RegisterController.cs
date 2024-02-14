using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignalR.EntityLayer.Entities;
using SignalR.WebUI.Dtos;

namespace SignalR.WebUI.Controllers;

public class RegisterController : Controller
{
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;

    public RegisterController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Index(RegisterDto dto)
    {
        var appUseR = new AppUser()
        {
            Name = dto.Name,
            Surname=dto.Surname,
            Email=dto.Mail,
            UserName=dto.Username,

        };
        var result=await _userManager.CreateAsync(appUseR,dto.Password);
        if(result.Succeeded)
        {
            return RedirectToAction("Index","Login");
        }
        return View(dto);
    }
}
