using System;
using TestDoublesDemo.Controllers;
using Xunit;

namespace Testing
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {   
            //ACT
            DesignationController designation = new DesignationController();
            //ASSERT
            Assert.Equal("Senior Software Engineer",designation.GetDesignation("L3"));
            Assert.NotEqual("Junior Software Engineer", designation.GetDesignation("L2"));
            

        }
    }
}
