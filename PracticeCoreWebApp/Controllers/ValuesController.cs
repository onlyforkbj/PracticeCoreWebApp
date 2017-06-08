using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace PracticeCoreWebApp.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ApplicationSettings appSettings;
        private readonly IHostingEnvironment hosting;

        public ValuesController(IOptions<ApplicationSettings> appSettings, IHostingEnvironment hosting)
        {
            this.hosting = hosting;
            this.appSettings = appSettings.Value;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new[] { appSettings.GraphUrl, appSettings.PeopleServiceUrl, hosting.EnvironmentName };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}