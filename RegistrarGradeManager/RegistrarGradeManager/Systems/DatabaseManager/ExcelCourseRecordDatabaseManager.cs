﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using RegistrarGradeManager.Models;
using Excel = Microsoft.Office.Interop.Excel;

namespace RegistrarGradeManager.Systems
{
    public class ExcelCourseRecordDatabaseManager : ICourseRecordDatabaseManager
    {
        string path = null;

        Excel.Application excelSandbox  = null;
        Excel.Workbook excelWorkbook    = null;
        Excel._Worksheet excelWorksheet = null;
        Excel.Range excelRange          = null;

        public ExcelCourseRecordDatabaseManager(string path)
        {
            this.path = path;
        }

        private void OpenExcelFile(string path)
        {
            if(this.excelSandbox == null)
                this.excelSandbox = new Excel.Application();

            this.excelWorkbook = excelSandbox.Workbooks.Open(path);
            this.excelWorksheet = this.excelWorkbook.Sheets[1];
            this.excelRange = this.excelWorksheet.UsedRange;

            if(excelSandbox == null)
                throw new InvalidOperationException("sandbox was failed to be found or created");
            if (excelWorkbook == null)
                throw new InvalidOperationException("issue finding or opening workbook");
            if (excelWorksheet == null)
                throw new InvalidOperationException("issue finding or opening worksheet");
            if (excelRange == null)
                throw new InvalidOperationException("issue finding or opening excel range");
        }

        private void CloseExcelFile()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Marshal.ReleaseComObject(this.excelRange);
            Marshal.ReleaseComObject(this.excelWorksheet);

            this.excelWorkbook.Close();
            Marshal.ReleaseComObject(this.excelWorkbook);

            this.excelSandbox.Quit();
            Marshal.ReleaseComObject(this.excelSandbox);
        }

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
            this.OpenExcelFile(path);

            List<CourseModel> retreivedRecords = new List<CourseModel>();

            string fileName = excelWorkbook.Name;
            fileName = fileName.Substring(0, fileName.Length - 5);


            string[] fileNameDisect = fileName.Split(' ');

            string coursePrefix = fileNameDisect[0];
            int courseNum = int.Parse(fileNameDisect[1]);
            int year = int.Parse(fileNameDisect[2]);
            string semester = fileNameDisect[3];

            for (int row = 2; row < excelRange.Rows.Count + 1; row++)
            {
                string studentID = excelRange[row, 2].Value2.ToString();
                string grade = excelRange[row, 3].Value2.ToString();

                CourseModel retreivedCourseRecord = 
                    new CourseModel(studentID, coursePrefix, courseNum, grade, year, semester);

                retreivedRecords.Add(retreivedCourseRecord);
            }

            this.CloseExcelFile();

            return retreivedRecords;
        }
    }
}
