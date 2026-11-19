using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Martos_HomeSales_Activity
{
    public partial class FrmSalesSummary : Form
    {
        public FrmSalesSummary(decimal danielleTotal, decimal edwardTotal, decimal fatimaTotal)
        {
            InitializeComponent();

            decimal grandTotal = danielleTotal + edwardTotal + fatimaTotal;

            lblReportBody.Text =
                $"HOME SALES SUMMARY REPORT" + Environment.NewLine +
                $"----------------------------------------" + Environment.NewLine +
                $"D - Danielle : {danielleTotal:C2}" + Environment.NewLine +
                $"E - Edward   : {edwardTotal:C2}" + Environment.NewLine +
                $"F - Fatima   : {fatimaTotal:C2}" + Environment.NewLine +
                $"----------------------------------------" + Environment.NewLine +
                $"Grand Total  : {grandTotal:C2}";
        }
    }
}
