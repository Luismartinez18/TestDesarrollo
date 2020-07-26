using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using TestDesarrollo.Models;

namespace TestDesarrollo.Logica
{

    public class Logica
    {
        Net_CoreContext db;
        public Logica()
        {
            db = new Net_CoreContext();
        }

        public void AddPosicion(Posicion AddPosicio)
        {
            db.Posicion.Add(AddPosicio);
            db.SaveChanges();
        }

        public List<Posicion> GetListPosicion()
        {
            List<Posicion> list = (from d in db.Posicion
                                   select new Posicion
                                   {
                                       Id = d.Id,
                                       Descrpcion = d.Descrpcion,

                                   }).ToList();
            return list;
        }

        public void AddEmpleado(Empleado AddEmpl)
        {
            db.Empleado.Add(AddEmpl);
            db.SaveChanges();
        }
        public List<ListEmpleado> GetListEmpleado()
        {
            List<ListEmpleado> list = new List<ListEmpleado>();
            list = (from d in db.Empleado
                    join a in db.Posicion on d.IdPosicion equals a.Id
                    select new ListEmpleado
                    {
                        id = d.Id,
                        Nombre = d.Nombre,
                        Apellido = d.Apellido,
                        FechaNacimiento = (DateTime)d.FechaNacimiento,
                        Posicion = a.Descrpcion
                    }).ToList();
            return list;
        }
        public Empleado GetDataEmp(int id)
        {
            var GetEmp = (from d in db.Empleado.Where(x => x.Id == id) select d).FirstOrDefault();
            return GetEmp;
        }
        public void EditarEmple(Empleado editEmp)
        {
            var Emp = db.Empleado.Find(editEmp.Id);
            Emp.Nombre = editEmp.Nombre;
            Emp.Apellido = editEmp.Apellido;
            Emp.Cedula = editEmp.Cedula;
            Emp.FechaNacimiento = editEmp.FechaNacimiento;
            Emp.IdPosicion = editEmp.IdPosicion;
            Emp.Telefono = editEmp.Telefono;
            Emp.Direccion = editEmp.Direccion;
            db.Entry(Emp).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteEmp( int id)
        {
            var commandText = "exec sp_Delete_Empleado @id";
            var name = new SqlParameter("@id", id);
            int noOfRowInserted = db.Database.ExecuteSqlCommand(commandText, name);

        }
    }
}
