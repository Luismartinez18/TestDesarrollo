using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestDesarrollo.Models;
using TestDesarrollo.Logica;
using Newtonsoft.Json;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace TestDesarrollo.Controllers
{
    public class EmpleadoController : Controller
    {
        TestDesarrollo.Logica.Logica cambio;
        public EmpleadoController()
        {
            cambio = new Logica.Logica();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetListEmpleado()
        {
            try
            {
                return Json(cambio.GetListEmpleado());
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

        }


        public IActionResult AdPosicion()
        {
            try
            {
            
                return View();
        
            }
            catch (Exception ex)
            {
           
               throw new Exception(ex.Message);
            }

        }

        [HttpPost]
        public IActionResult AdPosicion(Posicion AddPosicio)
        {
            try
            {
                cambio.AddPosicion(AddPosicio);
                //return View("Ok");
                return Ok("OK");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
                //throw new Exception(ex.Message);
            }
        
        }
        public IActionResult AddEmpleado()
        {
            return View();

        }
        [HttpPost]
        public IActionResult AddEmpleado(Empleado addEmpl)
        {
            try
            {
                cambio.AddEmpleado(addEmpl);
                return Json("Ok");
            }
            catch (Exception ex) {
                return Json(ex.Message);
            }
           

        }
        public IActionResult EditEmpleado(int id)
        {
            try
            {
                ViewBag.id = id;
                return View();
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }
        public IActionResult GetDataEmpleado(int id)
        {
            try
            {
                //ViewBag.id = id;
                return Json(cambio.GetDataEmp(id));
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult EditEmpleado(Empleado EditEmp)
        {
            try
            {
                cambio.EditarEmple(EditEmp);
                return Json("Ok");
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetListPosicion()
        {
            try
            {
                return Json(cambio.GetListPosicion());
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
         
        }
        public IActionResult DeleteEmp(int id)
        {
            try
            {
                ViewBag.id = id;
                return View();
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult DeleteEmp(Empleado Delete)
        {
            try
            {
                cambio.DeleteEmp(Delete.Id);
                return Json("Ok");
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }
    }
}
