using NUnit.Framework;
using RegistrarGradeManager.Systems;
using RegistrarGradeManager.Models;
using System.Collections.Generic;

namespace RegistrarGradeManager.Tests
{
    class ExcelCourseRecordDatabaseManagerTests
    {
        [Test]
        public void GetList_NullPassed_ReturnsListOfAll()
        {
            var excelDatabaseManager = new ExcelCourseRecordDatabaseManager(@"C:\Users\Micah\Desktop\CSC440SoloProject\RegistrarGradeManager\RegistrarGradeManager.Tests\TestExcelSheets\CSC 360 2021 Fall.xlsx");
            
            List<CourseModel> expectedCourseRecords = new List<CourseModel>();
            expectedCourseRecords.Add(new CourseModel("1111", "CSC", 360, "A", 2021, "Fall"));
            expectedCourseRecords.Add(new CourseModel("2222", "CSC", 360, "C", 2021, "Fall"));
            expectedCourseRecords.Add(new CourseModel("3333", "CSC", 360, "B", 2021, "Fall"));
            expectedCourseRecords.Add(new CourseModel("4444", "CSC", 360, "F", 2021, "Fall"));

            List<CourseModel> courseRecords = excelDatabaseManager.GetList(null);

            CollectionAssert.AreEqual(expectedCourseRecords, courseRecords);
        }

    }
}
