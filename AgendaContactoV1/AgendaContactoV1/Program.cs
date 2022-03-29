using System;

namespace AgendaContactoV1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Contacto Juan = new Contacto("Juan","Perez", "1198785634", "Calle 1 2345",DateTime.Now.AddYears(-35));
            Contacto Clara = new Contacto("Clara", "Argenti", "1143234234", "Calle ilusoria 42", DateTime.Now.AddYears(-34));
            Contacto Maria = new Contacto("María", "Lopez", "1178463792", "Calle x 123", DateTime.Now.AddYears(-32));
            Contacto Pedro = new Contacto("Pedro", "Gimeneh", "1124324435", "Calle y 323", DateTime.Now.AddYears(-28));

            Agenda agendaconcreta = new Agenda("Agenda", "electrónica", 23);

            agendaconcreta.AgregarContacto(Juan);
            agendaconcreta.AgregarContacto(Clara);
            agendaconcreta.AgregarContacto(Maria);
            agendaconcreta.AgregarContacto(Pedro);

            Console.WriteLine(agendaconcreta.ListadoDeContactos());

        }
    }
}
