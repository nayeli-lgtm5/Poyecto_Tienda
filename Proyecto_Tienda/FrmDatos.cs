using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Manejador1;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Tienda
{
	public partial class FrmDatos : Form
	{
		ManejadorProducto mp;
		public FrmDatos()
		{
			mp = new ManejadorProducto();
			InitializeComponent();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			/*if (Buscar.Id > 0)
			{
				mp.Mostrar(txtNombre, txtdescripcion, txtprecio);
			}
			else
			{*/
				mp.Guardar(txtNombre, txtdescripcion, txtprecio);
			}
			/*Close();*/
		}
	}
