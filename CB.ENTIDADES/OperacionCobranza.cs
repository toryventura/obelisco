using System;


namespace CB.ENTIDADES
{
	public class OperacionCobranza
	{
		public int operacionCobranzaID { get; set; }
		public string Comentario { get; set; }
		public string TelefonoAlternativo { get; set; }
		public string FechaCompromiso { get; set; }
		public string CausalMoraAnt { get; set; }
		public DateTime FeCre { get; set; }
		public DateTime FeMod { get; set; }
		public string UsrCre { get; set; }
		public string UsrMod { get; set; }
		public int AsignacionClienteID { get; set; }
		public int CausalMoraID { get; set; }
		public string NombreCausal { get; set; }
		public int CompromisoPagoID { get; set; }
		public bool activo { get; set; }
		public string compromisoPago { get; set; }
		public int parametroID { get; set; }

		public string nombreparametro { get; set; }
		public int presenciaClienteID { get; set; }
		public string nombrepresencia { get; set; }
		public int probalidadPagoID { get; set; }

		public string nombreprobalidadPago { get; set; }

	}
}
