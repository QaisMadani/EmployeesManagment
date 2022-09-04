using EmployeesManagment.IService;
using EmpManagment.Models;

namespace DepartmentsManagment.Service
{
    public class DepartmentService : IGenericService<Departments>
    {
        List<Departments> _Departments = new List<Departments>();

        public DepartmentService()
        {
            _Departments.Add(new Departments()
            {
                DepartmentId = 0,
                DepartmentName = "Management",
                DepartmentLocation = "Sector A"
            });
            _Departments.Add(new Departments()
            {
                DepartmentId = 1,
                DepartmentName = "Finance",
                DepartmentLocation = "Sector B"
            });
            _Departments.Add(new Departments()
            {
                DepartmentId = 2,
                DepartmentName = "IT",
                DepartmentLocation = "Sector C"
            });
        }

        public List<Departments> Delete(int id)
        {
            _Departments.RemoveAll(x => x.DepartmentId == id);
            return _Departments;
        }

        public List<Departments> GetAll()
        {
            return _Departments;
        }

        public Departments GetById(int id)
        {
            return _Departments.Where(x => x.DepartmentId == id).SingleOrDefault();
        }

        public List<Departments> Insert(Departments item)
        {
            _Departments.Add(item);
            return _Departments;
        }
    }
}
