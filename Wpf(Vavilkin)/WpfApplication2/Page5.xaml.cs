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

namespace WpfApplication2
{
    /// <summary>
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void ContChoiseButton_Click(object sender, RoutedEventArgs e)
        {


            if (Convert.ToString(ContName.Text) == "Северная Америка")
            {
                Page2 pg2 = new Page2();
                this.NavigationService.Navigate(pg2);
            }

            else if (Convert.ToString(ContName.Text) == "Евразия")
            {
                Page3 pg3 = new Page3();
                this.NavigationService.Navigate(pg3);
            }

            else if (Convert.ToString(ContName.Text) == "Южная Америка")
            {
                Page1 pg1 = new Page1();
                this.NavigationService.Navigate(pg1);
            }

            else if (Convert.ToString(ContName.Text) == "Австралия")
            {
                Page4 pg4 = new Page4();
                this.NavigationService.Navigate(pg4);
            }

            else
            {
                MessageBox.Show("Исправьте свою ошибку", "Вы неправильно ввели название",
                                MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
