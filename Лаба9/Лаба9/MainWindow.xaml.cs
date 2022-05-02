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

namespace Лаба9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Z1_Click(object sender, RoutedEventArgs e)
        {
            ValidateAndCoerce ValidateAndCoerce = new ValidateAndCoerce();
            ValidateAndCoerce.Show();
        }

        private void Z2_Click(object sender, RoutedEventArgs e)
        {
            RoutedEventBubblingEvents RoutedEventBubblingEvents = new RoutedEventBubblingEvents();
            RoutedEventBubblingEvents.Show();

        }

        private void Z3_Click(object sender, RoutedEventArgs e)
        {
            TunnelingEvents TunnelingEvents = new TunnelingEvents();
            TunnelingEvents.Show();
        }
 
        

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Welcom to WPF LABA 9.\n This is great application");
        }

        private void button_MouseEnter(object sender, MouseEventArgs e)
        {
            button.Content = "Cho-to izmenilos?";
        }

        private void Z4_Click(object sender, RoutedEventArgs e)
        {
            RoutedUICommand RoutedUICommand = new RoutedUICommand();
            RoutedUICommand.Show();
        }

        private void button_MouseLeave(object sender, MouseEventArgs e)
        {
            button.Content = "pokazalos";
        }
    }
}
