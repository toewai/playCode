using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
namespace UI.Models
{
    public class FrmPermissionInfo
    {
        public String FrmPermissionID { get; set; }
        public String FrmID { get; set; }
        public Boolean isRead { get; set; }
        public Boolean isSave { get; set; }
        public Boolean isUpdate { get; set; }
        public String UserID { get; set; }
        public Boolean Inactive { get; set; }
    }
    public class FrmPermissionCollections : Collection<FrmPermissionInfo> { }
}
