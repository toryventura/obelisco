﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
