using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clinic_Appointment_System.Models
{
    public class Patient
    {
        public string Name { get; set; }
        public int Phone { get; set; }
        public int NationalID { get; set; }

        public Patient(int NationalID, string Name, int Phone)
        {
            this.Name = Name;
            this.Phone = Phone;
            this.NationalID = NationalID;
        }


    }
}
