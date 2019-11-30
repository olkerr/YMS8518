using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FormApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Send([FromBody]Formapp.Data.ContactSendto contactSendto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest
            }
            return new JsonResult("ok");
        }
    }
}