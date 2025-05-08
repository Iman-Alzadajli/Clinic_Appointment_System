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
                        Console.Write("Enter Specialty to search : ");
                        string checksp = Console.ReadLine();

                        if((checksp.ToLower() != "pediatrics")  || (checksp.ToLower() != "Cardiology") || (checksp.ToLower() != "Dermtology"))
                        {
                            Console.WriteLine("Invalid");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Doctor found!");
                            foreach (Doctor d in doctors)
                            {
                                if (checksp.ToLower() == d.Specialty)
                                {
                                    Console.WriteLine($"Dr. {d.Name} | Phone: {d.Phone}");
                                }
                            }

                        }

                        break;

                    case 4:
                        Console.WriteLine("4. Book appointment\n");

                        break;
                    case 5:
                        Console.WriteLine("5. View patient appointments\n");

                        break;
                    case 6:
                        Console.WriteLine("6.View all appointment\n");

                        break;
                    case 7:
                        Console.WriteLine("7. Exit");
                        quit = false;

                        break;
                    default:
                        break;

                }
            }



        }
    }
}
