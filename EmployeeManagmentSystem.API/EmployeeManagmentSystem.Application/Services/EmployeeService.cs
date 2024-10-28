using EmployeeManagmentSystem.Application.DTO;
using EmployeeManagmentSystem.Domain.Entities;
using EmployeeManagmentSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace EmployeeManagmentSystem.Application.Services
{
    public class EmployeeService : IAppService<EmployeeDTO>
    {
        private AppDbContext _appDbContext;
        public EmployeeService(AppDbContext appContext)
        {
            _appDbContext = appContext;

        }

        public bool Commit()
        {
            var res = _appDbContext.SaveChanges();
            if (res > 0)
                return true;
            return false;
        }

        public bool Delete(int id)
        {
            var employee = _appDbContext.Employees.FirstOrDefault(x => x.EmployeeId == id);
            if (employee == null)
                return false;
            _appDbContext.Employees.Remove(employee);
            return Commit();
        }

        public List<EmployeeDTO> GetAll()
        {
            var Employees = _appDbContext.Employees.ToList();
            List<EmployeeDTO> employeeDTOs = new List<EmployeeDTO>();
            foreach (var employee in Employees)
            {
                employeeDTOs.Add(Mapper(employee));
            }
            return employeeDTOs;
        }

        private EmployeeDTO Mapper(Employee employee)
        {
            return new EmployeeDTO()
            {
                EmployeeId = employee.EmployeeId,
                FullName = employee.FirstName + " " + employee.LastName,
                Email = employee.Email,
                HireDate = employee.HireDate,
                JobTitle = employee.JobTitle,
                PhoneNumber = employee.PhoneNumber
            };
        }

        public EmployeeDTO GetById(int id)
        {
            var Employee = _appDbContext.Employees.FirstOrDefault(e => e.EmployeeId == id);
            if (Employee == null)
                return null;
            return Mapper(Employee);
        }

        public void Insert(EmployeeDTO entity)
        {
            var employee = MapperToEntity(entity);
            _appDbContext.Employees.Add(employee);
            Commit();
        }
        public List<EmployeeDTO> Search(string query)
        {
            if (query.IsNullOrEmpty())
                return null;

            var trimmedQuery = query.Trim();
            var result = _appDbContext.Employees.Where(e => e.FirstName.Contains(query) || e.LastName.Contains(query) ||
            e.Email.Contains(query) || e.JobTitle.Contains(query));
            List<EmployeeDTO> employees = new List<EmployeeDTO>();
            foreach (var item in result)
            {
                employees.Add(Mapper(item));
            }
            return employees;
        }
        public PagedResult<EmployeeDTO> GetPagedEmpolyees(int pageSize, int pageNumber)
        {
            var employees = GetAll();
            var totalCount = employees.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            if (pageSize > totalCount || pageNumber < 1 || pageSize < 1 ||pageNumber > totalPages )
                return null;
            var result = employees.Skip((pageNumber - 1) * pageSize)
                            .Take(pageSize)
                            .ToList();
            return new PagedResult<EmployeeDTO>()
            {
                Items = result,
                TotalCount = totalCount,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalPages = totalPages
            };
        }
    
    private Employee MapperToEntity(EmployeeDTO entity)
        {
            var fullName = entity.FullName.Split(" ");
            return new Employee()
            {
                EmployeeId= entity.EmployeeId,
                FirstName = fullName[0],
                LastName = fullName[1],
                Email = entity.Email,
                HireDate = entity.HireDate,
                JobTitle= entity.JobTitle,
                PhoneNumber= entity.PhoneNumber
            };
        }

        public void Update(EmployeeDTO entity, int id)
        {
            var fullName = entity.FullName.Split(" ");
            var employee = _appDbContext.Employees.FirstOrDefault(e=>e.EmployeeId ==id);
            if (employee == null) return;

            employee.FirstName = fullName[0];
            employee.LastName = fullName[1];
            employee.Email = entity.Email;
            employee.JobTitle = entity.JobTitle;
            employee.PhoneNumber = entity.PhoneNumber;
            employee.HireDate = entity.HireDate;
            _appDbContext.Update(employee);
            Commit();
            
        }
    }
}
