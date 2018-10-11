using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CB.ENTIDADES
{
	public class Alertas
	{
		public string CodCliente { get; set; }
		public string Nombre { get; set; }
		public int AsignacionClienteId { get; set; }
		public string Descripcion { get; set; }
		public DateTime FechaCompromiso { get; set; }
	}
}
