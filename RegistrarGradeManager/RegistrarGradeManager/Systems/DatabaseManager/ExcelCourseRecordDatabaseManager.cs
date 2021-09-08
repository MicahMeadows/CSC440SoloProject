using System;
using System.Collections.Generic;
using RegistrarGradeManager.Models;
// using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace RegistrarGradeManager.Systems
{
    public class ExcelCourseRecordDatabaseManager : ICourseRecordDatabaseManager
    {
        public void Add(CourseModel courseToAdd)
        {
            if (this.GetRecordExists(courseToAdd))
            {
                // record already exists do something
            }
            else
            {
                // add record into excel sheet
            }
            throw new NotImplementedException();
        }

        public void Delete(CourseModel courseToDelete)
        {
            if (this.GetRecordExists(courseToDelete))
            {
                // delete record
            }
            else
            {
                // cant delete record because it doesnt exist
            }
            throw new NotImplementedException();
        }

        public void Edit(CourseModel courseToEdit)
        {
            if (this.GetRecordExists(courseToEdit))
            {
                // allow to edit record
                // this.Add(new edited record)
                // this.Delete(old record)
            }
            throw new NotImplementedException();
        }

        public bool GetRecordExists(CourseModel courseToCheck)
        {
            // look into excel sheet
            // if there is a record that matches all in template
            // return true
            // else return false
            throw new NotImplementedException();
        }

        public List<CourseModel> GetList(CourseModel filter)
        {
            // foreach row in excel sheet
            // check if all items match filter
            // if so add to list
            // otherwise continue
            // return final list
            throw new NotImplementedException();
        }
    }
}
