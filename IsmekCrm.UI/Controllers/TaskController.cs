using IsmekCrm.Bll.Abstract;
using IsmekCrm.UI.Models;
using Microsoft.AspNetCore.Mvc;
using IsmekCrm.Entity.Concrete;


namespace IsmekCrm.UI.Controllers
{

    public class TaskController : Controller
    {

        ITaskService taskService;
        public TaskController(ITaskService _taskService)
        {
            taskService = _taskService;
        }



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var list = taskService.GetAll();


            return View(new TaskViewModel { TaskList = list });
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
