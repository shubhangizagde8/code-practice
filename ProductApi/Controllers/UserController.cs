using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductApi.Models;

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase

    {
        CustomerDbContext db;

        public UserController(CustomerDbContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return db.Customers;
        }

        [HttpPost]
        public string Post([FromBody] Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
            return "success";
        }
        [HttpPut]
        public string Put([FromBody] Customer customer)
        {
            var tblsampleObj = db.Customers.Where(x => x.Id == customer.Id);
            if (tblsampleObj != null)
            {
                db.Customers.Update(customer);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }
        [HttpDelete]
        public string Delete([FromBody] int Id)
        {
            
            var Obj = db.Customers.Where(x => x.Id == Id).FirstOrDefault();
            if (Obj != null)
            {
                db.Customers.Remove(Obj);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }


    }
}
