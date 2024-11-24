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
    }
}