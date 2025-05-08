using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Specialty
{
    Pediatrics,Cardiology,Dermatology
}

namespace Clinic_Appointment_System.Models
{
    public class Doctor
    {
        public int Did { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }

        public Specialty Specialty { get; set; }

        public Doctor (int Did, string Name, int Phone , Specialty Specialty)
        {
            this.Did = Did;
            this.Name = Name;
            this.Phone = Phone;
            this.Specialty = Specialty;
        }
         
    }

}
