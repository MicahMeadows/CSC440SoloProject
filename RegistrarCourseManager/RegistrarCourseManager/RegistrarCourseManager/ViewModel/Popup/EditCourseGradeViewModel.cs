using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using RegistrarCourseManager.Commands;
using RegistrarCourseManager.Model;
using RegistrarCourseManager.Model.Repositories;

namespace RegistrarCourseManager.ViewModel.Popup
{
    class EditCourseGradeViewModel : ViewModelBase
    {
        public IGradesRepository gradeRepository;

        public ICommand SubmitCommand { get; set; }

        private CourseGrade origional;
        private CourseGrade toEdit;

        public CourseGrade ToEdit
        {
            get => toEdit;
            set
            {
                toEdit = value;
                OnPropertyChanged("ToEdit");
            }
        }

        private Window popup;

        void submitEdit(object _)
        {
            if (!origional.Equals(ToEdit))
            {
                try
                {
                    gradeRepository.AddCourseGrade(ToEdit);
                    gradeRepository.DeleteCourseGrade(origional);

                }
                catch
                {
                    MessageBox.Show("Edit failed");
                }
            } else
            {
                MessageBox.Show("No Edit Found");
            }
            popup.Close();
        }

        void submitAdd(object _)
        {
            try
            {
                gradeRepository.AddCourseGrade(ToEdit);
            } catch
            {
                MessageBox.Show("Grade record already exists");
                // grade exists
            }
            popup.Close();
        }

        public EditCourseGradeViewModel(IGradesRepository gradeRepository, string studentID, Window popup)
        {
            this.popup = popup;
            this.gradeRepository = gradeRepository;

            ToEdit = new CourseGrade(studentID, "", 0, "", 0, "");
            SubmitCommand = new BaseCommand(submitAdd);
        }

        public EditCourseGradeViewModel(IGradesRepository gradeRepository, CourseGrade courseGradeToEdit, Window popup)
        {
            this.popup = popup;
            this.gradeRepository = gradeRepository;

            origional = courseGradeToEdit;
            ToEdit = courseGradeToEdit.Copy();
            SubmitCommand = new BaseCommand(submitEdit);
        }
    }
}
