using CB.ENTIDADES;
using System.Collections.Generic;
using System.Linq;

namespace CB.LOGICA
{
	public class LFase
	{
		private DATA.USER.COBRANZA_CBEntities db = new DATA.USER.COBRANZA_CBEntities();
		public List<Fase> getImtesAll()
		{
			try
			{
				var list = (from x in db.Fases
							select new ENTIDADES.Fase()
							{
								Descripcion = x.Descripcion,
								ID = x.ID
							}).ToList();

				return list ?? null;
			}
			catch (System.Exception ex)
			{
				return null;

			}
		}
	}
}
