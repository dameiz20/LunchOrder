using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DLM.LunchOrder.UI
{
    public partial class frmLunchOrder : Form
    {
        
        private const decimal AddOnPrice = 0.75m;

        private decimal subtotal = 0.0m;
        private decimal tax = 0.0m;
        private decimal total = 0.0m;
        public frmLunchOrder()
        {
            InitializeComponent();

        }
        private void CalculateOrder()
        {
            subtotal = 0.0m;
            tax = 0.0m;
            total = 0.0m;

            // Check which main course is selected
            if (rbtnHamburger.Checked)
                subtotal += 6.95m;
            else if (rbtnPizza.Checked)
                subtotal += 5.95m;
            else if (rbtnSalad.Checked)
                subtotal += 4.95m;

            // Check add-ons and update subtotal
            if (ckbxOption1.Checked)
                subtotal += AddOnPrice;
            if (ckbxOption2.Checked)
                subtotal += AddOnPrice;
            if (ckbxOption3.Checked)
                subtotal += AddOnPrice;
            if (ckbxOption4.Checked)
                subtotal += AddOnPrice;
            if (ckbxOption5.Checked)
                subtotal += AddOnPrice;
            if (ckbxOption6.Checked)
                subtotal += AddOnPrice;
            if (ckbxOption7.Checked)
                subtotal += AddOnPrice;
            if (ckbxOption8.Checked)
                subtotal += AddOnPrice;
            if (ckbxOption9.Checked)
                subtotal += AddOnPrice;

            tax = subtotal * 0.0775m;
            total = subtotal + tax;

            textBox1.Text = $"Subtotal: {subtotal:C}";
            textBox2.Text = $"Tax: {tax:C}";
            textBox3.Text = $"Total Due: {total:C}";
        }

        private void ClearAddOnCheckmarks()
        {
            // Clear add-on checkmarks within the addOnsGroupBox
            ckbxOption1.Checked = false;
            ckbxOption2.Checked = false;
            ckbxOption3.Checked = false;
            ckbxOption4.Checked = false;
            ckbxOption5.Checked = false;
            ckbxOption6.Checked = false;
            ckbxOption7.Checked = false;
            ckbxOption8.Checked = false;
            ckbxOption9.Checked = false;

        }

        private void ClearOrderTotals()
        {
            //clearing out all totals 
            textBox1.Text = "Subtotal: ";
            textBox2.Text = "Tax: ";
            textBox3.Text = "Total Due: ";
        }

        private void grpmainCourse_CheckedChanged(object sender, EventArgs e)
        {
            // removing checks from the add on group box clearing the order total then calculating the new total
            ClearAddOnCheckmarks();
            ClearOrderTotals();
            CalculateOrder();
        }

        private void grpaddOn_CheckedChanged(object sender, EventArgs e)
        {
            //clearing totals once the checkbox changes then calculating the order
            ClearOrderTotals();
            CalculateOrder();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            //running the code once the place order button is clicked 
            CalculateOrder();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Exiting the application
            Application.Exit();
        }
    }
}
