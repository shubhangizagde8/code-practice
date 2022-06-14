using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class HomeController: ControllerBase
    {
        SampleDbContext db = new SampleDbContext();

        /*public string Get()
        {
            return "shubhangi zagade";
        }*/

        [HttpGet]
        public List<Tblsample> Get()
         {

             return db.Tblsamples.ToList();
         }
       /* public List<Employee> Get()
        {

            return db.Employees.ToList();
        }*/

        [HttpPost]
        public string Post([FromBody] string sample)
        {
           // SampleDBContext db = new SampleDBContext();
            Tblsample s = new Tblsample();
            s.Text = sample;
            db.Tblsamples.Add(s);
            db.SaveChanges();
            return "Success";
        }

        [HttpPut]
        public string Put([FromBody] Tblsample tblsample)
        {
            //SampleDBContext db = new SampleDBContext();
            var tblsampleObj = db.Tblsamples.Where(x => x.Id == tblsample.Id);
            if (tblsampleObj != null)
            {
                db.Tblsamples.Update(tblsample);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

        [HttpDelete]
        public string Delete([FromBody] int Id)
        {
           // SampleDBContext db = new SampleDBContext();
            var tblsampleObj = db.Tblsamples.Where(x => x.Id == Id).FirstOrDefault();
            if (tblsampleObj != null)
            {
                db.Tblsamples.Remove(tblsampleObj);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }


    }
}


//Scaffold-DbContext " Data Source=DESKTOP-S0BV6A2;Initial Catalog=SampleDb;Integrated Security=True"  Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models