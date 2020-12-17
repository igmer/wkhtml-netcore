using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyExampleWkhtml.Controllers
{
    public class CrearPdf : Controller
    {
        public IActionResult Index()
        {
            return new ViewAsPdf("Index");
        }
    }
}
