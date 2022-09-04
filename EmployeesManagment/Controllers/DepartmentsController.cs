using EmployeesManagment;
using EmployeesManagment.Controllers;
using EmployeesManagment.IService;
using EmpManagment.Models;
using Microsoft.AspNetCore.Mvc;

namespace DepartmentsManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : GenericController<Departments>
    {
        public DepartmentsController(IGenericService<Departments> genericService, JwtAuthenticationManager jwtAuthenticationManager) : base(genericService, jwtAuthenticationManager)
        {
            
        }
    }
}
