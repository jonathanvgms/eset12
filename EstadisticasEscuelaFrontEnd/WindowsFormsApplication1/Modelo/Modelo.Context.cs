﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EestadisticasEscuelaEntities : DbContext
    {
        public EestadisticasEscuelaEntities()
            : base("name=EestadisticasEscuelaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<alumno> alumno { get; set; }
        public DbSet<alumno_x_curso> alumno_x_curso { get; set; }
        public DbSet<asistencia> asistencia { get; set; }
        public DbSet<curso> curso { get; set; }
        public DbSet<docente> docente { get; set; }
        public DbSet<especialidad> especialidad { get; set; }
        public DbSet<materia> materia { get; set; }
        public DbSet<materia_x_curso> materia_x_curso { get; set; }
        public DbSet<nota> nota { get; set; }
        public DbSet<rol> rol { get; set; }
        public DbSet<turno> turno { get; set; }
        public DbSet<usuario> usuario { get; set; }
    }
}
