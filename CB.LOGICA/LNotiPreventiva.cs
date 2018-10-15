using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CB.LOGICA
{
	public class LNotiPreventiva
	{
		/// <summary>
		/// add adanadimos 
		/// </summary>
		/// <param name="o">se esta pasando objeto a modificar</param>
		/// <returns></returns>
		public bool Add(ENTIDADES.NotiPreventivo o)
		{
			try
			{
				using (var db = new DATA.USER.COBRANZA_CBEntities())
				{
					DATA.USER.NotiPreventivo ob = new DATA.USER.NotiPreventivo()
					{
						CodCliente = o.CodCliente,
						FechaReg = o.FechaReg,
						Mensaje = o.Mensaje,
						Periodo = o.Periodo,
						TipoAccion = o.TipoAccion,
						UsrCre = o.UsrCre

					};
					db.NotiPreventivoes.Add(ob);
					db.SaveChanges();
					return true;
				}
			}
			catch (Exception ex)
			{

				throw new Exception("Logica NotiPreventiva", ex);
			}
		}
		/// <summary>
		///  ListNotiPreventivo sacamos la lista de notificaciones sin  importar.
		/// </summary>
		/// <returns></returns>
		public List<CB.ENTIDADES.NotiPreventivo> ListNotiPreventivo()
		{

			List<CB.ENTIDADES.NotiPreventivo> list = new List<ENTIDADES.NotiPreventivo>();
			var dbi = new DATA.INVENTARIO.INVENTARIO_CONSTRUCTORA_OBELISCOEntities();
			var per = dbi.Vwt_Persona.ToList();
			try
			{
				using (var db = new DATA.USER.COBRANZA_CBEntities())
				{
					var x = (from s in db.NotiPreventivoes
							 select new CB.ENTIDADES.NotiPreventivo()
							 {
								 TipoAccion = s.TipoAccion.Value,
								 CodCliente = s.CodCliente,
								 FechaReg = s.FechaReg.Value,
								 Mensaje = s.Mensaje,
								 NotificacionID = s.NotificacionID,
								 Periodo = s.Periodo,
								 UsrCre = s.UsrCre
							 }).ToList();
					list = x;
					foreach (var item in list)
					{
						item.Nombre = per.Where(s => s.CodCliente == item.CodCliente).Select(a => a.NombreCompleto).FirstOrDefault();
					}
					return list;
				}
			}
			catch (Exception ex)
			{

				throw new Exception("Logica:ListNotiPreventivo", ex);
			}


		}
	}

}
