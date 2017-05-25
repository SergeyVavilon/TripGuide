using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    class Root
    {

        public string continent;
        public string country;
        public string capital;
        public string hotelname;
        
        

        public Root(string continent,string country, string capital, string hotelname)
        {
            this.continent = continent;
            this.country = country;
            this.capital = capital;
            this.hotelname = hotelname;
            
            
        }

        public string rootshow()
        {
            return continent +" "+ country +" "+ capital +" "+ hotelname;
        }

        

    }
}
