using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NCWApi.EntityService;
using NCWApi.Entity;

namespace NCWApi.Controllers
{
    [Route("api/[controller]")]
    public class UserController : BaseController
    {
        IUserService _userService;        
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userService.GetAll();
            // return new string[] { "value1", "value2" };
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