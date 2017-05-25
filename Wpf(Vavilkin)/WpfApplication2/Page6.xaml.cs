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
    /// Логика взаимодействия для Page6.xaml
    /// </summary>
    public partial class Page6 : Page
    {

        List<Country> countrylist = new List<Country>();

        public Page6(int parametr)
        {

            InitializeComponent();

            Capital cap = new Capital();
            




            if (parametr == 1)
            {
                
                StreamReader sr = new StreamReader("southamerica.txt");
                while (!sr.EndOfStream)
                {
                    string[] input = sr.ReadLine().Split(' ');
                    countrylist.Add(new Country(input[0], input[1], input[2], int.Parse(input[3])));
                }
                foreach (Country country in countrylist)
                {
                    CountryBox.Items.Add(country.box());
                }
            }

            else if (parametr == 2)
            {
                
                StreamReader sr = new StreamReader("northamerica.txt");
                while (!sr.EndOfStream)
                {
                    string[] input = sr.ReadLine().Split(' ');
                    countrylist.Add(new Country(input[0], input[1], input[2], int.Parse(input[3])));
                }
                foreach (Country country in countrylist)
                {
                    CountryBox.Items.Add(country.box());
                }
            }

            else if (parametr == 3)
            {
                
                StreamReader sr = new StreamReader("eurasia.txt");
                while (!sr.EndOfStream)
                {
                    string[] input = sr.ReadLine().Split(' ');
                    countrylist.Add(new Country(input[0], input[1], input[2], int.Parse(input[3])));
                }
                foreach (Country country in countrylist)
                {
                    CountryBox.Items.Add(country.box());
                }
            }

            else 
            {
                
                StreamReader sr = new StreamReader("australia.txt");
                while (!sr.EndOfStream)
                {
                    string[] input = sr.ReadLine().Split(' ');
                    countrylist.Add(new Country(input[0], input[1], input[2], int.Parse(input[3])));
                }
                foreach (Country country in countrylist)
                {
                    CountryBox.Items.Add(country.box());
                }
            }


            PriceBox.Items.Add("*Grand Hotel* Цена за ночь:" + cap.H_hotel);
            PriceBox.Items.Add("*Midle Motel* Цена за ночь:" + cap.M_hotel);
            PriceBox.Items.Add("*General Hostel* Цена за ночь:" + cap.E_hotel);








        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Page7 pg7 = new WpfApplication2.Page7();
            this.NavigationService.Navigate(pg7);
        }

        private void AddRoot_Click(object sender, RoutedEventArgs e)
        {
            foreach(Country country in countrylist)
            {
                if(country.box() == CountryBox.Text)
                {
                    string[] hotelname = PriceBox.Text.Split('*');
                    RootList.Items.Add(country.root() + hotelname[1]);
                    StreamWriter sw = new StreamWriter("root.txt", true);
                    sw.WriteLine(country.root() + hotelname[1]);
                    sw.Close();
                    string[] hotelprice = PriceBox.Text.Split(':');
                    TotalCostList.Items.Add(country.Price + int.Parse(hotelprice[1]) * int.Parse(TimeTextBox.Text));
                }
            }
        }
    }
}
