using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CB.ENTIDADES;

namespace CB.LOGICA
{
	public class LReporte
	{
		public List<DetalleReporte> GetReporteOperaciones()
		{
			try
			{
				using (var db = new DATA.USER.COBRANZA_CBEntities())
				{
					var fr = (from s in db.sp_ReporteOperaciones()
							  select new DetalleReporte
							  {
								  asignacionClienteID = s.asignacionClienteID,
								  CodCliente = s.CodCliente,
								  Codigo = s.Codigo,
								  CodUsuario = s.CodUsuario.Value,
								  Comentario = s.Comentario,
								  FechaCompromiso = s.FechaCompromiso==null?"": s.FechaCompromiso.Value.ToString("dd/MM/yyyy HH:mm"),
								  FeCre = s.FeCre==null?"": s.FeCre.Value.ToString("dd/MM/yyyy HH:mm"),
								  FeMod = s.FeMod == null ? "" : s.FeMod.Value.ToString("dd/MM/yyyy HH:mm"),
								  NombreCobrador = s.NombreCobrador,
								  NombreCompleto = s.NombreCompleto,
								  NombreCompromisopago = s.NombreCompromisopago,
								  NombreCuasalMora = s.NombreCuasalMora,
								  NombreParametro = s.NombreParametro,
								  NombreProbalidadPago = s.NombreProbalidadPago,
								  NombreTipoGestion = s.NombreTipoGestion,
								  operacionCobranzaID = s.operacionCobranzaID,
								  Periodo = s.Periodo,
								  TelefonoAlternativo = s.TelefonoAlternativo,
								  UsrCre = s.UsrCre,
								  UsrMod = s.UsrMod
							  }).ToList();
					return fr;
				}
			}
			catch (Exception ex)
			{

				throw new Exception("Logiaca:GetReporteOperaciones", ex);
			}

		}
	}
}
