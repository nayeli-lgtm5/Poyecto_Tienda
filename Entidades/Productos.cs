using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Productos
	{ 
		public Productos(int id, string Nombre, string Descripcion, int Precio)
		{
			Id = id;
			Nombre = Nombre;
			Descripcion = Descripcion;
			Precio = precio;

		}

		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Descripcion { get; set; }
		public int precio { get; set; }
	}
}
