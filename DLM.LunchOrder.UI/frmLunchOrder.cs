using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DLM.LunchOrder.UI
{
    public partial class frmLunchOrder : Form
    {
        // Variables to store user selections
        private decimal subtotal = 0.0m;
        private decimal tax = 0.0m;
        private decimal total = 0.0m;
        public frmLunchOrder()
        {
            InitializeComponent();

        }
        private void CalculateOrder()
        {
            // Clear order totals
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
                subtotal += 0.75m;
            if(ckbxOption2.Checked)
                subtotal += 0.75m;
            if (ckbxOption3.Checked)
                subtotal += 0.75m;
            if (ckbxOption4.Checked)
                subtotal += 0.50m;
            if (ckbxOption5.Checked)
                subtotal += 0.50m;
            if (ckbxOption6.Checked)
                subtotal += 0.50m;
            if (ckbxOption7.Checked)
                subtotal += 0.25m;
            if (ckbxOption8.Checked)
                subtotal += 0.25m;
            if (ckbxOption9.Checked)
                subtotal += 0.25m;


            // Calculate tax and total
            tax = subtotal * 0.0775m;
            total = subtotal + tax;

            // Update textboxes to display the calculated values
            textBox1.Text = $" {subtotal:C}";
            textBox2.Text = $" {tax:C}";
            textBox3.Text = $" {total:C}";
        }

        // Event handler for main course selection change
        private void grpmainCourse_CheckedChanged(object sender, EventArgs e)
        {
            // Clear add-on checkmarks and order totals
            ClearOrderTotals();
            if (rbtnHamburger.Checked)
            {
                grpaddOn.Text = "Add-Ons ($.75/each)";
                ckbxOption1.Visible = ckbxOption2.Visible = ckbxOption3.Visible = true;
                ckbxOption4.Visible = ckbxOption5.Visible = ckbxOption6.Visible = false;
                ckbxOption7.Visible = ckbxOption8.Visible = ckbxOption9.Visible = false;

                ClearAddOnCheckmarks();
            }
            else if (rbtnPizza.Checked)
            {
                grpaddOn.Text = "Add-Ons ($.50/each)";
                ckbxOption1.Visible = ckbxOption2.Visible = ckbxOption3.Visible = false;
                ckbxOption4.Visible = ckbxOption5.Visible = ckbxOption6.Visible = true;
                ckbxOption7.Visible = ckbxOption8.Visible = ckbxOption9.Visible = false;

                ClearAddOnCheckmarks();
            }
            else if (rbtnSalad.Checked)
            {
                grpaddOn.Text = "Add-Ons ($.25/each)";
                ckbxOption1.Visible = ckbxOption2.Visible = ckbxOption3.Visible = false;
                ckbxOption4.Visible = ckbxOption5.Visible = ckbxOption6.Visible = false;
                ckbxOption7.Visible = ckbxOption8.Visible = ckbxOption9.Visible = true;
                
                ClearAddOnCheckmarks();
            }
        }

        // Event handler for add-on selection change
        private void grpaddOn_CheckedChanged(object sender, EventArgs e)
        {
            // Clear order totals

            ClearOrderTotals();
            //CalculateOrder();
        }

        // Method to clear add-on checkmarks
        private void ClearAddOnCheckmarks()
        {
            
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

        // Method to clear order totals
        private void ClearOrderTotals()
        {
            
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
        }
        // Event handler for Place Order button click
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // Calculate and display the order totals
            CalculateOrder();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Exiting the application
            Application.Exit();
        }
    }
}
