using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        [HttpGet]
        public ActionResult Index()
        {
            ML.Result result = BL.Paciente.GetAll();
            ML.Result resultDoctor = BL.Doctor.GetAll();
            ML.Paciente paciente= new ML.Paciente();
            paciente.Pacientes = result.Objects;
            paciente.Doctores= resultDoctor.Objects;
            return View(paciente);
        }

        [HttpGet]
        public ActionResult Form(int? IdPaciente) {
            ML.Paciente paciente = new ML.Paciente();
            ML.Result result= new ML.Result();
            if (IdPaciente!=null)
            {
                result = BL.Paciente.GetById(IdPaciente.Value);
                paciente = (ML.Paciente)result.Object;
            }

            return View(paciente);
        }

        [HttpPost]

        public ActionResult Form(ML.Paciente paciente) {

            ML.Result result=new ML.Result();
            HttpPostedFileBase file = Request.Files["fuImage"];
            if (paciente.Imagen == null)
            {
                byte[] imagen = ConvertToBytes(file);
                paciente.Imagen = Convert.ToBase64String(imagen);
            }
            if (paciente.IdPaciente == 0)
            {
                
                result = BL.Paciente.Add(paciente);
            }
            else { 
                result=BL.Paciente.Update(paciente);
            }
            
            ViewBag.Message=result.Message;
            return PartialView("Modal");
        }

        [HttpGet]

        public ActionResult Delete(int IdPaciente)
        {
            ML.Result result=BL.Paciente.Delete(IdPaciente);
            ViewBag.Message=result.Message;
            return PartialView("Modal");
        }

        public byte[] ConvertToBytes(HttpPostedFileBase foto)
        {

            byte[] data = null;
            System.IO.BinaryReader reader = new System.IO.BinaryReader(foto.InputStream);
            data = reader.ReadBytes((int)foto.ContentLength);
            return data;

        }
    }
}