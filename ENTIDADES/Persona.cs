using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ENTIDADES
{
    public  class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Email { get; set; }

        // Constructor
        public Persona(string nombre, string apellido, int edad, string email)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Email = email;
        }

        // Método para mostrar información de la persona
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
