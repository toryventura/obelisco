﻿using CB.BACKOFICEOFICIAL.Clases;
using CB.ENTIDADES;
using CB.LOGICA;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CB.BACKOFICEOFICIAL.Controllers
{
	public class OperacionesController : Controller
	{
		// GET: Operaciones
		LPersonasMora logica = new LPersonasMora();
		LOperaciones op = new LOperaciones();

		public ActionResult Index()
		{
			ViewBag.tipogestion = op.getTipeGestion();
			return View();
		}
		[HttpPost]
		public ActionResult PersonaAsigndos()
		{
			LPersonaCasas p = new LPersonaCasas();
			var itm = Util.Usuario.ID;
			var lis = p.GetClienteAllMoraXuser(itm);

			return Json(lis);
		}
		[HttpPost]
		public ActionResult getInfocliente(string id = "")
		{
			LPersonaCasas lp = new LPersonaCasas();
			var info = lp.GetClienteXID(id);
			return PartialView("_VerDatosPersonales", info);
		}
		[HttpPost]
		public ActionResult getCuotas(string id = "")
		{
			LPersonaCasas lp = new LPersonaCasas();
			var info = lp.GetClienteXID(id);
			return PartialView("_VerDatosPersonales", info);
		}
		public ActionResult getOperaciones(string id = "")
		{
			LOperaciones op = new LOperaciones();
			var oper = op.getLista(id);
			return Json(oper);
		}
		[HttpPost]
		public ActionResult getOperacionesrr(string id = "", string idclient = "")
		{
			Usuario us = Util.Usuario;
			int tipo = Convert.ToInt32(id);
			ViewBag.tipogestion = op.getTipeGestion();
			ViewBag.probalidadpago = op.getProbalidadPago();
			ViewBag.casualmora = op.getCasualMora();
			ViewBag.compromisopago = op.getCompromiso();
			ViewBag.parametro = op.getParametros(tipo);
			var ids = op.getAsignacion(idclient, us.ID);
			ViewBag.asignacionID = ids == 0 ? 0 : ids;
			OperacionCobranza ope = new OperacionCobranza();
			return PartialView("_Create", ope);

		}
		[HttpPost]
		public ActionResult getCuotasNoPagadas(string id = "")
		{
			LPersonasMora lp = new LPersonasMora();
			var lista = lp.GetClienteMoraDetails(id);
			return Json(lista);
		}
		[HttpPost]
		public ActionResult getCuotasPagadas(string id = "")
		{
			LPersonasMora lp = new LPersonasMora();
			var lista = lp.GetClienteMoraDetails(id);
			return Json(lista);
		}

		public ActionResult Imprimir(string idclient, int idoperacion=0)
		{
			ViewBag.fecha = DateTime.Now;
			ViewBag.idclient = idclient;
			ViewBag.idopracion = idoperacion;
			LPersonaCasas pc = new LPersonaCasas();
			LOperaciones op = new LOperaciones();
			Imprimir imp = new Imprimir
			{
				cliente = pc.GetClienteXID(idclient),
				operacion=op.GetOperacion(idoperacion)
			};

			return PartialView("_Imprimir", imp);
		}

		public ActionResult Printf(string idclient, int idoperacion=0)
		{
			ViewBag.fecha = DateTime.Now;
			LPersonaCasas pc = new LPersonaCasas();
			LOperaciones op = new LOperaciones();
			Imprimir imp = new Imprimir
			{
				cliente = pc.GetClienteXID(idclient),
				operacion = op.GetOperacion(idoperacion)
			};
			return View(imp);
		}
		public ActionResult Create(ENTIDADES.OperacionCobranza collection, string probalidadpago = "", string compromisopago = "", string casualmora = "", string parametro = "",string txtHora = "")
		{
			var mensajes = new List<KeyValuePair<string, string>>();
			try
			{
				if (txtHora!="")
				{
					var dt = collection.FechaCompromiso + " " + txtHora;
					collection.FechaCompromiso = dt;
				}
				
				Usuario us = Util.Usuario;
				collection.FeCre = DateTime.Now;
				collection.FeMod = DateTime.Now;
				collection.UsrCre = us.Login;
				collection.UsrMod = us.Login;
				collection.probalidadPagoID = Convert.ToInt32(probalidadpago);
				collection.CompromisoPagoID = Convert.ToInt32(compromisopago);
				collection.CausalMoraID = Convert.ToInt32(casualmora);
				collection.parametroID = Convert.ToInt32(parametro);
				int cout = op.add(collection);
				if (cout != 0)
				{
					mensajes.Add(Util.mensaje("OK", "La operacion correctamente" + "|" + cout));
				}
				else
				{
					mensajes.Add(Util.mensaje("ERROR", "No se completo la operacion"));
				}
			}
			catch (Exception ex)
			{
				mensajes.Clear();
				mensajes.Add(Util.mensaje("ERROR", ex.Message));
			}

			return Json(mensajes);
		}
	}
}