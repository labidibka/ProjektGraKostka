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
            if (liczbakostek != null && liczbakostektext != null)
                liczbakostektext.Text = liczbakostek.Value.ToString("F0");

            if (liczbascian != null && liczbasciantext != null)
                liczbasciantext.Text = liczbascian.Value.ToString("F0");
        }



        

        private void Button_Click(object sender, RoutedEventArgs e)
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

                switch (rzut)
                {
                    case 1:
                        kostka.Source = new BitmapImage(new Uri("pack://application:,,,/Images/kostka1.png"));
                        break;
                    case 2:
                        kostka.Source = new BitmapImage(new Uri("pack://application:,,,/Images/kostka2.png"));
                        break;
                    case 3:
                        kostka.Source = new BitmapImage(new Uri("pack://application:,,,/Images/kostka3.png"));
                        break;
                    case 4:
                        kostka.Source = new BitmapImage(new Uri("pack://application:,,,/Images/kostka4.png"));
                        break;
                    case 5:
                        kostka.Source = new BitmapImage(new Uri("pack://application:,,,/Images/kostka5.png"));
                        break;
                    case 6:
                        kostka.Source = new BitmapImage(new Uri("pack://application:,,,/Images/kostka6.png"));
                        break;
                    case 7:
                        kostka.Source = new BitmapImage(new Uri("pack://application:,,,/Images/kostka7.png"));
                        break;
                    case 8:
                        kostka.Source = new BitmapImage(new Uri("pack://application:,,,/Images/kostka8.png"));
                        break;
                    case 9:
                        kostka.Source = new BitmapImage(new Uri("pack://application:,,,/Images/kostka9.png"));
                        break;
                    case 10:
                        kostka.Source = new BitmapImage(new Uri("pack://application:,,,/Images/kostka10.png"));
                        break;
                    default:
                        kostka.Source = new BitmapImage(new Uri($"pack://application:,,,/Images/Default.png"));
                        break;
                }


                pokazwynik.Children.Add(kostka);

            }
            _wynikcalkowity += _Wynik;
            Wynik.Text = $"Wynik: {_Wynik}";
            calkowitaliczbapunktow.Text = $"Suma punktow: {_wynikcalkowity}";
        }

        private void Button_Click_Reset(object sender, RoutedEventArgs e)
        {
            _wynikcalkowity = 0;
            calkowitaliczbapunktow.Text = "Suma punktow: 0";
            Wynik.Text = "Wynik: 0";

            pokazwynik.Children.Clear();
        }
        private void liczbakostek_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            UpdateInterfejsu();
        }
        private void liczbascian_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) 
        {
            UpdateInterfejsu();
        }

    }
}