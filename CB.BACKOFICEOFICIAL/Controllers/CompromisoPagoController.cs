using CB.BACKOFICEOFICIAL.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CB.BACKOFICEOFICIAL.Controllers
{
	public class CompromisoPagoController : Controller
	{
		LOGICA.LCompromisoPago lg = new LOGICA.LCompromisoPago();

		// GET: CompromisoPago
		public ActionResult Index()
		{
			return View();
		}

		// GET: CompromisoPago/Details/5
		public ActionResult Details(int id)
		{
			var list = lg.ListAll();
			var obj = list.Where(x => x.compromisoPagoID == id).FirstOrDefault();
			if (obj != null)
			{
				return PartialView("_Details", obj);
			}
			return View();
		}

		// GET: CompromisoPago/Create
		public ActionResult Create()
		{
			var obj = new ENTIDADES.CompromisoPago();
			return PartialView("_Create", obj);
		}
		[HttpPost]
		public ActionResult Lists()
		{
			var list = lg.ListAll();
			return PartialView("_List", list);
		}
		// POST: CompromisoPago/Create
		[HttpPost]
		public ActionResult Create(ENTIDADES.CompromisoPago collection)
		{
			var mensajes = new List<KeyValuePair<string, string>>();
			try
			{
				// TODO: Add insert logic here
				var nun = lg.ListAll().Max(x => x.compromisoPagoID) + 1;
				collection.compromisoPagoID = nun;
				var sw = lg.add(collection);
				if (sw)
				{
					mensajes.Add(Util.mensaje(Util.OK, Util.OKMENSAJE));
				}
				else
				{
					mensajes.Add(Util.mensaje(Util.ERROR, Util.ERRORMENSAJE));
				}
				return Json(mensajes);

			}
			catch (Exception ex)
			{
				mensajes.Clear();
				mensajes.Add(Util.mensaje(Util.ERROR, ex.Message));
				return Json(mensajes);
			}
		}

		// GET: CompromisoPago/Edit/5
		public ActionResult Edit(int id)
		{
			var list = lg.ListAll();
			var obj = list.Where(x => x.compromisoPagoID == id).FirstOrDefault();
			if (obj != null)
			{
				return PartialView("_Edit", obj);
			}
			return View();

		}

		// POST: CompromisoPago/Edit/5
		[HttpPost]
		public ActionResult Edit(ENTIDADES.CompromisoPago collection)
		{
			var mensajes = new List<KeyValuePair<string, string>>();
			try
			{
				var sw = lg.update(collection);
				if (sw)
				{

					mensajes.Add(Util.mensaje(Util.OK, Util.OKMENSAJE));
				}
				else
				{
					mensajes.Add(Util.mensaje(Util.ERROR, Util.ERRORMENSAJE));
				}
				return Json(mensajes);
			}
			catch (Exception ex)
			{
				mensajes.Clear();
				mensajes.Add(Util.mensaje(Util.ERROR, ex.Message));
				return Json(mensajes);
			}
		}

		// GET: CompromisoPago/Delete/5
		[HttpPost]
		public ActionResult Delete(int id)
		{
			var mensajes = new List<KeyValuePair<string, string>>();
			try
			{
				var list = lg.ListAll();
				var obj = list.Where(x => x.compromisoPagoID == id).FirstOrDefault();
				if (obj != null)
				{
					var sw = lg.delete(obj);
					if (sw)
					{
						mensajes.Add(Util.mensaje(Util.OK, Util.OKMENSAJE));
					}
					else
					{
						mensajes.Add(Util.mensaje(Util.ERROR, Util.ERRORMENSAJE));
					}
				}
				else
					mensajes.Add(Util.mensaje(Util.ERROR, Util.ERRORMENSAJE));

				return Json(mensajes);


			}
			catch (Exception ex)
			{

				mensajes.Clear();
				mensajes.Add(Util.mensaje(Util.ERROR, ex.Message));
				return Json(mensajes);
			}

		}


	}
}
