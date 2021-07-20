using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SOLIDexperimentation;

namespace SOLIDexperimentationTest
{
    [TestClass]
    public class StudentUnitTests
    {
        //Adding a unit test for 100 percent mark
        [TestMethod]
        public void Student_With_100_Marks_In_All_Subjects()
        {
            //Arrange
            var subjectA = 100;
            var subjectB = 100;
            var subjectC = 100;
            var subjectD = 100;
            //mock implementation
            var studentMarksBasedOnSubjectsMock = new Mock<IStudentMarksBasedOnSubjects>();
            studentMarksBasedOnSubjectsMock.Setup(m => m.CalculateAverageMarks()).Returns(100);
            var studentFeesMock = new Mock<IStudentFees>();
            //Act
            Student testSubject = new Student(studentMarksBasedOnSubjectsMock.Object, studentFeesMock.Object);
            //Assert
            Assert.AreEqual(100, testSubject.GetMarks(subjectA, subjectB, subjectC,subjectD));
        }

        //Adding a unit test for 80 percent mark
        [TestMethod]
        public void Student_With_Different_Marks_In_All_Subjects()
        {
            //Arrange
            var subjectA = 80;
            var subjectB = 100;
            var subjectC = 90;
            var subjectD = 100;
            //mock implementation
            var studentMarksBasedOnSubjectsMock = new Mock<IStudentMarksBasedOnSubjects>();
            studentMarksBasedOnSubjectsMock.Setup(m => m.CalculateAverageMarks()).Returns(80);
            var studentFeesMock = new Mock<IStudentFees>();
            //Act
            Student testSubject = new Student(studentMarksBasedOnSubjectsMock.Object, studentFeesMock.Object);
            //Assert
            Assert.AreEqual(80, testSubject.GetMarks(subjectA, subjectB, subjectC,subjectD));
        }
    }
}
