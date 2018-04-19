using CB.BACKOFICEOFICIAL.Clases;
using System.Web.Mvc;

namespace CB.BACKOFICEOFICIAL.App_Start
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new AutorizarAtributo());
			//filters.Add(new HandleErrorAttribute());
		}
	}
}