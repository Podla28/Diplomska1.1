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

namespace Diplomska
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        static void Main()
        {
        }

        public MainWindow()
        {
            InitializeComponent();
            //NalogeList.ItemsSource = GetNaloge((App.Current as App).ConnectionString);

        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void TextBlock_MouseEnter(object sender, MouseEventArgs e)
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Izbira_Predmeta.Visibility = Visibility.Visible;
            Window2 obj2 = new Window2();
            this.Visibility = Visibility.Hidden;
            obj2.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            ZačetnaStran obj1 = new ZačetnaStran();
            this.Visibility = Visibility.Hidden;
            obj1.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource kontrolne_NalogeViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("kontrolne_NalogeViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // kontrolne_NalogeViewSource.Source = [generic data source]
        }
    }
}
