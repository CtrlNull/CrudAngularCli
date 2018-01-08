using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CrudAngularCli.Models;
using CrudAngularCli.Services;

namespace CrudAngularCli
{
    [Route("api/[cars]")]
    public class CarsController : Controller
    {
        // Get All
        [Route("getall"), HttpGet]
        public List<Car> GetAllCars()
        {
            carService carsService = new carService();
            return carsService.GetAllCars();
        }
    }
}