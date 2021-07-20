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
            studentMarksBasedOnSubjectsMock.SetupGet(m => m.SubjectA).Returns(subjectA);
            studentMarksBasedOnSubjectsMock.SetupGet(m => m.SubjectB).Returns(subjectB);
            studentMarksBasedOnSubjectsMock.SetupGet(m => m.SubjectC).Returns(subjectC);
            studentMarksBasedOnSubjectsMock.SetupGet(m => m.SubjectD).Returns(subjectD);
            studentMarksBasedOnSubjectsMock.Setup(m => m.CalculateAverageMarks()).Returns((studentMarksBasedOnSubjectsMock.Object.SubjectA+ studentMarksBasedOnSubjectsMock.Object.SubjectB+ studentMarksBasedOnSubjectsMock.Object.SubjectC+ studentMarksBasedOnSubjectsMock.Object.SubjectD)/400);
            studentMarksBasedOnSubjectsMock.Setup(m => m.StudentPrecentage()).Returns(studentMarksBasedOnSubjectsMock.Object.CalculateAverageMarks()*100);
            var studentFeesMock = new Mock<IStudentFees>();
            //Act
            Student testSubject = new Student(studentMarksBasedOnSubjectsMock.Object, studentFeesMock.Object);
            var result = studentMarksBasedOnSubjectsMock.Object.StudentPrecentage();
            //Assert
            Assert.AreEqual(100, result);
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
            studentMarksBasedOnSubjectsMock.SetupGet(m => m.SubjectA).Returns(subjectA);
            studentMarksBasedOnSubjectsMock.SetupGet(m => m.SubjectB).Returns(subjectB);
            studentMarksBasedOnSubjectsMock.SetupGet(m => m.SubjectC).Returns(subjectC);
            studentMarksBasedOnSubjectsMock.SetupGet(m => m.SubjectD).Returns(subjectD);
            studentMarksBasedOnSubjectsMock.Setup(m => m.CalculateAverageMarks()).Returns((studentMarksBasedOnSubjectsMock.Object.SubjectA + studentMarksBasedOnSubjectsMock.Object.SubjectB + studentMarksBasedOnSubjectsMock.Object.SubjectC + studentMarksBasedOnSubjectsMock.Object.SubjectD) / 400);
            studentMarksBasedOnSubjectsMock.Setup(m => m.StudentPrecentage()).Returns(studentMarksBasedOnSubjectsMock.Object.CalculateAverageMarks() * 100);
            var studentFeesMock = new Mock<IStudentFees>();
            //Act
            Student testSubject = new Student(studentMarksBasedOnSubjectsMock.Object, studentFeesMock.Object);
            var result = studentMarksBasedOnSubjectsMock.Object.StudentPrecentage();
            //Assert
            Assert.AreEqual(92.5, result);
        }
    }
}
