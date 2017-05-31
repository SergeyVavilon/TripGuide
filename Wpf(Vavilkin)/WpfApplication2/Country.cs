using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    class Country
    {
        public string continent;
        public string name;
        public string Capital;
        public int Price;

        public Country(string continent, string name, string Capital, int Price)
        {
            this.name = name;
            this.Capital = Capital;
            this.Price = Price;
            this.continent = continent;
        }

        public string show()
        {
            return "Название страны: " + name + " Столица: " + Capital + " Стоимость перелёта в $: " + Price;
        }

        public string box()
        {
            return name +": " + Capital;
        }

        public string cont()
        {
            return continent;
        }

        public string root()
        {
            return continent + " " + name + " " + Capital + " ";
        }
    }
}
