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
    /// Interaction logic for VehicleChoice.xaml
    /// </summary>
    public partial class VehicleChoice : Page
    {
        public VehicleChoice()
        {
            InitializeComponent();
        }

        //if no is clicked the program will stop
        private void RadioButton_Checked(object sender, RoutedEventArgs e) 
        {
            MainWindow main = Application.Current.MainWindow as MainWindow;
            main.Visibility = Visibility.Visible;
            main.Close();

        }

        //if yes is clicked the program will proceed to next page
        private void RadioButton_Vehicle_1(object sender, RoutedEventArgs e) 
        {
            Vehicle vehicle = new Vehicle();
            this.NavigationService.Navigate(vehicle);
        }
    }
}
