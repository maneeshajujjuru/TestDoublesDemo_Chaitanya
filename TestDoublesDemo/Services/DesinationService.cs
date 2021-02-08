using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestDoublesDemo.Interfaces;

namespace TestDoublesDemo.Services
{
    public class DesinationService : IDesignation
    {
        public string GetDesignation(string level)
        {
            List<string> Availablelevels = new List<string>() { "L1", "L2", "L3" };
            if (Availablelevels.Contains(level))
            {
                if (level == "L1")
                {
                    return ("Junior Software Engineer");
                }
                else if (level == "L2")
                {
                    return ("Software Engineer");
                }
                else
                {
                    return ("Senior Software Engineer");
                }
            }
            else
                return ("Given Level is invalid");
        }
    }
}
