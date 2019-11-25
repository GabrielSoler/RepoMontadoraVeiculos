using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace API.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public JsonResult ListarCarro(int idCarro = 1)
		{
			using (montadoraEntities2 db = new montadoraEntities2())
			{
				var carro = db.tbl_carros
										.Select(x => new
										{
											x.id,
											x.unidadesestoque,
											modelo = (x.tbl_trim.descricao != "m3") ? x.tbl_series.serienum + x.tbl_trim.descricao : x.tbl_trim.descricao,
											x.tbl_motor.deslocamento,
											x.tbl_motor.maxpotencia,
											x.tbl_motor.maxtorque,
											x.tbl_cambio.modo,
											x.tbl_series.chassis,
											x.preco,
											x.Cor
										})
										.Where(x => x.id == idCarro)
										.FirstOrDefault();

				return Json(carro, JsonRequestBehavior.AllowGet);
			}
		}

		[HttpGet]
		public JsonResult ListarCarros()
		{
			using (montadoraEntities2 db = new montadoraEntities2())
			{
				var carros = db.tbl_carros.Select(x => new
				{
					x.id,
					x.unidadesestoque,
					modelo = (x.tbl_trim.descricao != "m3")? x.tbl_series.serienum + x.tbl_trim.descricao : x.tbl_trim.descricao,
					x.tbl_motor.deslocamento,
					x.tbl_motor.maxpotencia,
					x.tbl_motor.maxtorque,
					x.tbl_cambio.modo,
					x.tbl_series.chassis,
					x.preco,
					x.Cor
				}).ToList();
				return Json(carros, JsonRequestBehavior.AllowGet);
			}
		}

		[HttpGet]
		public JsonResult InserirPedido(short idCarro = 0, string dtEntrega = null)
		{
			DateTime dtEntrega2 = (dtEntrega == null)?dtEntrega2 = DateTime.Now: DateTime.Parse(dtEntrega);
			pedido pedido = new pedido
			{
				id_carro = idCarro,
				databertura = DateTime.Now,
				dataentrega = dtEntrega2,	
			};
			montadoraEntities2 db = new montadoraEntities2();
			db.pedido.Add(pedido);
			db.SaveChanges();

			return Json("Salvo com sucesso",JsonRequestBehavior.AllowGet);
		}

		[HttpGet]
		public JsonResult ListarPedido(int idPedido = 1)
		{
			if (idPedido == 0)
				return Json("idPedido igual a 0", JsonRequestBehavior.AllowGet);

			montadoraEntities2 db = new montadoraEntities2();
			Pedido objPedido = db.pedido
					.Where(x => x.id == idPedido)
					.Select(x => new Pedido
					{
						IDPedido = x.id,
						IDCarro = x.id_carro,
						DTAbertura = x.databertura.ToString(),
						DTEntrega = x.dataentrega.ToString()
					})
					.SingleOrDefault();

			return Json(objPedido, JsonRequestBehavior.AllowGet);
		}
		private class Pedido
		{
			public byte IDPedido { get; set; }
			public short IDCarro { get; set; }
			public string DTAbertura { get; set; }
			public string DTEntrega { get; set; }
		}
	}
}