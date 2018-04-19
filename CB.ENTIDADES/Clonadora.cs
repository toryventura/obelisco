﻿using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace CB.ENTIDADES
{
	public class Clonadora
	{
		public static T Clonar<T>(T fuente)
		{
			//Verificamos que sea serializable antes de hacer la copia
			if (!typeof(T).IsSerializable)
			{
				throw new ArgumentException("El tipo de dato debe ser serializable.", "fuente");
			}
			if (Object.ReferenceEquals(fuente, null))
			{
				return default(T);
			}
			//Creamos un stream en memoria
			IFormatter formatter = new BinaryFormatter();
			Stream stream = new MemoryStream();
			using (stream)
			{
				formatter.Serialize(stream, fuente);
				stream.Seek(0, SeekOrigin.Begin);
				//Deserializamos la porcón de memoria en el nuevo objeto
				return (T)formatter.Deserialize(stream);
			}
		}
	}
}
