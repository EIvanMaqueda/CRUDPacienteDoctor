using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Doctor
    {
        public static ML.Result GetAll()
        {

            ML.Result result = new ML.Result();
            try
            {
                using (DL.DoctorPacienteEntities context = new DL.DoctorPacienteEntities())
                {
                    var query = context.DoctorGetAll();
                    if (query != null)
                    {
                        result.Objects = new List<object>();

                        foreach (var obj in query)
                        {
                            ML.Doctor doctor = new ML.Doctor();
                            doctor.IdDoctor = obj.IdDoctor;
                            doctor.Nombre = obj.Nombre;
                            doctor.Imagen = obj.Imagen;
                            doctor.Descripcion = obj.descripcion;

                            result.Objects.Add(doctor);
                        }
                        result.Correct = true;

                    }
                }
            }
            catch (Exception ex)
            {

                result.Message = ex.Message;
                result.Correct = false;
            }
            return result;
        }

        public static ML.Result GetById(int idDoctor)
        {

            ML.Result result = new ML.Result();
            try
            {
                using (DL.DoctorPacienteEntities context = new DL.DoctorPacienteEntities())
                {
                    var query = context.DoctorGetById(idDoctor).AsEnumerable().FirstOrDefault();
                    if (query != null)
                    {
                        ML.Doctor doctor = new ML.Doctor();
                        doctor.IdDoctor = doctor.IdDoctor;
                        doctor.Nombre = query.Nombre;
                        doctor.Descripcion = query.descripcion;
                        doctor.Imagen = query.Imagen;

                        result.Object = doctor;
                        result.Correct = true;
                    }

                }
            }
            catch (Exception ex)
            {

                result.Message = ex.Message;
                result.Correct = false;
            }
            return result;
        }

        public static ML.Result Add(ML.Doctor doctor)
        {

            ML.Result result = new ML.Result();

            try
            {
                using (DL.DoctorPacienteEntities context = new DL.DoctorPacienteEntities())
                {
                    int query = context.DoctorAdd(doctor.Nombre, doctor.Imagen, doctor.Descripcion);
                    if (query > 0)
                    {
                        result.Correct = true;
                        result.Message = "Doctor Agregado Correctamente";
                    }
                }

            }
            catch (Exception ex)
            {

                result.Message = ex.Message;
                result.Correct = false;
            }
            return result;

        }

        public static ML.Result Update(ML.Doctor doctor)
        {

            ML.Result result = new ML.Result();
            try
            {
                using (DL.DoctorPacienteEntities context = new DL.DoctorPacienteEntities())
                {
                    int query = context.DoctorUpdate(doctor.Nombre, doctor.Imagen, doctor.Descripcion, doctor.IdDoctor);
                    if (query > 0)
                    {
                        result.Correct = true;
                        result.Message = "Doctor Actualizado Correctamente";
                    }
                }
            }
            catch (Exception ex)
            {

                result.Message = ex.Message;
                result.Correct = false;
            }
            return result;
        }
        public static ML.Result Delete(int idDoctor)
        {

            ML.Result result = new ML.Result();
            try
            {
                using (DL.DoctorPacienteEntities context = new DL.DoctorPacienteEntities())
                {
                    int query = context.DoctorDelete(idDoctor);
                    if (query > 0)
                    {
                        result.Correct = true;
                        result.Message = "Doctor Eliminado Correctamente";
                    }
                }
            }
            catch (Exception ex)
            {

                result.Correct = false;
                result.Message = ex.Message;
            }
            return result;
        }
    }
}
