using RegistrarGradeManager.Models;

namespace RegistrarGradeManager.Systems
{
    public class ReportGenerator
    {
        public ReportModel GenerateReport(StudentModel student, IReportStrategy reportStrategy)
        {
            return reportStrategy.GenerateReport(student);
        }
    }
}
