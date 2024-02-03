namespace DLM.LunchOrder.UI
{
    partial class frmLunchOrder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            rbtnSalad = new RadioButton();
            rbtnPizza = new RadioButton();
            rbtnHamburger = new RadioButton();
            grpbxAddOnItems = new GroupBox();
            ckbxOption9 = new CheckBox();
            ckbxOption8 = new CheckBox();
            ckbxOption7 = new CheckBox();
            ckbxOption6 = new CheckBox();
            ckbxOption5 = new CheckBox();
            ckbxOption4 = new CheckBox();
            ckbxOption3 = new CheckBox();
            ckbxOption2 = new CheckBox();
            ckbxOption1 = new CheckBox();
            groupBox3 = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnPlaceOrder = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            grpbxAddOnItems.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnSalad);
            groupBox1.Controls.Add(rbtnPizza);
            groupBox1.Controls.Add(rbtnHamburger);
            groupBox1.Location = new Point(51, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 152);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Main Course";
            // 
            // rbtnSalad
            // 
            rbtnSalad.AutoSize = true;
            rbtnSalad.Location = new Point(20, 96);
            rbtnSalad.Name = "rbtnSalad";
            rbtnSalad.Size = new Size(116, 24);
            rbtnSalad.TabIndex = 2;
            rbtnSalad.TabStop = true;
            rbtnSalad.Text = "Salad - $4.95";
            rbtnSalad.UseVisualStyleBackColor = true;
            rbtnSalad.CheckedChanged += rbtnSalad_CheckedChanged;
            // 
            // rbtnPizza
            // 
            rbtnPizza.AutoSize = true;
            rbtnPizza.Location = new Point(20, 66);
            rbtnPizza.Name = "rbtnPizza";
            rbtnPizza.Size = new Size(113, 24);
            rbtnPizza.TabIndex = 1;
            rbtnPizza.TabStop = true;
            rbtnPizza.Text = "Pizza - $5.95";
            rbtnPizza.UseVisualStyleBackColor = true;
            rbtnPizza.CheckedChanged += rbtnPizza_CheckedChanged;
            // 
            // rbtnHamburger
            // 
            rbtnHamburger.AutoSize = true;
            rbtnHamburger.Location = new Point(20, 36);
            rbtnHamburger.Name = "rbtnHamburger";
            rbtnHamburger.Size = new Size(155, 24);
            rbtnHamburger.TabIndex = 0;
            rbtnHamburger.TabStop = true;
            rbtnHamburger.Text = "Hamburger - $6.95";
            rbtnHamburger.UseVisualStyleBackColor = true;
            rbtnHamburger.CheckedChanged += rbtnHamburger_CheckedChanged;
            // 
            // grpbxAddOnItems
            // 
            grpbxAddOnItems.Controls.Add(ckbxOption9);
            grpbxAddOnItems.Controls.Add(ckbxOption8);
            grpbxAddOnItems.Controls.Add(ckbxOption7);
            grpbxAddOnItems.Controls.Add(ckbxOption6);
            grpbxAddOnItems.Controls.Add(ckbxOption5);
            grpbxAddOnItems.Controls.Add(ckbxOption4);
            grpbxAddOnItems.Controls.Add(ckbxOption3);
            grpbxAddOnItems.Controls.Add(ckbxOption2);
            grpbxAddOnItems.Controls.Add(ckbxOption1);
            grpbxAddOnItems.Location = new Point(412, 59);
            grpbxAddOnItems.Name = "grpbxAddOnItems";
            grpbxAddOnItems.Size = new Size(251, 152);
            grpbxAddOnItems.TabIndex = 1;
            grpbxAddOnItems.TabStop = false;
            grpbxAddOnItems.Text = "Add-On Items";
            // 
            // ckbxOption9
            // 
            ckbxOption9.AutoSize = true;
            ckbxOption9.Location = new Point(12, 106);
            ckbxOption9.Name = "ckbxOption9";
            ckbxOption9.Size = new Size(111, 24);
            ckbxOption9.TabIndex = 8;
            ckbxOption9.Text = "Bread Sticks";
            ckbxOption9.UseVisualStyleBackColor = true;
            ckbxOption9.Visible = false;
            // 
            // ckbxOption8
            // 
            ckbxOption8.AutoSize = true;
            ckbxOption8.Location = new Point(11, 67);
            ckbxOption8.Name = "ckbxOption8";
            ckbxOption8.Size = new Size(100, 24);
            ckbxOption8.TabIndex = 7;
            ckbxOption8.Text = "Bacon Bits";
            ckbxOption8.UseVisualStyleBackColor = true;
            ckbxOption8.Visible = false;
            // 
            // ckbxOption7
            // 
            ckbxOption7.AutoSize = true;
            ckbxOption7.Location = new Point(11, 29);
            ckbxOption7.Name = "ckbxOption7";
            ckbxOption7.Size = new Size(90, 24);
            ckbxOption7.TabIndex = 6;
            ckbxOption7.Text = "Croutons";
            ckbxOption7.UseVisualStyleBackColor = true;
            ckbxOption7.Visible = false;
            // 
            // ckbxOption6
            // 
            ckbxOption6.AutoSize = true;
            ckbxOption6.Location = new Point(11, 106);
            ckbxOption6.Name = "ckbxOption6";
            ckbxOption6.Size = new Size(71, 24);
            ckbxOption6.TabIndex = 5;
            ckbxOption6.Text = "Olives";
            ckbxOption6.UseVisualStyleBackColor = true;
            ckbxOption6.Visible = false;
            // 
            // ckbxOption5
            // 
            ckbxOption5.AutoSize = true;
            ckbxOption5.Location = new Point(11, 67);
            ckbxOption5.Name = "ckbxOption5";
            ckbxOption5.Size = new Size(86, 24);
            ckbxOption5.TabIndex = 4;
            ckbxOption5.Text = "Sausage";
            ckbxOption5.UseVisualStyleBackColor = true;
            ckbxOption5.Visible = false;
            // 
            // ckbxOption4
            // 
            ckbxOption4.AutoSize = true;
            ckbxOption4.Location = new Point(12, 29);
            ckbxOption4.Name = "ckbxOption4";
            ckbxOption4.Size = new Size(98, 24);
            ckbxOption4.TabIndex = 3;
            ckbxOption4.Text = "Pepperoni";
            ckbxOption4.UseVisualStyleBackColor = true;
            ckbxOption4.Visible = false;
            // 
            // ckbxOption3
            // 
            ckbxOption3.AutoSize = true;
            ckbxOption3.Location = new Point(11, 106);
            ckbxOption3.Name = "ckbxOption3";
            ckbxOption3.Size = new Size(108, 24);
            ckbxOption3.TabIndex = 2;
            ckbxOption3.Text = "French Fries";
            ckbxOption3.UseVisualStyleBackColor = true;
            // 
            // ckbxOption2
            // 
            ckbxOption2.AutoSize = true;
            ckbxOption2.Location = new Point(11, 67);
            ckbxOption2.Name = "ckbxOption2";
            ckbxOption2.Size = new Size(219, 24);
            ckbxOption2.TabIndex = 1;
            ckbxOption2.Text = "Ketchup, Mustard, and Mayo";
            ckbxOption2.UseVisualStyleBackColor = true;
            // 
            // ckbxOption1
            // 
            ckbxOption1.AutoSize = true;
            ckbxOption1.Location = new Point(11, 29);
            ckbxOption1.Name = "ckbxOption1";
            ckbxOption1.Size = new Size(213, 24);
            ckbxOption1.TabIndex = 0;
            ckbxOption1.Text = "Lettuce, Tomato, and Onion";
            ckbxOption1.TextAlign = ContentAlignment.MiddleCenter;
            ckbxOption1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(51, 239);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 144);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Order Total";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(105, 99);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(105, 65);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(105, 32);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Order Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 68);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "Tax (7.75%):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 35);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Subtotal:";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(501, 248);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(94, 29);
            btnPlaceOrder.TabIndex = 3;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // button2
            // 
            button2.Location = new Point(501, 354);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "E&xit";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmLunchOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 450);
            Controls.Add(button2);
            Controls.Add(btnPlaceOrder);
            Controls.Add(groupBox3);
            Controls.Add(grpbxAddOnItems);
            Controls.Add(groupBox1);
            Name = "frmLunchOrder";
            Text = "Lunch Order";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpbxAddOnItems.ResumeLayout(false);
            grpbxAddOnItems.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox grpbxAddOnItems;
        private GroupBox groupBox3;
        private RadioButton rbtnSalad;
        private RadioButton rbtnPizza;
        private RadioButton rbtnHamburger;
        private CheckBox ckbxOption3;
        private CheckBox ckbxOption2;
        private CheckBox ckbxOption1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnPlaceOrder;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private CheckBox ckbxOption9;
        private CheckBox ckbxOption8;
        private CheckBox ckbxOption7;
        private CheckBox ckbxOption6;
        private CheckBox ckbxOption5;
        private CheckBox ckbxOption4;
    }
}
