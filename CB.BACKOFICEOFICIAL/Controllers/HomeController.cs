using CB.ENTIDADES;
using CB.LOGICA;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CB.BACKOFICEOFICIAL.Controllers
{
	public class HomeController : Controller
	{
		// GET: Home
		public ActionResult Index()
		{
			LPersonaCasas per = new LPersonaCasas();
			LPersonasMora lg = new LPersonasMora();
			DateTime re = DateTime.Now;
			string mes = re.Month < 10 ? "0" + Convert.ToString(re.Month) : Convert.ToString(re.Month);
			string year = Convert.ToString(re.Year);
			string periodo = mes + "/" + year;
			ViewBag.fase1 = lg.getfase1();
			ViewBag.fase2 = lg.getfase2();
			ViewBag.fase3 = lg.getfase3();
			ViewBag.fase4 = lg.getfase4();
			ViewBag.fase5 = lg.getfase5();
			ViewBag.NoAsiginadas = per.CantidadclienteNoasignados(periodo);
			ViewBag.Asignados = per.CantidadclienteAsignados(periodo);
			ViewBag.total = lg.totalClienteMora();
			return View();
		}
		public ActionResult Fase(int id)
		{
			ViewBag.fase = id;
			List<PersonaCasas> list = new List<PersonaCasas>();
			LPersonaCasas pl = new LPersonaCasas();
			list = pl.GetClienteAllMoraNoAsignados(id);
			return View(list);
		}
	}
}