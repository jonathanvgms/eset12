//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EstadisticasEscuelaFrontEnd.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class rol
    {
        public rol()
        {
            this.usuario1 = new HashSet<usuario>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Usuario { get; set; }
        public bool Rol1 { get; set; }
        public bool Cursos { get; set; }
        public bool Materias { get; set; }
        public bool Alumnos { get; set; }
        public bool Asistencias { get; set; }
        public bool Notas { get; set; }
    
        public virtual ICollection<usuario> usuario1 { get; set; }
    }
}
