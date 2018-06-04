using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CB.ENTIDADES
{
 public	class NotiPreventiva
	{
		public string CodCliente { get; set; }
		public string Nombre { get; set; }
		public string Codigo { get; set; }
		public int NroCuota { get; set; }
		public DateTime Fecha { get; set; }
		public double TotalCuota { get; set; }
		public int Accion { get; set; }
	}
}
