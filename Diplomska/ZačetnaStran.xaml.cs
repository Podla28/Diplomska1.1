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
using System.Windows.Shapes;

namespace Diplomska
{
    /// <summary>
    /// Interaction logic for ZačetnaStran.xaml
    /// </summary>
    public partial class ZačetnaStran : Window
    {
       
        public ZačetnaStran()
        {
            InitializeComponent();
        }

        private void Btn_VSTOP_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj3 = new MainWindow();
            this.Visibility = Visibility.Hidden;
            obj3.Show();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Btn_EXIT_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
