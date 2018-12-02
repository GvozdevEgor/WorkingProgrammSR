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
            SetColorDryContactSensor(0xAAAA);
        }

        private void RadioButtonDiscoveryMechanism_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void RadioButtonDiscoveryUnit_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButtonPowerFrame_Checked(object sender, RoutedEventArgs e)
        {

        }

        public void SetColorDryContactSensor(UInt16 data)
        {
            for (int i = 0; i < 16; i++)
            {
                bool stat = (data & (1 << i)) > 0;
                switch(i)
                {
                    case 0:
                        GridDR11.Background = stat ? On : Off;
                        break;
                    case 1:
                        GridDR12.Background = stat ? On : Off;
                        break;
                    case 2:
                        GridDR21.Background = stat ? On : Off;
                        break;
                    case 3:
                        GridDR22.Background = stat ? On : Off;
                        break;
                    case 4:
                        GridDR31.Background = stat ? On : Off;
                        break;
                    case 5:
                        GridDR32.Background = stat ? On : Off;
                        break;
                    case 6:
                        GridDR41.Background = stat ? On : Off;
                        break;
                    case 7:
                        GridDR42.Background = stat ? On : Off;
                        break;
                    case 8:
                        GridDZ11.Background = stat ? On : Off;
                        break;
                    case 9:
                        GridDZ12.Background = stat ? On : Off;
                        break;
                    case 10:
                        GridDZ21.Background = stat ? On : Off;
                        break;
                    case 11:
                        GridDZ22.Background = stat ? On : Off;
                        break;
                    case 12:
                        GridDD1.Background = stat ? On : Off;
                        break;
                    case 13:
                        GridDD2.Background = stat ? On : Off;
                        break;
                    case 14:
                        GridKS1.Background = stat ? On : Off;
                        break;
                    case 15:
                        GridKS2.Background = stat ? On : Off;
                        break;
                }
            }
        }
    }
}
