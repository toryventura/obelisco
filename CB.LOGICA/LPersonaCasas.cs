
using CB.DATA.INVENTARIO;
using CB.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
namespace CB.LOGICA
{
	public class LPersonaCasas
	{
		public List<PersonaCasas> GetClienteAll()
		{
			try
			{
				using (var db = new DATA.INVENTARIO.INVENTARIO_CONSTRUCTORA_OBELISCOEntities())
				{
					List<PersonaCasas> lista = new List<PersonaCasas>();
					var lis = (from s in db.Personas
							   where s.EsCajero == -1 || s.EsVendedor == -1 || s.EsAlmacenero == -1
							   select s).ToList();
					foreach (var item in lis)
					{
						lista.Add(ToEntides(item));
					}
					return lista;
				}
			}
			catch (Exception ex)
			{

				throw new Exception("Logica", ex);
			}

		}
		public List<DetalleFase> GetClientesAlDia()
		{
			try
			{
				using (var db = new DATA.INVENTARIO.INVENTARIO_CONSTRUCTORA_OBELISCOEntities())
				{
					var list = (from x in db.spt_DetalleClienteAlDia()
								select new DetalleFase()
								{
									CantidadCouta = x.CantidadCouta,
									CodCliente = x.CodCliente,
									Codigo = x.Codigo,
									CodMora = x.CodMora,
									Fecha = x.Fecha.ToString("dd/MM/yyyy"),
									MontoCuota = x.MontoCuota.Value,
									NombreCompleto = x.NombreCompleto,
									NroCuota = x.NroCuota + "/" + x.NroCuotas,
									SaldoCuota = Math.Round(x.SaldoCuota.Value, 2),
									Telefono = x.Telefono,
									NroCuotas = x.NroCuotas,
									Tc = x.Tc.Value

								}).ToList();
					return list;
				}
			}
			catch (Exception ex)
			{

				throw new Exception("Logica:GetNotiPreventivas ", ex);
			}
		}

		public dynamic CantidadSinMora()
		{
			try
			{
				using (var db = new DATA.INVENTARIO.INVENTARIO_CONSTRUCTORA_OBELISCOEntities())
				{
					var count = db.Vwt_ClienteAlDia.Count();
					return count;
				}
			}
			catch (Exception ex)
			{

				throw new Exception("", ex);
			}
			throw new NotImplementedException();
		}

		public List<DetalleFase> GetNotiPreventivas(int dias)
		{
			try
			{
				using (var db = new DATA.INVENTARIO.INVENTARIO_CONSTRUCTORA_OBELISCOEntities())
				{
					var list = (from x in db.spt_NotificacionPreventiva(dias)
								select new DetalleFase()
								{
									CantidadCouta = x.CantidadCouta.Value,
									CodCliente = x.CodCliente,
									Codigo = x.Codigo,
									CodMora = x.CodMora,
									Fecha = x.Fecha.Value.ToString("dd/MM/yyyy"),
									MontoCuota = x.MontoCuota.Value,
									NombreCompleto = x.NombreCompleto,
									NroCuota = x.NroCuota.Value + "/" + x.NroCuotas.Value,
									SaldoCuota =Math.Round( x.SaldoCuota.Value,2),
									Telefono = x.Telefono,
									NroCuotas = x.NroCuotas.Value,
									Tc = x.Tc.Value

								}).ToList();
					return list;
				}
			}
			catch (Exception ex)
			{

				throw new Exception("Logica:GetNotiPreventivas ", ex);
			}
		}

		public List<DetalleFase> GetNotiPreventivasXFecha(DateTime dateTime)
		{
			try
			{
				using (var db = new DATA.INVENTARIO.INVENTARIO_CONSTRUCTORA_OBELISCOEntities())
				{
					var list = (from x in db.spt_NotificacionPreventivaXFecha(dateTime)
								select new DetalleFase()
								{
									CantidadCouta = x.CantidadCouta.Value,
									CodCliente = x.CodCliente,
									Codigo = x.Codigo,
									CodMora = x.CodMora,
									Fecha = x.Fecha.Value.ToString("dd/MM/yyyy"),
									MontoCuota = x.MontoCuota.Value,
									NombreCompleto = x.NombreCompleto,
									NroCuota = x.NroCuota.Value + "/" + x.NroCuotas.Value,
									SaldoCuota = Math.Round( x.SaldoCuota.Value,2),
									Telefono = x.Telefono,
									NroCuotas = x.NroCuotas.Value,
									Tc = x.Tc.Value

								}).ToList();
					return list;
				}
			}
			catch (Exception ex)
			{

				throw new Exception("Logica:GetNotiPreventivas ", ex);
			}
		}

