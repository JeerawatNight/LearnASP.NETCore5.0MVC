using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    [Route("Admin/[controller]")]
    public class ContactController : Controller
    {
        [Route("Main")]
        public IActionResult Index()
        {
            return Ok("Action main called");
        }

        [Route("Details/{id?}")]
        public IActionResult SomeActionName(int? id)
        {
            if (id == null)
                return Ok("Action Details called");
            else
                return Ok("Action Details called with id : " + id);
        }
    }
}
