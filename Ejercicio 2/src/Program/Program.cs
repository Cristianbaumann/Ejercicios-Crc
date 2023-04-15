using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Paciente persona1 = new Paciente("Pedro","53537302","46","097248789");
            Doctor doctor1 = new Doctor("Pedro","Cirujano");

            Paciente persona2 = new Paciente("Jorge","53537301","19","097224555");
            Doctor doctor2 = new Doctor("Juan","Pediatra");


            string appointmentResult = AppointmentService.CreateAppointment(persona2, DateTime.Now, "Wall Street", doctor1);
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment(persona2, DateTime.Now, "Queen Street", doctor2);
            Console.WriteLine(appointmentResult2);

        }
    }
}
