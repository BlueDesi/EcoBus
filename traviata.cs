//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Micros
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class traviata
    {
        public int id { get; set; }
        public string NombreApellido { get; set; }
        public string Destino { get; set; }
        public Nullable<System.DateTime> FechaSalida { get; set; }
        [Range(typeof(TimeSpan),"07:00","19:00",ErrorMessage ="Hora debe estar entre 07 y 19")]
        public Nullable<System.TimeSpan> HoraSalida { get; set; }
        public Nullable<System.DateTime> FechaHoraCompra { get; set; } = DateTime.Now;
    }
}
