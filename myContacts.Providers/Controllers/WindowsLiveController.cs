using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace myContacts.Providers.Controllers
{
    public class WindowsLiveController : ApiController
    {
        // GET: api/WindowsLive
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/WindowsLive/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/WindowsLive
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/WindowsLive/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/WindowsLive/5
        public void Delete(int id)
        {
        }
    }
}
