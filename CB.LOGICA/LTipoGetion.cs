using System;
using System.Collections.Generic;
using System.Linq;

namespace CB.LOGICA
{
	public class LTipoGetion
	{
		public bool add(ENTIDADES.TipoGestion o)
		{
			try
			{
				using (var db = new DATA.USER.COBRANZA_CBEntities())
				{
					db.TipoGestions.Add(toTipoGestion(o));
					db.SaveChanges();
					return true;
				}
			}
			catch (System.Exception ex)
			{

				throw new Exception("Logica add", ex);
			}


		}
		public bool update(ENTIDADES.TipoGestion o)
		{
			try
			{
				using (var db = new DATA.USER.COBRANZA_CBEntities())
				{
					var dr = db.TipoGestions.Where(x => x.tipoGestionID == o.tipoGestionID).FirstOrDefault();
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

				throw new Exception("Logica update", ex);
			}

		}
		public bool delete(ENTIDADES.TipoGestion o)
		{
			try
			{
				using (var db = new DATA.USER.COBRANZA_CBEntities())
				{
					var dr = db.TipoGestions.Where(x => x.tipoGestionID == o.tipoGestionID).FirstOrDefault();
					if (dr != null)
					{
						db.TipoGestions.Remove(dr);
						db.SaveChanges();
						return true;
					}
					else
						return false;

				}
			}
			catch (System.Exception ex)
			{

				throw new Exception("Logica delete", ex);
			}

		}

		public List<ENTIDADES.TipoGestion> ListAll()
		{
			try
			{
				using (var db = new DATA.USER.COBRANZA_CBEntities())
				{
					var lis = (from x in db.TipoGestions
							   select new ENTIDADES.TipoGestion()
							   {
								   tipoGestionID = x.tipoGestionID,
								   Nombre = x.Nombre
							   }).ToList();
					return lis != null ? lis : null;
				}

			}
			catch (System.Exception ex)
			{

				throw new Exception("Logica listAlll", ex);
			}
		}
		public DATA.USER.TipoGestion toTipoGestion(ENTIDADES.TipoGestion o)
		{
			return new DATA.USER.TipoGestion()
			{
				tipoGestionID = o.tipoGestionID,
				Nombre = o.Nombre
			};
		}
	}
}
