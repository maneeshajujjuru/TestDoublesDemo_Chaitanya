using System;
using TestDoublesDemo.Controllers;
using Xunit;

namespace TestDoubles_Fake_Demo_Test
{
    public class GetTestFake
    {
        [Fact]
        public void Fake_Returns_Designation_Level()
        {
            Fake stubClass = new Fake();
            DesignationController designation = new DesignationController(stubClass);

            string result = designation.GetDesignation("L1");
            Assert.Equal("Junior Software Engineer", result);
        }
    }
}
