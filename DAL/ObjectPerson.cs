using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using MongoDB.Driver;
using ENTIDADES; // Importa el espacio de nombres donde se encuentra la clase Persona   


namespace DAL
{
    public class ObjectPerson
    {
        private IMongoCollection<Persona> _coleccionPersonas;
        private Conexion _conexion;

        public ObjectPerson()
        {
            // Inicializa la conexión a la base de datos
            _conexion = new Conexion();
            _coleccionPersonas = _conexion.ObtenerColeccion<Persona>("Persona"); // Reemplaza "person" con el nombre de tu colección
        }

        public void InsertarPersona(Persona persona)
        {
            // Inserta una persona en la colección
            _coleccionPersonas.InsertOne(persona);
        }

        public Persona ObtenerPersonaPorNombre(string nombre)
        {
            // Busca una persona por nombre en la colección
            return _coleccionPersonas.Find(p => p.Nombre == nombre).FirstOrDefault();
        }

        // Puedes agregar más métodos para consultar y actualizar personas según tus necesidades
    }
}

