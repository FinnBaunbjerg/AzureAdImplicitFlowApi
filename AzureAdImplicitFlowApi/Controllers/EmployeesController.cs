using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureAdImplicitFlowApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AzureAdImplicitFlowApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Finn Baunbjerg Hansen", Company = "Orion Business Innovations", City = "Kochi" },
                new Employee { Id = 2, Name = "Anil Soman", Company = "Cognizant", City = "Bangalare" }
            };
            return employees;
        }
    }
}
