using LiveOdia.APi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LiveOdia.APi.Controllers
{
    public class homeController : ApiController
    {
        // GET: api/home
        public DataTable Get()
        {
            return dbutility.getAllRecord();
        }

        // GET: api/home/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/home
        public bool Post(AdminModel value)
        {
            return dbutility.addNewCategory(value);
        }

        // PUT: api/home/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/home/5
        public void Delete(int id)
        {
        }
    }
}
