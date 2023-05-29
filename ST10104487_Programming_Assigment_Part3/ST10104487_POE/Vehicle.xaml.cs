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
    /// Interaction logic for Vehicle.xaml
    /// </summary>
    public partial class Vehicle : Page
    {
        public delegate void NotificationAlert(String loan);
        public static double LoanAmountVechile;
        public static double monthlyCost;
        public static double vehicle_gross_income;
        public static double vehicle_sum;
        public static double vehicle_LoanAmount;



        internal class Vehicles : HomeLoanBuy
        {


        }
        public Vehicle()
        {
            InitializeComponent();
        }   

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = Application.Current.MainWindow as MainWindow;
            main.Visibility = Visibility.Visible;
            main.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
                String Model;
                String Make;
                double Purchase_Price;
                double deposit;
                double interest_rate;
                double rate;
                double est_insurance_premium;

                Model = TextBox_Mode.Text;
                Make = TextBox_Mode.Text;
                Purchase_Price = Convert.ToDouble(TextBox_PurchasePrice.Text);
                deposit = Convert.ToDouble(TextBox_Deposit.Text);
                interest_rate = Convert.ToDouble(TextBox_Interest.Text);
                est_insurance_premium = Convert.ToDouble(TextBox_Insurance.Text);

                //Calculation for interest rate
                rate = (interest_rate / 100);

                vehicle_gross_income = HomeLoanBuy.gross_inco;
                vehicle_sum = HomeLoanBuy.sum_homeloan;
                vehicle_LoanAmount = HomeLoanBuy.LoanAmountHomeLoan;

                String alert;

                alert = (" ***** --- ALERT!   Total expenses have exceeded 75 % of the income  ----*****");
                if ((vehicle_LoanAmount + vehicle_sum + monthlyCost) > (0.75 * vehicle_gross_income))
                {
                    MessageBox.Show(alert);
                }

            }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SavingPlan save = new SavingPlan();
            this.NavigationService.Navigate(save);
        }
    }
    }

