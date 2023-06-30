using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Models
{
    public class StockInfo
    {
        public String StockID { get; set; }
        public String Name { get; set; }
        public String Code { get; set; }
        public String SubCategoryID { get; set; }
        public String CategoryID { get; set; }
        public Boolean Inactive { get; set; }
        public Boolean ToReOrder { get; set; }
        public Boolean ToAddPhoto { get; set; }
    }
}
