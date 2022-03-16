using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    public class BlogController : Controller
    {
        //Step-2
        [Route("Blog")]
        [Route("Blog/Index")]
        [Route("Blog/Index/{id?}")]     
        public IActionResult AnyActionName(int id)
        {
            return Ok("Index called");
        }

        public IActionResult Article()
        {
            return Ok("Action of Blog controller is called");
        }
    }
}
