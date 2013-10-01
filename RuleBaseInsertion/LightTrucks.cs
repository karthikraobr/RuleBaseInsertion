using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleBaseInsertion
{
    public class LightTrucks
    {
        DatabaseOperations databaseOperations = new DatabaseOperations();
        public List<LightTrucksDTO> MainLogic(List<string[]> entireExcel)
        {
            List<LightTrucksDTO> lightTrucksList = new List<LightTrucksDTO>();
            foreach (string[] row in entireExcel)
            {
                LightTrucksDTO luxurtyAutoDTO = new LightTrucksDTO();
                luxurtyAutoDTO.EffectiveDate = row[0];
                luxurtyAutoDTO.ExpiryDate = row[1];
                luxurtyAutoDTO.DepreciationMethod = row[3];
                if (string.Equals(row[7], "P"))
                {
                    luxurtyAutoDTO.IsBonus = "Yes";
                }
                else
                {
                    luxurtyAutoDTO.IsBonus = "No";
                }
                luxurtyAutoDTO.IsQualifiedByDefault = row[5];
                luxurtyAutoDTO.Zone = row[6];
                luxurtyAutoDTO.LimitYear1 = row[8];
                luxurtyAutoDTO.LimitYear2 = row[9];
                luxurtyAutoDTO.LimitYear3 = row[10];
                luxurtyAutoDTO.LimitYear4 = row[11];
                luxurtyAutoDTO.ThresholdLimit = row[12];
                luxurtyAutoDTO.PercentThresholdLimit = row[13];
                lightTrucksList.Add(luxurtyAutoDTO);
            }
            lightTrucksList.RemoveAt(1);
            return lightTrucksList;
        }

        public void PushToDatabase(List<LightTrucksDTO> lightTrucksList)
        {
            Guid autId = databaseOperations.GetPropertyTypeIdfromPropertyCode("LTV");
            Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(autId);
            Guid ruleProperty = databaseOperations.GetRulePropertyIdfromPropertyCode("LightTruckLimit");
            Guid rulePropertyIsBonus = databaseOperations.GetRulePropertyIdfromPropertyCode("IsBonus");
            Guid rulePropertyLM1 = databaseOperations.GetRulePropertyIdfromPropertyCode("LM1");
            Guid rulePropertyLM2 = databaseOperations.GetRulePropertyIdfromPropertyCode("LM2");
            Guid rulePropertyLM3 = databaseOperations.GetRulePropertyIdfromPropertyCode("LM3");
            Guid rulePropertyLM4 = databaseOperations.GetRulePropertyIdfromPropertyCode("LM4");
            Guid s179ThresholdLimit = databaseOperations.GetRulePropertyIdfromPropertyCode("S179ThresholdLimit");
            Guid s179PercentThresholdLimit = databaseOperations.GetRulePropertyIdfromPropertyCode("Section179PercentThresholdLimit");
            Guid qualByDefault = databaseOperations.GetRulePropertyIdfromPropertyCode("IsQualByDefault");
            Guid depreciationMethod = databaseOperations.GetRulePropertyIdfromPropertyCode("DM");

            foreach (LightTrucksDTO luxury in lightTrucksList)
            {
                Guid zoneId = databaseOperations.GetZoneIdBasedOnZoneCode(luxury.Zone);
                Guid lightTrucksDef = databaseOperations.AddRuleHeader(zoneId, ruleProperty, luxury.EffectiveDate, luxury.ExpiryDate, def.ToString(), 1);
                Guid lightTrucksDetailHeader = databaseOperations.AddRuleDetail(null, lightTrucksDef.ToString(), ruleProperty.ToString(), zoneId.ToString(), luxury.Zone, 1, 0, 0);
                databaseOperations.AddRuleDetail(lightTrucksDetailHeader.ToString(), lightTrucksDef.ToString(), rulePropertyIsBonus.ToString(), null, luxury.IsBonus.ToString(), 1, 0, 0);
                databaseOperations.AddRuleDetail(lightTrucksDetailHeader.ToString(), lightTrucksDef.ToString(), rulePropertyLM1.ToString(), null, luxury.LimitYear1.ToString(), 1, 0, 0);
                databaseOperations.AddRuleDetail(lightTrucksDetailHeader.ToString(), lightTrucksDef.ToString(), rulePropertyLM2.ToString(), null, luxury.LimitYear2.ToString(), 1, 0, 0);
                databaseOperations.AddRuleDetail(lightTrucksDetailHeader.ToString(), lightTrucksDef.ToString(), rulePropertyLM3.ToString(), null, luxury.LimitYear3.ToString(), 1, 0, 0);
                databaseOperations.AddRuleDetail(lightTrucksDetailHeader.ToString(), lightTrucksDef.ToString(), rulePropertyLM4.ToString(), null, luxury.LimitYear4.ToString(), 1, 0, 0);
                databaseOperations.AddRuleDetail(lightTrucksDetailHeader.ToString(), lightTrucksDef.ToString(), s179ThresholdLimit.ToString(), null, luxury.ThresholdLimit.ToString(), 1, 0, 0);
                databaseOperations.AddRuleDetail(lightTrucksDetailHeader.ToString(), lightTrucksDef.ToString(), s179PercentThresholdLimit.ToString(), null, luxury.PercentThresholdLimit.ToString(), 1, 0, 0);
                databaseOperations.AddRuleDetail(lightTrucksDetailHeader.ToString(), lightTrucksDef.ToString(), qualByDefault.ToString(), null, luxury.IsQualifiedByDefault.ToString(), 1, 0, 0);
                //databaseOperations.AddRuleDetail(lightTrucksDetailHeader.ToString(), lightTrucksDef.ToString(), qualByDefault.ToString(), null, luxury.IsQualifiedByDefault.ToString(), 1, 0);
                if (!string.IsNullOrEmpty(luxury.DepreciationMethod) && luxury.DepreciationMethod.Contains(','))
                {
                    string[] dms = luxury.DepreciationMethod.Split(',');
                    foreach (string dm in dms)
                    {
                        Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(dm);
                        databaseOperations.AddRuleDetail(lightTrucksDetailHeader.ToString(), lightTrucksDef.ToString(), depreciationMethod.ToString(), dmid.ToString(), dm, 1, 0, 0);
                    }
                }

                else if (!string.IsNullOrEmpty(luxury.DepreciationMethod))
                {
                    Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(luxury.DepreciationMethod);
                    databaseOperations.AddRuleDetail(lightTrucksDetailHeader.ToString(), lightTrucksDef.ToString(), depreciationMethod.ToString(), dmid.ToString(), luxury.DepreciationMethod, 1, 0, 0);
                }
            }
            Console.WriteLine("****************************LightTruck***************************************");
        }
    }
}
