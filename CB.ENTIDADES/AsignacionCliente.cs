using System;

namespace CB.ENTIDADES
{
	public class AsignacionCliente
	{
		public int asignacionClienteID { get; set; }
		public string CodCliente { get; set; }
		public DateTime FechaAsignacion { get; set; }
		public string NombreCliente { get; set; }
		public string NombreUsario { get; set; }
		public string UsrCre { get; set; }
		public string UsrMod { get; set; }
		public DateTime FeCre { get; set; }
		public DateTime FechaMod { get; set; }
		public int CodUsuario { get; set; }
		public bool Estado { get; set; }
		public DateTime FechaReasignacion { get; set; }
		public virtual Usuario Usuario { get; set; }
		public string Periodo { get; set; }
	}
}
