using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hill_Mortgage2
{
    public partial class MainFrm : Form
    {
        double principal = 0D;
        int years = 0;
        double interest = 0D;
        const int months = 12;
        double total = 0D;
        double r = 0D;
        double n = 0D;
        double P = 0D;
        bool number_input = false;
        bool number_input2 = false;
        bool inputPrincipal = false;
        bool inputYears = false;
        bool inputRadBtns = false;
        bool inputOtherYears = false;
        bool inputInterest = false;

        bool errors = false;
        string errorPrincipal = "Error: letters, special characters, and empty space not accepted in \"Principal\"";
        string errorYearsOther = "Error: letters, special characters, decimal numbers, and empty space are not accepted in \"Other\" box";
        string errorRadBtn = "Error: no term year selected.";
        string errorYearsOtherRange = "Error: please select between 5 and 40 years";
        string errorInterest = "Error: please select an interest rate";

        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            txtOtherYear.Visible = false;
            lblOutput.Visible = false;
            this.ActiveControl = txtPrincipal;
            btnReset.Enabled = false;
            btnReset.BackColor = Color.DarkGray;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radOther_CheckedChanged(object sender, EventArgs e)
        {
            txtOtherYear.Visible = true;
        }

        private void rad15Year_CheckedChanged(object sender, EventArgs e)
        {
            txtOtherYear.Visible = false;
            years = 15;
        }

        private void rad30year_CheckedChanged(object sender, EventArgs e)
        {
            txtOtherYear.Visible = false;
            years = 30;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            principal = 0D;
            years = 30;
            interest = 0D;
            total = 0D;
            r = 0D;
            n = 0D;
            P = 0D;
            txtPrincipal.Clear();
            cboInterest.SelectedItem = null;
            rad30year.Checked = false;
            rad15Year.Checked = false;
            radOther.Checked = false;
            txtOtherYear.Visible = false;
            lblOutput.Text = string.Empty;
            lblOutput.Visible = false;
            btnReset.Enabled = false;
            btnReset.BackColor = Color.DarkGray;
            errors = false;
        }

        private void cboInterest_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboInterest.SelectedIndex)
            {
                case 0:
                    interest = 0.03;
                    break;
                case 1:
                    interest = 0.031;
                    break;
                case 2:
                    interest = 0.032;
                    break;
                case 3:
                    interest = 0.033;
                    break;
                case 4:
                    interest = 0.034;
                    break;
                case 5:
                    interest = 0.035;
                    break;
                case 6:
                    interest = 0.036;
                    break;
                case 7:
                    interest = 0.037;
                    break;
                case 8:
                    interest = 0.038;
                    break;
                case 9:
                    interest = 0.039;
                    break;
                case 10:
                    interest = 0.04;
                    break;
                case 11:
                    interest = 0.041;
                    break;
                case 12:
                    interest = 0.042;
                    break;
                case 13:
                    interest = 0.043;
                    break;
                case 14:
                    interest = 0.044;
                    break;
                case 15:
                    interest = 0.045;
                    break;
                default:
                    break;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            getInfo();
            checkErrors();

            r = interest / months;
            n = years * months;
            P = principal;
            total = P * (r * Math.Pow((1 + r), n) / (Math.Pow((1 + r), n) - 1));

            lblOutput.Visible = true;
            if (errors)
            {
                lblOutput.Text = "Please try again";
                if (!inputPrincipal && inputRadBtns && inputInterest)
                {
                    lblOutput.Text = "Error: No principal given.";
                }
                else if (!inputRadBtns && inputInterest && inputPrincipal)
                {
                    lblOutput.Text = "Error: no term in years selected";
                }
                else if (!inputInterest && inputPrincipal && inputRadBtns)
                {
                    lblOutput.Text = "Error: no interest selected";
                }
            }
            else
            {
            lblOutput.Text = "Monthly payment is: " + total.ToString("C", CultureInfo.CurrentCulture);
            }

            btnReset.Enabled = true;
            btnReset.BackColor = Color.White;
            errors = false;
        }

        private void getInfo()
        {
            number_input = double.TryParse(txtPrincipal.Text, out principal);
            if (number_input)
            {
                principal = double.Parse(txtPrincipal.Text);
                inputPrincipal = true;
            }
            else
            {
                inputPrincipal = false;
                errors = true;
            }

            if (radOther.Checked)
            {
                number_input2 = int.TryParse(txtOtherYear.Text, out years);
                if (number_input2)
                {
                    years = int.Parse(txtOtherYear.Text);
                    inputYears = true;
                }
                else
                {
                    inputYears = false;
                    errors = true;
                }
            }

            if (!rad15Year.Checked && !rad30year.Checked && !radOther.Checked)
            {
                inputRadBtns = false;
                errors = true;
            }
            else
            {
                inputRadBtns = true;
            }

            if (years < 5 || years > 40)
            {
                inputOtherYears = false;
                errors = true;
            }
            else
            {
                inputOtherYears = true;
            }

            if (cboInterest.SelectedIndex == -1)
            {
                inputInterest = false;
                errors = true;
            }
            else
            {
                inputInterest = true;
            }

        }

        private void checkErrors()
        {
            if (!inputPrincipal && !inputRadBtns && !inputInterest)
            {
                MessageBox.Show(errorPrincipal + "\n" +  errorRadBtn + "\n" + errorInterest);
            }
            else if (!inputPrincipal && !inputInterest && !inputOtherYears)
            {
                MessageBox.Show(errorPrincipal + "\n" + errorYearsOtherRange + "\n" + errorInterest);
            }
            else if (!inputPrincipal && !inputInterest) {
                MessageBox.Show(errorPrincipal + "\n" + errorInterest);
            }
            else if (!inputYears && !inputInterest)
            {
                MessageBox.Show(errorYearsOther + "\n" + errorInterest);
            }
            else if (!inputInterest && !inputRadBtns)
            {
                MessageBox.Show(errorRadBtn + "\n" + errorInterest);
            }
            else if (radOther.Checked && !inputOtherYears)
            {
                MessageBox.Show(errorYearsOtherRange);
            }
            else if (inputPrincipal && !inputRadBtns && !inputInterest)
            {
                MessageBox.Show(errorRadBtn + "\n" + errorInterest);
            }
        }

    }
}