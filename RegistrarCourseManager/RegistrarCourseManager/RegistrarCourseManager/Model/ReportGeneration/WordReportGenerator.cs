using Microsoft.Office.Interop.Word;
using RegistrarCourseManager.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using word = Microsoft.Office.Interop.Word;

namespace RegistrarCourseManager.Model.ReportGeneration
{
    class WordReportGenerator : IReportGenerator
    {
        public void GenerateReport(Student student, ICourseRepository courseRepository, IGradesRepository gradesRepository)
        {
            try
            {
                word.Application wordApp = new word.Application();
                wordApp.ShowAnimation = false;
                wordApp.Visible = true; // try false

                object missing = System.Reflection.Missing.Value;

                word.Document transcriptDocument = wordApp.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                foreach (word.Section section in transcriptDocument.Sections)
                {
                    word.Range headerRange = section.Headers[word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, word.WdFieldType.wdFieldPage);
                    headerRange.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
                    headerRange.Font.ColorIndex = word.WdColorIndex.wdBlue;
                    headerRange.Font.Size = 10;
                    headerRange.Text = "Header text goes here";
                    foreach (Microsoft.Office.Interop.Word.Section wordSection in transcriptDocument.Sections)
                    {
                        //Get the footer range and add the footer details.  
                        Microsoft.Office.Interop.Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                        footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdDarkRed;
                        footerRange.Font.Size = 10;
                        footerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                        footerRange.Text = "Footer text goes here";
                    }

                    //adding text to document  
                    transcriptDocument.Content.SetRange(0, 0);
                    transcriptDocument.Content.Text = "This is test document " + Environment.NewLine;

                    //Add paragraph with Heading 1 style  
                    Microsoft.Office.Interop.Word.Paragraph para1 = transcriptDocument.Content.Paragraphs.Add(ref missing);
                    object styleHeading1 = "Heading 1";
                    para1.Range.set_Style(ref styleHeading1);
                    para1.Range.Text = "Para 1 text";
                    para1.Range.InsertParagraphAfter();

                    //Add paragraph with Heading 2 style  
                    Microsoft.Office.Interop.Word.Paragraph para2 = transcriptDocument.Content.Paragraphs.Add(ref missing);
                    object styleHeading2 = "Heading 2";
                    para2.Range.set_Style(ref styleHeading2);
                    para2.Range.Text = "Para 2 text";
                    para2.Range.InsertParagraphAfter();

                    //Create a 5X5 table and insert some dummy record  
                    Table firstTable = transcriptDocument.Tables.Add(para1.Range, 5, 5, ref missing, ref missing);

                    firstTable.Borders.Enable = 1;
                    foreach (Row row in firstTable.Rows)
                    {
                        foreach (Cell cell in row.Cells)
                        {
                            //Header row  
                            if (cell.RowIndex == 1)
                            {
                                cell.Range.Text = "Column " + cell.ColumnIndex.ToString();
                                cell.Range.Font.Bold = 1;
                                //other format properties goes here  
                                cell.Range.Font.Name = "verdana";
                                cell.Range.Font.Size = 10;
                                //cell.Range.Font.ColorIndex = WdColorIndex.wdGray25;                              
                                cell.Shading.BackgroundPatternColor = WdColor.wdColorGray25;
                                //Center alignment for the Header cells  
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

                            }
                            //Data row  
                            else
                            {
                                cell.Range.Text = (cell.RowIndex - 2 + cell.ColumnIndex).ToString();
                            }
                        }
                    }

                    //Save the document  
                    object filename = @"c:\temp1.docx";
                    transcriptDocument.SaveAs2(ref filename);
                    transcriptDocument.Close(ref missing, ref missing, ref missing);
                    transcriptDocument = null;
                    wordApp.Quit(ref missing, ref missing, ref missing);
                    wordApp = null;
                    MessageBox.Show("Document created successfully !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
