using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ejercicio3.Models
{
    public class tareas2
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(60)]
        public string nombre { get; set; }
        [MaxLength(60)]
        public string apellido { get; set; }
        [MaxLength(60)]
        public int edad { get; set; }
        [MaxLength(60)]
        public string correo { get; set; }
       [MaxLength(60)]
       public string direccion { get; set; }
       

    }
}
