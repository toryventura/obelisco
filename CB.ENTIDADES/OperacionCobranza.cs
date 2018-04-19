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
		public int asignacionClienteID { get; set; }
		public int causalMoraID { get; set; }

		public int compromisoPagoID { get; set; }

		public string compromisoPago { get; set; }
		public int tipoGestionID { get; set; }

		public string nombretipogetion { get; set; }
		public int presenciaClienteID { get; set; }
		public string nombrepresencia { get; set; }
		public int probalidadPagoID { get; set; }

		public string nombreprobalidadPago { get; set; }

	}
}
