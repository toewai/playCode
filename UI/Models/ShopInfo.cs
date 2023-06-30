using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
namespace UI.Models
{
    public class ShopInfo
    {
        public String ShopID { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public String Phone1 { get; set; }
        public String Phone2 { get; set; }
        public String email { get; set; }
    }
    public class ShopCollections : Collection<ShopInfo>{}
}
