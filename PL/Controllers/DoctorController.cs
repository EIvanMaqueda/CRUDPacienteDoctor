using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class DoctorController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ML.Result result=BL.Doctor.GetAll();
            ML.Doctor doctor=new ML.Doctor();
            doctor.Doctores = result.Objects;
            return View(doctor);
        }

        [HttpGet]
        public ActionResult Form(int? IdDoctor)
        {
            ML.Doctor doctor = new ML.Doctor();
            ML.Result result = new ML.Result();
            if (IdDoctor != null)
            {
                result = BL.Doctor.GetById(IdDoctor.Value);
                doctor = (ML.Doctor)result.Object;
            }

            return View(doctor);
        }

        [HttpPost]

        public ActionResult Form(ML.Doctor doctor)
        {

            ML.Result result = new ML.Result();
            
            HttpPostedFileBase file = Request.Files["fuImage"];
            if (doctor.Imagen==null)
            {
                byte[] imagen = ConvertToBytes(file);
                doctor.Imagen = Convert.ToBase64String(imagen);
            }
            if (doctor.IdDoctor == 0)
            {
               
                result = BL.Doctor.Add(doctor);
            }
            else
            {
                result = BL.Doctor.Update(doctor);
            }

            ViewBag.Message = result.Message;
            return PartialView("Modal");
        }

        [HttpGet]

        public ActionResult Delete(int IdDoctor)
        {
            ML.Result result = BL.Doctor.Delete(IdDoctor);
            ViewBag.Message = result.Message;
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