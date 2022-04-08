using System;

namespace AgendaContactoV1
{
    class Program
    {
        static void Main(string[] args)
        {

            Validador validador = new Validador();
            string nombre;  
            string apellido; 
            string telefono;
            string direccion;
            DateTime fecha;
            Contacto contacto;
            Agenda agendaconcreta = new Agenda("Agenda especial","electrónica",2);
            string opcion;
            int codigo;

            //do
            //{

            //    nombre = validador.pedirString("Ingrese nombre");
            //    apellido = validador.pedirString("apellido");
            //    telefono = validador.pedirString("telefono");
            //    direccion = validador.pedirString("dirección");

            //    do
            //    {
            //        opcion = validador.pedirString("Continue S/N");
            //        if (opcion != "S" && opcion != "N")
            //        {
            //            Console.WriteLine("Ingrese una opción válida"); 
            //        }
            //    } while (opcion != "S" && opcion != "N");
            //    contacto = new Contacto(nombre, apellido, telefono, direccion, DateTime.Now.AddYears(-35));
            //   // codigo = contacto.AutoIncrementar();
            //    agendaconcreta.AgregarContacto(contacto);


            //} while (opcion != "N");

            //Console.WriteLine(agendaconcreta.ListadoDeContactos());

            //Antes era así.

            //Contacto Juan = new Contacto(1,"Juan","Perez", "1198785634", "Calle 1 2345",DateTime.Now.AddYears(-35));
            //Contacto Clara = new Contacto(2,"Clara", "Argenti", "1143234234", "Calle ilusoria 42", DateTime.Now.AddYears(-34));
            //ContactoBase contacto2 = new Contacto(2,"Carlos", "Lopez", "342342342", "Calle fg", DateTime.Now.AddYears(-20));

            ContactoFisico Juan = new ContactoFisico(1, "Juan", "Perez", "1198785634", "Calle 1 2345", DateTime.Now.AddYears(-35));
            ContactoBase contacto2 = new ContactoJuridico(2, "Carlos", "Lopez", "342342342", "Calle fg","Pyme srl" ,DateTime.Now.AddYears(-2));
            
            ContactoEspecial ce1 = new ContactoEspecial(3, "Gabriela", "Zaifon");
            ContactoBase ce2 = new ContactoEspecial(4, "Susana","Fernandez");

            //Juan.Apellido();


            static ContactoBase GetContactoRandom()
            {
                if (DateTime.Now.Minute > 30)
                {
                    return new ContactoFisico(2, "Clara", "Argenti", "1143234234", "Calle ilusoria 42", DateTime.Now.AddYears(-34));
                } //Cambio en 1:38:17
                else
                {
                   return new ContactoEspecial(4, "Susana", "Fernandez");
                }
            }

            //ContactoEspecial crandom = GetContactoRandom() Esto no iria porque necesitamos que se reciban las dos cosas. 
            //Luego viene la conversión explicita.

            //01:23:47. La variable que quiero convertir es un contacobase Sirve para comparar contactos. 

           

            

            agendaconcreta.AgregarContacto(Juan);
            agendaconcreta.AgregarContacto(ce1);
            agendaconcreta.AgregarContacto(ce2);

            //Hariamos un for recorriendo la lista y dependiendo de que ibjeto se trate, se hace una cosa u otra.

            ContactoBase crandom = GetContactoRandom(); //Partimos en orden. ContactoBase, Contacto, ContacoEspecial. Ver todo como sigue abajo

            if (crandom is Contacto)
            {
                //Ahora viene el tema de como se lo convierte.

                Contacto convertToContacto = (Contacto)crandom; //La variable crandom que del tipo contacto Contactobase la pasamos a contacto

                Console.WriteLine(convertToContacto.Direccion);
            }


            else if(crandom is ContactoEspecial)//si fuera contacto convencional no podría acceder a antiguedad (abajo)
            {
                ContactoEspecial ConvertTocontactoEspecial = (ContactoEspecial)crandom;

                Console.WriteLine(ConvertTocontactoEspecial.Antiguedad); 
            }

            //La clase base solo sirve "para traer y llevar cosas"

            //Contacto2. si hago esto no voy a poder utilizar carateristicas propias de la especialización (contacto especial). 
            //No se puede porque es´tá encerrado en una variable base. 1:20:59
            //Contacto Maria = new Contacto("María", "Lopez", "1178463792", "Calle x 123", DateTime.Now.AddYears(-32));
            //Contacto Pedro = new Contacto("Pedro", "Gimeneh", "1124324435", "Calle y 323", DateTime.Now.AddYears(-28));

            //Agenda agendaconcreta = new Agenda("Agenda", "electrónica", 23);

            //agendaconcreta.AgregarContacto(Juan);
            //agendaconcreta.AgregarContacto(Clara);
            //agendaconcreta.AgregarContacto(Maria);
            //agendaconcreta.AgregarContacto(Pedro);

            //Console.WriteLine(agendaconcreta.ListadoDeContactos());


            //2) Ahora especialización 1:29:59

            //Por ejemplo un contacto de empresa o emrpesa física



            //1)

            ContactoEspecial ce = new ContactoEspecial();
            //ce hereda de la clase object. Hereda solo cuatro metodos.
            //ce.

            //Pero ahora vamos a generalizar. Es decir que haya dos clases hijas de una superclase (contacto y contacto especial)
            //Son del mismo tipo pero distinto.

            ContactoBase cb1 = new ContactoEspecial(); // cb1 es un ContactoEspecial pero también un ContactoBase porque es su padre.
                                                       // Esta bien que no se pueda intanciar contacto base, pero puede recibir a contactoespecial.

            //Si se hace cb1. solo se verá solo lo que está declarado en el padre.

            ContactoEspecial cb2 = new ContactoEspecial(); //Esto es lo mismo. Pero depende el caso, a veces queremos recibir una variable
                                                           // y no sabemos de que tipo específico es. Sabemos que es de base pero no sabemos
                                                           // cual de los dos contactos es.  
            //Esto es generalización. Es decir, te pongo un padre para unir dos abstracciones. En este caso estoy uniendo Contacto y ContactoEspecial


        }
    }
}
