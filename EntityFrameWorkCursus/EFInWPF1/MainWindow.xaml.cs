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

namespace EFInWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EFInWPFContext context = new EFInWPFContext();
        public MainWindow()
        {
            InitializeComponent();
            VulListMentors();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            context.Dispose();
        }

        private void VulListMentors()
        {
            listMentors.ItemsSource = (from cursist in context.Cursisten
                                       where cursist.Beschermelingen.Count() != 0
                                       orderby cursist.Voornaam, cursist.Familienaam
                                       select cursist).ToList();
        }

        private void listMentors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(listMentors.SelectedItem != null)
            {
                var mentor = (Cursist)listMentors.SelectedItem;
                //listBeschermelingen.ItemsSource = mentor.Beschermelingen;
                beschermelingenDataGrid.ItemsSource = mentor.Beschermelingen;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource cursistViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("cursistViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // cursistViewSource.Source = [generic data source]
        }

        private void Opslaan(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
            VulListMentors();
        }
    }
}
