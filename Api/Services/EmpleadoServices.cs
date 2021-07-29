using Api.Models;
using Api.Persistences;
using EFCore.BulkExtensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Services
{
    public class EmpleadoServices
    {
        private readonly AppDbContext _appDbContext;
        private DateTime Inicio;
        private TimeSpan EspacioTiempo;
        public EmpleadoServices(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
        }


        public async Task<TimeSpan> AgregarDatosAsincronaMasivamente() 
        {
            List<Empleado> emp = new List<Empleado>();
            Inicio = DateTime.Now;
            for (int i = 0; i < 1000000; i++) 
            {
                emp.Add(new Empleado()
                {
                    Nombre = "Empleado_" + i,
                    Cargo = "Cargo_" + i,
                    Ciudad = "Ciudad_" + i
                });
            }
            await _appDbContext.BulkInsertAsync(emp);
            EspacioTiempo = DateTime.Now - Inicio;
            return EspacioTiempo;
        }

        public async Task<TimeSpan> ActualizarDatosAsincronaMasivamente() 
        {
            List<Empleado> emp = new List<Empleado>();
            Inicio = DateTime.Now;
            for (int i = 0; i < 1000000; i++)
            {
                emp.Add(new Empleado()
                {
                    Nombre = "Edit_Empleado_" + i,
                    Cargo = "Edit_Cargo_" + i,
                    Ciudad = "Edit_Ciudad_" + i
                });
            }
            await _appDbContext.BulkUpdateAsync(emp);
            EspacioTiempo = DateTime.Now - Inicio;
            return EspacioTiempo;
        }

        public async Task<TimeSpan> EliminarDatosAsincronaMasivamente() 
        {
            List<Empleado> emp = new List<Empleado>();
            Inicio = DateTime.Now;
            emp = _appDbContext.Empleado.ToList();
            await _appDbContext.BulkDeleteAsync(emp);
            EspacioTiempo = DateTime.Now - Inicio;
            return EspacioTiempo;
        }
    }
}
