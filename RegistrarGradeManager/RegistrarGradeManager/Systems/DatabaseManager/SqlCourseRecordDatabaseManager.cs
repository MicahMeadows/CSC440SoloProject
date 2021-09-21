using System;
using System.Collections.Generic;
using RegistrarGradeManager.Models;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace RegistrarGradeManager.Systems
{
    public class SqlCourseRecordDatabaseManager : ICourseRecordDatabaseManager
    {
        MySqlConnection sqlConnection = null;

        public SqlCourseRecordDatabaseManager(string sqlConnectionString)
        {
            this.sqlConnection = new MySqlConnection(sqlConnectionString);
        }

        public void Add(CourseModel courseToAdd)
        {
            if (this.GetRecordExists(courseToAdd))
            {
                // record already exists do something about that
            }
            else
            {
                // add record to database
            }
            throw new NotImplementedException();
        }

        public void Delete(CourseModel courseToDelete)
        {
            if (this.GetRecordExists(courseToDelete))
            {
                // record exists so allow deletion
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
                // record exists so edit
                // this.Add(new edited record)
                // this.Delete(old record)
            }
            else
            {
                // cant edit because record doesnt exist
            }
            throw new NotImplementedException();
        }

        public bool GetRecordExists(CourseModel course)
        {
            // fetch with sql if record matching template exists
            // if it does we return true
            // if it doesnt we return false
            throw new NotImplementedException();
        }

        public List<CourseModel> GetList(CourseModel filter)
        {
            // get list of all matching from the database with sql
            throw new NotImplementedException();
        }
    }
}
