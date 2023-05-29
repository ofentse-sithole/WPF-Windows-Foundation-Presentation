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
    /// Interaction logic for Expense.xaml
    /// </summary>
    public partial class Expense : Page
    {
        public static double sum = 0;
        public static double  monthly_tax;
        public static double gross_income;
        public static double LoanAmount;
        public Expense()
        {
            
        InitializeComponent();
            
            
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gross_income = Convert.ToDouble(TextBox_Monthly.Text);
            monthly_tax = Convert.ToDouble(TextBox_Tax.Text);

            sum += Convert.ToDouble(TextBox_Groceries.Text) + Convert.ToDouble(TextBox_WaterLights.Text)
                + Convert.ToDouble(TextBox_Travel.Text) + Convert.ToDouble(TextBox_Cellphone.Text) +
                Convert.ToDouble(TextBox_other.Text);
            HomeLoanChoice choice = new HomeLoanChoice();
            this.NavigationService.Navigate(choice);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            

        }
    }
}
