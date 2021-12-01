using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolåneberäkning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbInterest.Items.Add("2");
            cmbInterest.Items.Add("3");
            cmbInterest.Items.Add("4");
            cmbInterest.Items.Add("5");

            cmbLoan.Items.Add("1000000");
            cmbLoan.Items.Add("2000000");
            cmbLoan.Items.Add("3000000");
            cmbLoan.Items.Add("4000000");

            lstLoptid.Items.Add("20");
            lstLoptid.Items.Add("25");
            lstLoptid.Items.Add("30");
            lstLoptid.Items.Add("35");
            lstLoptid.Items.Add("40");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbCalculate_Click(object sender, EventArgs e)
        {
            ////Deklarera konstanter för räntesatser 
            //const double skatt1 = 0.02;
            //const double skatt2 = 0.03;
            //const double skatt3 = 0.04;
            //const double skatt4 = 0.05;

            //Variabler för räntesats och lånebelopp

            double lopTid = double.Parse(lstLoptid.Text);

            double interesttext = double.Parse(cmbInterest.Text);

            double loneBelopp = double.Parse(cmbLoan.Text);



            // int valdInterest = cmbInterest.SelectedIndex;
            //int valdInterest = cmbInterest.SelectedIndex;
            ////double valdInterestDouble = double.Parse();
            //int valdAmount = cmbLoan.SelectedIndex;
            //int valdLoptid = lstLoptid.SelectedIndex;

            //Variabler för månadsränta och amortering och total
            //double monthInterest = 0;
            //double monthPayment = 0;
            //double monthTotal = 0;

            //Variabler för att anropa metoder 
            double monthInterestAnrop = MonthInterestCalc(interesttext,loneBelopp);

            double monthPaymentAnrop = MonthPayments(interesttext, loneBelopp);

            double monthTotAnrop = MonthTot(interesttext, loneBelopp);


            //Skriv ut värden i textrutor
            txtMonthInterest.Text = Convert.ToString(Math.Round(monthInterestAnrop, 0));
            txtMonthPayment.Text = Convert.ToString(Math.Round(monthPaymentAnrop,0));
            txtMonthTot.Text = Convert.ToString(Math.Round(monthTotAnrop, 0));
        }

        public double MonthInterestCalc(double interest, double loanAmount1)
        {
            double rate = 0;
            //double loanAmount1 = 0;
            
            rate = (loanAmount1 * interest) /12;

            return rate;

        }

        public double MonthPayments(double interest, double loanAmount2)
        {
            double monthRate = 0;

            monthRate = loanAmount2 /12;

            return monthRate;
        }

        public double MonthTot(double interest, double loanAmount3)
        {
            double monthTotal = 0;

            monthTotal = ((loanAmount3 * interest) + loanAmount3)/ 12;

            return monthTotal;
        }

        private void cmbAvsluta_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
