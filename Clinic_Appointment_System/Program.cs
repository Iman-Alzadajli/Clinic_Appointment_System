using Clinic_Appointment_System.Models;

namespace Clinic_Appointment_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("Welcome to Oman Clinic Appointment System");
            Console.WriteLine("=========================================\n");

            List<Patient> patients = new List<Patient>();
            List<Doctor> doctors = new List<Doctor>();
            List<Appointment> appointment = new List<Appointment>();

            bool quit = true;

            while (quit)
            {
                Console.WriteLine("1. Register new patient\n2. Add new doctor\n3. Search doctor by specility\n4. Book appointment\n5. View patient appointments\n6.View all appointment\n7. Exit");
                Console.Write("\nEnter your choice (1-7): ");
                int choice = int.Parse(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("-- Register new patient -- ");
                        Console.Write("Enter Patient Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter National ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Phone Number: ");
                        int phone = int.Parse(Console.ReadLine());
                        patients.Add(new Patient(id, name, phone));
                        // add error checker
                        Console.WriteLine("Patient registered successfully!");
                        break;

                    case 2:
                        Console.WriteLine("-- Register new Doctor -- ");
                        Console.Write("Enter Doctor Name: ");
                        string named = Console.ReadLine();
                        Console.Write("Enter National ID: ");
                        int idd = int.Parse(Console.ReadLine());
                        Console.Write("Enter Specialty : ");
                        string sp= Console.ReadLine();
                        Console.Write("Enter Phone Number: ");
                        int phoned = int.Parse(Console.ReadLine());
                        doctors.Add(new Doctor(idd, named, phoned ,sp));
                        // add error checker
                        Console.WriteLine("Patient registered successfully!");

                        break;
                    case 3:
                        Console.WriteLine("--Search doctor by specility--");
                        Console.Write("Enter Specialty to search: ");
                        string specilty = Console.ReadLine();

                        foreach (Doctor d in doctors)
                        {
                            if(d.Specialty == specilty)
                            {
                                Console.WriteLine($"Dr.{d.Name} | Phone: {d.Phone}");
                            }
                        }

                        break;

                    case 4:
                        Console.WriteLine("-- Book appointment --");
                        Console.Write("Enter Patient National ID: ");
                        int PID = int.Parse(Console.ReadLine());

                        Patient tempP =  null;
                        foreach(Patient pat in patients)
                        {
                            if(pat.NationalID == PID)
                            {
                                tempP = pat;
                            }
                        }

                        Console.Write("Enter Doctor Name: ");
                        string nameDr = Console.ReadLine();

                        Doctor tempD = null;
                        foreach (Doctor d in doctors)
                        {
                            if (d.Name == nameDr)
                            {
                                tempD = d;
                            }
                        }

                        Console.Write("Enter appointment date (dd/mm/yyyy): ");
                        string date = Console.ReadLine();

                        appointment.Add(new Appointment(date, tempD, tempP));

                        Console.WriteLine("Appintment booked successfully!");
                        break;

                    case 5:
                        Console.WriteLine("-- View patient appointments--\n");
                        Console.Write("Enter Patient National ID: ");
                        int PaitentID = int.Parse(Console.ReadLine());

                        foreach (Appointment a in appointment)
                        {
                            if (a.Patient.NationalID == PaitentID){
                                Console.WriteLine($"Appointments for {a.Patient.Name}:");
                                Console.WriteLine($"Date: {a.Date} | Doctor: {a.Doctor.Name} | Spitiality: {a.Doctor.Specialty}");
                            }
                        }
                        break;
                    case 6:
                        Console.WriteLine("--View all appointment--\n");
                        foreach (Appointment a in appointment)
                        {
                            Console.WriteLine($"Patient: {a.Patient.Name} | Doctor: {a.Doctor.Name} | Date: {a.Date} | Spitiality: {a.Doctor.Specialty}");
                        }
                        break;
                    case 7:
                        Console.WriteLine("Thank you for using the System. Good Bye!");
                        quit = false;

                        break;
                    default:
                        break;

                }
            }



        }
    }
}
