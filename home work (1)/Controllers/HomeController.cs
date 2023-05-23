using home_work__1_.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace home_work__1_.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult refarse()
        {
            return View();
        }
        [HttpPost]
        public IActionResult refarse(Name name)
        {
            string text = "";
            for (int k = name.text.Length - 1; k >= 0; k--)
            {
                text += name.text[k];
            }

            ViewBag.n = text;

            return View();
        }


        public IActionResult calc()
        {
            return View();
        }
        [HttpPost]
        public IActionResult calc(Number number)
        { int k = 0;
            switch (number.operation)

            {
                
                case '+': k=number.nOne + number.nTwo;
                    break;
                case '-':
                    k = number.nOne - number.nTwo;
                    break;
                case '*':
                    k = number.nOne *number.nTwo;
                    break;
                case '/':
                    k = number.nOne / number.nTwo;
                    break;

            }
            ViewBag.resalt = k;


            return View();
        }
    }
}