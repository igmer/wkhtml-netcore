using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyExampleWkhtml.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Wkhtmltopdf.NetCore;

namespace MyExampleWkhtml.Controllers
{
    public class HomeController : Controller
    {
        readonly string htmlView = @"@model MyExampleWkhtml.Models.TestData
                        <!DOCTYPE html>
                        <html>
                        <head>
                        </head>
                        <body>
                            <header>
                                <h1>@Model.Text</h1>
                            </header>
                            <div>
                                <h2>@Model.Number</h2>
                            </div>
                        </body>
                        </html>";


        readonly string formHtml = "<!DOCTYPE html>" +
                                    "<html>" +
                                    "<body>" +
                                    "<h2>HTML Forms</h2>" +
                                    "<form>" +
                                    "  <label for=\"fname\">First name:</label><br>" +
                                    "  <input type =\"text\" id=\"fname\" name=\"fname\"><br>" +
                                    "  <label for=\"lname\">Last name:</label><br>" +
                                    "  <input type =\"text\" id=\"lname\" name=\"lname\"><br><br>" +
                                    "</form> " +
                                    "</body>" +
                                    "</html>";


        public HomeController()
        {
        }

        

        public async Task<IActionResult> Index()
        {
            return View();
            //return await _generatePdf.GetPdf("Views/Home/Index.cshtml", "Hello World");
            //var data = new TestData
            //{
            //    Text = "This is not a test",
            //    Number = 12345678
            //};


            //var pdf = await _generatePdf.GetByteArrayViewInHtml(htmlView, data);
            //var pdfStream = new System.IO.MemoryStream();
            //pdfStream.Write(pdf, 0, pdf.Length);
            //pdfStream.Position = 0;
            //return new FileStreamResult(pdfStream, "application/pdf");
            //var data = new TestData
            //{
            //    Text = "This is not a test",
            //    Number = 12345678
            //};

            //return await _generatePdf.GetPdf("Views/Home/Index.cshtml", "Hello World");
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
    }
}
