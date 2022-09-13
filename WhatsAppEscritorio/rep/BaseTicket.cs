using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsAppEscritorio.rep
{
    public partial class BaseTicket : Form
    {
        public BaseTicket()
        {
            InitializeComponent();
        }

        public void VerTicket(int IdVenta)
        {
            rptTicket rpt = new rptTicket();
            rpt.SetParameterValue("pIdVenta", IdVenta);
            Crv.ReportSource = rpt;
        }

    }
}
