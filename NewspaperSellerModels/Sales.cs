using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class Sales
    {  
        public SimulationSystem sim_system { get; set; }
        public SimulationCase sc; 
        public decimal sales_revnue(int demand)
        {  
            if (sim_system.NumOfNewspapers > demand)
                return sc.SalesProfit = demand * sim_system.SellingPrice;
            return sc.SalesProfit = sim_system.NumOfNewspapers * sim_system.SellingPrice;
        }
       public decimal total_cost(int demand)
        {
            return sc.DailyCost = sim_system.NumOfNewspapers * sim_system.PurchasePrice;
        }
        public decimal lost_profit(int demand)
        {
            if (demand > sim_system.NumOfNewspapers)
                return (sc.LostProfit = demand - (sim_system.NumOfNewspapers) * sim_system.SellingPrice);
            return 0;
        }
        public decimal scrap_profit(int demand)
        {
            if (demand < sim_system.NumOfNewspapers)
                return sc.ScrapProfit = (sim_system.NumOfNewspapers - demand) * sim_system.ScrapPrice;
            return 0;
        }
        public decimal total_profit(int demand)
        {
            return sc.DailyNetProfit = sales_revnue(demand) + scrap_profit(demand) - lost_profit(demand) - total_cost(demand);
        }
       
    }
}
