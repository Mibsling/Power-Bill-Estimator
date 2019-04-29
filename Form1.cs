using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        public double Validate (string txtInput)
        {
            double Result;
            if (double.TryParse(txtInput, out Result))
            {
                
                return Result;
        
            }
            else
            {
                Result = 0;
                return Result;
            }
        }


        public void btnCalculate_Click(object sender, EventArgs e)
        {

            double usage = Validate(txtInput.Text);
            
            if (Residential.Checked == true && usage >= 0)
            {
                double Answer = 6.00 + (usage * 0.052);
                Output.Text = "Your Bill is $" + Answer.ToString();
            }

            else if (Commercial.Checked == true && usage <= 1000)
            {
                double Answer1 = 60.00;
                Output.Text = "Your Bill is $" + Answer1.ToString();
            }

            else if (Commercial.Checked == true && usage > 1000)
            {
                double Answer2 = 60.00 + (usage * 0.065);
                Output.Text = "Your Bill is $" + Answer2.ToString();
            }


            else if (PeakHours.Checked == true && usage <= 1000)
            {
                double Answer3 = 76.00;
                Output.Text = "Your Bill is $" + Answer3.ToString();
            }

            else if (PeakHours.Checked == true && usage > 1000)
            {
                double Answer4 = 76.00 + (usage * 0.065);
                Output.Text = "Your Bill is $" + Answer4.ToString();
            }

            else if (OffPeak.Checked == true && usage <= 1000)
            {
                double Answer5 = 40.00;
                Output.Text = "Your Bill is $" + Answer5.ToString();
            }
            else if (OffPeak.Checked == true && usage > 1000)
            {
                double Answer6 = 40.00 + (usage * 0.028);
                Output.Text = "Your Bill is $" + Answer6.ToString();
            }

            else
            {
                Output.Text = "Enter a valid number";
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblWelcome.Show();
            lblOption.Hide();
            Residential.Hide();
            Commercial.Hide();
            Industrial.Hide();
            PeakHours.Hide();
            OffPeak.Hide();
            lblEnter.Hide();
            txtInput.Hide();
            btnCalculate.Hide();
            btnClear.Hide();
            Output.Hide();
            Choose.Show();
            btnExit.Hide();
        }

        public void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = String.Empty;
            Output.Text = String.Empty;
            PeakHours.Checked = false;
            OffPeak.Checked = false;
            btnExit.Show();
        }

        private void Residential_CheckedChanged(object sender, EventArgs e)
        {
            lblWelcome.Hide();
            lblOption.Hide();
            PeakHours.Hide();
            OffPeak.Hide();
            lblEnter.Show();
            txtInput.Show();
            btnCalculate.Show();
            btnClear.Show();
            Output.Show();
            Choose.Hide();
            btnExit.Show();

        }

        private void Commercial_CheckedChanged(object sender, EventArgs e)
        {
            lblWelcome.Hide();
            lblOption.Hide();
            PeakHours.Hide();
            OffPeak.Hide();
            lblEnter.Show();
            txtInput.Show();
            btnCalculate.Show();
            btnClear.Show();
            Output.Show();
            Choose.Hide();
            btnExit.Show();
        }

        private void Industrial_CheckedChanged(object sender, EventArgs e)
        {
            lblWelcome.Hide();
            lblOption.Hide();
            PeakHours.Show();
            OffPeak.Show();
            lblEnter.Show();
            txtInput.Show();
            btnCalculate.Show();
            btnClear.Show();
            Output.Show();
            Choose.Hide();
            btnExit.Show();
        }

     

        private void Choose_Click(object sender, EventArgs e)
        {
            Choose.Hide();
            lblWelcome.Hide();
            lblOption.Hide();
            Residential.Show();
            Commercial.Show();
            Industrial.Show();
            PeakHours.Hide();
            OffPeak.Hide();
            lblEnter.Hide();
            txtInput.Hide();
            btnCalculate.Hide();
            btnClear.Hide();
            Output.Hide();
            btnExit.Hide();
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
