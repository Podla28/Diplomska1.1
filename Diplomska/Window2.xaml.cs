using System;
using System.Collections;
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
    /// Interaction logic for Window2.xaml
    /// </summary>

    
    public partial class Window2 : Window
    {

        
        public Window2()
        {
            
            InitializeComponent();
            
            Izbira_Letnika.Visibility = Visibility.Hidden;
            Izbira_Poglavja.Visibility = Visibility.Hidden;
            Izbira_Težavnosti.Visibility = Visibility.Hidden;
        }

        private void naprej1_Click(object sender, RoutedEventArgs e)
        {
            if(RadioFIZ.IsChecked == true)
            {
                Izbira_Letnika.Visibility = Visibility.Visible;
                Radio4.Visibility = Visibility.Hidden;
            }
            else
            {
                Izbira_Letnika.Visibility = Visibility.Visible;
            }
            
           
        }

        private RadioButton findViewById(object p)
        {
            throw new NotImplementedException();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Izbira_Poglavja.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Izbira_Težavnosti.Visibility = Visibility.Visible;
        }

        private void Btn_EXIT_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ZačetnaStran obj0 = new ZačetnaStran();
            this.Visibility = Visibility.Hidden;
            obj0.Show();
        }

        private void naprej4_Click(object sender, RoutedEventArgs e)
        {
            IzdelavaNaloge obj4 = new IzdelavaNaloge();
            this.Visibility = Visibility.Hidden;
            obj4.Show();


        }

      
    }
}
