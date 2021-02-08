using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestDoublesDemo.Interfaces;

namespace TestDoublesDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DesignationController : Controller
    {

        private readonly IDesignation _designationService;

        public DesignationController(IDesignation designationService)
        {
            _designationService = designationService;
        }
        public string GetDesignation(string level)
        {
            return _designationService.GetDesignation(level);
            
        }
    }
}
