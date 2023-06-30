using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Models
{
    public class CounterInfo
    {
        public String CounterID { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }
        public String DefaultName { get; set; }
        public Boolean UsedDefault { get; set; }
        public Boolean Inactive { get; set; }
    }
    public class CounterCollections : Collection<CounterInfo> { }
}
