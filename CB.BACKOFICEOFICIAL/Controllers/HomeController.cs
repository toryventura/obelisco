using CB.ENTIDADES;
using CB.LOGICA;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;

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
		public	ActionResult Notificacion()
		{ 
			List<NotiPreventiva> list = new List<NotiPreventiva>();
			LPersonaCasas pl = new LPersonaCasas();
			list = pl.GetNotiPreventivas(5);
			return View(list);
		}
		public ActionResult ExportToExcel(int fase)
		{

			var gv = new GridView();
			List<PersonaCasas> list = new List<PersonaCasas>();
			LPersonaCasas pl = new LPersonaCasas();
			list = pl.GetClienteAllMoraNoAsignados(fase);
			gv.DataSource = list;
			gv.DataBind();
			Response.ClearContent();
			Response.Buffer = true;
			Response.AddHeader("content-disposition", "attachment; filename=DemoExcel.xls");
			Response.ContentType = "application/ms-excel";
			Response.Charset = "";

			StringWriter objStringWriter = new StringWriter();
			HtmlTextWriter objHtmlTextWriter = new HtmlTextWriter(objStringWriter);
			gv.RenderControl(objHtmlTextWriter);
			Response.Output.Write(objStringWriter.ToString());
			Response.Flush();
			Response.End();

			return View("Fase", list);


		}
	}
}