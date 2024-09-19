using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejador1;

namespace Proyecto_Tienda
{
	public partial class FrmBuscar : Form
	{
		ManejadorProducto mp;
		public static int Id = 0;
		public FrmBuscar()
		{ 
			mp = new ManejadorProducto();
			InitializeComponent();
		}

		private void FrmBuscar_Load(object sender, EventArgs e)
		{

		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			Id = 0;
			FrmDatos fu = new FrmDatos();
			fu.ShowDialog();
			txtproducto.Focus();
		}
	}
}
