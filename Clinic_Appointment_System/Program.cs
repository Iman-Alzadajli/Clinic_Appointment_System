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
            Console.WriteLine("1. Register new patient\n2. Add new doctor\n3. Search doctor by specility\n4. Book appointment\n5. View patient appointments\n6.View all appointment\n7. Exit");

            List<Patient> patients = new List<Patient>();
            List<Doctor> doctors = new List<Doctor>();

            bool quit = false;

            while (quit)
            {
                Console.Write("Enter your choice (1-7): ");
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
                        Console.WriteLine("1. Add new doctor");


                        break;
                    case 3:
                        Console.WriteLine("3. Search doctor by specility");

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

                        break;
                    default:
                        break;

                }
            }



        }
    }
}
