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
using System.IO;

namespace WpfApplication2
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {

        public int parametr;

        public Page2()
        {
            InitializeComponent();

            List<Country> countrylist = new List<Country>();
            StreamReader sr = new StreamReader("northamerica.txt");
            while (!sr.EndOfStream)
            {
                string[] input = sr.ReadLine().Split(' ');
                countrylist.Add(new Country(input[0], input[1], input[2], int.Parse(input[3])));
            }
            foreach (Country country in countrylist)
            {
                CountryList.Items.Add(country.show());
            }

        }

        private void Backbutton_Click(object sender, RoutedEventArgs e)
        {
            Page5 pg5 = new Page5();
            this.NavigationService.Navigate(pg5);
        }

        private void RootButton_Click(object sender, RoutedEventArgs e)
        {
            parametr = 2;
            Page6 pg6 = new Page6(parametr);
            this.NavigationService.Navigate(pg6);
            
        }

    }
}
