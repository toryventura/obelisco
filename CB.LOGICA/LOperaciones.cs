
using CB.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CB.LOGICA
{
	public class LOperaciones
	{
		public List<OperacionCobranza> getLista(string clienteID = "")
		{

			using (var db = new DATA.USER.COBRANZA_CBEntities())
			{
				try
				{
					var idAsigancion = db.AsignacionClientes.Where(x => x.CodCliente == clienteID && x.Estado == true).Select(x => x.asignacionClienteID).FirstOrDefault();
					var _lists = new List<ENTIDADES.OperacionCobranza>();
					if (idAsigancion != 0)
					{
						var _List = db.OperacionCobranzas.Where(s => s.asignacionClienteID == idAsigancion).ToList();
						foreach (var item in _List)
						{
							_lists.Add(ToEntidades(item));
						}
					}

					return _lists;

				}
				catch (System.Exception ex)
				{
					return null;
				}
			}

		}
		public int getAsignacion(string id, long us)
		{
			using (var db = new DATA.USER.COBRANZA_CBEntities())
			{
				var asig = db.AsignacionClientes.Where(x => x.CodCliente == id && x.CodUsuario == us && x.Estado == true).Select(x => x.asignacionClienteID).FirstOrDefault();
				return asig;
			}
		}
		public OperacionCobranza GetOperacion(int id)
		{
			try
			{
				using (var db = new DATA.USER.COBRANZA_CBEntities())
				{
					var op = db.OperacionCobranzas.Where(x => x.operacionCobranzaID == id).FirstOrDefault();

					return ToEntidades(op);
				}
			}
			catch (Exception ex)
			{

				throw new Exception("Logica : GetOperacion", ex);
			}

		}
		public int add(ENTIDADES.OperacionCobranza o)
		{
			using (var db = new DATA.USER.COBRANZA_CBEntities())
			{
				try
				{
					var count = db.OperacionCobranzas.Count() + 1;
					var pres = db.Parametros.Where(x => x.ID == o.parametroID).Select(x => x.TipoGestionId.Value).FirstOrDefault();
					var uss = new DATA.USER.OperacionCobranza()
					{
						asignacionClienteID = o.AsignacionClienteID,
						causalMoraID = o.CausalMoraID,
						CausalMoraAnt = o.CausalMoraAnt,
						Comentario = o.Comentario,
						compromisoPagoID = o.CompromisoPagoID,
						FechaCompromiso = Convert.ToDateTime(o.FechaCompromiso),
						FeCre = o.FeCre,
						FeMod = o.FeMod,
						operacionCobranzaID = count,
						presenciaClienteID = pres,
						probalidadPagoID = o.probalidadPagoID,
						TelefonoAlternativo = o.TelefonoAlternativo,
						activo=o.activo,
						UsrCre = o.UsrCre,
						UsrMod = o.UsrMod,
						parametroID = o.parametroID
					};
					db.OperacionCobranzas.Add(uss);
					db.SaveChanges();
					return count;

				}
				catch (System.Exception ex)
				{
					throw new Exception("Logico add", ex);

				}
			}
		}
		public OperacionCobranza ToEntidades(DATA.USER.OperacionCobranza o)
		{
			return new OperacionCobranza()
			{
				AsignacionClienteID = o.asignacionClienteID.Value,
				CausalMoraAnt = o.CausalMoraAnt,
				CausalMoraID = o.causalMoraID.Value,
				Comentario = o.Comentario,
				CompromisoPagoID = o.compromisoPagoID.Value,
				FechaCompromiso = Convert.ToString(o.FechaCompromiso.Value),
				FeCre = o.FeCre.Value,
				FeMod = o.FeMod.Value,
				compromisoPago = "",
				NombreCausal = getNombreCausual(o.causalMoraID.Value),
				nombrepresencia = getNombrePresencia(o.presenciaClienteID.Value),
				nombreprobalidadPago = getNombrPerobalidad(o.probalidadPagoID.Value),
				nombreparametro = getTipogestion(o.parametroID.Value),
				operacionCobranzaID = o.operacionCobranzaID,
				presenciaClienteID = o.presenciaClienteID.Value,
				activo=o.activo.Value,
				probalidadPagoID = o.probalidadPagoID.Value,
				TelefonoAlternativo = o.TelefonoAlternativo == null ? "" : o.TelefonoAlternativo,
				parametroID = o.parametroID.Value,
				UsrCre = o.UsrCre,
				UsrMod = o.UsrMod
			};
		}

		private string getNombreCausual(int causalMoraID)
		{
			using (var db = new DATA.USER.COBRANZA_CBEntities())
			{
				var mon = db.CausalMoras.Where(s => s.causalMoraID == causalMoraID).Select(s => s.Nombre).FirstOrDefault();
				return mon ?? "";
			}
		}

		private string getTipogestion(int p)
		{
			using (var db = new DATA.USER.COBRANZA_CBEntities())
			{
				var nom = db.TipoGestions.Where(s => s.tipoGestionID == p).Select(s => s.Nombre).FirstOrDefault();
				return nom ?? "";
			}
		}

		private string getNombrPerobalidad(int p)
		{
			using (var db = new DATA.USER.COBRANZA_CBEntities())
			{
				var nom = db.ProbalidadPagoes.Where(s => s.ID == p).Select(s => s.Nombre).FirstOrDefault();
				return nom ?? "";
			}
		}

		private string getNombrePresencia(int p)
		{
			using (var db = new DATA.USER.COBRANZA_CBEntities())
			{
				var nom = db.Parametros.Where(s => s.ID == p).Select(s => s.Descripcion).FirstOrDefault();
				return nom ?? "";
			}
		}
		public List<KeyValuePair<int, string>> getTipeGestion()
		{
			using (var db = new DATA.USER.COBRANZA_CBEntities())
			{
				var lsita = db.TipoGestions.ToList();
				List<KeyValuePair<int, string>> l = new List<KeyValuePair<int, string>>();
				foreach (var item in lsita)
				{
					l.Add(new KeyValuePair<int, string>(item.tipoGestionID, item.Nombre));
				}
				return l;
			}

		}
		public List<KeyValuePair<int, string>> getCasualMora()
		{
			using (var db = new DATA.USER.COBRANZA_CBEntities())
			{
				var lsita = db.CausalMoras.ToList();
				List<KeyValuePair<int, string>> l = new List<KeyValuePair<int, string>>();
				foreach (var item in lsita)
				{
					l.Add(new KeyValuePair<int, string>(item.causalMoraID, item.Nombre));
				}
				return l;

			}

		}
		public List<KeyValuePair<int, string>> getProbalidadPago()
		{
			using (var db = new DATA.USER.COBRANZA_CBEntities())
			{
				var lsita = db.ProbalidadPagoes.ToList();
				List<KeyValuePair<int, string>> l = new List<KeyValuePair<int, string>>();
				foreach (var item in lsita)
				{
					l.Add(new KeyValuePair<int, string>(item.ID, item.Nombre));
				}
				return l;

			}

		}
		public List<KeyValuePair<int, string>> getParametros(int tipog)
		{
			using (var db = new DATA.USER.COBRANZA_CBEntities())
			{
				var lsita = db.Parametros.Where(x => x.TipoGestionId == tipog).ToList();
				List<KeyValuePair<int, string>> l = new List<KeyValuePair<int, string>>();
				foreach (var item in lsita)
				{
					l.Add(new KeyValuePair<int, string>(item.ID, item.Descripcion));
				}
				return l;

			}

		}
		public List<KeyValuePair<int, string>> getCompromiso()
		{
			using (var db = new DATA.USER.COBRANZA_CBEntities())
			{
				var lsita = db.CompromisoPagoes.ToList();
				List<KeyValuePair<int, string>> l = new List<KeyValuePair<int, string>>();
				foreach (var item in lsita)
				{
					l.Add(new KeyValuePair<int, string>(item.compromisoPagoID, item.Nombre));
				}
				return l;

			}

		}
	}
}
