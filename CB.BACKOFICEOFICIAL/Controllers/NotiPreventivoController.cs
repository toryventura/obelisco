﻿using CB.LOGICA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CB.BACKOFICEOFICIAL.Controllers
{
    public class NotiPreventivoController : Controller
    {
		List<CB.ENTIDADES.NotiPreventivo> preventivos = new List<ENTIDADES.NotiPreventivo>();
		LNotiPreventiva op = new LNotiPreventiva();
		// GET: NotiPreventivo
		public ActionResult Index()
        {
			preventivos = op.ListNotiPreventivo();
			ViewBag.Noti = preventivos;

			return View();
        }

        // GET: NotiPreventivo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NotiPreventivo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NotiPreventivo/Create
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

        // GET: NotiPreventivo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NotiPreventivo/Edit/5
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

        // GET: NotiPreventivo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NotiPreventivo/Delete/5
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
