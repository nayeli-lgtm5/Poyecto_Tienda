using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace Manejador1
{
	public class ManejadorProducto
	{
		Funciones f = new Funciones();
		public void Guardar(TextBox Nombre, TextBox Descripcion, TextBox precio)
		{

			MessageBox.Show(f.Guardar($"insert into producto (Nombre, Descripcion, precio) values ('{Nombre.Text}', '{Descripcion.Text}', {precio.Text})"),
				"!Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		DataGridViewButtonColumn Boton(string t, Color co)
		{
			DataGridViewButtonColumn bo = new DataGridViewButtonColumn();
			bo.Text = t;
			bo.UseColumnTextForButtonValue = true;
			bo.FlatStyle = FlatStyle.Popup;
			bo.DefaultCellStyle.BackColor = co;
			bo.DefaultCellStyle.ForeColor = Color.White;
			return bo;
		}
		/*public void Mostrar(DataGridView tabla, string filtro)
		{
			tabla.Columns.Clear();
			tabla.DataSource = f.Mostrar($"Select * from producto where nombre like '%{filtro}%'",
				"producto").Tables[0];
			tabla.Columns.Insert(4, Boton("Borrar", Color.Red));
			tabla.Columns.Insert(5, Boton("Modificar", Color.Green));
			tabla.AutoResizeColumns();
			tabla.AutoResizeRows();
		}

		public void Mostrar(TextBox txtNombre, TextBox txtdescripcion, TextBox txtprecio)
		{
			throw new NotImplementedException();*/
		}
	
}

