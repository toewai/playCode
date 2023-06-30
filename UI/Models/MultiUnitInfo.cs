using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
namespace UI.Models
{
    public class MultiUnitInfo
    {
        public String MultiUnitID { get; set; }
        public String StockID { get; set; }
        public int Sr { get; set; }
        public String CountID { get; set; }
        public Int32 Amount { get; set; }
        public Boolean UsedDefault { get; set; }
        public Boolean Inactive { get; set; }
    }
    public class MultiUnitCollections : Collection<MultiUnitInfo> { }
}
