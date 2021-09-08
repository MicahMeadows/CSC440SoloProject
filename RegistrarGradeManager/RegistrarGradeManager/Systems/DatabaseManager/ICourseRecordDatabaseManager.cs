using System.Collections.Generic;
using RegistrarGradeManager.Models;

namespace RegistrarGradeManager.Systems
{
    public interface ICourseRecordDatabaseManager
    {
        void Add(CourseModel courseRecord);
        void Delete(CourseModel courseRecord);
        void Edit(CourseModel courseRecord);
        bool GetRecordExists(CourseModel courseRecord);
        List<CourseModel> GetList(CourseModel filter);
    }
}
