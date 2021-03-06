﻿using GlassdoorAPI;
using System.Collections.Generic;
using System.Web.Http;
using Newtonsoft.Json;

namespace Test.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/SearchQuery = 
        public DataModel Get(string jobfield)
        {
            Glassdoor glassdoor = new Glassdoor(jobfield);
            glassdoor.SetCredentials("[Partner ID]", "[API Key]");
            string content = glassdoor.Search();
            return JsonConvert.DeserializeObject<DataModel>(content);
        }

        

        // POST api/values
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
