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

namespace ProjektGraKostka
{
    
    public partial class MainWindow : Window
    {
        private Random _random = new Random();
        private int _wynikcalkowity = 0;
        public MainWindow()
        {
            InitializeComponent();
            UpdateInterfejsu();
           
        }
        private void UpdateInterfejsu() 
        {
            liczbakostektext.Text = liczbakostek.Value.ToString("F0");
            liczbasciantext.Text = liczbascian.Value.ToString("F0");
        }

        private void rzuckostka_click(object sender, RoutedEventArgs e) 
        {
            int liczba_kostek = (int)liczbakostek.Value;
            int sciany = (int)liczbascian.Value;

            pokazwynik.Children.Clear();

            int _Wynik = 0;

            for (int i = 0; i < liczba_kostek; i++) 
            {
                int rzut = _random.Next(1, sciany + 1);
                    _Wynik += rzut;

                Image kostka = new Image();
                kostka.Width = 50;
                kostka.Height = 50;

                if (sciany >= 4 && sciany <= 10)
                {
                    kostka.Source = new BitmapImage();
                }
                else
                {
                    kostka.Source = new BitmapImage();
                }
                
            }
        }

        private void resetujwynik_click(object sender, RoutedEventArgs e) 
        {
        }
    }
}