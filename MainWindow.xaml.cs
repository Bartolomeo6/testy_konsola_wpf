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

namespace zadanieSlowo
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

        private void bezPowtorzen_Click(object sender, RoutedEventArgs e)
        {
            string bezPowtorzen = "";
            string slowo = podaneSlowo.Text;
            for (int i = 0; i < slowo.Length - 1; i++)
            {

                if (slowo[i] == slowo[i + 1])
                {
                    bezPowtorzen += slowo[i];
                }

            }
            slowoBezPowt.Content = "Slowo bez powtorzen: " + bezPowtorzen;
        }

        private void ileSamoglosek_Click(object sender, RoutedEventArgs e)
        {
            int licznikSamo = 0;
            string slowo = podaneSlowo.Text;
            string samoGloski = "AĄEĘIOUÓYaąeęiouóy";
            for (int i = 0; i < samoGloski.Length; i++)
            {
                for (int j = 0; j < slowo.Length; j++)
                {
                    if (slowo[j] == samoGloski[i])
                    {
                        licznikSamo++;
                    }
                }
            }
            ileSamoglosekWString.Content = "Liczba samoglosek w tekscie: " + licznikSamo;

        }
    }
}