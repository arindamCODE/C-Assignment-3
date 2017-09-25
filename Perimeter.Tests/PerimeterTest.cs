using System;
using Xunit;
using PerimeterCal;

namespace Perimeter.Tests
{
    public class PerimeterTest
    {
        [Fact]
        public void TestPerimeter()
        {
            //Arrange
            PeriTest obj = new PeriTest();

            //Act
            int res1 = obj.TraiPeri(2,3,4);
            int res2 = obj.RectPeri(2,3);
            int res3 = obj.SqPeri(2);

            //Assert
            Assert.IsType<int>(res1);
            Assert.IsType<int>(res2);
            Assert.IsType<int>(res3);
            
            Assert.Equal(9,res1);
            Assert.NotEqual(10,res1);

            Assert.Equal(10,res2);
            Assert.NotEqual(11,res2);

            Assert.Equal(8, res3);
            Assert.NotEqual(10, res3);
        }
    }
}
