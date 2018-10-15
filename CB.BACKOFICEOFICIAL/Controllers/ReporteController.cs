using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CB.BACKOFICEOFICIAL.Clases;
using CB.ENTIDADES;
using CB.LOGICA;

namespace CB.BACKOFICEOFICIAL.Controllers
{
	public class ReporteController : Controller
	{

		// GET: Reporte
		public ActionResult Index()
		{
			return View();
		}

		// GET: Reporte/Details/5
		public ActionResult Details()
		{
			return View();
		}
		public ActionResult GetListaReport()
		{
			LReporte lg = new LReporte();
			List<DetalleReporte> detalles = new List<DetalleReporte>();
			detalles = lg.GetReporteOperaciones();
			return Json(detalles);
		}

		// GET: Reporte/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Reporte/Create
		[HttpPost]
		public ActionResult Create(FormCollection collection)
		{
			try
			{
				// TODO: Add insert logic here

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}
		/// <summary>
		/// alertas que se muestran el dia, por defecto 
		/// </summary>
		/// <returns></returns>
		public ActionResult Alertas()
		{
			List<Alertas> list = new List<Alertas>();
			LPersonaCasas pl = new LPersonaCasas();
			DateTime datetimeFrom = DateTime.Now.Date;
			DateTime datetimeTo = datetimeFrom.AddDays(1);
			list = pl.GetAlertas(datetimeFrom, datetimeTo);
			//return Json(list);
			ViewBag.Alert = list;
			return View();
		}

		public ActionResult GetAlertas()
		{
			List<Alertas> list = new List<Alertas>();
			LPersonaCasas pl = new LPersonaCasas();
			DateTime datetimeFrom = DateTime.Now.Date;
			DateTime datetimeTo = datetimeFrom.AddDays(1);
			list = pl.GetAlertas(datetimeFrom, datetimeTo);
			//return Json(list);
			
			return PartialView("_listAletas",list);
		}
		/// <summary>
		/// cambiar de estado a alerta que se ha gnerado
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public ActionResult Change(int id = 0)
		{
			var mensaje = new List<KeyValuePair<string, string>>();
			try
			{
				LOperaciones op = new LOperaciones();
				if (!op.change(id,false))
					mensaje.Add(Util.mensaje(Util.ERROR, Util.ERRORMENSAJE));else
				{
					mensaje.Add(Util.mensaje(Util.OK, Util.OKMENSAJE));
				}
			}
			catch (Exception ex)
			{

				mensaje.Clear();
				mensaje.Add(Util.mensaje("ERROR", ex.Message));
			}
 			return Json(mensaje);
		}


		// GET: Reporte/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: Reporte/Edit/5
		[HttpPost]
		public ActionResult Edit(int id, FormCollection collection)
		{
			try
			{
				// TODO: Add update logic here

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

		// GET: Reporte/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: Reporte/Delete/5
		[HttpPost]
		public ActionResult Delete(int id, FormCollection collection)
		{
			try
			{
				// TODO: Add delete logic here

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}
	}
}
