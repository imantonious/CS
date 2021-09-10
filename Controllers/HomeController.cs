using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CSMVC.Models;

namespace CSMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string message = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Ad tempore incidunt similique, accusantium in nostrum obcaecati, itaque ea dolorum, ipsam est. Odio, ullam odit. Nam harum aliquid quia doloribus laborum?";
            return View("Index", message);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        [Route("user")]
        public new IActionResult User()
        {
            User user = new User()
            {
                FirstName = "Steve",
                LastName = "Wozniak"
            };
            return View(user);
        }

        [HttpGet]
        [Route("users")]
        public IActionResult Users()
        {
            List<User> users = new List<User> ()
            {
                new User() { FirstName = "Antonio", LastName =  "Toriz" },
                new User() { FirstName = "Stephanie", LastName = "Toriz" },
                new User() { FirstName = "Ezra", LastName = "Toriz" }
            };
            return View(users);
        }

        [HttpGet]
        [Route("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = new int[] { 1, 3, 4, 2, 4, 6, 64, 545, 45 };
            return View(numbers);
        }

        [HttpGet]
        [Route("survey")]
        public IActionResult Survey()
        {
            return View();
        }

        [HttpPost]
        [Route("result")]
        public IActionResult Result(Survey yourSurvey)
        {
            if (ModelState.IsValid)
            {
                return View("Result", yourSurvey);
            }
            else
            {
                return View("Survey");
            }
        }

        [HttpGet]
        [Route("user/create")]
        public IActionResult NewUser()
        {
            return View();
        }

        [HttpPost]
        [Route("user/create")]
        public IActionResult Create(User newUser)
        {
            if (ModelState.IsValid)
            {
                // do something like add to db //! to come
                return RedirectToAction("Welcome");
            }
            else
            {
                return View("NewUser");
            }
        }

        [HttpGet]
        [Route("welcome")]
        public IActionResult Welcome()
        {
            return View();
        }

    }
}
