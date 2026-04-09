using Microsoft.AspNetCore.Mvc;
using COMP003B.Assignment3.Models;

namespace COMP003B.Assignment3.Controllers
{
    [Route("event")]
    public class EventController : Controller
    {

        [HttpGet("register/{eventCode}")]

        public IActionResult ViewEvent(string eventCode)
        {
            var model = new EventRegistration { EventCode = eventCode };
            return View(model);
        }



        [HttpGet("register")]
        public IActionResult Register()
        {
            return View(new EventRegistration());
        }

        [HttpPost("register")]
        public IActionResult Register(EventRegistration model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return RedirectToAction("Success", model);

        }

        [HttpGet("success")]
        public IActionResult Success(EventRegistration model)
        {
            return View(model);
        }
            
     
    }
}
