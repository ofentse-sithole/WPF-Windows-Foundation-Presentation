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
    /// Interaction logic for HomeLoanChoice.xaml
    /// </summary>
    public partial class HomeLoanChoice : Page
    {
        public HomeLoanChoice()
        {
            InitializeComponent();
        }
        private void RadioButton1_Checked(object sender, RoutedEventArgs e)
        {
            HomeLoanRent rent = new HomeLoanRent();
            this.NavigationService.Navigate(rent);
        }


        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            HomeLoanBuy buy = new HomeLoanBuy();
            this.NavigationService.Navigate(buy);
        }
    }
}
