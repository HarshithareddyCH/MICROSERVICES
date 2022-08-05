using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DriverService.Models;


namespace Driverservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        static List<Driver> driverList = new List<Driver>()
        {
            new Driver(){DriverId=101,Name="D1",Gender="Female",Location="Bangalore",PhoneNumber=91XXXXXXXX},
            new Driver(){DriverId=102,Name="D2",Gender="male",Location="Tamilnadu",PhoneNumber=63XXXXXXXX},
            new Driver(){DriverId=103,Name="D3",Gender="Female",Location="Delhi",PhoneNumber=87XXXXXXXX}
        };

        [HttpGet]
        public List<Driver> Get()
        {
            return driverList;
        }

        [HttpGet("{id}")]
        public Driver Get(int id)
        {
            Driver obj = driverList.Find(item => item.DriverId == id);
            return obj;
        }

        [HttpPost]
        public List<Driver> Post([FromBody] Driver obj)
        {
            driverList.Add(obj);
            return driverList;
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Driver newObj)
        {
            Driver oldObj = driverList.Find(item => item.DriverId == id);
            if (oldObj != null)
            {
                driverList.Insert(id - 1, newObj);
                driverList.Remove(oldObj);
                return Ok();
            }
            return NotFound("Failed : No such Driver Exists");

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Driver obj = driverList.Find(item => item.DriverId == id);
            if (obj != null)
            {
                driverList.Remove(obj);
                return Ok();
            }
            return NotFound("Failed : No such Driver Exists");
        }
    }
}