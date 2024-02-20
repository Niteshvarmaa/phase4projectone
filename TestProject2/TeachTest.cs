using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TestProject2
{
    [TestFixture]
    public class TeachTest
    {
        [Test]
        public void Test_CreateTeacher()
        {
            // Arrange
            var teacher = new Teacher();
            teacher.TeacherId = 101;
            teacher.Name = "Mrs. Sunitha";
            // Act & Assert
            Assert.AreEqual(101, teacher.TeacherId);
            Assert.AreEqual("Mrs. Sunitha", teacher.Name);
        }
    }
}