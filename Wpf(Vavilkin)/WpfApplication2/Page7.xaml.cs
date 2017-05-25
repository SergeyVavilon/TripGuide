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
    /// Логика взаимодействия для Page7.xaml
    /// </summary>
    public partial class Page7 : Page
    {
        public Page7()
        {
            InitializeComponent();

            List<Root> rootlist = new List<Root>();
            StreamReader sr = new StreamReader("root.txt");
            while (!sr.EndOfStream)
            {
                string[] input = sr.ReadLine().Split('>');
                rootlist.Add(new Root(input[0], input[1], input[2], input[3]));
            }
            foreach (Root root in rootlist)
            {
                DeleteEditBox.AppendText(root.rootshow());
                DeleteEditBox.AppendText("\n");
            }

            


        }

        private void DeleteEditButton_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("root.txt");
            string[] rootmass = DeleteEditBox.Text.Split('\n');
            for(int i=0; i != rootmass.Length; i++)
            {
                sw.WriteLine(rootmass[i]);
            }

            sw.Close();

            MessageBox.Show("Изменения сохранены");

        }
    }
}