		public PersonaCasas GetClienteXID(string id = "")
		{
			using (var db = new DATA.INVENTARIO.INVENTARIO_CONSTRUCTORA_OBELISCOEntities())
			{
				var persona = db.Personas.Where(s => s.CodCliente == id).FirstOrDefault();

				return persona == null ? new PersonaCasas() : ToEntides(persona);
			}
		}
		public List<PersonaCasas> GetClienteAllMoraNoAsignados()
		{
			var db = new DATA.INVENTARIO.INVENTARIO_CONSTRUCTORA_OBELISCOEntities();
			var db1 = new DATA.USER.COBRANZA_CBEntities();
			try
			{
				var _listAsiganado = db1.AsignacionClientes.Where(x => x.Estado == true).Select(w => w.Codigo).ToList();
				var moras = (from x in db.Vwt_CantidadClienteMora select x).ToList();
				var _listmoras = moras.Where(x => !_listAsiganado.Contains(x.Codigo)).Select(w => w.Codigo).ToList();
				var cta = db.CtaPorCobrars.Where(s => s.TipoCtaPorCobrar == 5).ToList();
				var lista_cta = cta.Where(j => _listmoras.Contains(j.Codigo)).ToList();
				var listasfinal = new List<PersonaCasas>();
				foreach (var item in lista_cta)
				{
					var per = db.Personas.Where(h => h.CodCliente == item.CodCliente).FirstOrDefault();
					if (per != null)
					{
						var cat = moras.Where(s => s.Codigo == item.Codigo).Select(s => s.CantidadCouta).FirstOrDefault();
						listasfinal.Add(ToEntides(per, item.Codigo, cat));
					}

				}
				return listasfinal;


			}
			catch (Exception ex)
			{
				throw new Exception("Logica", ex);
			}
		}

		private PersonaCasas ToEntides(Persona s, string codigo, int? cat)
		{
			return new PersonaCasas()
			{
				Apellido = s.Apellido,
				AutorizaCotizacion = s.AutorizaCotizacion,
				AutorizaOCompra = s.AutorizaOCompra,
				AutorizaPedido = s.AutorizaPedido,
				Ccosto = s.Ccosto,
				CI = s.CI,
				Ciudad = s.Ciudad,
				clave = s.clave ?? "",
				CodCliente = s.CodCliente,
				CodCuenta = s.CodCuenta,
				CodEstado = s.CodEstado == null ? -99 : s.CodEstado.Value,
				CodSubcc = s.CodSubcc,
				Consolidado = s.Consolidado,
				Contacto = s.Contacto,
				Correo = s.Correo,
				DiasCredito = s.DiasCredito,
				DireccionDomicilio = s.DireccionDomicilio,
				DireccionTrabajo = s.DireccionTrabajo,
				EmiteFactura = s.EmiteFactura,
				EsAlmacenero = s.EsAlmacenero,
				EsCajero = s.EsCajero,
				EsCliente = s.EsCliente,
				EsProveedor = s.EsProveedor,
				EstadoCivil = s.EstadoCivil,
				EsUsuario = s.EsUsuario,
				EsVendedor = s.EsVendedor,
				EsVendedorF = s.EsVendedorF,
				Fax = s.Fax,
				FechaReg = s.FechaReg,
				IdArea = s.IdArea,
				LimiteCredito = s.LimiteCredito,
				NIT = s.NIT,
				NombreFactura = s.NombreFactura,
				NombreP = s.NombreP,
				NomCorto = s.NomCorto ?? "",
				RevisaOCompra = s.RevisaOCompra,
				Seg_Apellido = s.Seg_Apellido ?? "",
				Sexo = s.Sexo,
				SolicitaOCompra = s.SolicitaOCompra,
				SolicitaPedido = s.SolicitaPedido,
				Telefono = s.Telefono,
				TipoPrecio = s.TipoPrecio,
				UsuaReg = s.UsuaReg,
				Vendedor = s.Vendedor,
				Codigo = codigo,
				CantidadCouta = cat.Value

			};
		}

