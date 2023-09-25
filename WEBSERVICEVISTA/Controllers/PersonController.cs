using Microsoft.AspNetCore.Mvc;
using DAL;
using ENTIDADES;
using System;

namespace WEBSERVICEVISTA.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ObjectPerson _objectPerson;

        public PersonController()
        {
            // Inicializa una instancia de ObjectPerson desde DAL
            _objectPerson = new ObjectPerson();
        }

        // Otras acciones del controlador...

        // POST: api/Person/AgregarPersona
        [HttpPost("AgregarPersona")]
        public IActionResult AgregarPersona()
        {
            try
            {
                // Crear una nueva persona
                var nuevaPersona = new Persona("John", "Doe", 30, "john.doe@example.com");

                // Insertar la nueva persona en la base de datos
                _objectPerson.InsertarPersona(nuevaPersona);

                return Ok("Persona insertada con éxito");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }
    }
}
