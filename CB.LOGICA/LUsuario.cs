using CB.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
namespace CB.LOGICA
{
	public class LUsuario
	{
		public static Usuario IniciarSesion(string login, string contrasena)
		{
			try
			{
				using (var BD = new DATA.USER.COBRANZA_CBEntities())
				{

					var usr = BD.Usuarios.FirstOrDefault(x => x.UsuarioLogin == login && x.UsuarioContrasena == contrasena);
					if (usr == null)
					{
						throw new Exception("Usuario y/o contraseña inválida");
					}
					if (usr.UsuarioHabilitado == false)
					{
						throw new Exception("El usuario no tiene acceso al sistema");
					}
					var lr = LUsuario.DataToEntidad(usr, false);
					return lr;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public static bool add(ENTIDADES.Usuario us)
		{
			using (var db = new DATA.USER.COBRANZA_CBEntities())
			{
				using (var trx = db.Database.BeginTransaction())
				{
					try
					{

						var usu = new DATA.USER.Usuario()
						{
							UsuarioApellido1 = us.Apellido1,
							UsuarioApellido2 = us.Apellido2,
							UsuarioContrasena = us.Contrasena,
							UsuarioCambiarContrasena = us.CambiarContrasena,
							UsuarioEmail = us.Email,
							UsuarioEsSuperAdmin = us.EsSuperAdmin,
							UsuarioHabilitado = us.Habilitado,
							UsuarioLogin = us.Login,
							UsuarioNombre = us.Nombre,
							UsuarioTelefono = us.Telefono,
							UsuarioID = Convert.ToInt32(us.ID)
						};

						db.Usuarios.Add(usu);
						var fu = new DATA.USER.FaseUsuario()
						{
							Idfase = us.IdFase,
							Idusuario = Convert.ToInt32(us.ID)

						};
						db.FaseUsuarios.Add(fu);
						db.SaveChanges();
						trx.Commit();
						return true;
					}
					catch (Exception)
					{
						trx.Rollback();
						return false;

					}
				}


			}
		}
		public static bool update(ENTIDADES.Usuario us)
		{
			using (var db = new DATA.USER.COBRANZA_CBEntities())
			{
				try
				{

					var usu = new DATA.USER.Usuario()
					{
						UsuarioApellido1 = us.Apellido1,
						UsuarioApellido2 = us.Apellido2,
						UsuarioContrasena = us.Contrasena,
						UsuarioCambiarContrasena = us.CambiarContrasena,
						UsuarioEmail = us.Email,
						UsuarioEsSuperAdmin = us.EsSuperAdmin,
						UsuarioHabilitado = us.Habilitado,
						UsuarioLogin = us.Login,
						UsuarioNombre = us.Nombre,
						UsuarioTelefono = us.Nombre,
						UsuarioID = Convert.ToInt32(us.ID)
					};

					db.Usuarios.Add(usu);
					db.SaveChanges();
					return true;
				}
				catch (Exception)
				{
					return false;

				}

			}
		}
		public static bool delet(ENTIDADES.Usuario us)
		{
			return false;
		}
		public static bool add(ENTIDADES.Usuario us, int perfrilid, int faseid)
		{
			try
			{
				using (var db = new DATA.USER.COBRANZA_CBEntities())
				{
					using (var trx = db.Database.BeginTransaction())
					{
						var perfil = db.Perfils.Find(perfrilid);
						var usu = new DATA.USER.Usuario()
						{
							UsuarioApellido1 = us.Apellido1,
							UsuarioApellido2 = us.Apellido2,
							UsuarioContrasena = us.Contrasena,
							UsuarioCambiarContrasena = us.CambiarContrasena,
							UsuarioEmail = us.Email,
							UsuarioEsSuperAdmin = us.EsSuperAdmin,
							UsuarioHabilitado = us.Habilitado,
							UsuarioLogin = us.Login,
							UsuarioNombre = us.Nombre,
							UsuarioTelefono = us.Nombre,
							UsuarioID = Convert.ToInt32(us.ID),

						};
						usu.Perfils.Add(perfil);
						db.Usuarios.Add(usu);
						var fu = new DATA.USER.FaseUsuario()
						{
							Idfase = us.IdFase,
							Idusuario = Convert.ToInt32(us.ID)

						};
						db.FaseUsuarios.Add(fu);
						db.SaveChanges();
						trx.Commit();

						return true;
					}
				}

			}
			catch (Exception ex)
			{

				throw new Exception("Logica add", ex);
			}


		}
		public static List<CB.ENTIDADES.Usuario> toListaUsuario()
		{
			using (var db = new DATA.USER.COBRANZA_CBEntities())
			{
				var _list = db.Usuarios.ToList();
				List<CB.ENTIDADES.Usuario> _listfinal = new List<Usuario>();
				ENTIDADES.Usuario obj;
				foreach (var item in _list)
				{

					obj = DataToEntidad(item);
					obj.IdFase = db.FaseUsuarios.Where(x => x.Idusuario == obj.ID).Select(x => x.Idfase.Value).FirstOrDefault();
					obj.NombreFase = GetNombreFase(obj.IdFase);
					_listfinal.Add(obj);
				}
				return _listfinal;
			}
			;
		}
		public static List<CB.ENTIDADES.Usuario> toListUsuariosParaAsignar()
		{
			using (var db = new DATA.USER.COBRANZA_CBEntities())
			{
				var _list = db.Usuarios.ToList();
				List<CB.ENTIDADES.Usuario> _listfinal = new List<Usuario>();
				ENTIDADES.Usuario obj;
				foreach (var item in _list)
				{
					obj = DataToEntidad(item);
					obj.IdFase = db.FaseUsuarios.Where(x => x.Idusuario == obj.ID).Select(x => x.Idfase.Value).FirstOrDefault();
					obj.NombreFase = GetNombreFase(obj.IdFase);
					_listfinal.Add(obj);
				}
				return _listfinal;
			}
			;
		}

		private static string GetNombreFase(int idFase)
		{
			try
			{
				using (var db= new DATA.USER.COBRANZA_CBEntities())
				{
					var fase = db.Fases.Where(s => s.ID == idFase).Select(s => s.Descripcion).FirstOrDefault();
					return fase;
				}
			}
			catch (Exception ex)
			{

				throw new Exception("Logica:GetnombreFase", ex);
			}
		}

		public static CB.ENTIDADES.Usuario DataToEntidad(DATA.USER.Usuario d, bool Listado = true)
		{
			var perfiles = new List<CB.ENTIDADES.Perfil>();
			var permisos = new List<CB.ENTIDADES.Permiso>();

			if (!Listado)
			{
				foreach (var p in d.Perfils)
				{
					perfiles.Add(LPerfil.DataToEntidad(p, false));
				}
				foreach (var p in d.Permisoes)
				{
					permisos.Add(LPermiso.DataToEntidad(p, false));
				}

			}
			else
			{
				foreach (var p in d.Perfils)
				{
					perfiles.Add(LPerfil.DataToEntidad(p, true));
				}
			}
			return new CB.ENTIDADES.Usuario()
			{
				Apellido1 = d.UsuarioApellido1,
				Apellido2 = d.UsuarioApellido2,
				Contrasena = "",
				Email = d.UsuarioEmail, 
				EsSuperAdmin = d.UsuarioEsSuperAdmin.Value,
				Habilitado = d.UsuarioHabilitado.Value,
				ID = d.UsuarioID,
				Login = d.UsuarioLogin,
				Nombre = d.UsuarioNombre,
				Perfiles = perfiles,
				Permisos = permisos,
				Telefono = d.UsuarioTelefono,
				CambiarContrasena = d.UsuarioCambiarContrasena.Value
				

			};
		}
	}
}
