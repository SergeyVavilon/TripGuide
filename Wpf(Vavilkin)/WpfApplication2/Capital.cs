using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    class Capital
    {
        
        public int H_hotel;
        public int M_hotel;
        public int E_hotel;

        public Capital()
        {
            
            Random rand = new Random();
            this.H_hotel = rand.Next(1000,1500);
            this.M_hotel = rand.Next(300,700);
            this.E_hotel = rand.Next(1,200);
            
        }


    }
}
