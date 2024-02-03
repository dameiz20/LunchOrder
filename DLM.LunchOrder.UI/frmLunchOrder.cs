namespace DLM.LunchOrder.UI
{
    public partial class frmLunchOrder : Form
    {
        public frmLunchOrder()
        {
            InitializeComponent();
            //set initial values for check boxes
            ckbxOption1.Tag = ckbxOption2.Tag = ckbxOption3.Tag = 0.75;
            ckbxOption4.Tag = ckbxOption5.Tag = ckbxOption6.Tag = 0.50;
            ckbxOption7.Tag = ckbxOption8.Tag = ckbxOption9.Tag = 0.25;

        }

        private void rbtnHamburger_CheckedChanged(object sender, EventArgs e)
        {

            // make checkboxes visible when the corresponding radio button is checked
            ckbxOption1.Visible = ckbxOption2.Visible = ckbxOption3.Visible = rbtnHamburger.Checked;

        }

        private void rbtnPizza_CheckedChanged(object sender, EventArgs e)
        {
            // make checkboxes visible when the corresponding radio button is checked
            ckbxOption4.Visible = ckbxOption5.Visible = ckbxOption6.Visible = rbtnPizza.Checked;

        }

        private void rbtnSalad_CheckedChanged(object sender, EventArgs e)
        {
            // make checkboxes visible when the corresponding radio button is checked
            ckbxOption7.Visible = ckbxOption8.Visible = ckbxOption9.Visible = rbtnSalad.Checked;
            
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            double total = 0;
            //check each checkbox and accumulate the total
            foreach (CheckBox checkBox  in Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked)
                {
                    total += Convert.ToDouble(checkBox.Tag);
                }
            }
            // output total to txt box
            textBox1.Text = Convert.ToString(total);
        }
        
    }
}
