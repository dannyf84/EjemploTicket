using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsAppEscritorio
{
    public partial class FrmVerVentas : Form
    {
        public FrmVerVentas()
        {
            InitializeComponent();
        }

        private void ventaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ventaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pruebaTikDataSet);

        }

        private void FrmVerVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pruebaTikDataSet.VentaDetalle' Puede moverla o quitarla según sea necesario.
            this.ventaDetalleTableAdapter.Fill(this.pruebaTikDataSet.VentaDetalle);
            // TODO: esta línea de código carga datos en la tabla 'pruebaTikDataSet.Venta' Puede moverla o quitarla según sea necesario.
            this.ventaTableAdapter.Fill(this.pruebaTikDataSet.Venta);

        }


    }
}
