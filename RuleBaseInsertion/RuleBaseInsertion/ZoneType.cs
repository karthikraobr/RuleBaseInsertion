using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleBaseInsertion
{
    public class ZoneType
    {
        DatabaseOperations databaseOperations = new DatabaseOperations();
        private const string ticked = "P";
        private const string enterprise = "EN";
        private const string neyYork = "NY";
        private const string goZone ="GO";
        private const string kansas = "KS";
        private const string disaster = "DS";
        private const string noZone = "NO";
        Guid ZoneTypeRulePropertyId = new Guid("1ED4F200-5DF3-403D-AC82-48F0E8F5BF82");

        public List<string[]> LoadCSV(string Path)
        {
            List<string[]> rows = new List<string[]>();
            var lines = File.ReadAllLines(Path).Select(a => a.Split(';'));
            var csv = from line in lines
                      select (from piece in line
                              select piece).ToList();
            foreach (var value in csv)
            {
                if (value[0].ToString() != ",")
                {
                    string[] temp = value[0].ToString().Split(',');
                    rows.Add(temp);
                }
            }

            return rows;
        }

        public Dictionary<string, List<string>> GetZoneTypes(string propertyType,List<string[]> Data)
        {
            Dictionary<string, List<string>> zones = new Dictionary<string, List<string>>();
            int pos = GetPositionOfPropertType(propertyType);
            foreach (string[] row in Data)
            {
                string key = row[0] + "~" + row[1];
                List<string> values = new List<string>();
                if (String.Equals(row[pos - 1], ticked))
                {
                    if (!string.IsNullOrEmpty(row[24]))
                    {
                        values.Add(noZone);
                    }
                    if (!string.IsNullOrEmpty(row[25]))
                    {
                        values.Add(enterprise);
                    }
                    if (!string.IsNullOrEmpty(row[26]))
                    {
                        values.Add(neyYork);
                    }
                    if (!string.IsNullOrEmpty(row[27]))
                    {
                        values.Add(goZone);
                    }
                    if (!string.IsNullOrEmpty(row[28]))
                    {
                        values.Add(kansas);
                    }
                    if (!string.IsNullOrEmpty(row[29]))
                    {
                        values.Add(disaster);
                    }
                    zones.Add(key, values);
                }
                //else
                //{
                //    values.Add(noZone);
                //}
                
            }
            return zones;
        }

        public void AddZoneTypeRecords(string propertyType,Dictionary<string, List<string>> zoneTypes)
        {
            Guid propertyTypeId = databaseOperations.GetPropertyTypeIdfromPropertyCode(propertyType);
             Guid defRowId = databaseOperations.GetDefinitionIdBasedOnPropertyTypeId(propertyTypeId);
             //Guid zoneTypeHeader = databaseOperations.AddRuleHeader(propertyTypeId, ZoneTypeRulePropertyId, new DateTime(1920, 1, 1).ToString(), new DateTime(1992, 12, 31).ToString(), defRowId.ToString(), 1);
             //Guid zoneTypeId1 = databaseOperations.GetZoneIdBasedOnZoneCode(noZone);
             //databaseOperations.AddRuleDetail(null, zoneTypeHeader.ToString(), ZoneTypeRulePropertyId.ToString(), zoneTypeId1.ToString(), noZone, 1, 0,0);

             //Guid zoneTypeHeader1 = databaseOperations.AddRuleHeader(propertyTypeId, ZoneTypeRulePropertyId, new DateTime(2014, 1, 1).ToString(),null, defRowId.ToString(), 1);
             //databaseOperations.AddRuleDetail(null, zoneTypeHeader1.ToString(), ZoneTypeRulePropertyId.ToString(), zoneTypeId1.ToString(), noZone, 1, 0, 0);

            foreach (KeyValuePair<string, List<string>> zone in zoneTypes)
            {
                string[] dateRange = zone.Key.Split('~');

                Guid zoneTypeHeaderId = databaseOperations.AddRuleHeader(propertyTypeId, ZoneTypeRulePropertyId, dateRange[0], dateRange[1], defRowId.ToString(), 1);
                foreach (string zoneType in zone.Value)
                {
                    Guid zoneTypeId = databaseOperations.GetZoneIdBasedOnZoneCode(zoneType);
                    if (string.Equals(zoneType, noZone))
                    {
                        databaseOperations.AddRuleDetail(null, zoneTypeHeaderId.ToString(), ZoneTypeRulePropertyId.ToString(), zoneTypeId.ToString(), zoneType, 1, 0,0);
                    }
                    else
                    {
                        databaseOperations.AddRuleDetail(null, zoneTypeHeaderId.ToString(), ZoneTypeRulePropertyId.ToString(), zoneTypeId.ToString(), zoneType, 0, 0,0);
                    }
                }
            }
        }
        public int GetPositionOfPropertType(string propertyType)
        {
            int value = 0;
            switch (propertyType)
            {
                case "AUT": value = 3;
                    break;
                case "BDG": value = 4;
                    break;
                case "BUS": value = 5;
                    break;
                case "CEQ": value = 6;
                    break;
                case "COQ": value = 7;
                    break;
                case "CSW": value = 8;
                    break;
                case "FFE": value = 9;
                    break;
                case "INT": value = 10;
                    break;
                case "LDI": value = 11;
                    break;
                case "LHI": value = 12;
                    break;
                case "LND": value = 13;
                    break;
                case "LTV": value = 14;
                    break;
                case "MFG": value = 15;
                    break;
                case "PPN": value = 16;
                    break;
                case "RPN": value = 17;
                    break;
                case "RRB": value = 18;
                    break;
                case "SUV": value = 19;
                    break;
                case "TLR": value = 20;
                    break;
                case "TRH": value = 21;
                    break;
                case "UNT": value = 22;
                    break;
                case "WRS": value = 23;
                    break;
                case "CST": value = 24;
                    break;
            }
            return value;
        }


    }

}
