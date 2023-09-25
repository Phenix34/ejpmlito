using DAL;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LN
{
    public class PersonaService
    {
        private readonly ApplicationDbContext _context;

        public PersonaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void InsertarPersona(Persona persona)
        {
            // Validación de datos
            if (string.IsNullOrWhiteSpace(persona.Nombre))
            {
                throw new ArgumentException("El nombre de la persona es obligatorio.");
            }

            // Aplicación de reglas de negocio
            if (persona.Edad < 0)
            {
                throw new ArgumentException("La edad no puede ser un número negativo.");
            }

            // Lógica de negocio adicional (por ejemplo, generar un número de identificación único)

            // Inserción en la base de datos
            _context.Personas.Add(persona);
            _context.SaveChanges();
        }
    }

}
