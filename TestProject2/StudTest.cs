﻿using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TestProject2
{
    [TestFixture]
    public class StudTest
    {
        [Test]
        public void TestStudentName()
        {
            // Arrange
            Student student = new Student();
            student.SName = "Pranav";
            // Act
            string studentName = student.SName;
            // Assert
            Assert.AreEqual("Pranav", studentName);
        }
        [Test]
        public void TestStudentAddress()
        {
            // Arrange
            Student student = new Student();
            student.Address = "46 rama Street";
            // Act
            string studentAddress = student.Address;
            // Assert
            Assert.AreEqual("46 rama Street", studentAddress);
        }
    }
}