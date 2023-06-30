using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Models
{
    public class CategoryInfo
    {
        public String CategoryID { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }
        public Boolean Inactive { get; set; }
    }
    public class CategoryCollections : Collection<CategoryInfo> { }
}
