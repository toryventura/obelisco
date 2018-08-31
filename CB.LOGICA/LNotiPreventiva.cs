using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CB.LOGICA
{
	public class LNotiPreventiva
	{
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
	}
}
