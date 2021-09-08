using System.Collections.Generic;
using RegistrarGradeManager.Models;

namespace RegistrarGradeManager.Systems
{

    // import record files
    // add individual record
    // delete record
    // edit record
    // print transcript
    // print report card

    public class CourseRecordManager
    {
        private ICourseRecordDatabaseManager sourceCourseRecordDatabaseManager;
        private ICourseRecordDatabaseManager destinationCourseRecordDatabaseManager;
        private ReportGenerator reportGenerator;

        public CourseRecordManager(ICourseRecordDatabaseManager sourceCourseRecordDatabaseManager, 
            ICourseRecordDatabaseManager destinationCourseRecordDatabaseManager,
            ReportGenerator reportGenerator)
        {
            this.sourceCourseRecordDatabaseManager = sourceCourseRecordDatabaseManager;
            this.destinationCourseRecordDatabaseManager = destinationCourseRecordDatabaseManager;
            this.reportGenerator = reportGenerator;
        }

        public void ImportRecords()
        {
            List<CourseModel> courseRecordsToAdd = sourceCourseRecordDatabaseManager.GetList(null);

            foreach (var record in courseRecordsToAdd)
            {
                if (destinationCourseRecordDatabaseManager.GetRecordExists(record))
                {
                    // record already exists!
                }
                else
                {
                    // record didnt exist so we add it
                    destinationCourseRecordDatabaseManager.Add(record);
                }
            }
        }
    }
}
