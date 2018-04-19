using System.Collections.Generic;
using System.Linq;

namespace CB.LOGICA
{
	public class LParametro
	{
		public bool add(ENTIDADES.Parametro o)
		{
			try
			{
				using (var db = new DATA.USER.COBRANZA_CBEntities())
				{
					db.Parametros.Add(toParametro(o));
					db.SaveChanges();
					return true;
				}
			}
			catch (System.Exception ex)
			{

				return false;
			}


		}
		public bool update(ENTIDADES.Parametro o)
		{
			try
			{
				using (var db = new DATA.USER.COBRANZA_CBEntities())
				{
					var dr = db.Parametros.Where(x => x.ID == o.ID).FirstOrDefault();
					if (dr != null)
					{
						dr.Descripcion = o.Descripcion;
						dr.TipoGestionId = o.TipoGestionId;
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
		public bool delete(ENTIDADES.Parametro o)
		{
			try
			{
				using (var db = new DATA.USER.COBRANZA_CBEntities())
				{
					var dr = db.Parametros.Where(x => x.ID == o.ID).FirstOrDefault();
					if (dr != null)
					{
						db.Parametros.Remove(dr);
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

		public List<ENTIDADES.Parametro> ListAll()
		{
			try
			{
				using (var db = new DATA.USER.COBRANZA_CBEntities())
				{
					var lis = (from x in db.Parametros
							   select new ENTIDADES.Parametro()
							   {
								   ID = x.ID,
								   Descripcion = x.Descripcion,
								   TipoGestionId = x.TipoGestionId.Value,
								   TipoGestion = new ENTIDADES.TipoGestion() { Nombre = x.TipoGestion.Nombre, tipoGestionID = x.TipoGestion.tipoGestionID }
							   }).ToList();
					return lis != null ? lis : null;
				}

			}
			catch (System.Exception ex)
			{

				return null;
			}
		}
		public DATA.USER.Parametro toParametro(ENTIDADES.Parametro o)
		{
			return new DATA.USER.Parametro()
			{
				ID = o.ID,
				Descripcion = o.Descripcion,
				TipoGestionId = o.TipoGestionId
			};
		}
		
	}
}
