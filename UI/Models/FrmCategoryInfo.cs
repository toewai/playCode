using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
namespace UI.Models
{
    public class FrmCategoryInfo
    {
        public String FrmCategoryID { get; set; }
        public String CategoryName { get; set; }
        public String CategoryMyan { get; set; }
        public Boolean Inactive { get; set; }
    }
    public class FrmCategoryCollections : Collection<FrmCategoryInfo> { }
}
