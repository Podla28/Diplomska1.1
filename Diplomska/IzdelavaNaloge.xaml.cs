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
    /// Interaction logic for IzdelavaNaloge.xaml
    /// </summary>
    public partial class IzdelavaNaloge : Window
    {
        

        public IzdelavaNaloge()
        {
            InitializeComponent();
            
            
            
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
             //txtINFO.Text = predmet;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ZačetnaStran obj0 = new ZačetnaStran();
            this.Visibility = Visibility.Hidden;
            obj0.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource kriterijViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("kriterijViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // kriterijViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource nalogeViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("nalogeViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // nalogeViewSource.Source = [generic data source]
            Diplomska.BazaDiplomskaNovaDataSet bazaDiplomskaNovaDataSet = ((Diplomska.BazaDiplomskaNovaDataSet)(this.FindResource("bazaDiplomskaNovaDataSet")));
            // Load data into the table Predmeti. You can modify this code as needed.
            Diplomska.BazaDiplomskaNovaDataSetTableAdapters.PredmetiTableAdapter bazaDiplomskaNovaDataSetPredmetiTableAdapter = new Diplomska.BazaDiplomskaNovaDataSetTableAdapters.PredmetiTableAdapter();
            bazaDiplomskaNovaDataSetPredmetiTableAdapter.Fill(bazaDiplomskaNovaDataSet.Predmeti);
            System.Windows.Data.CollectionViewSource predmetiViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("predmetiViewSource")));
            predmetiViewSource.View.MoveCurrentToFirst();
            // Load data into the table Stopnja_Težavnosti. You can modify this code as needed.
            Diplomska.BazaDiplomskaNovaDataSetTableAdapters.Stopnja_TežavnostiTableAdapter bazaDiplomskaNovaDataSetStopnja_TežavnostiTableAdapter = new Diplomska.BazaDiplomskaNovaDataSetTableAdapters.Stopnja_TežavnostiTableAdapter();
            bazaDiplomskaNovaDataSetStopnja_TežavnostiTableAdapter.Fill(bazaDiplomskaNovaDataSet.Stopnja_Težavnosti);
            System.Windows.Data.CollectionViewSource stopnja_TežavnostiViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("stopnja_TežavnostiViewSource")));
            stopnja_TežavnostiViewSource.View.MoveCurrentToFirst();
            // Load data into the table Poglavje. You can modify this code as needed.
            Diplomska.BazaDiplomskaNovaDataSetTableAdapters.PoglavjeTableAdapter bazaDiplomskaNovaDataSetPoglavjeTableAdapter = new Diplomska.BazaDiplomskaNovaDataSetTableAdapters.PoglavjeTableAdapter();
            bazaDiplomskaNovaDataSetPoglavjeTableAdapter.Fill(bazaDiplomskaNovaDataSet.Poglavje);
            System.Windows.Data.CollectionViewSource poglavjeViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("poglavjeViewSource")));
            poglavjeViewSource.View.MoveCurrentToFirst();
        }

        private void kriterijDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
