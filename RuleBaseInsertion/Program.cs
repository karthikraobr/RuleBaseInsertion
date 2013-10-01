using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleBaseInsertion
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelTasks excelTasks = new ExcelTasks();
            ProcessExcel processExcel = new ProcessExcel();

            List<string[]> propertyExcel = excelTasks.ConvertExcelToList(excelTasks.LoadExcelSheet(@"D:\Sage\SRC\RuleBaseInsertion\Rulebase-Prop Types, Depr Methods and Lifes(1).xlsx", "Book Defaults"));
            processExcel.Mainlogic(propertyExcel);

            List<string[]> excelMacrs = excelTasks.ConvertExcelToListMacrsBonus(excelTasks.LoadExcelSheet(@"D:\Sage\SRC\RuleBaseInsertion\Rulebase-MACRS Bonus.xlsx", "Defaults by PT & PIS"));
            MacrsBonus macrs = new MacrsBonus();
            macrs.PushToDatabase(macrs.Mainlogic(excelMacrs));

            List<string[]> excelITC = excelTasks.ConvertExcelToListITC(excelTasks.LoadExcelSheet(@"D:\Sage\SRC\RuleBaseInsertion\Rulebase-ITC.xls", "ITC"));
            ITC itc = new ITC();
            itc.PushToDatabase(itc.MainLogic(excelITC));

            List<string[]> excelS179 = excelTasks.ConvertExcelToListS179(excelTasks.LoadExcelSheet(@"D:\Sage\SRC\RuleBaseInsertion\Rulebase-Section 179_new.xlsx", "A. 179 Limits"));
            S179 s179 = new S179();
            s179.PushToDatabase(s179.MainLogic(excelS179));

            List<string[]> excelLuxuryAuto = excelTasks.ConvertExcelToListLuxuryAuto(excelTasks.LoadExcelSheet(@"D:\Sage\SRC\RuleBaseInsertion\Rulebase-Section 179_new.xlsx", "B. Luxury Autos"));
            LuxuryAuto luxuryAuto = new LuxuryAuto();
            luxuryAuto.PushToDatabase(luxuryAuto.MainLogic(excelLuxuryAuto));

            List<string[]> excelLightTrucks = excelTasks.ConvertExcelToListLightTrucks(excelTasks.LoadExcelSheet(@"D:\Sage\SRC\RuleBaseInsertion\Rulebase-Section 179_new.xlsx", "C. Luxury TrucksVans"));
            LightTrucks lighttrucks = new LightTrucks();
            lighttrucks.PushToDatabase(lighttrucks.MainLogic(excelLightTrucks));

            List<string[]> excelS179Other = excelTasks.ConvertExcelToListS179Others(excelTasks.LoadExcelSheet(@"D:\Sage\SRC\RuleBaseInsertion\Rulebase-Other Basis Reductions.xls", "179Other"));
            S179OtherDeductions other = new S179OtherDeductions();
            other.MainLogic(excelS179Other);


            List<string[]> excelSalvage = excelTasks.ConvertExcelToListSalvage(excelTasks.LoadExcelSheet(@"D:\Sage\SRC\RuleBaseInsertion\Rulebase-Other Basis Reductions.xls", "179Other"));
            Salvage salvage = new Salvage();
            salvage.MainLogic(excelSalvage);

           List<string[]> excelPreACRS = excelTasks.ConvertExcelToListPreACRSBonus(excelTasks.LoadExcelSheet(@"D:\Sage\SRC\RuleBaseInsertion\Rulebase-Other Basis Reductions.xls", "179Other"));
           PreACRSBonus preACRSBonus = new PreACRSBonus();
           preACRSBonus.MainLogic(excelPreACRS);

           ZoneType zoneType = new ZoneType();
           List<string[]> zoneTypeData = zoneType.LoadCSV(@"D:\Sage\SRC\RuleBaseInsertion\ZoneType.csv");
            List<string> propertyList = new List<string>();
                propertyList.Add( "AUT");
                propertyList.Add( "BDG");
                propertyList.Add( "BUS");
                propertyList.Add( "CEQ");
                propertyList.Add( "COQ");
                propertyList.Add( "CSW");
                propertyList.Add( "FFE");
                propertyList.Add( "INT");
                propertyList.Add( "LDI");
                propertyList.Add( "LHI");
                propertyList.Add( "LND");
                propertyList.Add( "MFG");
                propertyList.Add( "PPN");
                propertyList.Add( "RPN");
                propertyList.Add( "RRB");
                propertyList.Add( "TLR");
                propertyList.Add( "TRH");
                propertyList.Add( "LTV");
                propertyList.Add( "UNT");
                propertyList.Add( "WRS");
                propertyList.Add( "CST");
                Console.WriteLine("ZoneTypes");
            foreach(string propertyType in propertyList)
            {
                Dictionary<string, List<string>> zones = zoneType.GetZoneTypes(propertyType, zoneTypeData);
                zoneType.AddZoneTypeRecords(propertyType, zones);
            }

        }
    }
}
