using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JMMB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Kwadratowa_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(kwadratowaTxtA.Text);
                double b = double.Parse(kwadratowaTxtB.Text);
                double c = double.Parse(kwadratowaTxtC.Text);

                OknoWykresu okno = new OknoWykresu(a, b, c, 1);
                okno.Show();
            }catch
            {
                MessageBox.Show("Niepoprawne dane.", "Błąd!");
            }
        }
        private void Liniowa_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(liniowaTxtA.Text);
                double b = double.Parse(liniowaTxtB.Text);

                OknoWykresu okno = new OknoWykresu(a, b, 0, 2);
                okno.Show();
            }
            catch
            {
                MessageBox.Show("Niepoprawne dane.", "Błąd!");
            }
        }
        private void Logarytmiczna_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(logarytmicznaTxtA.Text);
                double b = double.Parse(logarytmicznaTxtB.Text);

                OknoWykresu okno = new OknoWykresu(a, b, 0, 3);
                okno.Show();
            }
            catch
            {
                MessageBox.Show("Niepoprawne dane.", "Błąd!");
            }
        }
    }
}