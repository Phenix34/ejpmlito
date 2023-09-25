using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Driver;

namespace DAL
{
    internal class Conexion
    {
        private IMongoClient _cliente;
        private IMongoDatabase _baseDeDatos;

        public Conexion()
        {
            // Cadena de conexión a tu base de datos MongoDB
            string cadenaConexion = "mongodb+srv://rele:123@cluster0.u0z21ys.mongodb.net/";

            // Crear el cliente MongoDB
            _cliente = new MongoClient(cadenaConexion);

            // Obtener una referencia a la base de datos
            _baseDeDatos = _cliente.GetDatabase("tecnologiasEmergentes");
        }

        public IMongoCollection<T> ObtenerColeccion<T>(string nombreColeccion)
        {
            // Obtener una referencia a la colección específica
            return _baseDeDatos.GetCollection<T>(nombreColeccion);
        }
    }
}

