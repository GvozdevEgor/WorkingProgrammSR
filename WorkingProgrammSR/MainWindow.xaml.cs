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

namespace WorkingProgrammSR
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SolidColorBrush On = new SolidColorBrush(Colors.Aquamarine);
        SolidColorBrush Off = new SolidColorBrush(Colors.LightPink);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButtonDiagnosticObject_Checked(object sender, RoutedEventArgs e)
        {
            if (RadioButtonDiscoveryMechanism.IsChecked == true)
            {
                //RadioButtonNotStop.IsChecked = true;
                //RadioButtonStopDR.IsEnabled = false;
                //RadioButtonStopAngle.IsEnabled = false;
                //RadioButtonStopStep.IsEnabled = false;
            }
            if (RadioButtonDiscoveryUnit.IsChecked == true)
            {
                //RadioButtonStopDR.IsEnabled = true;
                //RadioButtonStopAngle.IsEnabled = true;
                //RadioButtonStopStep.IsEnabled = true;
            }
            if (RadioButtonPowerFrame.IsChecked == true)
            {
                //RadioButtonStopDR.IsEnabled = true;
                //RadioButtonStopAngle.IsEnabled = true;
                //RadioButtonStopStep.IsEnabled = true;
            }
        }
    }
}
