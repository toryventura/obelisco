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
			return View();
		}
		public ActionResult FaseDetalle(int id)
		{
			
			List<DetalleFase> list = new List<DetalleFase>();
			LPersonaCasas pl = new LPersonaCasas();
			list = pl.GetClienteMoraDetalleXFase(id);
			return Json(list);
		}
		public ActionResult Notificacion()
		{

			return View();
		}
		public ActionResult ListNPreventiva()
		{
			List<DetalleFase> list = new List<DetalleFase>();
			LPersonaCasas pl = new LPersonaCasas();
			list = pl.GetNotiPreventivas(5);
			return Json(list);
		}
		public ActionResult Email()
		{
			return PartialView("_Coreo");
		}
		[HttpPost]
		public ActionResult EnviarCoreo(string para = "", string asunto = "", string mensaje = "", HttpPostedFileBase httpPostedFileBase = null)
		{
			try
			{
				MailMessage coreo = new MailMessage();
				coreo.From = new MailAddress("tory.ven.16@gmail.com", "TORY", System.Text.Encoding.UTF8);
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