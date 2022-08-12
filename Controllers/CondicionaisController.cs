using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Exercicios.Controllers
{
    public class CondicionaisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    [HttpGet]
	public IActionResult CondicionalIf()
	{
		return View();
	}

	[HttpGet]
	public IActionResult CondicionalSwitch()
	{
		return View();
	}
    
    }
    
}