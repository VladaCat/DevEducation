using System;
using System.Linq;
using System.Runtime.Versioning;
using HW_11.Class;
using HW_11.Interfaces;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestMarkService
{
    [TestFixture]
    public class Tests
    {

        private ITeacher _teacher;
        private Mock<IMarkService> _markService;
        private IStudent _student1 = new Student(new int[] { 2, 3, 5, 4, 1, 7 });
        private IStudent _student2 = new Student(new int[] { 6, 7, 9, 8, 10, 9 });
        private IStudent _student3 = new Student(new int[] { 4, 7, 2, 9, 10, 5 });



        [SetUp]
        public void SetUp()
        {
            _markService = new Mock<IMarkService>(MockBehavior.Strict);
            _teacher = new Teacher(_markService.Object);
        }

        [Test]
        public void StudentGetAllMarksTest_1()
        {
            Assert.AreEqual(_student1.CheckMark(), "Bad job");
        }

        [Test]
        public void StudentGetAllMarksTest_2()
        {
            Assert.AreEqual(_student2.CheckMark(), "Great job");
        }
        [Test]
        public void StudentGetAllMarksTest_3()
        {
            Assert.AreEqual(_student3.CheckMark(), "Bad job");
        }

        [TestCase(false,10)]
        [TestCase(true,9)]
        public void TeacherGetLastMarkTest_4(bool islast,int exp)
        {
            _markService.Setup(a => a.GetLastMark(_student2,islast)).Returns(exp);
            double currentresult = _teacher.GetLastMark(_student2,islast);
            _markService.Verify(a => a.GetLastMark(_student2,islast), Times.Once);
            Assert.AreEqual(exp, currentresult);
        }

        [Test]
        public void TeacherGetAverageTest_5()
        {
            double exp=((Student)_student1).marks.Average();
            _markService.Setup(a => a.GetAverage(_student1)).Returns(exp);
            double currentresult=_teacher.GetAverage(_student1);
            _markService.Verify(a => a.GetAverage(_student1), Times.Once);
            Assert.AreEqual(exp, currentresult);
        }

        public void TeacherGetAllMarks_6()
        {
            int[] exp = ((Student)_student3).marks;
            _markService.Setup(a => a.GetAllMarks(_student3)).Returns(exp);
            int[] currentresult = _teacher.GetAllMarks(_student3);
            _markService.Verify(a => a.GetAllMarks(_student3), Times.Once);
            Assert.AreEqual(currentresult, ((Student)_student3).marks);
        }

    }
}
