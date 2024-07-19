using System;

namespace MedicalClinic
{
    class PatientDetails
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string PatientLastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public bool Haslnsurance { get; set; }
        public double Weight { get; set; }

        public DateTime LastVisitDate { get; set; }
        public string ContactNumber { get; set; }
        public void DisplayPatientDetails()
        {
            Console.WriteLine($"Patient Id : {PatientId}");
            Console.WriteLine($"Patient Name : {PatientName}");
            Console.WriteLine($"Patient LastName : {PatientLastName}");
            Console.WriteLine($"Patient Age : {Age}");
            Console.WriteLine($"Patient Gender : {Gender}");
            Console.WriteLine($"Patient Haslnsuran : {Haslnsurance}");
            Console.WriteLine($"Patient Weight : {Weight}");
            Console.WriteLine($"Patient Last VisitDate : {LastVisitDate}");
            Console.WriteLine($"Patient ContectNumber : {ContactNumber}");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            PatientDetails patient = new PatientDetails
            {
                PatientId = 100,
                PatientName = "Sandy",
                PatientLastName = "Yadli",

                Age = 25,
                Gender = "Male",
                Haslnsurance = true,
                Weight = 70,
                LastVisitDate = DateTime.Now.AddMonths(-1),
                ContactNumber = " 3456789012",

            };
            patient.DisplayPatientDetails();

        }
    }
}

