using GlassdoorAPI;
using System.Collections.Generic;
using System.Web.Http;
using Newtonsoft.Json;

namespace Test.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/google
        public DataModel Get(string jobfield)
        {
            Glassdoor glassdoor = new Glassdoor(jobfield);
            string content = glassdoor.Search();
            return JsonConvert.DeserializeObject<DataModel>(content);
        }

        

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
