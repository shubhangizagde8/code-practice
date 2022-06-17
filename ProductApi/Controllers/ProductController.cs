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
    public class ProductController : ControllerBase
    {

        CustomerDbContext db;

        public ProductController(CustomerDbContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return db.Products;
        }

        [HttpPost]
        public string Post([FromBody] Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return "success";
        }
        [HttpPut]
        public string Put([FromBody] Product product)
        {
            var Obj = db.Products.Where(x => x.Id == product.Id);
            if (Obj != null)
            {
                db.Products.Update(product);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }
        [HttpDelete]
        public string Delete([FromBody] int Id)
        {

            var Obj = db.Products.Where(x => x.Id == Id).FirstOrDefault();
            if (Obj != null)
            {
                db.Products.Remove(Obj);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

    }
}
