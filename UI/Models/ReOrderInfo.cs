using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
namespace UI.Models
{
    public class ReOrderInfo
    {
        public String ReOrderID { get; set; }
        public String StockID { get; set; }
        public int Sr { get; set; }
        public String CountID { get; set; }
        public Int32 Amount { get; set; }
    }
    public class ReOrderCollections : Collection<ReOrderInfo> { }
}
