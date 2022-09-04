using EmployeesManagment.IService;
using EmpManagment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : GenericController<Employees>
    {
        public EmployeesController(IGenericService<Employees> genericService , JwtAuthenticationManager jwtAuthenticationManager) : base(genericService, jwtAuthenticationManager)
        {
            
        }
    }
}
