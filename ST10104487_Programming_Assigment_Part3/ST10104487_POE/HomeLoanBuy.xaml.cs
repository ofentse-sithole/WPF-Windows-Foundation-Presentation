using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ST10104487_POE
{
    /// <summary>
    /// Interaction logic for HomeLoanBuy.xaml
    /// </summary>
    public partial class HomeLoanBuy : Page
    {
        public static double gross_inco;
        public static double LoanAmountHomeLoan;
        public double  total_gross_tax;
        public double Monthly_Payment;
        public static double available_Monthly;
        public static double monthlytax_homeloan;
        public static double sum_homeloan;

        //public static 

        internal class HomeLoanBuys : Expense
        {

            HomeLoanRent rent = new HomeLoanRent();
            HomeLoanBuy buy = new HomeLoanBuy();



        }

        public HomeLoanBuy()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VehicleChoice vehiclechoice = new VehicleChoice();
            this.NavigationService.Navigate(vehiclechoice);
        }

        private void Button_Calculate_AvailableMoney_Click(object sender, RoutedEventArgs e)
        {
            double Purchase_Price;
            double Deposit;
            double Interest_Rate;
            double Num_Months;
            
            double A;
            double Year;
            double Rate;

            Purchase_Price = Convert.ToDouble(TextBox_Purchase_Buy.Text);
            Deposit = Convert.ToDouble(TextBox_Deposit_Buy.Text);
            Interest_Rate = Convert.ToDouble(TextBox_Interest_Buy.Text);
            Num_Months = Convert.ToDouble(TextBox_Months.Text);

            Rate = Interest_Rate / 100;
            Year = Num_Months / 12;

            //Calculating the deposit and the price of the house
            A = (((Purchase_Price - Deposit) + (1 + Rate * Year)));

            Monthly_Payment = (A / Year);


            //calculation for tax and gross
            total_gross_tax = gross_inco - monthlytax_homeloan;

            LoanAmountHomeLoan = (Deposit * ((1 + Rate * Year)));
            HomeLoanRent rent = new HomeLoanRent();
            available_Monthly = total_gross_tax - (sum_homeloan - rent.Monthly_Rental - LoanAmountHomeLoan);

            //the answer for monthly payment, loan amount and available monthly
            TextBox_AvailableMoney.Text = "The users monthly payment will be : R" + Monthly_Payment
                + "\n" + "The monthly home loan amount is: R" + LoanAmountHomeLoan + "\n"+
                "Your available money is R" + available_Monthly;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //HomeLoanBuys.CalcMonthly();
            LoanAmountHomeLoan = HomeLoanBuys.LoanAmount;
            gross_inco = HomeLoanBuys.gross_income;
            sum_homeloan = HomeLoanBuys.sum;
            monthlytax_homeloan = HomeLoanBuys.monthly_tax;
            

            if (LoanAmountHomeLoan > (1 / 3 * gross_inco))
            {
                TextBox_Qualify.Text = "The approval of the home loan is unlikely";

            }
            else
            {
                TextBox_Qualify.Text = "Your loan is approved";
            }
        }
       

        }
    }


    
