
namespace CB.ENTIDADES
{
	public class Parametro
	{
		public int ID { get; set; }
		public string Descripcion { get; set; }
		public int TipoGestionId { get; set; }

		public virtual TipoGestion TipoGestion { get; set; }
	}
}
