using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace NATA20241103DB.Models
{
    public class Empleado
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Puesto { get; set; }

        public ICollection<ReferenciaPersonal> ReferenciasPersonales { get; set; }
    }
    public class ReferenciaPersonal
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }

        public int EmpleadoID { get; set; }
        public Empleado Empleado { get; set; }
    }
    public class MiContexto : DbContext
    {
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<ReferenciaPersonal> ReferenciasPersonales { get; set; }
    }

}

