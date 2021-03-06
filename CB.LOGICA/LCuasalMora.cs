﻿using System.Collections.Generic;
using System.Linq;
namespace CB.LOGICA
{
	public class LCuasalMora
	{
		public bool add(ENTIDADES.CausalMora o)
		{
			try
			{
				using (var db = new DATA.USER.COBRANZA_CBEntities())
				{
					db.CausalMoras.Add(toCausalMora(o));
					db.SaveChanges();
					return true;
				}
			}
			catch (System.Exception ex)
			{

				throw new System.Exception("Logica:add", ex);
			}


		}
		public bool update(ENTIDADES.CausalMora o)
		{
			try
			{
				using (var db = new DATA.USER.COBRANZA_CBEntities())
				{
					var dr = db.CausalMoras.Where(x => x.causalMoraID == o.causalMoraID).FirstOrDefault();
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

				throw new System.Exception("Logica:update", ex);
			}

		}
		public bool delete(ENTIDADES.CausalMora o)
		{
			try
			{
				using (var db = new DATA.USER.COBRANZA_CBEntities())
				{
					var dr = db.CausalMoras.Where(x => x.causalMoraID == o.causalMoraID).FirstOrDefault();
					if (dr != null)
					{
						db.CausalMoras.Remove(dr);
						db.SaveChanges();
						return true;
					}
					else
						return false;

				}
			}
			catch (System.Exception ex)
			{

				throw new System.Exception("Logica:delete", ex); 
			}

		}

		public List<ENTIDADES.CausalMora> ListAll()
		{
			try
			{
				using (var db = new DATA.USER.COBRANZA_CBEntities())
				{
					var lis = (from x in db.CausalMoras
							   select new ENTIDADES.CausalMora()
							   {
								   causalMoraID = x.causalMoraID,
								   Nombre = x.Nombre
							   }).ToList();
					return lis ?? null;
				}

			}
			catch (System.Exception ex)
			{

				throw new System.Exception("Logica:ListAll",ex);
			}
		}
		public DATA.USER.CausalMora toCausalMora(ENTIDADES.CausalMora o)
		{
			return new DATA.USER.CausalMora()
			{
				causalMoraID = o.causalMoraID,
				Nombre = o.Nombre
			};
		}
	}
}
