using RegistrarCourseManager.Model.Repositories;

namespace RegistrarCourseManager.Model.ReportGeneration
{
    interface IReportGenerator
    {
        public void GenerateReport(Student student, ICourseRepository courseRepository, IGradesRepository gradesRepository);
    }
}
