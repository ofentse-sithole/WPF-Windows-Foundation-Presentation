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
    /// Interaction logic for HomeLoanRent.xaml
    /// </summary>
    public partial class HomeLoanRent : Page
    {
        public double Monthly_Rental;
        public HomeLoanRent()
        {
            InitializeComponent();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            VehicleChoice vehiclechoice = new VehicleChoice();
            this.NavigationService.Navigate(vehiclechoice);
        }

        private void Button_Calculate_Monthly_Click(object sender, RoutedEventArgs e)
        {
            Monthly_Rental = Convert.ToDouble(TextBox_Rental.Text);
            TextBox_Monthly_Rental.Text = "Your monthly rental amount is R" + Monthly_Rental;
        }
    }
}
