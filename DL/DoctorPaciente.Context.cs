﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DoctorPacienteEntities : DbContext
    {
        public DoctorPacienteEntities()
            : base("name=DoctorPacienteEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cita> Citas { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Paciente> Pacientes { get; set; }
    
        public virtual int CitaAdd(Nullable<int> idDoctor, Nullable<int> idPaciente, Nullable<System.TimeSpan> horaInicio, Nullable<System.TimeSpan> horafin, string descripcion)
        {
            var idDoctorParameter = idDoctor.HasValue ?
                new ObjectParameter("idDoctor", idDoctor) :
                new ObjectParameter("idDoctor", typeof(int));
    
            var idPacienteParameter = idPaciente.HasValue ?
                new ObjectParameter("idPaciente", idPaciente) :
                new ObjectParameter("idPaciente", typeof(int));
    
            var horaInicioParameter = horaInicio.HasValue ?
                new ObjectParameter("horaInicio", horaInicio) :
                new ObjectParameter("horaInicio", typeof(System.TimeSpan));
    
            var horafinParameter = horafin.HasValue ?
                new ObjectParameter("horafin", horafin) :
                new ObjectParameter("horafin", typeof(System.TimeSpan));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CitaAdd", idDoctorParameter, idPacienteParameter, horaInicioParameter, horafinParameter, descripcionParameter);
        }
    
        public virtual int CitaDelete(Nullable<int> idCita)
        {
            var idCitaParameter = idCita.HasValue ?
                new ObjectParameter("idCita", idCita) :
                new ObjectParameter("idCita", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CitaDelete", idCitaParameter);
        }
    
        public virtual ObjectResult<CitaGetAll_Result> CitaGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CitaGetAll_Result>("CitaGetAll");
        }
    
        public virtual ObjectResult<CitaGetById_Result> CitaGetById(Nullable<int> idCita)
        {
            var idCitaParameter = idCita.HasValue ?
                new ObjectParameter("IdCita", idCita) :
                new ObjectParameter("IdCita", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CitaGetById_Result>("CitaGetById", idCitaParameter);
        }
    
        public virtual int CitaUpdate(Nullable<int> idDoctor, Nullable<int> idPaciente, Nullable<System.TimeSpan> horaInicio, Nullable<System.TimeSpan> horaFin, string descripcion, Nullable<int> idCita)
        {
            var idDoctorParameter = idDoctor.HasValue ?
                new ObjectParameter("idDoctor", idDoctor) :
                new ObjectParameter("idDoctor", typeof(int));
    
            var idPacienteParameter = idPaciente.HasValue ?
                new ObjectParameter("idPaciente", idPaciente) :
                new ObjectParameter("idPaciente", typeof(int));
    
            var horaInicioParameter = horaInicio.HasValue ?
                new ObjectParameter("horaInicio", horaInicio) :
                new ObjectParameter("horaInicio", typeof(System.TimeSpan));
    
            var horaFinParameter = horaFin.HasValue ?
                new ObjectParameter("horaFin", horaFin) :
                new ObjectParameter("horaFin", typeof(System.TimeSpan));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            var idCitaParameter = idCita.HasValue ?
                new ObjectParameter("idCita", idCita) :
                new ObjectParameter("idCita", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CitaUpdate", idDoctorParameter, idPacienteParameter, horaInicioParameter, horaFinParameter, descripcionParameter, idCitaParameter);
        }
    
        public virtual int DoctorAdd(string nombre, string imagen, string descripcion)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("imagen", imagen) :
                new ObjectParameter("imagen", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DoctorAdd", nombreParameter, imagenParameter, descripcionParameter);
        }
    
        public virtual int DoctorDelete(Nullable<int> idDoctor)
        {
            var idDoctorParameter = idDoctor.HasValue ?
                new ObjectParameter("IdDoctor", idDoctor) :
                new ObjectParameter("IdDoctor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DoctorDelete", idDoctorParameter);
        }
    
        public virtual ObjectResult<DoctorGetAll_Result> DoctorGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DoctorGetAll_Result>("DoctorGetAll");
        }
    
        public virtual ObjectResult<DoctorGetById_Result> DoctorGetById(Nullable<int> idDoctor)
        {
            var idDoctorParameter = idDoctor.HasValue ?
                new ObjectParameter("idDoctor", idDoctor) :
                new ObjectParameter("idDoctor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DoctorGetById_Result>("DoctorGetById", idDoctorParameter);
        }
    
        public virtual int DoctorUpdate(string nombre, string imagen, string descripcion, Nullable<int> idDoctor)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("imagen", imagen) :
                new ObjectParameter("imagen", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            var idDoctorParameter = idDoctor.HasValue ?
                new ObjectParameter("idDoctor", idDoctor) :
                new ObjectParameter("idDoctor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DoctorUpdate", nombreParameter, imagenParameter, descripcionParameter, idDoctorParameter);
        }
    
        public virtual ObjectResult<GetAll_Result> GetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAll_Result>("GetAll");
        }
    
        public virtual ObjectResult<GetById_Result> GetById(Nullable<int> idPaciente)
        {
            var idPacienteParameter = idPaciente.HasValue ?
                new ObjectParameter("idPaciente", idPaciente) :
                new ObjectParameter("idPaciente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetById_Result>("GetById", idPacienteParameter);
        }
    
        public virtual int PacienteAdd(string nombre, string imagen, string descripcion)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("imagen", imagen) :
                new ObjectParameter("imagen", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PacienteAdd", nombreParameter, imagenParameter, descripcionParameter);
        }
    
        public virtual int PacienteDelete(Nullable<int> idPaciente)
        {
            var idPacienteParameter = idPaciente.HasValue ?
                new ObjectParameter("idPaciente", idPaciente) :
                new ObjectParameter("idPaciente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PacienteDelete", idPacienteParameter);
        }
    
        public virtual ObjectResult<PacienteGetAll_Result> PacienteGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PacienteGetAll_Result>("PacienteGetAll");
        }
    
        public virtual ObjectResult<PacienteGetById_Result> PacienteGetById(Nullable<int> idPaciente)
        {
            var idPacienteParameter = idPaciente.HasValue ?
                new ObjectParameter("idPaciente", idPaciente) :
                new ObjectParameter("idPaciente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PacienteGetById_Result>("PacienteGetById", idPacienteParameter);
        }
    
        public virtual int PacienteUpdate(string nombre, string imagen, string descripcion, Nullable<int> idPaciente)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("imagen", imagen) :
                new ObjectParameter("imagen", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            var idPacienteParameter = idPaciente.HasValue ?
                new ObjectParameter("idPaciente", idPaciente) :
                new ObjectParameter("idPaciente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PacienteUpdate", nombreParameter, imagenParameter, descripcionParameter, idPacienteParameter);
        }
    }
}
