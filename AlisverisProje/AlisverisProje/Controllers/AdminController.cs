using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AlisverisProje.Models; // Kullandığınız namespace'e göre düzenleyin
using AlisverisProje.Areas.Identity.Data;

public class AdminController : Controller
{
    private readonly UserManager<AlisverisProjeUser> _userManager;

    public AdminController(UserManager<AlisverisProjeUser> userManager)
    {
        _userManager = userManager;
    }

    public IActionResult Index()
    {
        // Admin paneli ana sayfası
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> AddUserToAdminRole(string userName)
    {
        var user = await _userManager.FindByNameAsync(userName);
        if (user != null)
        {
            var result = await _userManager.AddToRoleAsync(user, "Admin");
            if (result.Succeeded)
            {
                TempData["SuccessMessage"] = "Kullanıcı başarıyla Admin rolüne eklendi.";
            }
            else
            {
                TempData["ErrorMessage"] = "Admin rolüne kullanıcı eklenirken bir hata oluştu.";
            }
        }
        else
        {
            TempData["ErrorMessage"] = "Kullanıcı bulunamadı.";
        }

        return RedirectToAction("Index");
    }
}
