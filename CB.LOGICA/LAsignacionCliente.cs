using CB.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CB.LOGICA
{
	public class LAsignacionCliente
	{

		public List<AsignacionCliente> GetClientesAsignadosAll()
		{
			using (var db = new DATA.USER.COBRANZA_CBEntities())
			{
				try
				{
					List<AsignacionCliente> lista = new List<AsignacionCliente>();
					var items = db.AsignacionClientes.ToList();
					foreach (var item in items)
					{
						lista.Add(toEntidades(item));
					}
					return lista;
				}
				catch (Exception)
				{
					return null;
					throw;
				}
			}
		}

		public List<AsignacionCliente> GetClientesAsignadosAll(int id)
		{
			using (var db = new DATA.USER.COBRANZA_CBEntities())
			{
				try
				{
					List<AsignacionCliente> lista = new List<AsignacionCliente>();

					var items = db.AsignacionClientes.Where(s => s.CodUsuario.Value == id).ToList();
					foreach (var item in items)
					{
						lista.Add(toEntidades(item));
					}
					return lista;
				}
				catch (Exception ex)
				{
					throw new Exception("Logica", ex);
				}
			}
		}
		public bool add(AsignacionCliente o)
		{
			using (var db = new DATA.USER.COBRANZA_CBEntities())
			{

				using (var transation = db.Database.BeginTransaction())
				{
					try
					{
						var cout = 0;
						if (db.AsignacionClientes.Count() > 0)
						{
							cout = db.AsignacionClientes.Select(s => s.asignacionClienteID).Max();
						}

						DATA.USER.AsignacionCliente cl = new DATA.USER.AsignacionCliente()
						{
							asignacionClienteID = cout + 1,
							CodCliente = o.CodCliente,
							Codigo = o.codigo,
							CodUsuario = o.CodUsuario,
							FechaAsignacion = o.FechaAsignacion,
							FechaMod = o.FechaMod,
							FeCre = o.FeCre,
							UsrCre = o.UsrCre,
							UsrMod = o.UsrMod,
							Estado = o.Estado,
							Periodo = o.Periodo,
							FechaReasignacion = o.FechaReasignacion
						};
						db.AsignacionClientes.Add(cl);
						db.SaveChanges();
						transation.Commit();
						return true;
					}
					catch (Exception ex)
					{
						transation.Rollback();
						throw new Exception("Logica", ex);
					}
				}
			}
		}
		public bool Edit(AsignacionCliente o)
		{
			using (var db = new DATA.USER.COBRANZA_CBEntities())
			{

				using (var transation = db.Database.BeginTransaction())
				{
					try
					{
						DATA.USER.AsignacionCliente cl = new DATA.USER.AsignacionCliente()
						{
							asignacionClienteID = o.asignacionClienteID,
							CodCliente = o.CodCliente,
							CodUsuario = o.CodUsuario,
							FechaAsignacion = o.FechaAsignacion,
							FechaMod = o.FechaMod,
							FeCre = o.FeCre,
							UsrCre = o.UsrCre,
							UsrMod = o.UsrMod

						};
						db.Entry(cl).State = EntityState.Modified;
						db.SaveChanges();
						transation.Commit();
						return true;
					}
					catch (Exception ex)
					{
						transation.Rollback();
						throw new Exception("Logica", ex);
					}
				}
			}
		}
		public AsignacionCliente toEntidades(DATA.USER.AsignacionCliente o)
		{
			return new AsignacionCliente()
			{
				asignacionClienteID = o.asignacionClienteID,
				CodCliente = o.CodCliente,
				CodUsuario = o.CodUsuario.Value,
				NombreCliente = sacarCl(o.CodCliente),
				NombreUsario = sacarCod(o.CodUsuario),
				FechaAsignacion = o.FechaAsignacion.Value,
				FechaMod = o.FechaMod.Value,
				FeCre = o.FeCre.Value,
				UsrCre = o.UsrCre,
				UsrMod = o.UsrMod
			};
		}

		private string sacarCod(int? nullable)
		{
			try
			{
				using (var db = new DATA.USER.COBRANZA_CBEntities())
				{
					var resp = db.Usuarios.Where(x => x.UsuarioID == nullable).FirstOrDefault();
					return resp != null ? resp.UsuarioNombre + " " + resp.UsuarioApellido1 : null;
				}
			}
			catch (Exception ex)
			{

				throw new Exception("Logica", ex);
			}
		}

		private string sacarCl(string p)
		{
			try
			{
				using (var db = new DATA.INVENTARIO.INVENTARIO_CONSTRUCTORA_OBELISCOEntities())
				{
					var resp = db.Personas.Where(x => x.CodCliente == p).FirstOrDefault();
					return resp != null ? resp.NombreP + " " + resp.Apellido : null;
				}
			}
			catch (Exception ex)
			{

				throw new Exception("Logica", ex);
			}
		}
		public int CountCleintsAsignados()
		{
			return 0;
		}


	}
}
