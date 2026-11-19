using System;
using System.Windows.Forms;

namespace Martos_HomeSales_Activity
{
    public partial class FrmSalesHouse : Form
    {
        private decimal danielleTotal = 0m;
        private decimal edwardTotal = 0m;
        private decimal fatimaTotal = 0m;

        public FrmSalesHouse()
        {
            InitializeComponent();

            txt_Initial.MaxLength = 1;
            txt_Initial.CharacterCasing = CharacterCasing.Upper;
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            string initialInput = txt_Initial.Text.Trim();

            if (string.IsNullOrWhiteSpace(initialInput))
            {
                MessageBox.Show("Please enter a sales person's initial.", "Missing Initial",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Initial.Focus();
                return;
            }

            if (!double.TryParse(txt_Amount.Text.Trim(), out double parsedAmount) || parsedAmount <= 0)
            {
                MessageBox.Show("Please enter a valid sales amount.", "Invalid Amount",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Amount.Focus();
                txt_Amount.SelectAll();
                return;
            }

            getSalesPerson_Amount(initialInput, parsedAmount);

            txt_Initial.Clear();
            txt_Amount.Clear();
            txt_Initial.Focus();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            clearEntry();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            using (FrmSalesSummary summaryForm = new FrmSalesSummary(danielleTotal, edwardTotal, fatimaTotal))
            {
                summaryForm.ShowDialog(this);
            }
        }

        private void getSalesPerson_Amount(String salesInitial, double salesAmount)
        {
            string normalizedInitial = (salesInitial ?? string.Empty).Trim().ToUpperInvariant();
            decimal amountToAdd = Convert.ToDecimal(salesAmount);

            string salespersonName;
            decimal updatedPersonTotal;

            if (normalizedInitial == "D")
            {
                danielleTotal += amountToAdd;
                salespersonName = "Danielle";
                updatedPersonTotal = danielleTotal;
            }
            else if (normalizedInitial == "E")
            {
                edwardTotal += amountToAdd;
                salespersonName = "Edward";
                updatedPersonTotal = edwardTotal;
            }
            else if (normalizedInitial == "F")
            {
                fatimaTotal += amountToAdd;
                salespersonName = "Fatima";
                updatedPersonTotal = fatimaTotal;
            }
            else
            {
                lbl_Output.Text = $"Invalid sales person's initial \"{salesInitial}\". Please enter D (Danielle), E (Edward), or F (Fatima).";
                return;
            }

            decimal grandTotal = danielleTotal + edwardTotal + fatimaTotal;

            lbl_Output.Text =
                $"Recorded sale of {amountToAdd:C2} for {salespersonName}" + Environment.NewLine +
                $"{salespersonName} Running Total: {updatedPersonTotal:C2}" + Environment.NewLine +
                $"All Salespersons Total: D={danielleTotal:C2} | E={edwardTotal:C2} | F={fatimaTotal:C2} | Grand={grandTotal:C2}";
        }

        private void clearEntry()
        {
            txt_Initial.Clear();
            txt_Amount.Clear();
            lbl_Output.Text = string.Empty;
            txt_Initial.Focus();
        }
    }
}