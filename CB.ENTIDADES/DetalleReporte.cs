using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CB.ENTIDADES
{
	public class DetalleReporte
	{
		public int asignacionClienteID { get; set; }
		public string CodCliente { get; set; }
		public string NombreCompleto { get; set; }
		public string Codigo { get; set; }
		public Nullable<int> CodUsuario { get; set; }
		public string NombreCobrador { get; set; }
		public int operacionCobranzaID { get; set; }
		public string Comentario { get; set; }
		public string TelefonoAlternativo { get; set; }
		public string FechaCompromiso { get; set; }
		public string FeCre { get; set; }
		public string FeMod { get; set; }
		public string UsrCre { get; set; }
		public string UsrMod { get; set; }
		public string NombreCuasalMora { get; set; }
		public string NombreCompromisopago { get; set; }
		public string NombreProbalidadPago { get; set; }
		public string NombreParametro { get; set; }
		public string NombreTipoGestion { get; set; }
		public string Periodo { get; set; }
	}
}
