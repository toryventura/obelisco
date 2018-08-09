using CB.BACKOFICEOFICIAL.Clases;
using CB.ENTIDADES;
using CB.LOGICA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CB.BACKOFICEOFICIAL.Controllers
{
	public class UsuarioController : Controller
	{
		// GET: Usuario
		public ActionResult Index()
		{
			return View();
		}

		// GET: CompromisoPago/Details/5
		public ActionResult Details(int id)
		{
			var list = LUsuario.toListaUsuario();
			var obj = list.Where(x => x.ID == id).FirstOrDefault();
			if (obj != null)
			{
				return PartialView("_Details", obj);
			}
			return View();
		}

		// GET: CompromisoPago/Create
		public ActionResult Create()
		{
			LOGICA.LFase ob = new LOGICA.LFase();
			var obj = new ENTIDADES.Usuario();
			ViewBag.IdFase = new SelectList(ob.getImtesAll(), "ID", "Descripcion");
			var perfils = LPerfil.allPerfils();
			ViewBag.IdPerfil = new SelectList(perfils, "ID", "Nombre");
			return PartialView("_Create", obj);
		}
		public ActionResult Edit(int id)
		{
			LOGICA.LFase ob = new LOGICA.LFase();
			var list = LUsuario.toListaUsuario();
			var obj = list.Where(x => x.ID == id).FirstOrDefault();
			int select = obj.IdFase == null ? 1 : obj.IdFase;
			ViewBag.IdFase = new SelectList(ob.getImtesAll(), "ID", "Descripcion", select);
			if (obj != null)
			{
				return PartialView("_Edit", obj);
			}
			return View();

		}
		[HttpPost]
		public ActionResult Lists()
		{
			var list = LUsuario.toListaUsuario();
			var litsfinal= list.Where(x => x.EsSuperAdmin == false).ToList();
			return PartialView("_List", litsfinal);
		}
		// POST: CompromisoPago/Create
		[HttpPost]
		public ActionResult Create(ENTIDADES.Usuario collection)
		{
			var mensajes = new List<KeyValuePair<string, string>>();
			try
			{
				// TODO: Add insert logic here

				collection.Habilitado = true;
				collection.Contrasena = SEGURIDAD.encriptarMD5(collection.Contrasena);
				var sw = LUsuario.add(collection, collection.IdPerfil, collection.IdFase);
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


		// POST: CompromisoPago/Edit/5
		[HttpPost]
		public ActionResult Edit(ENTIDADES.Usuario collection)
		{
			var mensajes = new List<KeyValuePair<string, string>>();
			try
			{
				var sw = LUsuario.update(collection);
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
				var list = LUsuario.toListaUsuario();
				var obj = list.Where(x => x.ID == id).FirstOrDefault();
				if (obj != null)
				{
					var sw = LUsuario.delet(obj);
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
