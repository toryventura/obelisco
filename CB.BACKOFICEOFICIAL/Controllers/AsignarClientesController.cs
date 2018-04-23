﻿
using CB.BACKOFICEOFICIAL.Clases;
using CB.ENTIDADES;
using CB.LOGICA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CB.BACKOFICEOFICIAL.Controllers
{
	public class AsignarClientesController : Controller
	{
		// GET: AsignarClientes
		LAsignacionCliente l = new LAsignacionCliente();


		public ActionResult Index()
		{
			return View();
		}
		public ActionResult ListaAsignado()
		{
			var mensajes = new List<KeyValuePair<string, string>>();
			Perfil ps = Util.perfil;
			try
			{
				if (ps.Nombre == "Administrador")
				{

				}
				var list = l.GetClientesAsignadosAll();
				return PartialView("_ListaAsignado", list);

			}
			catch (Exception ex)
			{
				mensajes.Clear();
				mensajes.Add(Util.mensaje("ERROR", ex.Message));
				return Json(mensajes);
			}


		}
		public ActionResult add(AsignacionCliente o)
		{

			var mensajes = new List<KeyValuePair<string, string>>();
			try
			{
				Usuario us = (Usuario)Session["LoginUsuario"];
				o.UsrCre = us.Login;
				o.FeCre = DateTime.Now;
				l.add(o);
				mensajes.Add(Util.mensaje("OK", ""));
				return Json(mensajes);
			}
			catch (Exception ex)
			{
				mensajes.Clear();
				mensajes.Add(Util.mensaje("ERROR", ex.Message));
				return Json(mensajes);
			}

		}
		public ActionResult Details(int id)
		{

			var mensajes = new List<KeyValuePair<string, string>>();
			try
			{
				var lista = l.GetClientesAsignadosAll();
				var items = lista.Where(s => s.asignacionClienteID == id).FirstOrDefault();
				if (items != null)
				{
					return PartialView("_ver", items);
				}
				mensajes.Add(Util.mensaje("ERROR", ""));
				return Json(mensajes);
			}
			catch (Exception ex)
			{
				mensajes.Clear();
				mensajes.Add(Util.mensaje("ERROR", ex.Message));
				return Json(mensajes);
			}

		}
		public ActionResult Edit(int id)
		{

			var mensajes = new List<KeyValuePair<string, string>>();
			try
			{
				var lista = l.GetClientesAsignadosAll();
				var items = lista.Where(s => s.asignacionClienteID == id).FirstOrDefault();
				if (items != null)
				{
					return PartialView("_Editar", items);
				}
				mensajes.Add(Util.mensaje("ERROR", ""));
				return Json(mensajes);
			}
			catch (Exception ex)
			{
				mensajes.Clear();
				mensajes.Add(Util.mensaje("ERROR", ex.Message));
				return Json(mensajes);
			}

		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(AsignacionCliente asignacionCliente)
		{
			var mensajes = new List<KeyValuePair<string, string>>();
			try
			{
				if (ModelState.IsValid)
				{
					l.Edit(asignacionCliente);
					mensajes.Add(Util.mensaje("OK", "Se realizo correctamenta"));
					return Json(mensajes);
				}

				mensajes.Add(Util.mensaje("ERROR", "Fallo"));
				return Json(mensajes);
			}
			catch (Exception ex)
			{

				mensajes.Clear();
				mensajes.Add(Util.mensaje("ERROR", ex.Message));
				return Json(mensajes);
			}

		}
		[HttpPost]

		public ActionResult SetEnviarPametros(int codusuario, string[] lista)
		{
			var mensajes = new List<KeyValuePair<string, string>>();
			try
			{
				Usuario us = Util.Usuario;
				List<string> list = lista.ToArray<string>().ToList();
				DateTime an = DateTime.Now;
				string per = Convert.ToString(an.Month) + "/" + Convert.ToString(an.Year);
				foreach (var item in list)
				{
					AsignacionCliente o = new AsignacionCliente()
					{
						CodUsuario = codusuario,
						CodCliente = item,
						FechaAsignacion = DateTime.Now,
						FechaMod = DateTime.Now,
						FeCre = DateTime.Now,

						UsrCre = us.Login,
						UsrMod = us.Login,
						Estado = true,
						Periodo = per,
						FechaReasignacion = DateTime.Now

					};
					l.add(o);
				}
				mensajes.Add(Util.mensaje("OK", "Se realizo correctamenta"));
				return Json(mensajes);
			}
			catch (Exception ex)
			{
				mensajes.Clear();
				mensajes.Add(Util.mensaje("ERROR", ex.Message));
				return Json(mensajes);
			}
		}


	}
}