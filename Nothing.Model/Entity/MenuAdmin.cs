using System;
using System.Collections.Generic;
using System.Text;

namespace Nothing.Model.Entity
{
    public class MenuAdmin
    {
        public int Id_Menu { get; set; }
        public string NameMenu { get; set; }
        public int ParentID { get; set; }
        public string Where { get; set; }
    }
}
