using RegistrarGradeManager.Models;

namespace RegistrarGradeManager.Systems
{
    public interface IReportStrategy
    {
        ReportModel GenerateReport(StudentModel student);
    }
}
