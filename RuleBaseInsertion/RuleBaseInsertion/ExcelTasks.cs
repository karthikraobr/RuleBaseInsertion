using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Linq;

namespace RuleBaseInsertion
{
    public class ExcelTasks
    {
        public List<string[]> ConvertExcelToList(Worksheet workSheet)
        {
            List<string[]> rows = new List<string[]>();

            for (int i = 5; i <= 1462; i++)
            {
                Range range = workSheet.get_Range("A" + i.ToString(), "AC" + i.ToString());
                System.Array myvalues = (System.Array)range.Cells.Value;
                string[] strArray = ConvertToStringArray(myvalues);
                rows.Add(strArray);
            }
            return rows;
        }

        public Worksheet LoadExcelSheet(string Path,string workBookName)
        {
            Application excel = new Application();
            var oWorkBook = excel.Workbooks.Open(Path);
            Worksheet oSheet = oWorkBook.Worksheets[workBookName];
            return oSheet;
        }

        private string[] ConvertToStringArray(System.Array values)
        {
            // create a new string array
            string[] theArray = new string[values.Length];

            // loop through the 2-D System.Array and populate the 1-D String Array
            for (int i = 1; i <= values.Length; i++)
            {
                if (values.GetValue(1, i) == null)
                    theArray[i - 1] = "";
                else
                    theArray[i - 1] = (string)values.GetValue(1, i).ToString();
            }

            return theArray;
        }

        public List<string[]> ConvertExcelToListCodeSection(Worksheet workSheet)
        {
            List<string[]> rows = new List<string[]>();

            for (int i = 4; i <= 29; i++)
            {
                Range range = workSheet.get_Range("A" + i.ToString(), "J" + i.ToString());
                System.Array myvalues = (System.Array)range.Cells.Value;
                string[] strArray = ConvertToStringArray(myvalues);
                rows.Add(strArray);
            }
            return rows;
        }

        public List<string[]> ConvertExcelToListMacrsBonus(Worksheet workSheet)
        {
            List<string[]> rows = new List<string[]>();

            for (int i = 7; i <= 50; i++)
            {
                Range range = workSheet.get_Range("C" + i.ToString(), "AD" + i.ToString());
                System.Array myvalues = (System.Array)range.Cells.Value;
                string[] strArray = ConvertToStringArray(myvalues);
                rows.Add(strArray);
            }
            return rows;
        }

        public List<string[]> ConvertExcelToListITC(Worksheet workSheet)
        {
            List<string[]> rows = new List<string[]>();

            for (int i = 2; i <= 23; i++)
            {
                //Fixed
                Range range = workSheet.get_Range("B" + i.ToString(), "AD" + i.ToString());
                System.Array myvalues = (System.Array)range.Cells.Value;
                string[] strArray = ConvertToStringArray(myvalues);
                rows.Add(strArray);
            }
            return rows;
        }

        public List<string[]> ConvertExcelToListS179(Worksheet workSheet)
        {
            List<string[]> rows = new List<string[]>();

            for (int i = 4; i <= 110; i++)
            {
                Range range = workSheet.get_Range("A" + i.ToString(), "AF" + i.ToString());
                System.Array myvalues = (System.Array)range.Cells.Value;
                string[] strArray = ConvertToStringArray(myvalues);
                rows.Add(strArray);
            }
            return rows;
        }

        public List<string[]> ConvertExcelToListLuxuryAuto(Worksheet workSheet)
        {
            List<string[]> rows = new List<string[]>();

            for (int i = 4; i <= 99; i++)
            {
                Range range = workSheet.get_Range("A" + i.ToString(), "N" + i.ToString());
                System.Array myvalues = (System.Array)range.Cells.Value;
                string[] strArray = ConvertToStringArray(myvalues);
                rows.Add(strArray);
            }
            return rows;
        }

        public List<string[]> ConvertExcelToListLightTrucks(Worksheet workSheet)
        {
            List<string[]> rows = new List<string[]>();

            for (int i = 4; i <= 72; i++)
            {
                Range range = workSheet.get_Range("A" + i.ToString(), "N" + i.ToString());
                System.Array myvalues = (System.Array)range.Cells.Value;
                string[] strArray = ConvertToStringArray(myvalues);
                rows.Add(strArray);
            }
            return rows;
        }

        public List<string[]> ConvertExcelToListS179Others(Worksheet workSheet)
        {
            List<string[]> rows = new List<string[]>();

            for (int i = 3; i <= 8; i++)
            {
                Range range = workSheet.get_Range("B" + i.ToString(), "AO" + i.ToString());
                System.Array myvalues = (System.Array)range.Cells.Value;
                string[] strArray = ConvertToStringArray(myvalues);
                rows.Add(strArray);
            }
            return rows;
        }

        public List<string[]> ConvertExcelToListSalvage(Worksheet workSheet)
        {
            List<string[]> rows = new List<string[]>();

            for (int i = 23; i <= 25; i++)
            {
                Range range = workSheet.get_Range("B" + i.ToString(), "AO" + i.ToString());
                System.Array myvalues = (System.Array)range.Cells.Value;
                string[] strArray = ConvertToStringArray(myvalues);
                rows.Add(strArray);
            }
            return rows;
        }

        public List<string[]> ConvertExcelToListPreACRSBonus(Worksheet workSheet)
        {
            List<string[]> rows = new List<string[]>();

            for (int i = 33; i <= 33; i++)
            {
                Range range = workSheet.get_Range("B" + i.ToString(), "AO" + i.ToString());
                System.Array myvalues = (System.Array)range.Cells.Value;
                string[] strArray = ConvertToStringArray(myvalues);
                rows.Add(strArray);
            }
            return rows;
        }

        public List<string[]> ConvertExceltoListS179Classification(Worksheet worksheet)
        {
            List<string[]> rows = new List<string[]>();

            for (int i = 7; i <= 11; i++)
            {
                Range range = worksheet.get_Range("A" + i.ToString(), "AA" + i.ToString());
                System.Array myvalues = (System.Array)range.Cells.Value;
                string[] strArray = ConvertToStringArray(myvalues);
                rows.Add(strArray);
            }
            return rows;
            
        }

        
    }
}