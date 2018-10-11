using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CB.BACKOFICEOFICIAL.Models
{
	public class MNotificacion
	{
		public string CodCliente { get; set; }
		public string Nombre { get; set; }
		public string Telefono { get; set; }
		public int Tipo { get; set; }
		public string Massage { get; set; }
		public List<CB.ENTIDADES.DetalleFase> Detalles { get; set; }
		public List<KeyValuePair<int, string>> Tipos { get; set; }
	}
}