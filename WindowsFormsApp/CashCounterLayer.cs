using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class CashCounterLayer : DataBaseAccess
    {
        
        public static int GetCustomerId()
        {
            var a = Get("", type: 14);
            if (a!=null && a.Rows.Count > 0)
            {
                return Convert.ToInt32( a.Rows[0]["CustomerId"])+1;
            }
            return 0001;
        }

        public static int InsertCustomerDetail(CashCounterModel cashCounter)
        {
            return Add(cashCounter, 13);
        }
    }

    public class CashCounterModel : ProductItem
    {
        public int CustomerId { get; set; }
    }


}
