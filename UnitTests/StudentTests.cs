using System;
using Xunit;
using YudemyAPI.Models;

namespace UnitTests
{
    public class StudentTests
    {
        [Fact]
        public void ShouldAddCreditsToStudentAccount()
        {
            //Arrange
            Student student = new Student();
            var expectedFunds = 1D;

            //Act
            student.AddFunds(1);

            //Assert
            Assert.Equal(expectedFunds, student.Funds);
        }

        [Fact]
        public void ShouldRemoveCreditsToStudentAccount()
        {
            //Arrange
            Student student = new Student();
            var expectedFunds = 17D;

            student.AddFunds(25);

            //Act
            student.DebitFunds(8);

            //Assert
            Assert.Equal(expectedFunds, student.Funds);
        }
    }
}
