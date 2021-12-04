using Microsoft.Win32;
using RegistrarCourseManager.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.IO;
using System.Windows.Forms;
using RegistrarCourseManager.Model.Repositories;
using RegistrarCourseManager.Model;
using ExcelDataReader;
using MessageBox = System.Windows.MessageBox;

namespace RegistrarCourseManager.ViewModel.Tabs
{
    class UploadRecordsViewModel : ViewModelBase
    {
        public IGradesRepository gradesRepository { get; set; }
        public ICourseRepository courseRepository { get; set; }

        public ICommand BrowseFilesCommand { get; set; }
        public ICommand UploadFilesCommand { get; set; }

        private string selectedItem;
        public string SelectedItem
        {
            get { return selectedItem; }
            set { 
                selectedItem = value;
                FilePath.Remove(selectedItem);
                OnPropertyChanged("FilePath");
                OnPropertyChanged("SelectedItem");
            }
        }

        private ObservableCollection<string> filePath;
        public ObservableCollection<string> FilePath
        {
            get { return filePath; }
            set { 
                filePath = value;
                OnPropertyChanged("FilePath");
            }
        }


        void uploadRecords(object _)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            try
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result.Equals(DialogResult.OK))
                {
                    Console.WriteLine(folderBrowserDialog.SelectedPath);

                    DirectoryInfo d = new DirectoryInfo(folderBrowserDialog.SelectedPath);

                    foreach (var file in d.GetFiles("*.xlsx"))
                    {
                        FilePath.Add(file.Name);

                        var words = Path.GetFileNameWithoutExtension(file.Name).Split(new char[] { ' ', '_' });
                        string coursePrefix = words[0];
                        string courseNum = words[1];
                        string year = words[2];
                        string semester = words[3];


                        // AddCourseIfNotExists(newCourse);

                        using (var stream = file.OpenRead())
                        {
                            using (var reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                do
                                {
                                    // Skip headers
                                    reader.Read();

                                    while (reader.Read())
                                    {
                                        string studentName = reader.GetString(0);
                                        string studentId = reader.GetDouble(1).ToString();
                                        string gradeLetter = reader.GetString(2);

                                        Console.WriteLine($"{studentName} {studentId} {gradeLetter}");

                                        //Student newStudent = new Student()
                                        //{
                                        //    Name = studentName,
                                        //    Id = studentId
                                        //};

                                        // AddStudentIfNotExists(newStudent);

                                        //Grade newGrade = new Grade()
                                        //{
                                        //    StudentId = studentId,
                                        //    CoursePrefix = coursePrefix,
                                        //    CourseNum = courseNum,
                                        //    Year = year,
                                        //    Semester = semester,
                                        //    Letter = gradeLetter
                                        //};

                                        CourseGrade grade = new CourseGrade(studentId, coursePrefix, int.Parse(courseNum), gradeLetter, int.Parse(year), semester);

                                        try
                                        {
                                            gradesRepository.AddCourseGrade(grade);
                                        }
                                        catch
                                        {
                                            Console.WriteLine("grade already exists");
                                        }
                                        // AddGradeIfNotExists(newGrade);
                                    }
                                } while (reader.NextResult());
                            }
                        }

                    }

                    MessageBox.Show("Excel files imported successfully");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        void uploadFiles(object _)
        {
            foreach(var file in FilePath)
            {
                
            }

            System.Windows.MessageBox.Show("upload files click");
        }

        public UploadRecordsViewModel()
        {
            gradesRepository = RepositorySingleton.Instance.gradesRepository;

            BrowseFilesCommand = new BaseCommand(uploadRecords);
            UploadFilesCommand = new BaseCommand(uploadFiles);

            FilePath = new ObservableCollection<string>();
            //FilePath.Add("test/1/path");
            //FilePath.Add("test/2/path");
            //FilePath.Add("test/3/path");
        }
    }
}
