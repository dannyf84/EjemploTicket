using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppEscritorio.Models;

namespace WhatsAppEscritorio
{
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void CalcularTotal()
        {
            double TOTAL = 0;
            foreach (DataGridViewRow dr in DgvTemp.Rows)
            {
                double importe = double.Parse(dr.Cells[3].Value.ToString());
                TOTAL += importe;
            }
            lblTOTAL.Text = TOTAL.ToString("0.00");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Cantidad = Nud1.Text;
            string Descripcion = txtDescripcion.Text.Trim();
            double Precio = double.Parse(txtPrecio.Text.Trim());
            string Importe = (double.Parse(Cantidad) * (Precio)).ToString("0.00");
            //
            DgvTemp.Rows.Add(new object[] {0, Cantidad, Descripcion, Precio.ToString("0.00"), Importe });
            CalcularTotal();
            Nud1.Value = 1;
            txtDescripcion.Clear();
            txtPrecio.Clear();
            DgvTemp.CurrentRow.Selected = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Se usa EntityFramework para el acceso a Datos
            using (PruebaTikEntities db = new PruebaTikEntities())
            {
                Venta oV = new Venta();
                oV.Num = txtNum.Text;
                oV.Cliente = txtCliente.Text;
                oV.Fecha = DateTime.Now;
                oV.TOTAL = Convert.ToDecimal(lblTOTAL.Text);
                //
                db.Venta.Add(oV);
                db.SaveChanges();
                foreach (DataGridViewRow dr in DgvTemp.Rows)
                {
                    VentaDetalle oD = new VentaDetalle();
                    oD.IdVenta = oV.Id;
                    oD.Cantidad = int.Parse(dr.Cells[1].Value.ToString());
                    oD.Descripcion = dr.Cells[2].Value.ToString();
                    oD.PrecioUnitario = decimal.Parse(dr.Cells[3].Value.ToString());
                    oD.Importe = decimal.Parse(dr.Cells[4].Value.ToString());
                    db.VentaDetalle.Add(oD);    
                }
                db.SaveChanges();
            }
            MessageBox.Show("Venta Guardada Exitosamente");
            this.Close();
        }
    }
}
