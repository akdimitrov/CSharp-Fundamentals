using System;
using Microsoft.Office.Interop;
using Excel = Microsoft.Office.Interop.Excel;

namespace _06.EXCELlentKnowledge
{
    class Program
    {
        static void Main(string[] args)
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook workbook = app.Workbooks.Open(@"C:\Users\AkDimitrov\source\repos\02.Fundamentals.C#January2022\_PF - More Exercises\21.ObjectsClassesFilesAndExceptions-MoreExercises\06.EXCELlentKnowledge\sample_table.xlsx");
            Excel.Worksheet sheet = (Excel.Worksheet)workbook.Sheets["Sheet1"];
            Excel.Range range = sheet.UsedRange;
            int columnsCount = range.Columns.Count;
            int rowsCount = range.Rows.Count;
            for (int i = 1; i <= rowsCount; i++)
            {
                for (int j = 1; j <= columnsCount; j++)
                {
                    if (range.Cells[i, j] == null || ((Excel.Range)range.Cells[i, j]).Value2 == null)
                    {
                        goto Break;
                    }
                    Console.Write(((((Excel.Range)range.Cells[i, j]).Value2.ToString()) + "|"));
                }
                Console.WriteLine();
            }
        Break:
            workbook.Close();
            app.Quit();
        }
    }
}