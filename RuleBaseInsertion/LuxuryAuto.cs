using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleBaseInsertion
{
    public class LuxuryAuto
    {
        DatabaseOperations databaseOperations = new DatabaseOperations();
        public List<LuxuryAutoDTO> MainLogic(List<string[]> entireExcel)
        {
            List<LuxuryAutoDTO> luxuryAutoList = new List<LuxuryAutoDTO>();
            foreach (string[] row in entireExcel)
            {
                LuxuryAutoDTO luxurtyAutoDTO = new LuxuryAutoDTO();
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
                luxuryAutoList.Add(luxurtyAutoDTO);
            }
            //luxuryAutoList.RemoveAt(1);
            return luxuryAutoList;
        }

        public void PushToDatabase(List<LuxuryAutoDTO> luxuryAutoList)
        {
            Guid autId = databaseOperations.GetPropertyTypeIdfromPropertyCode("AUT");
            Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(autId);
            Guid ruleProperty = databaseOperations.GetRulePropertyIdfromPropertyCode("LuxuryAuto");
            Guid rulePropertyIsBonus = databaseOperations.GetRulePropertyIdfromPropertyCode("IsBonus");
            Guid rulePropertyLM1 = databaseOperations.GetRulePropertyIdfromPropertyCode("LM1");
            Guid rulePropertyLM2= databaseOperations.GetRulePropertyIdfromPropertyCode("LM2");
            Guid rulePropertyLM3= databaseOperations.GetRulePropertyIdfromPropertyCode("LM3");
            Guid rulePropertyLM4 = databaseOperations.GetRulePropertyIdfromPropertyCode("LM4");
            Guid s179ThresholdLimit = databaseOperations.GetRulePropertyIdfromPropertyCode("S179ThresholdLimit");
            Guid s179PercentThresholdLimit = databaseOperations.GetRulePropertyIdfromPropertyCode("Section179PercentThresholdLimit");
            Guid qualByDefault = databaseOperations.GetRulePropertyIdfromPropertyCode("IsQualByDefault");
            Guid depreciationMethod = databaseOperations.GetRulePropertyIdfromPropertyCode("DM");

            foreach(LuxuryAutoDTO luxury in  luxuryAutoList)
            {
                Guid zoneId = databaseOperations.GetZoneIdBasedOnZoneCode(luxury.Zone);
                Guid luxuryAutoDef = databaseOperations.AddRuleHeader(zoneId,ruleProperty,luxury.EffectiveDate,luxury.ExpiryDate,def.ToString(),1);
                Guid luxuryAutoDetailHeader = databaseOperations.AddRuleDetail(null,luxuryAutoDef.ToString(),ruleProperty.ToString(),zoneId.ToString(),luxury.Zone,1,0,0);
                databaseOperations.AddRuleDetail(luxuryAutoDetailHeader.ToString(), luxuryAutoDef.ToString(), rulePropertyIsBonus.ToString(), null, luxury.IsBonus.ToString(), 1, 0, 0);
                databaseOperations.AddRuleDetail(luxuryAutoDetailHeader.ToString(), luxuryAutoDef.ToString(), rulePropertyLM1.ToString(), null, luxury.LimitYear1.ToString(), 1, 0, 0);
                databaseOperations.AddRuleDetail(luxuryAutoDetailHeader.ToString(), luxuryAutoDef.ToString(), rulePropertyLM2.ToString(), null, luxury.LimitYear2.ToString(), 1, 0, 0);
                databaseOperations.AddRuleDetail(luxuryAutoDetailHeader.ToString(), luxuryAutoDef.ToString(), rulePropertyLM3.ToString(), null, luxury.LimitYear3.ToString(), 1, 0, 0);
                databaseOperations.AddRuleDetail(luxuryAutoDetailHeader.ToString(), luxuryAutoDef.ToString(), rulePropertyLM4.ToString(), null, luxury.LimitYear4.ToString(), 1, 0, 0);
                databaseOperations.AddRuleDetail(luxuryAutoDetailHeader.ToString(), luxuryAutoDef.ToString(), s179ThresholdLimit.ToString(), null, luxury.ThresholdLimit.ToString(), 1, 0, 0);
                databaseOperations.AddRuleDetail(luxuryAutoDetailHeader.ToString(), luxuryAutoDef.ToString(), s179PercentThresholdLimit.ToString(), null, luxury.PercentThresholdLimit.ToString(), 1, 0, 0);
                databaseOperations.AddRuleDetail(luxuryAutoDetailHeader.ToString(), luxuryAutoDef.ToString(), qualByDefault.ToString(), null, luxury.IsQualifiedByDefault.ToString(), 1, 0, 0);
                //databaseOperations.AddRuleDetail(luxuryAutoDetailHeader.ToString(), luxuryAutoDef.ToString(), qualByDefault.ToString(), null, luxury.IsQualifiedByDefault.ToString(), 1, 0);
                if (!string.IsNullOrEmpty(luxury.DepreciationMethod) && luxury.DepreciationMethod.Contains(','))
                {
                    string[] dms = luxury.DepreciationMethod.Split(',');
                    foreach (string dm in dms)
                    {
                        Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(dm);
                        databaseOperations.AddRuleDetail(luxuryAutoDetailHeader.ToString(), luxuryAutoDef.ToString(), depreciationMethod.ToString(), dmid.ToString(), dm, 1, 0, 0);
                    }
                }

                else if (!string.IsNullOrEmpty(luxury.DepreciationMethod))
                {
                    Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(luxury.DepreciationMethod);
                    databaseOperations.AddRuleDetail(luxuryAutoDetailHeader.ToString(), luxuryAutoDef.ToString(), depreciationMethod.ToString(), dmid.ToString(), luxury.DepreciationMethod, 1, 0, 0);
                }
            }
            Console.WriteLine("****************************LuxuryAuto***************************************");
        }
    }
}
