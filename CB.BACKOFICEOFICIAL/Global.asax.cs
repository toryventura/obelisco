using CB.BACKOFICEOFICIAL.App_Start;
using System;
using System.Threading;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CB.BACKOFICEOFICIAL
{
	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			DevExpress.XtraReports.Web.WebDocumentViewer.Native.WebDocumentViewerBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Disabled;
			DevExpress.XtraReports.Web.QueryBuilder.Native.QueryBuilderBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Disabled;
			DevExpress.XtraReports.Web.ReportDesigner.Native.ReportDesignerBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Disabled;
			AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);//filter config
			RouteConfig.RegisterRoutes(RouteTable.Routes);//Routerconfig
			BundleConfig.RegisterBundles(BundleTable.Bundles);//bun
		}
		protected void Application_PreRequestHandlerExecute(Object sender, EventArgs e)
		{
			Thread.CurrentThread.CurrentCulture = ENTIDADES.PyRFormato.Formato;
		}
	}
}
