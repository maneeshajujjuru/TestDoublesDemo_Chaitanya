using System;
using System.Collections.Generic;
using System.Text;
using TestDoublesDemo.Interfaces;

namespace TestDouble_Stub_Demo_Test
{
    public class StubDesignation : IDesignation
    {
        public string GetDesignation(string level)
        {
            return "Junior Software Engineer";
        }
    }
}
