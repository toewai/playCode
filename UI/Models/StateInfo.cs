using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Models
{
    public class StateInfo
    {
        public String StateID { get; set; }
        public String Code { get; set; }
        public String State { get; set; }
        public String City { get; set; }
    }
    public class StateCollections : Collection<StateInfo> { }
}
