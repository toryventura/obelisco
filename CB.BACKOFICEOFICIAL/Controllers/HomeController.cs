using CB.LOGICA;
using System.Web.Mvc;

namespace CB.BACKOFICEOFICIAL.Controllers
{
	public class HomeController : Controller
	{
		// GET: Home
		public ActionResult Index()
		{
			LPersonasMora lg = new LPersonasMora();
			ViewBag.fase1 = lg.getfase1();
			ViewBag.fase2 = lg.getfase2();
			ViewBag.fase3 = lg.getfase3();
			ViewBag.fase4 = lg.getfase4();
			ViewBag.fase5 = lg.getfase5();
			ViewBag.fase6 = lg.getfase6();
			ViewBag.total = lg.totalClienteMora();
			return View();
		}
	}
}