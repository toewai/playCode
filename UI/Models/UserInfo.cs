using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
namespace UI.Models
{
    public class UserInfo
    {
        public String UserID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public Boolean Inactive { get; set; }
    }
    public class UserCollections : Collection<UserInfo> { }
}
