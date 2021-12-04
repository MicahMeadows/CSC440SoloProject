using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RegistrarCourseManager.Model;
using RegistrarCourseManager.Model.Repositories;

namespace RegistrarCourseManager.ViewModel.Popup
{
    /// <summary>
    /// Interaction logic for EditCourseGradeView.xaml
    /// </summary>
    public partial class EditCourseGradeView : UserControl
    {
        CourseGrade courseGradeToChange;
        CourseGrade newCourseGrade;
        IGradesRepository gradeRepository;
        Window popup;

        public EditCourseGradeView(Window popup, IGradesRepository gradeRepository, CourseGrade courseGrade = null, string id = "")
        {
            InitializeComponent();

            this.popup = popup;
            this.gradeRepository = gradeRepository;
            this.courseGradeToChange = courseGrade;
            if (courseGrade != null)
                this.newCourseGrade = courseGrade.Copy();
            else
                this.newCourseGrade = new CourseGrade(id, "", 0, "", 0, "");

            if (courseGrade != null)
            {
                TextBox_Prefix.Text = courseGrade.CoursePrefix;
                TextBox_CourseNum.Text = courseGrade.CourseNum.ToString();
                TextBox_Semester.Text = courseGrade.Semester;
                TextBox_Year.Text = courseGrade.Year.ToString();
                TextBox_Grade.Text = courseGrade.Grade;
            }
        }

        private void TextBox_CoursePrefixChanged(object sender, TextChangedEventArgs e)
        {
            newCourseGrade.CoursePrefix = (sender as TextBox).Text;
        }

        private void TextBox_CourseNumChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                newCourseGrade.CourseNum = int.Parse((sender as TextBox).Text);
            }
            catch
            {

            }
        }

        private void TextBox_SemesterChanged(object sender, TextChangedEventArgs e)
        {
            newCourseGrade.Semester = (sender as TextBox).Text;
        }

        private void TextBox_YearChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                newCourseGrade.Year = int.Parse((sender as TextBox).Text);
            }
            catch
            {

            }
        }

        private void TextBox_GradeChanged(object sender, TextChangedEventArgs e)
        {
            newCourseGrade.Grade = (sender as TextBox).Text;
        }


        bool isValid(CourseGrade grade)
        {
            if (newCourseGrade.StudentID == ""
                || newCourseGrade.CourseNum == 0
                || newCourseGrade.CoursePrefix == ""
                || newCourseGrade.Year == 0
                || newCourseGrade.Semester == "")
            {
                return false;
            }
            return true;
        }

        private void Button_SubmitClick(object sender, RoutedEventArgs e)
        {
            var oldG = courseGradeToChange;
            var newG = newCourseGrade;

            bool newAdd = courseGradeToChange == null;

            if(newAdd)
            {
                if (isValid(newCourseGrade))
                {
                    try
                    {
                        gradeRepository.AddCourseGrade(newCourseGrade);
                    }
                    catch
                    {
                        MessageBox.Show("Record already exist");
                    }
                }
            }
            else if (isValid(newCourseGrade))
            {
                if (gradeRepository.CourseGradeExists(courseGradeToChange))
                {
                    if (newCourseGrade.Grade == courseGradeToChange.Grade)
                    {
                        MessageBox.Show("Record already exists");
                    }
                    else
                    {
                        try
                        {
                            gradeRepository.AddCourseGrade(newCourseGrade);
                            gradeRepository.DeleteCourseGrade(courseGradeToChange);
                        }
                        catch
                        {
                            MessageBox.Show("Failed to update");
                        }
                    }
                }
            }
            popup.Close();
        }
    }
}