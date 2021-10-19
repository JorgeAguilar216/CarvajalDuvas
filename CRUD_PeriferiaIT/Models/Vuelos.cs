using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_PeriferiaIT.Models
{
    public class Vuelos
    {
        [Key]
        public int VueloID { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string CiudadOrigen { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string CiudadDestino { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Fecha { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string HoraSalida { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string HoraLlegada { get; set; }
        [Column(TypeName = "int")]
        public int NumeroVuelo { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Aerolinia { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string EstadoVuelo { get; set; }
        
    }
}
