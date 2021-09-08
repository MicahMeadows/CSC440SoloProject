using System;

namespace RegistrarGradeManager.Models
{
    public class CourseModel
    {
        private string _studentID;
        private string _coursePrefix;
        private int _courseNum;
        private string _grade;
        private int _year;
        private string _semester;

        public CourseModel(string studentID, string coursePrefix, int courseNum, string grade, int year, string semester)
        {
            _studentID = studentID;
            _coursePrefix = coursePrefix;
            _courseNum = courseNum;
            _grade = grade;
            _year = year;
            _semester = semester;
        }

        public override string ToString()
        {
            return $"{_studentID} {_coursePrefix} {_courseNum} {_grade} {_year} {_semester}";
        }

        // the less in common items are the lower score they get
        // perfectly equal will have 6 points
        // completely different will have 3 points
        // for instance a record with the same student id but dif
        // everything else will have 1 point
        public override bool Equals(object obj)
        {
            var dstCourseModel = obj as CourseModel;

            if (this._studentID != dstCourseModel._studentID)
                return false;
            if (this._coursePrefix.ToLower() != dstCourseModel._coursePrefix.ToLower())
                return false;
            if (this._courseNum != dstCourseModel._courseNum)
                return false;
            if (this._grade != dstCourseModel._grade)
                return false;
            if (this._year != dstCourseModel._year)
                return false;
            if (this._semester.ToLower() != dstCourseModel._semester.ToLower())
                return false;

            return true;
        }
    }
}
