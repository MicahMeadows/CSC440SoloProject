using Aspose.Pdf;
using Aspose.Pdf.Text;
using RegistrarCourseManager.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RegistrarCourseManager.Model.ReportGeneration
{
    class PdfReportGenerator : IReportGenerator
    {
        void saveTranscript(string fileName, Document doc)
        {
            try
            {
                doc.Save(fileName);
            }
            catch
            {
                try
                {
                    System.IO.Directory.CreateDirectory("transcripts");
                    doc.Save(fileName);
                }
                catch
                {

                }
            }
        }

        public void makeSemester(string semesterName, List<CourseGrade> courses, int year, Page page, ICourseRepository courseRepository)
        {
            List<CourseGrade> semester = courses.Where(cGrade => cGrade.Semester.ToLower().Equals(semesterName.ToLower())).ToList();
            if (semester.Count > 0)
            {
                TextFragment semFrag = new TextFragment($"-{semesterName} {year}-");
                semFrag.TextState.FontSize = 14;
                semFrag.TextState.FontStyle = Aspose.Pdf.Text.FontStyles.Bold;
                page.Paragraphs.Add(semFrag);
                foreach (var grade in semester)
                {
                    TextFragment cFrag = new TextFragment($"{grade.CoursePrefix} {grade.CourseNum} {grade.Grade} {courseRepository.GetCourseHours(grade)}");
                    cFrag.TextState.FontSize = 10;
                    cFrag.TextState.FontStyle = Aspose.Pdf.Text.FontStyles.Bold;
                    page.Paragraphs.Add(cFrag);
                }
                page.Paragraphs.Add(new TextFragment());
            }
        }

        public void GenerateReport(Student student, ICourseRepository courseRepository, IGradesRepository gradesRepository)
        {
            Document doc = new Document();

            Page page = doc.Pages.Add();

            TextFragment nameFrag = new TextFragment(student.Name);
            nameFrag.TextState.FontSize = 30;
            nameFrag.TextState.FontStyle = Aspose.Pdf.Text.FontStyles.Bold;
            page.Paragraphs.Add(nameFrag);

            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(student.StudentID));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"GPA: {student.OverallGPA.ToString()}"));
            page.Paragraphs.Add(new TextFragment());


            ObservableCollection<CourseGrade> studentsGrades = gradesRepository.GetCourseGrades(student.StudentID);

            int year = studentsGrades[0].Year;
            foreach (var grade in studentsGrades)
            {
                if (grade.Year < year)
                    year = grade.Year;
            }

            bool generating = true;
            while (generating)
            {
                List<CourseGrade> gradesThisYear = studentsGrades.Where(cGrade => cGrade.Year == year).ToList();

                makeSemester("Spring", gradesThisYear, year, page, courseRepository);
                makeSemester("Summer", gradesThisYear, year, page, courseRepository);
                makeSemester("Fall", gradesThisYear, year, page, courseRepository);
                makeSemester("Winter", gradesThisYear, year, page, courseRepository);


                year++;
                if (!studentsGrades.Any(cGrade => cGrade.Year >= year))
                {
                    generating = false;
                }
            }

            saveTranscript($"transcripts/{student.Name}-transcript.pdf", doc);
            MessageBox.Show("Transcript Saved");
        }
    }
}