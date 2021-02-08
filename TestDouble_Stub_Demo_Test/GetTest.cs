using System;
using TestDoublesDemo.Controllers;
using Xunit;

namespace TestDouble_Stub_Demo_Test
{
    public class GetTest
    {
        [Fact]
        public void Designation_returns_Junior_software_engineer_for_L1()
        {
            StubDesignation stubDesignation = new StubDesignation();
            DesignationController designationController = new DesignationController(stubDesignation);

            string result = designationController.GetDesignation("L1");
            Assert.Equal("Junior Software Engineer", result);
        }
    }
}
