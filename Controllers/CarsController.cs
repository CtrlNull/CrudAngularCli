using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CrudAngularCli.Models;

namespace CrudAngularCli
{
    [Route("api/cars")]
    public class CarsController : Controller
    {
        // Get All
        [Route("getall"), HttpGet]
        public List<Car> GetAllCars()
        {
            CarsService carsService = new CarsService();
            return carsService.GetAllCars();
        }
    }
}