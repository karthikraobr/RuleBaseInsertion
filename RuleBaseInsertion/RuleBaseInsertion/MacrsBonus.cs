using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleBaseInsertion
{
    public class MacrsBonus
    {
        DatabaseOperations databaseOperations = new DatabaseOperations();

        public Dictionary<string, List<MacrsBonusDTO>> Mainlogic(List<string[]> entireExcel)
        {

            Dictionary<string, List<MacrsBonusDTO>> allPropertyMacrs = new Dictionary<string, List<MacrsBonusDTO>>();
            List<MacrsBonusDTO> macrsBonusListAut = new List<MacrsBonusDTO>();
            List<MacrsBonusDTO> macrsBonusListBdg = new List<MacrsBonusDTO>();
            List<MacrsBonusDTO> macrsBonusListBus = new List<MacrsBonusDTO>();
            List<MacrsBonusDTO> macrsBonusListCeq = new List<MacrsBonusDTO>();
            List<MacrsBonusDTO> macrsBonusListCoq = new List<MacrsBonusDTO>();
            List<MacrsBonusDTO> macrsBonusListCsw = new List<MacrsBonusDTO>();
            List<MacrsBonusDTO> macrsBonusListffe = new List<MacrsBonusDTO>();
            List<MacrsBonusDTO> macrsBonusListInt = new List<MacrsBonusDTO>();
            List<MacrsBonusDTO> macrsBonusListLdi = new List<MacrsBonusDTO>();
            List<MacrsBonusDTO> macrsBonusListLhi = new List<MacrsBonusDTO>();
            List<MacrsBonusDTO> macrsBonusListLnd = new List<MacrsBonusDTO>();
            List<MacrsBonusDTO> macrsBonusListLtv = new List<MacrsBonusDTO>();
            List<MacrsBonusDTO> macrsBonusListMfg = new List<MacrsBonusDTO>();
            List<MacrsBonusDTO> macrsBonusListPpn = new List<MacrsBonusDTO>();
            List<MacrsBonusDTO> macrsBonusListRpn = new List<MacrsBonusDTO>();
            List<MacrsBonusDTO> macrsBonusListRrb = new List<MacrsBonusDTO>();
            List<MacrsBonusDTO> macrsBonusListTlr = new List<MacrsBonusDTO>();
            List<MacrsBonusDTO> macrsBonusListTrh = new List<MacrsBonusDTO>();
            List<MacrsBonusDTO> macrsBonusListUnt = new List<MacrsBonusDTO>();
            List<MacrsBonusDTO> macrsBonusListWrs = new List<MacrsBonusDTO>();
            List<MacrsBonusDTO> macrsBonusListCst = new List<MacrsBonusDTO>();
            List<MacrsBonusDTO> macrsBonusListSuv = new List<MacrsBonusDTO>();

            foreach (string[] row in entireExcel)
            {
                if (string.Equals(row[2], "P"))
                {
                    MacrsBonusDTO macrsBonusDTO = new MacrsBonusDTO();

                    macrsBonusDTO.EffectiveDate = row[0];
                    macrsBonusDTO.ExpiryDate = row[1];
                    if (string.Equals(row[25], "Y")) { macrsBonusDTO.IsDefault = true; }
                    macrsBonusDTO.BonusPercentage = row[26];
                    macrsBonusDTO.Description = row[27];
                    macrsBonusListAut.Add(macrsBonusDTO);
                }
                if (string.Equals(row[3], "P"))
                {
                    MacrsBonusDTO macrsBonusDTO = new MacrsBonusDTO();

                    macrsBonusDTO.EffectiveDate = row[0];
                    macrsBonusDTO.ExpiryDate = row[1];
                    if (string.Equals(row[25], "Y")) { macrsBonusDTO.IsDefault = true; }
                    macrsBonusDTO.BonusPercentage = row[26];
                    macrsBonusDTO.Description = row[27];
                    macrsBonusListBdg.Add(macrsBonusDTO);
                }
                if (string.Equals(row[4], "P"))
                {
                    MacrsBonusDTO macrsBonusDTO = new MacrsBonusDTO();

                    macrsBonusDTO.EffectiveDate = row[0];
                    macrsBonusDTO.ExpiryDate = row[1];
                    if (string.Equals(row[25], "Y")) { macrsBonusDTO.IsDefault = true; }
                    macrsBonusDTO.BonusPercentage = row[26];
                    macrsBonusDTO.Description = row[27];
                    macrsBonusListBus.Add(macrsBonusDTO);
                }
                if (string.Equals(row[5], "P"))
                {
                    MacrsBonusDTO macrsBonusDTO = new MacrsBonusDTO();

                    macrsBonusDTO.EffectiveDate = row[0];
                    macrsBonusDTO.ExpiryDate = row[1];
                    if (string.Equals(row[25], "Y")) { macrsBonusDTO.IsDefault = true; }
                    macrsBonusDTO.BonusPercentage = row[26];
                    macrsBonusDTO.Description = row[27];
                    macrsBonusListCeq.Add(macrsBonusDTO);
                }
                if (string.Equals(row[6], "P"))
                {
                    MacrsBonusDTO macrsBonusDTO = new MacrsBonusDTO();

                    macrsBonusDTO.EffectiveDate = row[0];
                    macrsBonusDTO.ExpiryDate = row[1];
                    if (string.Equals(row[25], "Y")) { macrsBonusDTO.IsDefault = true; }
                    macrsBonusDTO.BonusPercentage = row[26];
                    macrsBonusDTO.Description = row[27];
                    macrsBonusListCoq.Add(macrsBonusDTO);
                }
                if (string.Equals(row[7], "P"))
                {
                    MacrsBonusDTO macrsBonusDTO = new MacrsBonusDTO();

                    macrsBonusDTO.EffectiveDate = row[0];
                    macrsBonusDTO.ExpiryDate = row[1];
                    if (string.Equals(row[25], "Y")) { macrsBonusDTO.IsDefault = true; }
                    macrsBonusDTO.BonusPercentage = row[26];
                    macrsBonusDTO.Description = row[27];
                    macrsBonusListCsw.Add(macrsBonusDTO);
                }
                if (string.Equals(row[8], "P"))
                {
                    MacrsBonusDTO macrsBonusDTO = new MacrsBonusDTO();

                    macrsBonusDTO.EffectiveDate = row[0];
                    macrsBonusDTO.ExpiryDate = row[1];
                    if (string.Equals(row[25], "Y")) { macrsBonusDTO.IsDefault = true; }
                    macrsBonusDTO.BonusPercentage = row[26];
                    macrsBonusDTO.Description = row[27];
                    macrsBonusListffe.Add(macrsBonusDTO);
                }
                if (string.Equals(row[9], "P"))
                {
                    MacrsBonusDTO macrsBonusDTO = new MacrsBonusDTO();

                    macrsBonusDTO.EffectiveDate = row[0];
                    macrsBonusDTO.ExpiryDate = row[1];
                    if (string.Equals(row[25], "Y")) { macrsBonusDTO.IsDefault = true; }
                    macrsBonusDTO.BonusPercentage = row[26];
                    macrsBonusDTO.Description = row[27];
                    macrsBonusListInt.Add(macrsBonusDTO);
                }
                if (string.Equals(row[10], "P"))
                {
                    MacrsBonusDTO macrsBonusDTO = new MacrsBonusDTO();

                    macrsBonusDTO.EffectiveDate = row[0];
                    macrsBonusDTO.ExpiryDate = row[1];
                    if (string.Equals(row[25], "Y")) { macrsBonusDTO.IsDefault = true; }
                    macrsBonusDTO.BonusPercentage = row[26];
                    macrsBonusDTO.Description = row[27];
                    macrsBonusListLdi.Add(macrsBonusDTO);
                }
                if (string.Equals(row[11], "P"))
                {
                    MacrsBonusDTO macrsBonusDTO = new MacrsBonusDTO();

                    macrsBonusDTO.EffectiveDate = row[0];
                    macrsBonusDTO.ExpiryDate = row[1];
                    if (string.Equals(row[25], "Y")) { macrsBonusDTO.IsDefault = true; }
                    macrsBonusDTO.BonusPercentage = row[26];
                    macrsBonusDTO.Description = row[27];
                    macrsBonusListLhi.Add(macrsBonusDTO);
                }
                if (string.Equals(row[12], "P"))
                {
                    MacrsBonusDTO macrsBonusDTO = new MacrsBonusDTO();

                    macrsBonusDTO.EffectiveDate = row[0];
                    macrsBonusDTO.ExpiryDate = row[1];
                    if (string.Equals(row[25], "Y")) { macrsBonusDTO.IsDefault = true; }
                    macrsBonusDTO.BonusPercentage = row[26];
                    macrsBonusDTO.Description = row[27];
                    macrsBonusListLnd.Add(macrsBonusDTO);
                }
                if (string.Equals(row[13], "P"))
                {
                    MacrsBonusDTO macrsBonusDTO = new MacrsBonusDTO();

                    macrsBonusDTO.EffectiveDate = row[0];
                    macrsBonusDTO.ExpiryDate = row[1];
                    if (string.Equals(row[25], "Y")) { macrsBonusDTO.IsDefault = true; }
                    macrsBonusDTO.BonusPercentage = row[26];
                    macrsBonusDTO.Description = row[27];
                    macrsBonusListLtv.Add(macrsBonusDTO);
                }
                if (string.Equals(row[14], "P"))
                {
                    MacrsBonusDTO macrsBonusDTO = new MacrsBonusDTO();

                    macrsBonusDTO.EffectiveDate = row[0];
                    macrsBonusDTO.ExpiryDate = row[1];
                    if (string.Equals(row[25], "Y")) { macrsBonusDTO.IsDefault = true; }
                    macrsBonusDTO.BonusPercentage = row[26];
                    macrsBonusDTO.Description = row[27];
                    macrsBonusListMfg.Add(macrsBonusDTO);
                }
                if (string.Equals(row[15], "P"))
                {
                    MacrsBonusDTO macrsBonusDTO = new MacrsBonusDTO();

                    macrsBonusDTO.EffectiveDate = row[0];
                    macrsBonusDTO.ExpiryDate = row[1];
                    if (string.Equals(row[25], "Y")) { macrsBonusDTO.IsDefault = true; }
                    macrsBonusDTO.BonusPercentage = row[26];
                    macrsBonusDTO.Description = row[27];
                    macrsBonusListPpn.Add(macrsBonusDTO);
                }
                if (string.Equals(row[16], "P"))
                {
                    MacrsBonusDTO macrsBonusDTO = new MacrsBonusDTO();

                    macrsBonusDTO.EffectiveDate = row[0];
                    macrsBonusDTO.ExpiryDate = row[1];
                    if (string.Equals(row[25], "Y")) { macrsBonusDTO.IsDefault = true; }
                    macrsBonusDTO.BonusPercentage = row[26];
                    macrsBonusDTO.Description = row[27];
                    macrsBonusListRpn.Add(macrsBonusDTO);
                }
                if (string.Equals(row[17], "P"))
                {
                    MacrsBonusDTO macrsBonusDTO = new MacrsBonusDTO();

                    macrsBonusDTO.EffectiveDate = row[0];
                    macrsBonusDTO.ExpiryDate = row[1];
                    if (string.Equals(row[25], "Y")) { macrsBonusDTO.IsDefault = true; }
                    macrsBonusDTO.BonusPercentage = row[26];
                    macrsBonusDTO.Description = row[27];
                    macrsBonusListRrb.Add(macrsBonusDTO);
                }
                if (string.Equals(row[18], "P"))
                {
                    MacrsBonusDTO macrsBonusDTO = new MacrsBonusDTO();

                    macrsBonusDTO.EffectiveDate = row[0];
                    macrsBonusDTO.ExpiryDate = row[1];
                    if (string.Equals(row[25], "Y")) { macrsBonusDTO.IsDefault = true; }
                    macrsBonusDTO.BonusPercentage = row[26];
                    macrsBonusDTO.Description = row[27];
                    macrsBonusListSuv.Add(macrsBonusDTO);
                }
                if (string.Equals(row[19], "P"))
                {
                    MacrsBonusDTO macrsBonusDTO = new MacrsBonusDTO();

                    macrsBonusDTO.EffectiveDate = row[0];
                    macrsBonusDTO.ExpiryDate = row[1];
                    if (string.Equals(row[25], "Y")) { macrsBonusDTO.IsDefault = true; }
                    macrsBonusDTO.BonusPercentage = row[26];
                    macrsBonusDTO.Description = row[27];
                    macrsBonusListTlr.Add(macrsBonusDTO);
                }
                if (string.Equals(row[20], "P"))
                {
                    MacrsBonusDTO macrsBonusDTO = new MacrsBonusDTO();

                    macrsBonusDTO.EffectiveDate = row[0];
                    macrsBonusDTO.ExpiryDate = row[1];
                    if (string.Equals(row[25], "Y")) { macrsBonusDTO.IsDefault = true; }
                    macrsBonusDTO.BonusPercentage = row[26];
                    macrsBonusDTO.Description = row[27];
                    macrsBonusListTrh.Add(macrsBonusDTO);
                }
                if (string.Equals(row[21], "P"))
                {
                    MacrsBonusDTO macrsBonusDTO = new MacrsBonusDTO();

                    macrsBonusDTO.EffectiveDate = row[0];
                    macrsBonusDTO.ExpiryDate = row[1];
                    if (string.Equals(row[25], "Y")) { macrsBonusDTO.IsDefault = true; }
                    macrsBonusDTO.BonusPercentage = row[26];
                    macrsBonusDTO.Description = row[27];
                    macrsBonusListUnt.Add(macrsBonusDTO);
                }
                if (string.Equals(row[22], "P"))
                {
                    MacrsBonusDTO macrsBonusDTO = new MacrsBonusDTO();

                    macrsBonusDTO.EffectiveDate = row[0];
                    macrsBonusDTO.ExpiryDate = row[1];
                    if (string.Equals(row[25], "Y")) { macrsBonusDTO.IsDefault = true; }
                    macrsBonusDTO.BonusPercentage = row[26];
                    macrsBonusDTO.Description = row[27];
                    macrsBonusListWrs.Add(macrsBonusDTO);
                }
                if (string.Equals(row[23], "P"))
                {
                    MacrsBonusDTO macrsBonusDTO = new MacrsBonusDTO();

                    macrsBonusDTO.EffectiveDate = row[0];
                    macrsBonusDTO.ExpiryDate = row[1];
                    if (string.Equals(row[25], "Y")) { macrsBonusDTO.IsDefault = true; }
                    macrsBonusDTO.BonusPercentage = row[26];
                    macrsBonusDTO.Description = row[27];
                    macrsBonusListCst.Add(macrsBonusDTO);
                }
            }
            allPropertyMacrs.Add("AUT", macrsBonusListAut); 
            allPropertyMacrs.Add("BDG",macrsBonusListBdg); 
            allPropertyMacrs.Add("BUS",macrsBonusListBus); 
            allPropertyMacrs.Add("CEQ",macrsBonusListCeq);
            allPropertyMacrs.Add("COQ",macrsBonusListCoq); 
            allPropertyMacrs.Add("CSW",macrsBonusListCsw); 
            allPropertyMacrs.Add("FFE",macrsBonusListffe); 
            allPropertyMacrs.Add("INT",macrsBonusListInt); 
            allPropertyMacrs.Add("LDI",macrsBonusListLdi); 
            allPropertyMacrs.Add("LHI",macrsBonusListLhi); 
            allPropertyMacrs.Add("LND",macrsBonusListLnd); 
            allPropertyMacrs.Add("LTV",macrsBonusListLtv); 
            allPropertyMacrs.Add("MFG",macrsBonusListMfg);
            allPropertyMacrs.Add("PPN",macrsBonusListPpn); 
            allPropertyMacrs.Add("RPN",macrsBonusListRpn); 
            allPropertyMacrs.Add("RRB",macrsBonusListRrb); 
            allPropertyMacrs.Add("TLR",macrsBonusListTlr); 
            allPropertyMacrs.Add("TRH",macrsBonusListTrh);  
            allPropertyMacrs.Add("UNT",macrsBonusListUnt); 
            allPropertyMacrs.Add("WRS",macrsBonusListWrs);
            allPropertyMacrs.Add("CST", macrsBonusListCst);
            allPropertyMacrs.Add("SUV", macrsBonusListSuv);
            return allPropertyMacrs;
        }

        public void PushToDatabase(Dictionary<string, List<MacrsBonusDTO>> allPropertyMacrs)
        {
            
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
            Guid macrsRulePropertyId = databaseOperations.GetRulePropertyIdfromPropertyCode("MACRSBONUS");

            Console.WriteLine("****************************MACRS Bonus***************************************");
            if (allPropertyMacrs.ContainsKey("AUT"))
            {
                List<MacrsBonusDTO> macrsList = allPropertyMacrs["AUT"];
                foreach (MacrsBonusDTO macrsBonusDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(autId);
                    Guid macrsHeader = databaseOperations.AddRuleHeader(autId, macrsRulePropertyId, macrsBonusDTO.EffectiveDate, macrsBonusDTO.ExpiryDate, def.ToString(), 1);
                    Guid macrsId = databaseOperations.GetMacrsBonusBasedOnDescription(macrsBonusDTO.Description);
                    databaseOperations.AddRuleDetail(null, macrsHeader.ToString(), macrsRulePropertyId.ToString(), macrsId.ToString(), macrsBonusDTO.BonusPercentage.ToString(), macrsBonusDTO.IsDefault ? 1:0, 0,0);
                }
                Console.WriteLine("Automobile");
                Console.WriteLine("\n\n");
            }
            if (allPropertyMacrs.ContainsKey("BDG"))
            {
                List<MacrsBonusDTO> macrsList = allPropertyMacrs["BDG"];
                foreach (MacrsBonusDTO macrsBonusDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(bdgId);
                    Guid macrsHeader = databaseOperations.AddRuleHeader(bdgId, macrsRulePropertyId, macrsBonusDTO.EffectiveDate, macrsBonusDTO.ExpiryDate, def.ToString(), 1);
                    Guid macrsId = databaseOperations.GetMacrsBonusBasedOnDescription(macrsBonusDTO.Description);
                    databaseOperations.AddRuleDetail(null, macrsHeader.ToString(), macrsRulePropertyId.ToString(), macrsId.ToString(), macrsBonusDTO.BonusPercentage.ToString(), macrsBonusDTO.IsDefault ? 1 : 0, 0,0);
                }
                Console.WriteLine("Building");
                Console.WriteLine("\n\n");
            }
            if (allPropertyMacrs.ContainsKey("BUS"))
            {
                List<MacrsBonusDTO> macrsList = allPropertyMacrs["BUS"];
                foreach (MacrsBonusDTO macrsBonusDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(busId);
                    Guid macrsHeader = databaseOperations.AddRuleHeader(busId, macrsRulePropertyId, macrsBonusDTO.EffectiveDate, macrsBonusDTO.ExpiryDate, def.ToString(), 1);
                    Guid macrsId = databaseOperations.GetMacrsBonusBasedOnDescription(macrsBonusDTO.Description);
                    databaseOperations.AddRuleDetail(null, macrsHeader.ToString(), macrsRulePropertyId.ToString(), macrsId.ToString(), macrsBonusDTO.BonusPercentage.ToString(), macrsBonusDTO.IsDefault ? 1 : 0, 0,0);
                }
                Console.WriteLine("Bus");
                Console.WriteLine("\n\n");
            }
            if (allPropertyMacrs.ContainsKey("CEQ"))
            {
                List<MacrsBonusDTO> macrsList = allPropertyMacrs["CEQ"];
                foreach (MacrsBonusDTO macrsBonusDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(ceqId);
                    Guid macrsHeader = databaseOperations.AddRuleHeader(ceqId, macrsRulePropertyId, macrsBonusDTO.EffectiveDate, macrsBonusDTO.ExpiryDate, def.ToString(), 1);
                    Guid macrsId = databaseOperations.GetMacrsBonusBasedOnDescription(macrsBonusDTO.Description);
                    databaseOperations.AddRuleDetail(null, macrsHeader.ToString(), macrsRulePropertyId.ToString(), macrsId.ToString(), macrsBonusDTO.BonusPercentage.ToString(), macrsBonusDTO.IsDefault ? 1 : 0, 0,0);
                }
                Console.WriteLine("Ceq");
                Console.WriteLine("\n\n");
            }
            if (allPropertyMacrs.ContainsKey("COQ"))
            {
                List<MacrsBonusDTO> macrsList = allPropertyMacrs["COQ"];
                foreach (MacrsBonusDTO macrsBonusDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(coqId);
                    Guid macrsHeader = databaseOperations.AddRuleHeader(coqId, macrsRulePropertyId, macrsBonusDTO.EffectiveDate, macrsBonusDTO.ExpiryDate, def.ToString(), 1);
                    Guid macrsId = databaseOperations.GetMacrsBonusBasedOnDescription(macrsBonusDTO.Description);
                    databaseOperations.AddRuleDetail(null, macrsHeader.ToString(), macrsRulePropertyId.ToString(), macrsId.ToString(), macrsBonusDTO.BonusPercentage.ToString(), macrsBonusDTO.IsDefault ? 1 : 0, 0,0);
                }
                Console.WriteLine("Coq");
                Console.WriteLine("\n\n");
            }
            if (allPropertyMacrs.ContainsKey("CSW"))
            {
                List<MacrsBonusDTO> macrsList = allPropertyMacrs["CSW"];
                foreach (MacrsBonusDTO macrsBonusDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(cswId);
                    Guid macrsHeader = databaseOperations.AddRuleHeader(cswId, macrsRulePropertyId, macrsBonusDTO.EffectiveDate, macrsBonusDTO.ExpiryDate, def.ToString(), 1);
                    Guid macrsId = databaseOperations.GetMacrsBonusBasedOnDescription(macrsBonusDTO.Description);
                    databaseOperations.AddRuleDetail(null, macrsHeader.ToString(), macrsRulePropertyId.ToString(), macrsId.ToString(), macrsBonusDTO.BonusPercentage.ToString(), macrsBonusDTO.IsDefault ? 1 : 0, 0,0);
                }
                Console.WriteLine("Csw");
                Console.WriteLine("\n\n");
            }
            if (allPropertyMacrs.ContainsKey("FFE"))
            {
                List<MacrsBonusDTO> macrsList = allPropertyMacrs["FFE"];
                foreach (MacrsBonusDTO macrsBonusDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(ffeId);
                    Guid macrsHeader = databaseOperations.AddRuleHeader(ffeId, macrsRulePropertyId, macrsBonusDTO.EffectiveDate, macrsBonusDTO.ExpiryDate, def.ToString(), 1);
                    Guid macrsId = databaseOperations.GetMacrsBonusBasedOnDescription(macrsBonusDTO.Description);
                    databaseOperations.AddRuleDetail(null, macrsHeader.ToString(), macrsRulePropertyId.ToString(), macrsId.ToString(), macrsBonusDTO.BonusPercentage.ToString(), macrsBonusDTO.IsDefault ? 1 : 0, 0,0);
                }
                Console.WriteLine("Ffe");
                Console.WriteLine("\n\n");
            }
            if (allPropertyMacrs.ContainsKey("INT"))
            {
                List<MacrsBonusDTO> macrsList = allPropertyMacrs["INT"];
                foreach (MacrsBonusDTO macrsBonusDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(intId);
                    Guid macrsHeader = databaseOperations.AddRuleHeader(intId, macrsRulePropertyId, macrsBonusDTO.EffectiveDate, macrsBonusDTO.ExpiryDate, def.ToString(), 1);
                    Guid macrsId = databaseOperations.GetMacrsBonusBasedOnDescription(macrsBonusDTO.Description);
                    databaseOperations.AddRuleDetail(null, macrsHeader.ToString(), macrsRulePropertyId.ToString(), macrsId.ToString(), macrsBonusDTO.BonusPercentage.ToString(), macrsBonusDTO.IsDefault ? 1 : 0, 0,0);
                }
                Console.WriteLine("Int");
                Console.WriteLine("\n\n");
            }
            if (allPropertyMacrs.ContainsKey("LDI"))
            {
                List<MacrsBonusDTO> macrsList = allPropertyMacrs["LDI"];
                foreach (MacrsBonusDTO macrsBonusDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(ldiId);
                    Guid macrsHeader = databaseOperations.AddRuleHeader(ldiId, macrsRulePropertyId, macrsBonusDTO.EffectiveDate, macrsBonusDTO.ExpiryDate, def.ToString(), 1);
                    Guid macrsId = databaseOperations.GetMacrsBonusBasedOnDescription(macrsBonusDTO.Description);
                    databaseOperations.AddRuleDetail(null, macrsHeader.ToString(), macrsRulePropertyId.ToString(), macrsId.ToString(), macrsBonusDTO.BonusPercentage.ToString(), macrsBonusDTO.IsDefault ? 1 : 0, 0,0);
                }
                Console.WriteLine("Ldi");
                Console.WriteLine("\n\n");
            }
            if (allPropertyMacrs.ContainsKey("LHI"))
            {
                List<MacrsBonusDTO> macrsList = allPropertyMacrs["LHI"];
                foreach (MacrsBonusDTO macrsBonusDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(lhiId);
                    Guid macrsHeader = databaseOperations.AddRuleHeader(lhiId, macrsRulePropertyId, macrsBonusDTO.EffectiveDate, macrsBonusDTO.ExpiryDate, def.ToString(), 1);
                    Guid macrsId = databaseOperations.GetMacrsBonusBasedOnDescription(macrsBonusDTO.Description);
                    databaseOperations.AddRuleDetail(null, macrsHeader.ToString(), macrsRulePropertyId.ToString(), macrsId.ToString(), macrsBonusDTO.BonusPercentage.ToString(), macrsBonusDTO.IsDefault ? 1 : 0, 0,0);
                }
                Console.WriteLine("Lhi");
                Console.WriteLine("\n\n");
            }
            if (allPropertyMacrs.ContainsKey("LND"))
            {
                List<MacrsBonusDTO> macrsList = allPropertyMacrs["LND"];
                foreach (MacrsBonusDTO macrsBonusDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(lndId);
                    Guid macrsHeader = databaseOperations.AddRuleHeader(lndId, macrsRulePropertyId, macrsBonusDTO.EffectiveDate, macrsBonusDTO.ExpiryDate, def.ToString(), 1);
                    Guid macrsId = databaseOperations.GetMacrsBonusBasedOnDescription(macrsBonusDTO.Description);
                    databaseOperations.AddRuleDetail(null, macrsHeader.ToString(), macrsRulePropertyId.ToString(), macrsId.ToString(), macrsBonusDTO.BonusPercentage.ToString(), macrsBonusDTO.IsDefault ? 1 : 0, 0,0);
                }
                Console.WriteLine("Lnd");
                Console.WriteLine("\n\n");
            }
            if (allPropertyMacrs.ContainsKey("LTV"))
            {
                List<MacrsBonusDTO> macrsList = allPropertyMacrs["LTV"];
                foreach (MacrsBonusDTO macrsBonusDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(ltvId);
                    Guid macrsHeader = databaseOperations.AddRuleHeader(ltvId, macrsRulePropertyId, macrsBonusDTO.EffectiveDate, macrsBonusDTO.ExpiryDate, def.ToString(), 1);
                    Guid macrsId = databaseOperations.GetMacrsBonusBasedOnDescription(macrsBonusDTO.Description);
                    databaseOperations.AddRuleDetail(null, macrsHeader.ToString(), macrsRulePropertyId.ToString(), macrsId.ToString(), macrsBonusDTO.BonusPercentage.ToString(), macrsBonusDTO.IsDefault ? 1 : 0, 0,0);
                }
                Console.WriteLine("Ltv");
                Console.WriteLine("\n\n");
            }
            if (allPropertyMacrs.ContainsKey("MFG"))
            {
                List<MacrsBonusDTO> macrsList = allPropertyMacrs["MFG"];
                foreach (MacrsBonusDTO macrsBonusDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(mfgId);
                    Guid macrsHeader = databaseOperations.AddRuleHeader(mfgId, macrsRulePropertyId, macrsBonusDTO.EffectiveDate, macrsBonusDTO.ExpiryDate, def.ToString(), 1);
                    Guid macrsId = databaseOperations.GetMacrsBonusBasedOnDescription(macrsBonusDTO.Description);
                    databaseOperations.AddRuleDetail(null, macrsHeader.ToString(), macrsRulePropertyId.ToString(), macrsId.ToString(), macrsBonusDTO.BonusPercentage.ToString(), macrsBonusDTO.IsDefault ? 1 : 0, 0,0);
                }
                Console.WriteLine("Mfg");
                Console.WriteLine("\n\n");
            }
            if (allPropertyMacrs.ContainsKey("PPN"))
            {
                List<MacrsBonusDTO> macrsList = allPropertyMacrs["PPN"];
                foreach (MacrsBonusDTO macrsBonusDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(ppnId);
                    Guid macrsHeader = databaseOperations.AddRuleHeader(ppnId, macrsRulePropertyId, macrsBonusDTO.EffectiveDate, macrsBonusDTO.ExpiryDate, def.ToString(), 1);
                    Guid macrsId = databaseOperations.GetMacrsBonusBasedOnDescription(macrsBonusDTO.Description);
                    databaseOperations.AddRuleDetail(null, macrsHeader.ToString(), macrsRulePropertyId.ToString(), macrsId.ToString(), macrsBonusDTO.BonusPercentage.ToString(), macrsBonusDTO.IsDefault ? 1 : 0, 0,0);
                }
                Console.WriteLine("Ppn");
                Console.WriteLine("\n\n");
            }
            if (allPropertyMacrs.ContainsKey("RPN"))
            {
                List<MacrsBonusDTO> macrsList = allPropertyMacrs["RPN"];
                foreach (MacrsBonusDTO macrsBonusDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(rpnId);
                    Guid macrsHeader = databaseOperations.AddRuleHeader(rpnId, macrsRulePropertyId, macrsBonusDTO.EffectiveDate, macrsBonusDTO.ExpiryDate, def.ToString(), 1);
                    Guid macrsId = databaseOperations.GetMacrsBonusBasedOnDescription(macrsBonusDTO.Description);
                    databaseOperations.AddRuleDetail(null, macrsHeader.ToString(), macrsRulePropertyId.ToString(), macrsId.ToString(), macrsBonusDTO.BonusPercentage.ToString(), macrsBonusDTO.IsDefault ? 1 : 0, 0,0);
                }
                Console.WriteLine("Rpn");
                Console.WriteLine("\n\n");
            }
            if (allPropertyMacrs.ContainsKey("RRB"))
            {
                List<MacrsBonusDTO> macrsList = allPropertyMacrs["RRB"];
                foreach (MacrsBonusDTO macrsBonusDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(rrbId);
                    Guid macrsHeader = databaseOperations.AddRuleHeader(rrbId, macrsRulePropertyId, macrsBonusDTO.EffectiveDate, macrsBonusDTO.ExpiryDate, def.ToString(), 1);
                    Guid macrsId = databaseOperations.GetMacrsBonusBasedOnDescription(macrsBonusDTO.Description);
                    databaseOperations.AddRuleDetail(null, macrsHeader.ToString(), macrsRulePropertyId.ToString(), macrsId.ToString(), macrsBonusDTO.BonusPercentage.ToString(), macrsBonusDTO.IsDefault ? 1 : 0, 0,0);
                }
                Console.WriteLine("Rrb");
                Console.WriteLine("\n\n");
            }
            if (allPropertyMacrs.ContainsKey("TLR"))
            {
                List<MacrsBonusDTO> macrsList = allPropertyMacrs["TLR"];
                foreach (MacrsBonusDTO macrsBonusDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(tlrId);
                    Guid macrsHeader = databaseOperations.AddRuleHeader(tlrId, macrsRulePropertyId, macrsBonusDTO.EffectiveDate, macrsBonusDTO.ExpiryDate, def.ToString(), 1);
                    Guid macrsId = databaseOperations.GetMacrsBonusBasedOnDescription(macrsBonusDTO.Description);
                    databaseOperations.AddRuleDetail(null, macrsHeader.ToString(), macrsRulePropertyId.ToString(), macrsId.ToString(), macrsBonusDTO.BonusPercentage.ToString(), macrsBonusDTO.IsDefault ? 1 : 0, 0,0);
                }
                Console.WriteLine("Tlr");
                Console.WriteLine("\n\n");
            }
            if (allPropertyMacrs.ContainsKey("TRH"))
            {
                List<MacrsBonusDTO> macrsList = allPropertyMacrs["TRH"];
                foreach (MacrsBonusDTO macrsBonusDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(trhId);
                    Guid macrsHeader = databaseOperations.AddRuleHeader(trhId, macrsRulePropertyId, macrsBonusDTO.EffectiveDate, macrsBonusDTO.ExpiryDate, def.ToString(), 1);
                    Guid macrsId = databaseOperations.GetMacrsBonusBasedOnDescription(macrsBonusDTO.Description);
                    databaseOperations.AddRuleDetail(null, macrsHeader.ToString(), macrsRulePropertyId.ToString(), macrsId.ToString(), macrsBonusDTO.BonusPercentage.ToString(), macrsBonusDTO.IsDefault ? 1 : 0, 0,0);
                }
                Console.WriteLine("Trh");
                Console.WriteLine("\n\n");
            }
            if (allPropertyMacrs.ContainsKey("UNT"))
            {
                List<MacrsBonusDTO> macrsList = allPropertyMacrs["UNT"];
                foreach (MacrsBonusDTO macrsBonusDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(untId);
                    Guid macrsHeader = databaseOperations.AddRuleHeader(untId, macrsRulePropertyId, macrsBonusDTO.EffectiveDate, macrsBonusDTO.ExpiryDate, def.ToString(), 1);
                    Guid macrsId = databaseOperations.GetMacrsBonusBasedOnDescription(macrsBonusDTO.Description);
                    databaseOperations.AddRuleDetail(null, macrsHeader.ToString(), macrsRulePropertyId.ToString(), macrsId.ToString(), macrsBonusDTO.BonusPercentage.ToString(), macrsBonusDTO.IsDefault ? 1 : 0, 0,0);
                }
                Console.WriteLine("Unt");
                Console.WriteLine("\n\n");
            }
            if (allPropertyMacrs.ContainsKey("WRS"))
            {
                List<MacrsBonusDTO> macrsList = allPropertyMacrs["WRS"];
                foreach (MacrsBonusDTO macrsBonusDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(wrsId);
                    Guid macrsHeader = databaseOperations.AddRuleHeader(wrsId, macrsRulePropertyId, macrsBonusDTO.EffectiveDate, macrsBonusDTO.ExpiryDate, def.ToString(), 1);
                    Guid macrsId = databaseOperations.GetMacrsBonusBasedOnDescription(macrsBonusDTO.Description);
                    databaseOperations.AddRuleDetail(null, macrsHeader.ToString(), macrsRulePropertyId.ToString(), macrsId.ToString(), macrsBonusDTO.BonusPercentage.ToString(), macrsBonusDTO.IsDefault ? 1 : 0, 0,0);
                }
                Console.WriteLine("Wrs");
                Console.WriteLine("\n\n");
            }
            if (allPropertyMacrs.ContainsKey("CST"))
            {
                List<MacrsBonusDTO> macrsList = allPropertyMacrs["CST"];
                foreach (MacrsBonusDTO macrsBonusDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(cstId);
                    Guid macrsHeader = databaseOperations.AddRuleHeader(cstId, macrsRulePropertyId, macrsBonusDTO.EffectiveDate, macrsBonusDTO.ExpiryDate, def.ToString(), 1);
                    Guid macrsId = databaseOperations.GetMacrsBonusBasedOnDescription(macrsBonusDTO.Description);
                    databaseOperations.AddRuleDetail(null, macrsHeader.ToString(), macrsRulePropertyId.ToString(), macrsId.ToString(), macrsBonusDTO.BonusPercentage.ToString(), macrsBonusDTO.IsDefault ? 1 : 0, 0,0);
                }
                Console.WriteLine("Cst");
                Console.WriteLine("\n\n");
            }

            if (allPropertyMacrs.ContainsKey("SUV"))
            {
                List<MacrsBonusDTO> macrsList = allPropertyMacrs["SUV"];
                foreach (MacrsBonusDTO macrsBonusDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(suvId);
                    Guid macrsHeader = databaseOperations.AddRuleHeader(suvId, macrsRulePropertyId, macrsBonusDTO.EffectiveDate, macrsBonusDTO.ExpiryDate, def.ToString(), 1);
                    Guid macrsId = databaseOperations.GetMacrsBonusBasedOnDescription(macrsBonusDTO.Description);
                    databaseOperations.AddRuleDetail(null, macrsHeader.ToString(), macrsRulePropertyId.ToString(), macrsId.ToString(), macrsBonusDTO.BonusPercentage.ToString(), macrsBonusDTO.IsDefault ? 1 : 0, 0, 0);
                }
                Console.WriteLine("SUV");
                Console.WriteLine("\n\n");
            }
        }
    }
}
