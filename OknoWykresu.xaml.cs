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
using LiveCharts;
using LiveCharts.Wpf;

namespace JMMB
{
    /// <summary>
    /// Logika interakcji dla klasy OknoWykresu.xaml
    /// </summary>
    public partial class OknoWykresu : Window
    {
        double a, b, c;

        private void SaveImage_Click(object sender, RoutedEventArgs e)
        {

        }

        int tryb;
        public OknoWykresu(double a, double b, double c, int tryb)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.tryb = tryb;

            InitializeComponent();

            DataContext = this;
        }


    }
}
