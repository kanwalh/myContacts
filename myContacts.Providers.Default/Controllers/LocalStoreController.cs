using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace myContacts.Providers.Controllers
{
    public class LocalStoreController : ApiController
    {
        // GET: api/LocalStore
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/LocalStore/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/LocalStore
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/LocalStore/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/LocalStore/5
        public void Delete(int id)
        {
        }
    }
}
