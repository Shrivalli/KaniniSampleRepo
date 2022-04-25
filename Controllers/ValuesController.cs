using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        //get method added
        public ActionResult<string> GetValue()
        {
            return Ok("First");
        }

        [HttpPost]
        public ActionResult SaveValue(string name)
        {
            return Ok("Saved");
        }
    }
}
