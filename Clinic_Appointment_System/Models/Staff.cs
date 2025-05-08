using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Appointment_System.Models
{
    internal class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string password { get; set; }

        public Staff(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.password = password;
        }
    }
}
