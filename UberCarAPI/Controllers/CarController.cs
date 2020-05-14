using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UberCarAPI.Models;

namespace UberCarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        public CarController()
        {
        }


        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return Repository.CarRepository.Cars;
        }


        [HttpGet("{id}", Name = "Get")]
        public Car Get(int id)
        {
            return Repository.CarRepository.Cars.FirstOrDefault(x => x.Id == id);
        }


        [HttpPost]
        public IActionResult Post([FromBody] Car value)
        {
            if (value.FabricationYear < 2010)
            {
                return BadRequest(
                    new
                    {
                        Message = "Fabrication Year must be greater than 2010",
                        Error = true
                    });
            }
            if (value.HasAc == false)
            {
                return BadRequest(
                    new
                    {
                        Message = "Car must have an A/C",
                        Error = true
                    });

            }

            if (value.IsLuxe == true && (value.Color == "black" || value.Color == "Black"))
            {
                value.UberCategory = "black";
            }
            else
            {
                value.UberCategory = "x";
            }

            Repository.CarRepository.Cars.Add(value);

            return Ok(
                new
                {
                    Message = "Car registered successfully. " +
                    "Your car has been added to the category Uber " +
                    value.UberCategory
                });
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Car value)
        {
            Car cr = Repository.CarRepository.Cars.FirstOrDefault(x => x.Id == id);
            if (cr != null)
            {
                cr.Model = value.Model;
                cr.Brand = value.Brand;
                cr.Color = value.Color;
                cr.Plate = value.Plate;
                cr.FabricationYear = value.FabricationYear;
                cr.IsLuxe = value.IsLuxe;
                cr.HasAc = value.HasAc;
                cr.UberCategory = value.UberCategory;
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Car cr = Repository.CarRepository.Cars.FirstOrDefault(x => x.Id == id);
            if (cr != null)
            {
                Repository.CarRepository.Cars.Remove(cr);
            }
        }
    }
}
