using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace RegistrarGradeManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\Micah\Desktop\CSC440SoloProject\Grades 2021 Fall\CSC 440 2021 Fall.xlsx");
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;


            for (int row = 1; row < xlRange.Rows.Count; row++)
            {
                string msg = "";
                for (int col = 1; col < xlRange.Columns.Count; col++)
                {
                    msg += " " + xlRange.Cells[row, col].Value2.ToString();
                }
                listBox1.Items.Add(msg);
            }


            // MAKE SURE TO CLEANUP!
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);



        }
    }
}
