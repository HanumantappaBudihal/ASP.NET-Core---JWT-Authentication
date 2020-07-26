using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Hexagonal.ApiDocumentationSwagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        /// <summary>
        /// Get() Method : return all the values 
        /// </summary>
        /// <returns> List of strings</returns>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        /// <summary>
        /// Return the sting with parameter id
        /// </summary>
        /// <param name="id">item id</param>
        /// <returns>return string with id value</returns>
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value " + id; ;
        }

        // POST api/values
        /// <summary>
        ///Add the item in list
        /// </summary>
        /// <param name="value">string value</param>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        /// <summary>
        /// Update the values 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// Remove the string value from the list
        /// </summary>
        /// <param name="id">string value</param>
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
