using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
   public class Generate
    {
        public int generate_rand()
        {
            Random ran = new Random();
            int number = ran.Next(1, 101);
            return number;
        }
    }
}
