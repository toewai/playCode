using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
namespace UI.Models
{
    public class WarehouseInfo
    {
        public String WarehouseID { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }
        public Boolean UseDefault { get; set; }
        public Boolean Inactive { get; set; }
    }
    public class WarehouseCollections : Collection<WarehouseInfo> { }
}
