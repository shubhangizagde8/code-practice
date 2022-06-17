﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerApi.Models;


namespace CustomerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        CustomerDb1Context db;
        public SupplierController(CustomerDb1Context _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<Supplier> Get()
        {
            return db.Suppliers ;
        }

        [HttpPost]
        public string Post([FromBody] Supplier supplier)
        {
            db.Suppliers.Add(supplier);
            db.SaveChanges();
            return "success";
        }
    }
}
