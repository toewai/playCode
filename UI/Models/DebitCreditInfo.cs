using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Models
{
    public class DebitCreditInfo
    {
        public String DebitCreditID { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }
        public Boolean Income { get; set; }
        public Boolean Outcome { get; set; }
    }
    public class DebitCreditCollections : Collection<DebitCreditInfo> { }
}
