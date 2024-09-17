using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexion;

namespace AccesoDatos
{
	public class Funciones
	{
		Base b = new Base("localhost", "root", "", "Tienda2");
		public string Guardar(string q)
		{
			return b.comando(q);
		}

		public DataSet Mostrar(string q, string tabla)
		{
			return b.Mostrar(q, tabla);
		}
		public string Borrar(string q)
		{
			return b.comando(q);
		}

		public string Modificar(string q)
		{
			return b.comando(q);
		}
		public string ObtenerDato(string q, string tabla, string campo)
		{
			return b.ObtenerDato(q, tabla, campo);
		}
	}
}