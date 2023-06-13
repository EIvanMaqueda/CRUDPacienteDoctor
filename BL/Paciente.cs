using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Paciente
    {
        public static ML.Result GetAll() { 
        
            ML.Result result = new ML.Result();
            try
            {
                using (DL.DoctorPacienteEntities context=new DL.DoctorPacienteEntities())
                {
                    var query=context.PacienteGetAll();
                    if (query!=null)
                    {
                        result.Objects = new List<object>();
                        
                        foreach (var obj in query)
                        {
                            ML.Paciente paciente=new ML.Paciente();
                            paciente.IdPaciente = obj.IdPaciente;
                            paciente.Nombre= obj.Nombre;
                            paciente.Imagen=obj.Imagen;
                            paciente.Descripcion = obj.descripcion;
                            
                            result.Objects.Add(paciente);
                        }
                        result.Correct = true;
                        
                    }
                }
            }
            catch (Exception ex)
            {

                result.Message=ex.Message;
                result.Correct=false;
            }
            return result;
        }

        public static ML.Result GetById(int idPaciente) { 
        
            ML.Result result = new ML.Result();
            try
            {
                using (DL.DoctorPacienteEntities context=new DL.DoctorPacienteEntities())
                {
                    var query = context.PacienteGetById(idPaciente).AsEnumerable().FirstOrDefault();
                    if (query!=null)
                    {
                        ML.Paciente paciente = new ML.Paciente();
                        paciente.IdPaciente = query.IdPaciente;
                        paciente.Nombre = query.Nombre;
                        paciente.Descripcion = query.descripcion;
                        paciente.Imagen = query.Imagen;

                        result.Object = paciente;
                        result.Correct = true;
                    }
                    
                }
            }
            catch (Exception ex)
            {

                result.Message=ex.Message;
                result.Correct=false;
            }
            return result;
        }

        public static ML.Result Add(ML.Paciente paciente) {
            
            ML.Result result=new ML.Result();
           
            try
            {
                using (DL.DoctorPacienteEntities context=new DL.DoctorPacienteEntities())
                {
                    int query = context.PacienteAdd(paciente.Nombre,paciente.Imagen,paciente.Descripcion);
                    if (query>0) {
                        result.Correct = true;
                        result.Message = "Paciente Agregado Correctamente";
                    }
                }
                   
            }
            catch (Exception ex)
            {

                result.Message=ex.Message;  
                result.Correct=false;
            }
            return result;
        
        }

        public static ML.Result Update(ML.Paciente paciente) { 
        
            ML.Result result=new ML.Result();
            try
            {
                using (DL.DoctorPacienteEntities context=new DL.DoctorPacienteEntities())
                {
                    int query = context.PacienteUpdate(paciente.Nombre,paciente.Imagen,paciente.Descripcion,paciente.IdPaciente);
                    if (query>0)
                    {
                        result.Correct = true;
                        result.Message = "Paciente Actualizado Correctamente";
                    }
                }
            }
            catch (Exception ex)
            {

                result.Message=ex.Message;
                result.Correct=false;
            }
            return result;
        }
        public static ML.Result Delete(int idPaciente) { 
        
            ML.Result result=new ML.Result();
            try
            {
                using (DL.DoctorPacienteEntities context = new DL.DoctorPacienteEntities())
                {
                    int query = context.PacienteDelete(idPaciente);
                    if (query>0)
                    {
                        result.Correct = true;
                        result.Message = "Paciente Eliminado Correctamente";
                    }
                }
            }
            catch (Exception ex)
            {

                result.Correct = false;
                result.Message=ex.Message;
            }
            return result;
        }
    }
}
