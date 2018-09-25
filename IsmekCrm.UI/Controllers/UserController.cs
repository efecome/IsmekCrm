using IsmekCrm.Bll.Abstract;
using IsmekCrm.UI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace IsmekCrm.UI.Controllers
{
    public class UserController : Controller
    {
        IUserService userService;
        public UserController(IUserService _userService)
        {
            userService = _userService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {

            var list = userService.GetAll();
            return View(new UserViewModel { ListUser = list });
           
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
