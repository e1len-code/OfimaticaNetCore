using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AppPersonaDocker.Entity
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        public String DNI { get; set; }
        public String Nombres { get; set; }
        public String Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public String Sexo { get; set; }
        public int Telefono { get; set; }
        public String Email { get; set; }


    }
}
