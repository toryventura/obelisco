using CB.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CB.LOGICA
{
	public class LPersonasMora
	{
		public PersonaMora GetClientID(string ci)
		{
			using (var db = new DATA.INVENTARIO.INVENTARIO_CONSTRUCTORA_OBELISCOEntities())
			{
				try
				{
					var items = (from m in db.actualizarMoraDarias
								 join s in db.Personas on m.CodCliente equals s.CodCliente
								 where s.CodCliente == ci
								 select new PersonaMora()
								 {
									 CodCliente = m.CodCliente,
									 Codigo = m.Codigo,
									 CodigoCtaxcobrarDet = m.CodigoCtaxcobrarDet,
									 diasAtraso = m.diasAtraso.Value,
									 Doc = m.Doc,


									 NombreClinete = s.NombreP + " " + s.Apellido + " " + s.Seg_Apellido,

									 porcentaje = m.porcentaje
								 }).ToList();
					return items.FirstOrDefault();
				}
				catch (System.Exception)
				{

					return null;
				}

			}
		}
		public int totalClienteMora()
		{
			try
			{
				using (var db = new DATA.INVENTARIO.INVENTARIO_CONSTRUCTORA_OBELISCOEntities())
				{
					int xa = db.CantidadClienteMoras.Count();
					return xa;
				}
			}
			catch (System.Exception ex)
			{

				throw new Exception("Logica", ex);
			}
		}
		public int getfase1()
		{
			try
			{
				using (var db = new DATA.INVENTARIO.INVENTARIO_CONSTRUCTORA_OBELISCOEntities())
				{
					int xa = db.CantidadClienteMoras.Where(x => x.CantidadCouta.Value == 1).Count();
					return xa;
				}
			}
			catch (System.Exception ex)
			{

				throw new Exception("Logica", ex);
			}

		}
		public int getfase2()
		{
			try
			{
				using (var db = new DATA.INVENTARIO.INVENTARIO_CONSTRUCTORA_OBELISCOEntities())
				{
					int xa = db.CantidadClienteMoras.Where(x => x.CantidadCouta.Value == 2).Count();
					return xa;
				}
			}
			catch (System.Exception ex)
			{

				throw new Exception("Logica", ex);
			}

		}
		public int getfase3()
		{
			try
			{
				using (var db = new DATA.INVENTARIO.INVENTARIO_CONSTRUCTORA_OBELISCOEntities())
				{
					int xa = db.CantidadClienteMoras.Where(x => x.CantidadCouta.Value == 3).Count();
					return xa;
				}
			}
			catch (System.Exception ex)
			{

				throw new Exception("Logica", ex);
			}

		}
		public int getfase4()
		{
			try
			{
				using (var db = new DATA.INVENTARIO.INVENTARIO_CONSTRUCTORA_OBELISCOEntities())
				{
					int xa = db.CantidadClienteMoras.Where(x => x.CantidadCouta.Value == 4).Count();
					return xa;
				}
			}
			catch (System.Exception ex)
			{

				throw new Exception("Logica", ex);
			}

		}
		public int getfase5()
		{
			try
			{
				using (var db = new DATA.INVENTARIO.INVENTARIO_CONSTRUCTORA_OBELISCOEntities())
				{
					int xa = db.CantidadClienteMoras.Where(x => x.CantidadCouta.Value == 5).Count();
					return xa;
				}
			}
			catch (System.Exception ex)
			{

				throw new Exception("Logica", ex);
			}

		}
		public int getfase6()
		{
			try
			{
				using (var db = new DATA.INVENTARIO.INVENTARIO_CONSTRUCTORA_OBELISCOEntities())
				{
					int xa = db.CantidadClienteMoras.Where(x => x.CantidadCouta.Value > 5).Count();
					return xa;
				}
			}
			catch (System.Exception ex)
			{

				throw new Exception("Logica", ex);
			}

		}
		public List<PersonaMora> GetClienteMoraAll()
		{
			using (var db = new DATA.INVENTARIO.INVENTARIO_CONSTRUCTORA_OBELISCOEntities())
			{
				try
				{

					var items = (from m in db.actualizarMoraDarias
								 join s in db.Personas on m.CodCliente equals s.CodCliente

								 select new PersonaMora()
								 {
									 CodCliente = m.CodCliente,
									 Codigo = m.Codigo,
									 CodigoCtaxcobrarDet = m.CodigoCtaxcobrarDet,
									 diasAtraso = m.diasAtraso.Value,
									 Doc = m.Doc,


									 NombreClinete = s.NombreP + " " + s.Apellido + " " + s.Seg_Apellido,

									 porcentaje = m.porcentaje
								 }).ToList();
					return items;
				}
				catch (System.Exception)
				{
					return null;
				}

			}
		}
		public List<PersonaMora> GetClienteAllMoraXuser(long id = 0)
		{
			var db = new DATA.INVENTARIO.INVENTARIO_CONSTRUCTORA_OBELISCOEntities();
			var db1 = new DATA.USER.COBRANZA_CBEntities();

			try
			{
				var _listAsiganado = db1.AsignacionClientes.Where(x => x.CodUsuario == id && x.Estado == true).Select(w => w.CodCliente).ToList();
				if (_listAsiganado.Count > 0)
				{
					var items = (from m in db.actualizarMoraDarias
								 join s in db.Personas on m.CodCliente equals s.CodCliente
								 select new PersonaMora()
								 {
									 CodCliente = m.CodCliente,
									 Codigo = m.Codigo,
									 CodigoCtaxcobrarDet = m.CodigoCtaxcobrarDet,
									 diasAtraso = m.diasAtraso.Value,
									 Doc = m.Doc,


									 NombreClinete = s.NombreP + " " + s.Apellido + " " + s.Seg_Apellido,

									 porcentaje = m.porcentaje
								 }).ToList();
					var _listFinal = items.Where(s => _listAsiganado.Contains(s.CodCliente)).ToList();
					if (_listFinal.Count > 0)
					{

						return _listFinal;
					}
					return null;

				}
				return null;

			}
			catch
			{
				return null;
			}



		}


		public List<DetailsMoras> GetClienteMoraDetails(string codcliente)
		{
			using (var db = new DATA.INVENTARIO.INVENTARIO_CONSTRUCTORA_OBELISCOEntities())
			{
				var numcuenta = db.CtaPorCobrars.Where(x => x.CodCliente == codcliente && x.TipoCtaPorCobrar == 5).FirstOrDefault();
				if (numcuenta != null)
				{
					var deateils = (from x in db.actualizarMoraDarias
									join xs in db.CtaPorCobrarDets on x.Codigo equals xs.Codigo
									where x.NroCuota == xs.NroCuota && x.CodCliente == codcliente && x.CodigoCtaxcobrarDet == numcuenta.Codigo
									select new DetailsMoras()
									{
										CodCliente = x.CodCliente,
										Codigo = x.Codigo,
										CodigoCtaxcobrarDet = x.CodigoCtaxcobrarDet,
										diasAtraso = x.diasAtraso.Value,
										Doc = x.Doc,
										InteresMora = xs.Capital,
										NroCuota = xs.NroCuota,
										porcentaje = x.porcentaje,
										montopagar = db.CtaPorCobrars.Where(g => g.CodCliente == codcliente && g.TipoCtaPorCobrar == 1).Select(g => g.MontoCuota).FirstOrDefault()
									}).ToList();
					return deateils;
				}
				else
					return null;

			}



		}
	}
}
