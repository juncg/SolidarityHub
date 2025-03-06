using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRUEBAS.Models
{
    public class Afectado
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string DNI { get; set; }
        public required string Telefono { get; set; }
        public required string Direccion { get; set; }
        public required string Email { get; set; }
    }
}