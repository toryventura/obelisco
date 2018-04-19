using CB.BACKOFICEOFICIAL.Clases;
using CB.ENTIDADES;
using CB.LOGICA;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
namespace CB.BACKOFICEOFICIAL.Controllers
{
	public class PersonasCasasController : Controller
	{
		// GET: PersonasCasas

		LPersonaCasas logica = new LPersonaCasas();
		Usuario us = Util.Usuario;

		public ActionResult Index()
		{
			return View();
		}

		public ActionResult ListsPersonas()
		{
			var _list = logica.GetClienteAll();
			return Json(_list);
		}
		public ActionResult UsuariosSistemas()
		{
			var lusu = LUsuario.toListUsuariosParaAsignar();
			return Json(lusu);
		}

		// GET: PersonasCasas/Create
		public ActionResult CreateID(string id = "")
		{
			try
			{
				LPersonaCasas lp = new LPersonaCasas();
				var per = lp.GetClienteXID(id);
				var usu = new Usuario()
				{
					Nombre = per.NombreP,
					Apellido1 = per.Apellido,
					Apellido2 = per.Seg_Apellido,
					Email = per.Correo,
					ID = Convert.ToInt64(per.CodCliente)
				};
				return PartialView("_Create", usu);
			}
			catch (System.Exception)
			{
				return Json("");
				throw;
			}

		}

		// POST: PersonasCasas/Create
		[HttpPost]
		public ActionResult Create(Usuario collection)
		{
			var mensajes = new List<KeyValuePair<string, string>>();
			try
			{

				collection.Habilitado = true;
				collection.CambiarContrasena = false;
				collection.EsSuperAdmin = true;
				if (LUsuario.add(collection))
				{
					mensajes.Add(Util.mensaje("OK", "Se guardo exitosamente"));
				}
				else
				{

					mensajes.Add(Util.mensaje("ERROR", "No se puedo guardar"));
				}
				// TODO: Add insert logic 
				return Json(mensajes);
			}
			catch (Exception ex)
			{
				mensajes.Clear();
				mensajes.Add(Util.mensaje("ERROR", ex.Message));
				return Json(mensajes);
			}
		}


		// GET: PersonasCasas/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: PersonasCasas/Edit/5
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

		// GET: PersonasCasas/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: PersonasCasas/Delete/5
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
