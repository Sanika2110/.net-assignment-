using System;
using System.Windows.Forms;

namespace CollegeFestEventHandling
{
    public partial class Form1 : Form
    {
        private College college;

        private Catering catering;
        private Decoration decoration;

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            college = new College();
            catering = new Catering();
            decoration = new Decoration();

            college.OnFestEvent += catering.OnFestEventHandler;
            college.OnFestEvent += decoration.OnFestEventHandler;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int numPeople;

            if (int.TryParse(txtNumPeople.Text, out numPeople))
            {
                try
                {
                    college.RaiseFestEvent(numPeople);
                    int cateringCharge = numPeople * 200;
                    int decorationCharge = 10000 + (numPeople * 10);

                    lblResult.Text = $"Total Catering Charge: Rs {cateringCharge}{Environment.NewLine}Total Decoration Charge: Rs {decorationCharge}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }
    }
}
