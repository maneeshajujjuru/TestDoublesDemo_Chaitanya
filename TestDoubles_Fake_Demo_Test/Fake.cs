using System;
using System.Collections.Generic;
using System.Text;
using TestDoublesDemo.Interfaces;

namespace TestDoubles_Fake_Demo_Test
{
    class Fake : IDesignation
    {
        public string GetDesignation(string level)
        {
            if (level.Equals("L1"))
            {
                return "Junior Software Engineer";
            }
            else
            {
                return "Software Engineer";
            }
        }
    }
}
