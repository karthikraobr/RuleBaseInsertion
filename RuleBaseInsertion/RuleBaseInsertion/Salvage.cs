using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleBaseInsertion
{
    public class Salvage
    {

        DatabaseOperations databaseOperations = new DatabaseOperations();

        public void MainLogic(List<string[]> excel)
        {
            Guid rulePropertyId = databaseOperations.GetRulePropertyIdfromPropertyCode("SalvageValue");
            Guid depreciationMethodRulePropertyId = databaseOperations.GetRulePropertyIdfromPropertyCode("DM");

            Guid autId = databaseOperations.GetPropertyTypeIdfromPropertyCode("AUT");
            Guid bdgId = databaseOperations.GetPropertyTypeIdfromPropertyCode("BDG");
            Guid busId = databaseOperations.GetPropertyTypeIdfromPropertyCode("BUS");
            Guid ceqId = databaseOperations.GetPropertyTypeIdfromPropertyCode("CEQ");
            Guid coqId = databaseOperations.GetPropertyTypeIdfromPropertyCode("COQ");
            Guid cswId = databaseOperations.GetPropertyTypeIdfromPropertyCode("CSW");
            Guid ffeId = databaseOperations.GetPropertyTypeIdfromPropertyCode("FFE");
            Guid intId = databaseOperations.GetPropertyTypeIdfromPropertyCode("INT");
            Guid ldiId = databaseOperations.GetPropertyTypeIdfromPropertyCode("LDI");
            Guid lhiId = databaseOperations.GetPropertyTypeIdfromPropertyCode("LHI");
            Guid lndId = databaseOperations.GetPropertyTypeIdfromPropertyCode("LND");
            Guid ltvId = databaseOperations.GetPropertyTypeIdfromPropertyCode("LTV");
            Guid mfgId = databaseOperations.GetPropertyTypeIdfromPropertyCode("MFG");
            Guid ppnId = databaseOperations.GetPropertyTypeIdfromPropertyCode("PPN");
            Guid rpnId = databaseOperations.GetPropertyTypeIdfromPropertyCode("RPN");
            Guid rrbId = databaseOperations.GetPropertyTypeIdfromPropertyCode("RRB");
            Guid tlrId = databaseOperations.GetPropertyTypeIdfromPropertyCode("TLR");
            Guid trhId = databaseOperations.GetPropertyTypeIdfromPropertyCode("TRH");
            Guid untId = databaseOperations.GetPropertyTypeIdfromPropertyCode("UNT");
            Guid wrsId = databaseOperations.GetPropertyTypeIdfromPropertyCode("WRS");
            Guid cstId = databaseOperations.GetPropertyTypeIdfromPropertyCode("CST");
            Guid suvId = databaseOperations.GetPropertyTypeIdfromPropertyCode("SUV");

            Guid autdef = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(autId);
            Guid bdgdef = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(bdgId);
            Guid busdef = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(busId);
            Guid ceqdef = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(ceqId);
            Guid coqdef = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(coqId);
            Guid cswdef = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(cswId);
            Guid ffedef = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(ffeId);
            Guid intdef = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(intId);
            Guid ldidef = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(ldiId);
            Guid lhidef = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(lhiId);
            Guid lnddef = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(lndId);
            Guid ltvdef = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(ltvId);
            Guid mfgdef = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(mfgId);
            Guid ppndef = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(ppnId);
            Guid rpndef = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(rpnId);
            Guid rrbdef = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(rrbId);
            Guid tlrdef = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(tlrId);
            Guid trhdef = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(trhId);
            Guid untdef = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(untId);
            Guid wrsdef = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(wrsId);
            Guid cstdef = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(cstId);
            Guid suvdef = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(suvId);

            foreach (string[] row in excel)
            {
                Guid salvageId = databaseOperations.GetSalvageIdOnDecription(row[37]);
                Dictionary<string, Guid> availableDeprciationMethods = GetDepreciationMethod(row);
                if (string.Equals(row[0], "P"))
                {
                    Guid header = databaseOperations.AddRuleHeader(salvageId, rulePropertyId, row[22], row[23], autdef.ToString(), 1);
                    foreach (KeyValuePair<string, Guid> dm in availableDeprciationMethods)
                    {
                        databaseOperations.AddRuleDetail(null, header.ToString(), depreciationMethodRulePropertyId.ToString(), dm.Value.ToString(), dm.Key, 1, 0, 0);
                    }
                }
                if (string.Equals(row[1], "P"))
                {
                    Guid header = databaseOperations.AddRuleHeader(salvageId, rulePropertyId, row[22], row[23], bdgdef.ToString(), 1);
                    foreach (KeyValuePair<string, Guid> dm in availableDeprciationMethods)
                    {
                        databaseOperations.AddRuleDetail(null, header.ToString(), depreciationMethodRulePropertyId.ToString(), dm.Value.ToString(), dm.Key, 1, 0, 0);
                    }
                }
                if (string.Equals(row[2], "P"))
                {
                    Guid header = databaseOperations.AddRuleHeader(salvageId, rulePropertyId, row[22], row[23], busdef.ToString(), 1);
                    foreach (KeyValuePair<string, Guid> dm in availableDeprciationMethods)
                    {
                        databaseOperations.AddRuleDetail(null, header.ToString(), depreciationMethodRulePropertyId.ToString(), dm.Value.ToString(), dm.Key, 1, 0, 0);
                    }
                }
                if (string.Equals(row[3], "P"))
                {
                    Guid header = databaseOperations.AddRuleHeader(salvageId, rulePropertyId, row[22], row[23], ceqdef.ToString(), 1);
                    foreach (KeyValuePair<string, Guid> dm in availableDeprciationMethods)
                    {
                        databaseOperations.AddRuleDetail(null, header.ToString(), depreciationMethodRulePropertyId.ToString(), dm.Value.ToString(), dm.Key, 1, 0, 0);
                    }
                }
                if (string.Equals(row[4], "P"))
                {
                    Guid header = databaseOperations.AddRuleHeader(salvageId, rulePropertyId, row[22], row[23], coqdef.ToString(), 1);
                    foreach (KeyValuePair<string, Guid> dm in availableDeprciationMethods)
                    {
                        databaseOperations.AddRuleDetail(null, header.ToString(), depreciationMethodRulePropertyId.ToString(), dm.Value.ToString(), dm.Key, 1, 0, 0);
                    }
                }
                if (string.Equals(row[5], "P"))
                {
                    Guid header = databaseOperations.AddRuleHeader(salvageId, rulePropertyId, row[22], row[23], cswdef.ToString(), 1);
                    foreach (KeyValuePair<string, Guid> dm in availableDeprciationMethods)
                    {
                        databaseOperations.AddRuleDetail(null, header.ToString(), depreciationMethodRulePropertyId.ToString(), dm.Value.ToString(), dm.Key, 1, 0, 0);
                    }
                }
                if (string.Equals(row[6], "P"))
                {
                    Guid header = databaseOperations.AddRuleHeader(salvageId, rulePropertyId, row[22], row[23], ffedef.ToString(), 1);
                    foreach (KeyValuePair<string, Guid> dm in availableDeprciationMethods)
                    {
                        databaseOperations.AddRuleDetail(null, header.ToString(), depreciationMethodRulePropertyId.ToString(), dm.Value.ToString(), dm.Key, 1, 0, 0);
                    }
                }
                if (string.Equals(row[7], "P"))
                {
                    Guid header = databaseOperations.AddRuleHeader(salvageId, rulePropertyId, row[22], row[23], intdef.ToString(), 1);
                    foreach (KeyValuePair<string, Guid> dm in availableDeprciationMethods)
                    {
                        databaseOperations.AddRuleDetail(null, header.ToString(), depreciationMethodRulePropertyId.ToString(), dm.Value.ToString(), dm.Key, 1, 0, 0);
                    }
                }
                if (string.Equals(row[8], "P"))
                {
                    Guid header = databaseOperations.AddRuleHeader(salvageId, rulePropertyId, row[22], row[23], ldidef.ToString(), 1);
                    foreach (KeyValuePair<string, Guid> dm in availableDeprciationMethods)
                    {
                        databaseOperations.AddRuleDetail(null, header.ToString(), depreciationMethodRulePropertyId.ToString(), dm.Value.ToString(), dm.Key, 1, 0, 0);
                    }
                }
                if (string.Equals(row[9], "P"))
                {
                    Guid header = databaseOperations.AddRuleHeader(salvageId, rulePropertyId, row[22], row[23], lhidef.ToString(), 1);
                    foreach (KeyValuePair<string, Guid> dm in availableDeprciationMethods)
                    {
                        databaseOperations.AddRuleDetail(null, header.ToString(), depreciationMethodRulePropertyId.ToString(), dm.Value.ToString(), dm.Key, 1, 0, 0);
                    }
                }
                if (string.Equals(row[10], "P"))
                {
                    Guid header = databaseOperations.AddRuleHeader(salvageId, rulePropertyId, row[22], row[23], lnddef.ToString(), 1);
                    foreach (KeyValuePair<string, Guid> dm in availableDeprciationMethods)
                    {
                        databaseOperations.AddRuleDetail(null, header.ToString(), depreciationMethodRulePropertyId.ToString(), dm.Value.ToString(), dm.Key, 1, 0, 0);
                    }
                }
                if (string.Equals(row[11], "P"))
                {
                    Guid header = databaseOperations.AddRuleHeader(salvageId, rulePropertyId, row[22], row[23], ltvdef.ToString(), 1);
                    foreach (KeyValuePair<string, Guid> dm in availableDeprciationMethods)
                    {
                        databaseOperations.AddRuleDetail(null, header.ToString(), depreciationMethodRulePropertyId.ToString(), dm.Value.ToString(), dm.Key, 1, 0, 0);
                    }
                }
                if (string.Equals(row[12], "P"))
                {
                    Guid header = databaseOperations.AddRuleHeader(salvageId, rulePropertyId, row[22], row[23], mfgdef.ToString(), 1);
                    foreach (KeyValuePair<string, Guid> dm in availableDeprciationMethods)
                    {
                        databaseOperations.AddRuleDetail(null, header.ToString(), depreciationMethodRulePropertyId.ToString(), dm.Value.ToString(), dm.Key, 1, 0, 0);
                    }
                }
                if (string.Equals(row[13], "P"))
                {
                    Guid header = databaseOperations.AddRuleHeader(salvageId, rulePropertyId, row[22], row[23], ppndef.ToString(), 1);
                    foreach (KeyValuePair<string, Guid> dm in availableDeprciationMethods)
                    {
                        databaseOperations.AddRuleDetail(null, header.ToString(), depreciationMethodRulePropertyId.ToString(), dm.Value.ToString(), dm.Key, 1, 0, 0);
                    }
                }
                if (string.Equals(row[14], "P"))
                {
                    Guid header = databaseOperations.AddRuleHeader(salvageId, rulePropertyId, row[22], row[23], rpndef.ToString(), 1);
                    foreach (KeyValuePair<string, Guid> dm in availableDeprciationMethods)
                    {
                        databaseOperations.AddRuleDetail(null, header.ToString(), depreciationMethodRulePropertyId.ToString(), dm.Value.ToString(), dm.Key, 1, 0, 0);
                    }
                }
                if (string.Equals(row[15], "P"))
                {
                    Guid header = databaseOperations.AddRuleHeader(salvageId, rulePropertyId, row[22], row[23], rrbdef.ToString(), 1);
                    foreach (KeyValuePair<string, Guid> dm in availableDeprciationMethods)
                    {
                        databaseOperations.AddRuleDetail(null, header.ToString(), depreciationMethodRulePropertyId.ToString(), dm.Value.ToString(), dm.Key, 1, 0, 0);
                    }
                }
                if (string.Equals(row[16], "P"))
                {
                    Guid header = databaseOperations.AddRuleHeader(salvageId, rulePropertyId, row[22], row[23], suvdef.ToString(), 1);
                    foreach (KeyValuePair<string, Guid> dm in availableDeprciationMethods)
                    {
                        databaseOperations.AddRuleDetail(null, header.ToString(), depreciationMethodRulePropertyId.ToString(), dm.Value.ToString(), dm.Key, 1, 0, 0);
                    }
                }
                if (string.Equals(row[17], "P"))
                {
                    Guid header = databaseOperations.AddRuleHeader(salvageId, rulePropertyId, row[22], row[23], tlrdef.ToString(), 1);
                    foreach (KeyValuePair<string, Guid> dm in availableDeprciationMethods)
                    {
                        databaseOperations.AddRuleDetail(null, header.ToString(), depreciationMethodRulePropertyId.ToString(), dm.Value.ToString(), dm.Key, 1, 0, 0);
                    }
                }
                if (string.Equals(row[18], "P"))
                {
                    Guid header = databaseOperations.AddRuleHeader(salvageId, rulePropertyId, row[22], row[23], trhdef.ToString(), 1);
                    foreach (KeyValuePair<string, Guid> dm in availableDeprciationMethods)
                    {
                        databaseOperations.AddRuleDetail(null, header.ToString(), depreciationMethodRulePropertyId.ToString(), dm.Value.ToString(), dm.Key, 1, 0, 0);
                    }
                }
                if (string.Equals(row[19], "P"))
                {
                    Guid header = databaseOperations.AddRuleHeader(salvageId, rulePropertyId, row[22], row[23], untdef.ToString(), 1);
                    foreach (KeyValuePair<string, Guid> dm in availableDeprciationMethods)
                    {
                        databaseOperations.AddRuleDetail(null, header.ToString(), depreciationMethodRulePropertyId.ToString(), dm.Value.ToString(), dm.Key, 1, 0, 0);
                    }
                }
                if (string.Equals(row[20], "P"))
                {
                    Guid header = databaseOperations.AddRuleHeader(salvageId, rulePropertyId, row[22], row[23], wrsdef.ToString(), 1);
                    foreach (KeyValuePair<string, Guid> dm in availableDeprciationMethods)
                    {
                        databaseOperations.AddRuleDetail(null, header.ToString(), depreciationMethodRulePropertyId.ToString(), dm.Value.ToString(), dm.Key, 1, 0, 0);
                    }
                }
                if (string.Equals(row[21], "P"))
                {
                    Guid header = databaseOperations.AddRuleHeader(salvageId, rulePropertyId, row[22], row[23], cstdef.ToString(), 1);
                    foreach (KeyValuePair<string, Guid> dm in availableDeprciationMethods)
                    {
                        databaseOperations.AddRuleDetail(null, header.ToString(), depreciationMethodRulePropertyId.ToString(), dm.Value.ToString(), dm.Key, 1, 0, 0);
                    }
                }
            }
        }

        public Dictionary<string, Guid> GetDepreciationMethod(string[] row)
        {
            Dictionary<string, Guid> depreciationMethods = new Dictionary<string, Guid>();

            if (string.Equals(row[24], "P"))
            {
                Guid depreciationMethodId = databaseOperations.GetDepreciationMethodBasedOnCode("SL");
                depreciationMethods.Add("SL", depreciationMethodId);
            }
            if (string.Equals(row[25], "P"))
            {
                Guid depreciationMethodId = databaseOperations.GetDepreciationMethodBasedOnCode("DB");
                depreciationMethods.Add("DB", depreciationMethodId);
            }
            if (string.Equals(row[26], "P"))
            {
                Guid depreciationMethodId = databaseOperations.GetDepreciationMethodBasedOnCode("DC");
                depreciationMethods.Add("DC", depreciationMethodId);
            }
            if (string.Equals(row[27], "P"))
            {
                Guid depreciationMethodId = databaseOperations.GetDepreciationMethodBasedOnCode("SY");
                depreciationMethods.Add("SY", depreciationMethodId);
            }
            if (string.Equals(row[28], "P"))
            {
                Guid depreciationMethodId = databaseOperations.GetDepreciationMethodBasedOnCode("RV");
                depreciationMethods.Add("RV", depreciationMethodId);
            }
            if (string.Equals(row[29], "P"))
            {
                Guid depreciationMethodId = databaseOperations.GetDepreciationMethodBasedOnCode("AT");
                depreciationMethods.Add("AT", depreciationMethodId);
            }
            if (string.Equals(row[30], "P"))
            {
                Guid depreciationMethodId = databaseOperations.GetDepreciationMethodBasedOnCode("SA");
                depreciationMethods.Add("SA", depreciationMethodId);
            }
            if (string.Equals(row[31], "P"))
            {
                Guid depreciationMethodId = databaseOperations.GetDepreciationMethodBasedOnCode("ST");
                depreciationMethods.Add("ST", depreciationMethodId);
            }
            if (string.Equals(row[32], "P"))
            {
                Guid depreciationMethodId = databaseOperations.GetDepreciationMethodBasedOnCode("MF");
                depreciationMethods.Add("MF", depreciationMethodId);
            }
            if (string.Equals(row[33], "P"))
            {
                Guid depreciationMethodId = databaseOperations.GetDepreciationMethodBasedOnCode("MT");
                depreciationMethods.Add("MT", depreciationMethodId);
            }
            if (string.Equals(row[34], "P"))
            {
                Guid depreciationMethodId = databaseOperations.GetDepreciationMethodBasedOnCode("AD");
                depreciationMethods.Add("AD", depreciationMethodId);
            }
            if (string.Equals(row[35], "P"))
            {
                Guid depreciationMethodId = databaseOperations.GetDepreciationMethodBasedOnCode("CU");
                depreciationMethods.Add("CU", depreciationMethodId);
            }
            //if (string.Equals(row[35], "P"))
            //{
            //    Guid depreciationMethodId = databaseOperations.GetDepreciationMethodBasedOnCode("OC");
            //    depreciationMethods.Add("OC", depreciationMethodId);
            //}
            return depreciationMethods;
        }
    }
}
