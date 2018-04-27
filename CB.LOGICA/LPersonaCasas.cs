
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
						lista.Add(toEntides(item));
					}
					return lista;
				}
			}
			catch (Exception ex)
			{

				throw new Exception("Logica", ex);
			}

		}
		public PersonaCasas GetClienteXID(string id = "")
		{
			using (var db = new DATA.INVENTARIO.INVENTARIO_CONSTRUCTORA_OBELISCOEntities())
			{
				var persona = db.Personas.Where(s => s.CodCliente == id).FirstOrDefault();

				return persona == null ? new PersonaCasas() : toEntides(persona);
			}
		}
		public List<PersonaCasas> GetClienteAllMoraNoAsignados()
		{
			var db = new DATA.INVENTARIO.INVENTARIO_CONSTRUCTORA_OBELISCOEntities();
			var db1 = new DATA.USER.COBRANZA_CBEntities();
			try
			{
				var _listAsiganado = db1.AsignacionClientes.Where(x => x.Estado == true).Select(w => w.CodCliente).ToList();


				var listamoras = db.actualizarMoraDarias.Select(x => x.CodCliente).Distinct().ToList();
				var moras = db.CantidadClienteMoras.ToList();

				var personas = db.Personas.ToList();
				var listasfinal = new List<PersonaCasas>();
				foreach (var item in personas)
				{
					listasfinal.Add(toEntides(item));
				}
				var personasfinal = listasfinal.Where(x => listamoras.Contains(x.CodCliente)).ToList();
				if (_listAsiganado.Count > 0)
				{
					var _listFinal = personasfinal.Where(s => !_listAsiganado.Contains(s.CodCliente)).ToList();
					return _listFinal;
				}
				else
				{
					return personasfinal;
				}



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
				var _listAsiganado = db1.AsignacionClientes.Where(x => x.CodUsuario == id && x.Estado == true).Select(w => w.CodCliente).ToList();

				var personas = db.Personas.ToList();
				var listasfinal = new List<PersonaCasas>();
				foreach (var item in personas)
				{
					listasfinal.Add(toEntides(item));
				}
				var personasfinal = listasfinal.Where(x => _listAsiganado.Contains(x.CodCliente)).ToList();
				if (personasfinal.Count > 0)
				{
					return personasfinal;
				}
				return null;

			}
			catch (Exception ex)
			{
				throw new Exception("Logica", ex);

			}



		}

		public PersonaCasas toEntides(DATA.INVENTARIO.Persona s)
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
				clave = s.clave == null ? "" : s.clave,
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
				NomCorto = s.NomCorto == null ? "" : s.NomCorto,
				RevisaOCompra = s.RevisaOCompra,
				Seg_Apellido = s.Seg_Apellido == null ? "" : s.Seg_Apellido,
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
