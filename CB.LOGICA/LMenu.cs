
using CB.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
namespace CB.LOGICA
{
	public class LMenu
	{
		public static List<Menu> ObtenerMenus()
		{
			try
			{
				List<Menu> Menus = new List<Menu>();

				using (var BD = new DATA.USER.COBRANZA_CBEntities())
				{
					var me = (from x in BD.Menus orderby x.Orden select x).ToList();
					foreach (var m in me)
					{
						Menus.Add(DataToEntidad(m));
					}
				}
				return Menus;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public static Menu DataToEntidad(DATA.USER.Menu d)
		{
			Menu m = new Menu()
			{
				Accion = d.Accion,
				Controlador = d.Controlador,
				ID = d.MenuID,
				MenuPadre = d.MenuPadre,
				Orden = d.Orden.Value,
				Texto = d.Texto,
				EsGlobal = d.EsGlobal.Value
			};

			return m;
		}
	}
}
