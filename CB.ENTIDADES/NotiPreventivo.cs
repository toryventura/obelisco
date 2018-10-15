using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CB.ENTIDADES
{
	public class NotiPreventivo
	{
		public int NotificacionID { get; set; }
		public string CodCliente { get; set; }
		public string Periodo { get; set; }
		public string Mensaje { get; set; }
		public int TipoAccion { get; set; }
		public string Nombre { get; set; }
		public DateTime FechaReg { get; set; }
		public string UsrCre { get; set; }
	}
}
