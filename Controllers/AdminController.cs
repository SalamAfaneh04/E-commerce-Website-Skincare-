using E_commerce_Website__Skincare_.Data;
using E_commerce_Website__Skincare_.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_commerce_Website__Skincare_.Controllers
{
    //[Authorize(Roles = "Admin")]

    public class AdminController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;

        public AdminController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        // USERS PAGE
        public async Task<IActionResult> UsersInfo()
        {
            var users = await _userManager.Users.ToListAsync();

            return View(users);
        }
    }
}
