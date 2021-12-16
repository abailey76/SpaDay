using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/User/Add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/User/Add")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if(newUser.Password == verify)
            {
                ViewBag.user = newUser;
                return View("Index");
            }
            else
            {
                ViewBag.userName = newUser.UserName;
                ViewBag.Email = newUser.Email;
                ViewBag.error = "Your passwords should match!";
                return View("Add");
            }
            
        }


    }
}
