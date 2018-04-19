using System.Collections.Generic;
using System.Linq;

namespace CB.LOGICA
{
	public class LProbalidadPago
	{
		public bool add(ENTIDADES.ProbalidadPago o)
		{
			try
			{
				using (var db = new DATA.USER.COBRANZA_CBEntities())
				{
					db.ProbalidadPagoes.Add(toProbalidadPago(o));
					db.SaveChanges();
					return true;
				}
			}
			catch (System.Exception ex)
			{

				return false;
			}


		}
		public bool update(ENTIDADES.ProbalidadPago o)
		{
			try
			{
				using (var db = new DATA.USER.COBRANZA_CBEntities())
				{
					var dr = db.ProbalidadPagoes.Where(x => x.ID == o.ID).FirstOrDefault();
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
		public bool delete(ENTIDADES.ProbalidadPago o)
		{
			try
			{
				using (var db = new DATA.USER.COBRANZA_CBEntities())
				{
					var dr = db.ProbalidadPagoes.Where(x => x.ID == o.ID).FirstOrDefault();
					if (dr != null)
					{
						db.ProbalidadPagoes.Remove(dr);
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

		public List<ENTIDADES.ProbalidadPago> ListAll()
		{
			try
			{
				using (var db = new DATA.USER.COBRANZA_CBEntities())
				{
					var lis = (from x in db.ProbalidadPagoes
							   select new ENTIDADES.ProbalidadPago()
							   {
								   ID = x.ID,
								   Nombre = x.Nombre
							   }).ToList();
					return lis != null ? lis : null;
				}

			}
			catch (System.Exception ex)
			{

				return null;
			}
		}
		public DATA.USER.ProbalidadPago toProbalidadPago(ENTIDADES.ProbalidadPago o)
		{
			return new DATA.USER.ProbalidadPago()
			{
				ID = o.ID,
				Nombre = o.Nombre
			};
		}
	}
}
