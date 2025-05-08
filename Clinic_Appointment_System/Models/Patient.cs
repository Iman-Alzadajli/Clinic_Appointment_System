using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Appointment_System.Models
{
    public class Patient
    {
        public int Pid { get; set; }
        public string Name { get; set; }
        public int Phone {  get; set; }

        public Patient (int Pid, string Name, int Phone)
        {
            this.Pid = Pid;
            this.Name = Name;
            this.Phone = Phone;
        }

    }
}
