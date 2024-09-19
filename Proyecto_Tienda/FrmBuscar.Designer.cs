namespace Proyecto_Tienda
{
	partial class FrmBuscar
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.label4 = new System.Windows.Forms.Label();
			this.dtgvProductos = new System.Windows.Forms.DataGridView();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.txtproducto = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dtgvProductos)).BeginInit();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.Control;
			this.label4.Location = new System.Drawing.Point(249, 29);
			this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(194, 31);
			this.label4.TabIndex = 14;
			this.label4.Text = "PRODUCTOS";
			// 
			// dtgvProductos
			// 
			this.dtgvProductos.BackgroundColor = System.Drawing.SystemColors.ControlDark;
			this.dtgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvProductos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dtgvProductos.Location = new System.Drawing.Point(41, 173);
			this.dtgvProductos.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.dtgvProductos.Name = "dtgvProductos";
			this.dtgvProductos.Size = new System.Drawing.Size(565, 336);
			this.dtgvProductos.TabIndex = 13;
			// 
			// btnAgregar
			// 
			this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnAgregar.Location = new System.Drawing.Point(534, 110);
			this.btnAgregar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(72, 40);
			this.btnAgregar.TabIndex = 12;
			this.btnAgregar.Text = "+";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// txtproducto
			// 
			this.txtproducto.ForeColor = System.Drawing.SystemColors.Control;
			this.txtproducto.Location = new System.Drawing.Point(117, 116);
			this.txtproducto.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.txtproducto.Name = "txtproducto";
			this.txtproducto.Size = new System.Drawing.Size(391, 29);
			this.txtproducto.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(7, 119);
			this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 22);
			this.label1.TabIndex = 10;
			this.label1.Text = "Producto";
			// 
			// FrmBuscar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(638, 542);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dtgvProductos);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.txtproducto);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Name = "FrmBuscar";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.FrmBuscar_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgvProductos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dtgvProductos;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.TextBox txtproducto;
		private System.Windows.Forms.Label label1;
	}
}

