using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TestProject2
{
    [TestFixture]
    public class SubTest
    {
        [Test]
        public void TestSubjectName()
        {
            // Arrange
            Subject subject = new Subject();
            subject.SubName = "Maths";
            // Act
            string subjectName = subject.SubName;
            // Assert
            Assert.AreEqual("Maths", subjectName);
        }
        [Test]
        public void TestSubjectId()
        {
            // Arrange
            Subject subject = new Subject();
            subject.SubId = 5;
            // Act
            int subjectId = subject.SubId;
            // Assert
            Assert.AreEqual(5, subjectId);
        }
    }
}
