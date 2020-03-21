using System;
using System.Collections.Generic;
using System.Text;

namespace Nothing.Model.Entity
{
    public class Profile
    {
        public int Id_Profile { get; set; }
        public string Displayname { get; set; }
        public int Id_User { get; set; }
        public int Age { get; set; }

        public string Pathological { get; set; }// Bệnh lý
        public string DoctorComment { get; set; }
    }
}
