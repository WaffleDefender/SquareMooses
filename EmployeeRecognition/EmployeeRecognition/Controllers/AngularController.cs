using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeRecognition.Controllers
{
    public class AngularController : Controller
    {
        public IActionResult Main()
        {
            return PartialView();
        }
    }
}