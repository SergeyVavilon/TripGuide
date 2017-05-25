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
using System.Data;
using System.Data.SqlClient;



namespace WpfApplication2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        SqlConnection conn;

        


        public Window1()
        {
            InitializeComponent();

            Page5 pg5 = new Page5();
           

            myframe.NavigationService.Navigate(pg5);




        }

        
            

        }
    }

