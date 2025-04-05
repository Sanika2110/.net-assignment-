using System;
using System.Drawing;
using System.Windows.Forms;

namespace TShirtCalculator
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TShirtForm());
        }
    }

    public class TShirtForm : Form
    {
        private TextBox txtQuantity;
        private RadioButton rbSmall;
        private RadioButton rbMedium;
        private RadioButton rbLarge;
        private TextBox txtPromoCode;
        private Button btnCalculate;
        private Label lblFinalPrice;

        public TShirtForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "T-Shirt Ordering Calculator";
            this.Size = new Size(400, 350);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblQuantity = new Label
            {
                Text = "Number of T-Shirts:",
                Location = new Point(20, 20),
                AutoSize = true
            };

            txtQuantity = new TextBox
            {
                Location = new Point(200, 20),
                Size = new Size(100, 25),
                Text = "1",
                TextAlign = HorizontalAlignment.Right
            };

            // Size Group Box
            GroupBox gbSize = new GroupBox
            {
                Text = "Select Size",
                Location = new Point(20, 60),
                Size = new Size(350, 100)
            };

            rbSmall = new RadioButton
            {
                Text = "Small (Rs. 125)",
                Location = new Point(20, 20),
                Checked = true
            };

            rbMedium = new RadioButton
            {
                Text = "Medium (Rs. 175)",
                Location = new Point(20, 50)
            };

            rbLarge = new RadioButton
            {
                Text = "Large (Rs. 250)",
                Location = new Point(20, 80)
            };

            gbSize.Controls.Add(rbSmall);
            gbSize.Controls.Add(rbMedium);
            gbSize.Controls.Add(rbLarge);

            // Promo Code Label and TextBox
            Label lblPromo = new Label
            {
                Text = "Promo Code:",
                Location = new Point(20, 180),
                AutoSize = true
            };

            txtPromoCode = new TextBox
            {
                Location = new Point(200, 180),
                Size = new Size(100, 25)
            };

            btnCalculate = new Button
            {
                Text = "Calculate Total",
                Location = new Point(100, 230),
                Size = new Size(200, 35)
            };

            btnCalculate.Click += BtnCalculate_Click;

            lblFinalPrice = new Label
            {
                Text = "Final Price: Rs. 0.00",
                Location = new Point(20, 280),
                AutoSize = true,
                Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold)
            };

            this.Controls.Add(lblQuantity);
            this.Controls.Add(txtQuantity);
            this.Controls.Add(gbSize);
            this.Controls.Add(lblPromo);
            this.Controls.Add(txtPromoCode);
            this.Controls.Add(btnCalculate);
            this.Controls.Add(lblFinalPrice);
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate quantity
                if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Please enter a valid positive number of T-shirts.", "Input Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Determine base price
                double basePrice = rbSmall.Checked ? 125 :
                                   rbMedium.Checked ? 175 :
                                   rbLarge.Checked ? 250 : 0;

                // Calculate subtotal
                double subtotal = quantity * basePrice;

                // Apply promo code discount
                double discount = (txtPromoCode.Text.Trim().ToUpper() == "TRUEBLUE") ? subtotal * 0.10 : 0;
                double priceAfterDiscount = subtotal - discount;

                // Calculate GST
                double gst = priceAfterDiscount * 0.09;
                double finalPrice = priceAfterDiscount + gst;

                // Update final price label
                lblFinalPrice.Text = $"Final Price: Rs. {finalPrice:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}