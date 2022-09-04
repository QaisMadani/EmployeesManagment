using EmployeesManagment.IService;
using EmpManagment.Models;

namespace EmployeesManagment.Service
{
    public class EmployeeService : IGenericService<Employees>
    {
        List<Employees> _Employees = new List<Employees>();

        public EmployeeService()
        {
            for (int i = 1; i <= 9; i++)
            {
                _Employees.Add(new Employees()
                { 
                    //EmployeeId = i,
                    EmployeeName = "ITEmp" + i,
                    DepartmentRefId = 2,
                    CardRefId = Guid.NewGuid(),
                });
            }

            for (int i = 10; i <= 13; i++)
            {
                _Employees.Add(new Employees()
                {
                    //EmployeeId = i,
                    EmployeeName = "FinanceEmp" + (i - 9),
                    DepartmentRefId = 1,
                    CardRefId = Guid.NewGuid(),
                });
            }
                _Employees.Add(new Employees()
                {
                    //EmployeeId = 0,
                    EmployeeName = "Manager",
                    DepartmentRefId = 0,
                    CardRefId = Guid.NewGuid(),
                });
            
        }

        public List<Employees> Delete(int id)
        {
            _Employees.RemoveAll(x=> x.EmployeeId == id);
            return _Employees;
        }

        public List<Employees> GetAll()
        {
            return _Employees;
        }

        public Employees GetById(int id)
        {
            return _Employees.Where(x => x.EmployeeId == id).SingleOrDefault(); 
        }

        public List<Employees> Insert(Employees item)
        {
            _Employees.Add(item);
            return _Employees;  
        }
    }
}
