using System.Collections.Generic;
using System.Linq;

namespace CB.LOGICA
{
	public class LCompromisoPago
	{
		public bool add(ENTIDADES.CompromisoPago o)
		{
			try
			{
				using (var db = new DATA.USER.COBRANZA_CBEntities())
				{
					db.CompromisoPagoes.Add(toCompromisoPago(o));
					db.SaveChanges();
					return true;
				}
			}
			catch (System.Exception ex)
			{

				return false;
			}


		}
		public bool update(ENTIDADES.CompromisoPago o)
		{
			try
			{
				using (var db = new DATA.USER.COBRANZA_CBEntities())
				{
					var dr = db.CompromisoPagoes.Where(x => x.compromisoPagoID == o.compromisoPagoID).FirstOrDefault();
					if (dr != null)
					{
						dr.Nombre = o.Nombre;
						db.SaveChanges();
						return true;
					}
					else
						return false;

				}
			}
			catch (System.Exception ex)
			{

				return false;
			}

		}
		public bool delete(ENTIDADES.CompromisoPago o)
		{
			try
			{
				using (var db = new DATA.USER.COBRANZA_CBEntities())
				{
					var dr = db.CompromisoPagoes.Where(x => x.compromisoPagoID == o.compromisoPagoID).FirstOrDefault();
					if (dr != null)
					{
						db.CompromisoPagoes.Remove(dr);
						db.SaveChanges();
						return true;
					}
					else
						return false;

				}
			}
			catch (System.Exception ex)
			{

				return false;
			}

		}

		public List<ENTIDADES.CompromisoPago> ListAll()
		{
			try
			{
				using (var db = new DATA.USER.COBRANZA_CBEntities())
				{
					var lis = (from x in db.CompromisoPagoes
							   select new ENTIDADES.CompromisoPago()
							   {
								   compromisoPagoID = x.compromisoPagoID,
								   Nombre = x.Nombre
							   }).ToList();
					return lis ?? null;
				}

			}
			catch (System.Exception ex)
			{

				return null;
			}
		}
		public DATA.USER.CompromisoPago toCompromisoPago(ENTIDADES.CompromisoPago o)
		{
			return new DATA.USER.CompromisoPago()
			{
				compromisoPagoID = o.compromisoPagoID,
				Nombre = o.Nombre
			};
		}
	}
}
