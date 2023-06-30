using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
namespace UI.Models
{
    public class FrmInfo
    {
        public String FrmID { get; set; }
        public String FrmName { get; set; }
        public String FrmMyan { get; set; }
        public String FrmDescription { get; set; }
        public String FrmCategoryID { get; set; }
        public Boolean Inactive { get; set; }
    }
    public class FrmCollections : Collection<FrmInfo> { }
}
