using Microsoft.AspNetCore.Mvc;
using Shop.Models;

namespace Shop.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult GetMessage()
        {
            return PartialView("_GetMessage");
        }
        public IActionResult Index()
        {
            ViewData["Message"] = "Я-сообщение";
            ViewData["Apple"] = 1;
            ViewBag.Message = "Hello";
            MyTest obj =new MyTest();
            obj.Id = 1;
            obj.Name = "MyName";
            string myView = "Test";
            /*var obj = new { id = 1 };*/
            return View("~/Views/Sample/Index.cshtml",obj);
            /*return View(myView,obj); 
            return View(obj);*/
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
