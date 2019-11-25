using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace API_Montadora.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Title = "API Montadora";

			return View();
		}

		[HttpGet]
		public JsonResult ListarCarros()
		{
			
			return Json("Salada");
		}
	}
}
