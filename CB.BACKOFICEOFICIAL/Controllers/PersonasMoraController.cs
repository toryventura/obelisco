using CB.BACKOFICEOFICIAL.Clases;
using CB.LOGICA;
using System.Web.Mvc;

namespace CB.BACKOFICEOFICIAL.Controllers
{
	public class PersonasMoraController : Controller
	{
		// GET: PersonasMora
		LPersonasMora logica = new LPersonasMora();

		public ActionResult Index()
		{
			return View();
		}
		public ActionResult listaPersonaMora()
		{
			try
			{
				if (Util.perfil.Nombre == "Administrador")
				{
					var lis = logica.GetClienteMoraAll();

					return PartialView("_ListsPersonas", lis);
				}
				else
				{
					// TODO: Add insert logic her
					var itm = Util.Usuario.ID;
					var lis = logica.GetClienteAllMoraXuser(itm);

					return PartialView("_ListsPersonas", lis);
				}
			}
			catch
			{
				return View();
			}
		}
		public ActionResult GetClienteEnMora()
		{

			try
			{
				LPersonaCasas lg = new LPersonaCasas();
				var lista = lg.GetClienteAllMoraNoAsignados();
				if (lista != null)
				{
					return Json(lista);
				}
				return Json("");
			}
			catch (System.Exception)
			{

				throw;
			}
		}
	}
}