using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Models
{
    public class CustomerInfo
    {
        public String CustomerID { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }
        public String NRCNO { get; set; }
        public String PerAddress { get; set; }
        public String ContAddress { get; set; }
        public String State { get; set; }
        public String City { get; set; }
        public String Phone1 { get; set; }
        public String Phone2 { get; set; }
        public String Email { get; set; }
        public Boolean Inactive { get; set; }
    }
    public class CustomerCollections : Collection<CustomerInfo> { }
}
