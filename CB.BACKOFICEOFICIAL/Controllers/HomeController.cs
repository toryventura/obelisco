using CB.ENTIDADES;
using CB.LOGICA;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Web;
using System.Net;
using System.Linq;
using CB.BACKOFICEOFICIAL.Models;
using CB.BACKOFICEOFICIAL.Clases;
using Newtonsoft.Json;

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
			ViewBag.SinMora = per.CantidadSinMora();
			ViewBag.Preventivo = lg.GetNotificacionCount(5);
			ViewBag.total = lg.totalClienteMora();
			return View();
		}
		public ActionResult Fase(int id)
		{
			ViewBag.fase = id;
			return View();
		}
		/// <summary>
		/// mostrar datos por fase
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public ActionResult FaseDetalle(int id)
		{

			List<DetalleFase> list = new List<DetalleFase>();
			LPersonaCasas pl = new LPersonaCasas();
			list = pl.GetClienteMoraDetalleXFase(id);
			return Json(list);
		}

		public ActionResult CoutaPagada()
		{

			return View();
		}
		public ActionResult DetalleCoutaPagada()
		{

			List<DetalleFase> list = new List<DetalleFase>();
			LPersonaCasas pl = new LPersonaCasas();
			list = pl.GetClientesAlDia();
			return Json(list);
		}
		/// <summary>
		/// notificaciones preventivas 
		/// </summary>
		/// <returns></returns>
		public ActionResult Notificaciones()
		{
			List<DetalleFase> list = new List<DetalleFase>();
			LPersonaCasas pl = new LPersonaCasas();
			list = pl.GetNotiPreventivas(5);
			Session["Notificaciones"] = list;


			var listdif = list.Select(x => x.Codigo).Distinct().ToList();
			List<DetalleFase> distinctPeople = new List<DetalleFase>();
			//list.GroupBy(p => p.CodCliente)
			//.Select(g => g.FirstOrDefault())
			//  .ToList();
			foreach (var j in listdif)
			{
				distinctPeople.Add(list.Where(s => s.Codigo == j).OrderByDescending(r => r.Fecha).FirstOrDefault());
			}


			distinctPeople.ToList().ForEach(emp =>
			   {
				   emp.CodCliente = emp.CodCliente + ":" + list.Where(s => s.Codigo == emp.Codigo).Select(p => p.CantidadCouta).FirstOrDefault();
				   emp.CantidadCouta = list.Where(x => x.Codigo == emp.Codigo).Count();
			   });
			ViewBag.lista = distinctPeople;
			return View();
		}
		public ActionResult ListNotificaciones()
		{
			List<DetalleFase> list = new List<DetalleFase>();
			LPersonaCasas pl = new LPersonaCasas();
			list = pl.GetNotiPreventivas(5);
			Session["Notificaciones"] = list;


			var listdif = list.Select(x => x.Codigo).Distinct().ToList();
			List<DetalleFase> distinctPeople = new List<DetalleFase>();
			//list.GroupBy(p => p.CodCliente)
			//.Select(g => g.FirstOrDefault())
			//  .ToList();
			foreach (var j in listdif)
			{
				distinctPeople.Add(list.Where(s => s.Codigo == j).OrderByDescending(r => r.Fecha).FirstOrDefault());
			}


			distinctPeople.ToList().ForEach(emp =>
			{
				emp.CodCliente = emp.CodCliente + ":" + list.Where(s => s.Codigo == emp.Codigo).Select(p => p.CantidadCouta).FirstOrDefault();
				emp.CantidadCouta = list.Where(x => x.Codigo == emp.Codigo).Count();
			});

			return PartialView("_ListNotificaciones", distinctPeople);
		}
		//public ActionResult ListNPreventiva()
		//{
		//	List<DetalleFase> list = new List<DetalleFase>();
		//	LPersonaCasas pl = new LPersonaCasas();
		//	list = pl.GetClienteMoraDetalleXFase(5);
		//	Session["Notificaciones"] = list;
		//	List<DetalleFase> distinctPeople = list.OrderByDescending(p => p.Fecha)
		//	.GroupBy(p => p.CodCliente)
		//	 .Select(g => g.FirstOrDefault())
		//	   .ToList();
		//	distinctPeople.ToList().ForEach(emp =>
		//	{
		//		emp.CantidadCouta = list.Where(x => x.CodCliente == emp.CodCliente).Count();
		//	});
		//	return Json(distinctPeople);
		//}
		public ActionResult Email()
		{
			return PartialView("_Coreo");
		}
		//[HttpPost]
		//public ActionResult Getdatos1(string id = "")
		//{
		//	List<DetalleFase> list = (List<DetalleFase>)Session["Notificaciones"];
		//	var op = list.Where(s => s.CodCliente == id).FirstOrDefault();
		//	var detalles = list.Where(p => p.CodCliente == id).ToList();
		//	MNotificacion n = new MNotificacion()
		//	{
		//		CodCliente = op.CodCliente,
		//		Nombre = op.NombreCompleto,
		//		Telefono = op.Telefono,
		//		Detalles = detalles

		//	};
		//	ViewBag.Tipo = Util.GetTipos();
		//	//ViewBag.details = detalles;
		//	return PartialView("_Coreo", n);
		//}

		[HttpPost]
		public ActionResult Getdatos(string id = "")
		{
			List<DetalleFase> lists = new List<DetalleFase>();
			LPersonaCasas pl = new LPersonaCasas();
			lists = pl.GetNotiPreventivas(5);
			var op = lists.Where(s => s.CodCliente == id).FirstOrDefault();
			var detalles = lists.Where(p => p.CodCliente == id).ToList();
			MNotificacion n = new MNotificacion()
			{
				CodCliente = op.CodCliente,
				Nombre = op.NombreCompleto,
				Telefono = op.Telefono,
				Detalles = detalles,
				Tipos = Util.GetTipos()

			};

			return Json(n);
		}
		[HttpPost]
		public ActionResult GetdatosLista(string id = "")
		{
			List<DetalleFase> list = (List<DetalleFase>)Session["Notificaciones"];
			var op = list.Where(s => s.CodCliente == id).ToList();
			return Json(op);
		}

		/// <summary>
		/// getalertas para mostrar las alertas o notficaciones que van a mostrar 
		/// </summary>
		/// <returns></returns>
		[HttpPost]
		public ActionResult GetAlertas()
		{
			List<Alertas> list = new List<Alertas>();
			LPersonaCasas pl = new LPersonaCasas();
			DateTime datetimeFrom = DateTime.Now.Date;
			DateTime datetimeTo = datetimeFrom.AddDays(1);
			list = pl.GetAlertas(datetimeFrom, datetimeTo);
			return Json(list);
		}


		[HttpPost]
		public ActionResult BuscarFecha(DateTime fecha)
		{
			List<DetalleFase> list = new List<DetalleFase>();
			LPersonaCasas pl = new LPersonaCasas();
			//DateTime dt= Convert.ToDateTime(fecha.Trim());
			list = pl.GetNotiPreventivasXFecha(fecha);
			return Json(list);
		}
		[HttpPost]
		public ActionResult All()
		{
			List<DetalleFase> list = (List<DetalleFase>)Session["Notificaciones"];
			return Json(list);
		}
		[HttpPost]
		public ActionResult AddAcition(string CodCliente = "", string Tipo = "", string Mensaje = "")
		{
			LNotiPreventiva nt = new LNotiPreventiva();
			Usuario us = Util.Usuario;
			var mensaje = new List<KeyValuePair<string, string>>();
			if (CodCliente != null)
			{
				DateTime an = DateTime.Now;
				string mes = Convert.ToString(an.Month).Length == 1 ? "0" + Convert.ToString(an.Month) : Convert.ToString(an.Month);
				string per = mes + "/" + Convert.ToString(an.Year);
				int tip = Tipo != "" ? Convert.ToInt32(Tipo) : 0;
				NotiPreventivo notiPreventivo = new NotiPreventivo()
				{
					CodCliente = CodCliente,
					FechaReg = DateTime.Now,
					Mensaje = Mensaje,
					Periodo = per,
					TipoAccion = tip,
					UsrCre = us.Login
				};

				if (nt.Add(notiPreventivo))
				{
					mensaje.Add(Util.mensaje(Util.OK, Util.OKMENSAJE));

				}
				else
					mensaje.Add(Util.mensaje(Util.ERROR, Util.ERRORMENSAJE));
			}
			else
				mensaje.Add(Util.mensaje(Util.ERROR, Util.ERRORMENSAJE));
			return Json(mensaje);
		}
		[HttpPost]
		public ActionResult EnviarCoreo(string para = "", string asunto = "", string mensaje = "", HttpPostedFileBase httpPostedFileBase = null)
		{
			try
			{
				MailMessage coreo = new MailMessage
				{
					From = new MailAddress("tory.ven.16@gmail.com", "TORY", System.Text.Encoding.UTF8)
				};
				coreo.To.Add(para);
				coreo.Subject = asunto;
				coreo.Body = mensaje;
				coreo.SubjectEncoding = System.Text.Encoding.UTF8;
				coreo.IsBodyHtml = false;
				coreo.Priority = MailPriority.Normal;
				coreo.BodyEncoding = System.Text.Encoding.UTF8;
				string ruta = Server.MapPath("../Temporal");
				if (!Directory.Exists(ruta))
				{
					Directory.CreateDirectory(ruta);
				}
				if (httpPostedFileBase != null)
				{
					string filename = Path.GetFileName(httpPostedFileBase.FileName);
					httpPostedFileBase.SaveAs(ruta + filename);
					Attachment attachment = new Attachment(ruta + filename);
					coreo.Attachments.Add(attachment);
				}

				//configuration of the  server smpt
				SmtpClient smtpClient = new SmtpClient
				{
					Host = "smtp.gmail.com",
					Port = 587,
					EnableSsl = true,
					UseDefaultCredentials = true
				};
				string scuentacoreo = "tory.ven.16@gmail.com";
				string spassword = "comoolvidartemivida";
				smtpClient.Credentials = new NetworkCredential(scuentacoreo, spassword);
				smtpClient.Send(coreo);
			}
			catch (Exception ex)
			{

				throw new Exception("vista", ex);
			}
			return View();
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