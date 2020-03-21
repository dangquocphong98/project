using System;
using System.Collections.Generic;
using System.Text;

namespace Nothing.Model.Entity
{
    public class User
    {
        public int Id_User { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string RoleMenu { get; set; }
        public int Id_Role { get; set; }
    }
}