		private PersonaCasas ToEntides(DATA.INVENTARIO.Persona s, string p)
		{
			return new PersonaCasas()
			{
				Apellido = s.Apellido,
				AutorizaCotizacion = s.AutorizaCotizacion,
				AutorizaOCompra = s.AutorizaOCompra,
				AutorizaPedido = s.AutorizaPedido,
				Ccosto = s.Ccosto,
				CI = s.CI,
				Ciudad = s.Ciudad,
				clave = s.clave ?? "",
				CodCliente = s.CodCliente,
				CodCuenta = s.CodCuenta,
				CodEstado = s.CodEstado == null ? -99 : s.CodEstado.Value,
				CodSubcc = s.CodSubcc,
				Consolidado = s.Consolidado,
				Contacto = s.Contacto,
				Correo = s.Correo,
				DiasCredito = s.DiasCredito,
				DireccionDomicilio = s.DireccionDomicilio,
				DireccionTrabajo = s.DireccionTrabajo,
				EmiteFactura = s.EmiteFactura,
				EsAlmacenero = s.EsAlmacenero,
				EsCajero = s.EsCajero,
				EsCliente = s.EsCliente,
				EsProveedor = s.EsProveedor,
				EstadoCivil = s.EstadoCivil,
				EsUsuario = s.EsUsuario,
				EsVendedor = s.EsVendedor,
				EsVendedorF = s.EsVendedorF,
				Fax = s.Fax,
				FechaReg = s.FechaReg,
				IdArea = s.IdArea,
				LimiteCredito = s.LimiteCredito,
				NIT = s.NIT,
				NombreFactura = s.NombreFactura,
				NombreP = s.NombreP,
				NomCorto = s.NomCorto ?? "",
				RevisaOCompra = s.RevisaOCompra,
				Seg_Apellido = s.Seg_Apellido ?? "",
				Sexo = s.Sexo,
				SolicitaOCompra = s.SolicitaOCompra,
				SolicitaPedido = s.SolicitaPedido,
				Telefono = s.Telefono,
				TipoPrecio = s.TipoPrecio,
				UsuaReg = s.UsuaReg,
				Vendedor = s.Vendedor,
				Codigo = p

			};
		}
		public List<PersonaCasas> GetClienteAllMoraNoAsignados(int fase)
		{
			var db = new DATA.INVENTARIO.INVENTARIO_CONSTRUCTORA_OBELISCOEntities();
			var db1 = new DATA.USER.COBRANZA_CBEntities();
			try
			{

				List<string> moras = new List<string>();
				if (fase == 5)
				{

					moras = (from x in db.Vwt_CantidadClienteMora
							 join s in db.CtaPorCobrars on x.Codigo equals s.Codigo
							 where x.CantidadCouta >= fase
							 select s.CodCliente).ToList();
				}
				else
				{
					moras = (from x in db.Vwt_CantidadClienteMora
							 join s in db.CtaPorCobrars on x.Codigo equals s.Codigo
							 where x.CantidadCouta == fase
							 select s.CodCliente).ToList();
				}
				var personas = db.Personas.ToList();
				var listasfinal = new List<PersonaCasas>();
				foreach (var item in personas)
				{
					listasfinal.Add(ToEntides(item));
				}
				var personasfinal = listasfinal.Where(x => moras.Contains(x.CodCliente)).ToList();

				return personasfinal;
			}
			catch (Exception ex)
			{
				throw new Exception("Logica", ex);
			}
		}
		public List<DetalleFase> GetClienteMoraDetalleXFase(int fase)
		{
			var db = new DATA.INVENTARIO.INVENTARIO_CONSTRUCTORA_OBELISCOEntities();

			try
			{
				List<DetalleFase> detalleFases = new List<DetalleFase>();
				var listDetalle = db.sp_GetClienteMoraDetalleXFase(fase);
				foreach (var item in listDetalle)
				{
					detalleFases.Add(new DetalleFase()
					{
						CantidadCouta = item.CantidadCouta.Value,
						CodCliente = item.CodCliente,
						Codigo = item.Codigo,
						CodMora = item.CodMora,
						Fecha = item.Fecha.ToString("dd/MM/yyyy"),
						MontoCuota = item.MontoCuota,
						NombreCompleto = item.NombreCompleto,
						NroCuota = item.NroCuota + "/" + item.NroCuotas,
						SaldoCuota = Math.Round( item.SaldoCuota.Value,2),
						Telefono = item.Telefono,
						NroCuotas = item.NroCuotas,
						Tc = item.Tc.Value
					});
				}

				return detalleFases;
			}
			catch (Exception ex)
			{
				throw new Exception("Logica", ex);
			}
		}
		public int CantidadclienteNoasignados(string periodo)
		{
			var db = new DATA.INVENTARIO.INVENTARIO_CONSTRUCTORA_OBELISCOEntities();
			var db1 = new DATA.USER.COBRANZA_CBEntities();
			try
			{
				var _listAsiganado = db1.AsignacionClientes.Where(x => (x.Periodo == periodo && x.Estado == true)).Count();
				var _cantidamoras = db.Vwt_CantidadClienteMora.Count();
				var cta = _listAsiganado != 0 && _cantidamoras != 0 ? _cantidamoras - _listAsiganado : 0;

				return cta;

			}
			catch (Exception ex)
			{
				throw new Exception("Logica", ex);
			}
		}
		public int CantidadclienteAsignados(string periodo)
		{

			var db1 = new DATA.USER.COBRANZA_CBEntities();
			try
			{
				var _listAsiganado = db1.AsignacionClientes.Where(x => (x.Periodo == periodo && x.Estado == true)).Count();

				var cta = _listAsiganado != 0 ? _listAsiganado : 0;

				return cta;

			}
			catch (Exception ex)
			{
				throw new Exception("Logica", ex);
			}
		}
		public List<PersonaCasas> GetClienteAllMoraXuser(long id = 0)
		{
			var db = new DATA.INVENTARIO.INVENTARIO_CONSTRUCTORA_OBELISCOEntities();
			var db1 = new DATA.USER.COBRANZA_CBEntities();

			try
			{
				var _listAsiganado = db1.AsignacionClientes.Where(x => x.CodUsuario == id && x.Estado == true).ToList();
				var moras = (from x in db.Vwt_CantidadClienteMora select x).ToList();
				var listasfinal = new List<PersonaCasas>();
				ENTIDADES.PersonaCasas obj;
				foreach (var item in _listAsiganado)
				{
					var p = db.Personas.Where(s => s.CodCliente == item.CodCliente).FirstOrDefault();
					var cm = moras.Where(x => x.Codigo == item.Codigo).Select(x => x.CantidadCouta).FirstOrDefault();
					obj = ToEntides(p, item.Codigo, cm);
					if (cm < 5)
					{
						obj.NombreFase = db1.Fases.Where(j => j.ID == cm+1).Select(j => j.Descripcion).FirstOrDefault();
					}
					else {
						obj.NombreFase = "Fase 5";
					}
					//obj.IdFase = db1.FaseUsuarios.Where(x => x.Idusuario == obj.CI).Select(x => x.Idfase.Value).FirstOrDefault();
					//obj.NombreFase = GetNombreFase(obj.IdFase);
					listasfinal.Add(obj);
				}
				return listasfinal;
				
			}
			catch (Exception ex)
			{
				throw new Exception("Logica", ex);

			}
		}
		public PersonaCasas ToEntides(DATA.INVENTARIO.Persona s)
		{
			return new PersonaCasas()
			{
				Apellido = s.Apellido,
				AutorizaCotizacion = s.AutorizaCotizacion,
				AutorizaOCompra = s.AutorizaOCompra,
				AutorizaPedido = s.AutorizaPedido,
				Ccosto = s.Ccosto,
				CI = s.CI,
				Ciudad = s.Ciudad,
				clave = s.clave ?? "",
				CodCliente = s.CodCliente,
				CodCuenta = s.CodCuenta,
				CodEstado = s.CodEstado == null ? -99 : s.CodEstado.Value,
				CodSubcc = s.CodSubcc,
				Consolidado = s.Consolidado,
				Contacto = s.Contacto,
				Correo = s.Correo,
				DiasCredito = s.DiasCredito,
				DireccionDomicilio = s.DireccionDomicilio,
				DireccionTrabajo = s.DireccionTrabajo,
				EmiteFactura = s.EmiteFactura,
				EsAlmacenero = s.EsAlmacenero,
				EsCajero = s.EsCajero,
				EsCliente = s.EsCliente,
				EsProveedor = s.EsProveedor,
				EstadoCivil = s.EstadoCivil,
				EsUsuario = s.EsUsuario,
				EsVendedor = s.EsVendedor,
				EsVendedorF = s.EsVendedorF,
				Fax = s.Fax,
				FechaReg = s.FechaReg,
				IdArea = s.IdArea,
				LimiteCredito = s.LimiteCredito,
				NIT = s.NIT,
				NombreFactura = s.NombreFactura,
				NombreP = s.NombreP,
				NomCorto = s.NomCorto ?? "",
				RevisaOCompra = s.RevisaOCompra,
				Seg_Apellido = s.Seg_Apellido ?? "",
				Sexo = s.Sexo,
				SolicitaOCompra = s.SolicitaOCompra,
				SolicitaPedido = s.SolicitaPedido,
				Telefono = s.Telefono,
				TipoPrecio = s.TipoPrecio,
				UsuaReg = s.UsuaReg,
				Vendedor = s.Vendedor

			};
		}
	}

}
