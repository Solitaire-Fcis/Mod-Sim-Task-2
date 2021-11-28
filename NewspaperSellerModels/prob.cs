using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
   public class prob
    {
        public
           
        int type;
        int day_ran;
        int demand_ran;
        Sales s;
        Generate g;
        prob(Sales sa)
        {
            day_ran = g.generate_rand();
            demand_ran= g.generate_rand();
            s = sa;

            day_type();
        }
        void day_type()
        {
            if (day_ran < s.sim_system.DayTypeDistributions[0].MaxRange)
            {
                type = 0;
            }
            else if(day_ran < s.sim_system.DayTypeDistributions[1].MaxRange){
                type = 1;
            }
            else{
                type = 2;
            }
        }
        
    }
}
