using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagmentSystem.Application.DTO
{
    public class EmployeeDTO
    {
        
        public int EmployeeId { get; set; }
       
        public  string FullName { get; set; }
       
        public  string Email { get; set; }
       
        public  string PhoneNumber { get; set; }
     
        public required string JobTitle { get; set; }
       
        public DateOnly HireDate { get; set; }
    }
}
