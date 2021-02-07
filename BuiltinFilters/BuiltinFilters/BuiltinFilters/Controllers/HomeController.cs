using BuiltinFilters.Filters;
using BuiltinFilters.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BuiltinFilters.Controllers
{
    [MyExceptionFilter]
    public class HomeController : Controller
    {
        public HomeController()
        {

        }
        [ResourceFilterExampleAttribute]
        public IActionResult Index()
        {
            return View();
        }

        [ResourceFilterAsyncAttribute]
        public IActionResult Index1()
        {
            return View("Index");
        }

        public IActionResult Index2()
        {
            return View("Index");
        }

        [Route("Home/Validatemodel")]
        [HttpPost]
        [ModelValidate]
        public IActionResult Index3([FromBody] UserMaster user)
        {
            return Ok(user);
        }

        [Route("Home/exception")]
        [MyExceptionFilter]
        public IActionResult Index4()
        {
            int i = Convert.ToInt32("");
            return View("Index");
        }


        [Route("Home/exception1")]
        [CustomExceptionFilterAttribute]
        public IActionResult Index5()
        {
            int i = Convert.ToInt32("");
            return View("Index");
        }

        [Route("Home/resultfilter")]
        [SetAuthor("Test Value")]
        public IActionResult Index6()
        {
            return View("Index");
        }

        [Authorize]
        [Route("Home/autho")]
        public IActionResult Index7()
        {
            return View("Index");
        }

        [Route("Home/login")]
        [AllowAnonymous]
        public IActionResult Index8()
        {
            
            return View("Index");
        }
    }
}
