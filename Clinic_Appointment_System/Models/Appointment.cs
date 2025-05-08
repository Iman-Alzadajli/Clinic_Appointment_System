using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Appointment_System.Models
{
    internal class Appointment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public Doctor Doctor { get; set; }
        // public int / { get; set; }
        public Patient Patient { get; set; }
        // public int PatientId { get; set; }


        public Appointment(int id, DateTime date, Doctor doctor, Patient patient)
        {
            this.Id = id;
            this.Date = date;
            this.Doctor = doctor;
            this.Patient = patient;

        }


    }
}

