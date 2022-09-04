using EmployeesManagment.IService;
using EmployeesManagment.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeesManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T> : Controller where T : class
    {
        private IGenericService<T> _genericService;

        private readonly JwtAuthenticationManager _jwtAuthenticationManager;

        /*public GenericController(JwtAuthenticationManager jwtAuthenticationManager)
        {
            this._jwtAuthenticationManager = jwtAuthenticationManager;
        }*/

        public GenericController(IGenericService<T> genericService, JwtAuthenticationManager jwtAuthenticationManager)
        {
            _genericService = genericService;
            _jwtAuthenticationManager = jwtAuthenticationManager;   

        }
        

        [Authorize]
        [HttpGet]
        public List<T> Get()
        {
            return _genericService.GetAll();
        }

        [Authorize]
        [HttpGet("{id}")]
        public T Get(int id)
        {
            return _genericService.GetById(id);
        }

        [Authorize]
        [HttpPost]
        public List<T> Post([FromBody] T value)
        {
            return _genericService.Insert(value);
        }

        [Authorize]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [Authorize]
        [HttpDelete("{id}")]
        public List<T> Delete(int id)
        {
            return _genericService.Delete(id);
        }

        [AllowAnonymous]
        [HttpPost("Authorize")]
        public IActionResult AuthUser([FromBody] User usr)
        {
            var token = _jwtAuthenticationManager.Authenticate(usr.UserName, usr.Password);
            if (token == null)
            {
                return Unauthorized();
            }

            return Ok(token);
        }

    }
}

