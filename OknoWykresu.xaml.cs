using System;
using System.Collections.Generic;
using System.IO;
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
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using Microsoft.Win32;

namespace JMMB
{
    /// <summary>
    /// Logika interakcji dla klasy OknoWykresu.xaml
    /// </summary>
    public partial class OknoWykresu : Window
    {
        double a, b, c;

        int tryb;
        public ChartValues<ObservablePoint> ChartValues { get; set; }
        public OknoWykresu(double a, double b, double c, int tryb)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.tryb = tryb;

            InitializeComponent();

            DataContext = this;
            ChartValues = new ChartValues<ObservablePoint>();

            //rysowanie funkcji kwadratowej
            if (tryb == 1)
            {
                for (double x = -10; x <= 10; x += 0.1)
                {
                    double y = a * x * x + b * x + c;
                    ChartValues.Add(new ObservablePoint(x, y));
                }
            }

            //rysowanie funkcji liniowej
            if (tryb == 2)
            {
                for (double x = -10; x <= 10; x += 0.1)
                {
                    double y = a * x + b;
                    ChartValues.Add(new ObservablePoint(x, y));
                }
            }

            //rysowanie funkcji wykladniczej
            if (tryb == 3)
            {
                for (double x = -10; x <= 10; x += 0.1)
                {
                    double y = a * Math.Log10(x) + b;
                    ChartValues.Add(new ObservablePoint(x, y));
                }
            }
        }

        private void SaveImage_Click(object sender, RoutedEventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Pliki obrazów (*.png)|*.png",
                DefaultExt = "png",
                Title = "Zapisz wykres"
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                Zapisz(chart, saveFileDialog.FileName);
            }
        }
        void Zapisz(FrameworkElement visual, string fileName)
        {
            var encoder = new PngBitmapEncoder();

            var bitmap = new RenderTargetBitmap((int)visual.ActualWidth, (int)visual.ActualHeight, 96, 96, PixelFormats.Pbgra32);
            bitmap.Render(visual);
            encoder.Frames.Add(BitmapFrame.Create(bitmap));

            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                encoder.Save(stream);
            }
        }
    }
}
