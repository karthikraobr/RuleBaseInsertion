using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleBaseInsertion
{
    public class ITC
    {
        DatabaseOperations databaseOperations = new DatabaseOperations();

        public Dictionary<string, List<ITCDTO>> MainLogic(List<string[]> excelITC)
        {
            Dictionary<string, List<ITCDTO>> allPropertyITC = new Dictionary<string, List<ITCDTO>>();
            List<ITCDTO> iTCListAut = new List<ITCDTO>();
            List<ITCDTO> iTCListBdg = new List<ITCDTO>();
            List<ITCDTO> iTCListBus = new List<ITCDTO>();
            List<ITCDTO> iTCListCeq = new List<ITCDTO>();
            List<ITCDTO> iTCListCoq = new List<ITCDTO>();
            List<ITCDTO> iTCListCsw = new List<ITCDTO>();
            List<ITCDTO> iTCListffe = new List<ITCDTO>();
            List<ITCDTO> iTCListInt = new List<ITCDTO>();
            List<ITCDTO> iTCListLdi = new List<ITCDTO>();
            List<ITCDTO> iTCListLhi = new List<ITCDTO>();
            List<ITCDTO> iTCListLnd = new List<ITCDTO>();
            List<ITCDTO> iTCListLtv = new List<ITCDTO>();
            List<ITCDTO> iTCListMfg = new List<ITCDTO>();
            List<ITCDTO> iTCListPpn = new List<ITCDTO>();
            List<ITCDTO> iTCListRpn = new List<ITCDTO>();
            List<ITCDTO> iTCListRrb = new List<ITCDTO>();
            List<ITCDTO> iTCListTlr = new List<ITCDTO>();
            List<ITCDTO> iTCListTrh = new List<ITCDTO>();
            List<ITCDTO> iTCListUnt = new List<ITCDTO>();
            List<ITCDTO> iTCListWrs = new List<ITCDTO>();
            List<ITCDTO> iTCListCst = new List<ITCDTO>();

            foreach (string[] row in excelITC)
            {
                if (string.Equals(row[7], "P"))
                {
                    ITCDTO itcDto = new ITCDTO();
                    itcDto.Code = row[0];
                    itcDto.Name = row[1];
                    itcDto.EffectiveDate = row[2];
                    if (!string.IsNullOrEmpty(row[3]))
                    {
                        itcDto.ExpiryDate = row[3]; 
                    }
                    if (!string.IsNullOrEmpty(row[4]))
                    {
                        itcDto.MaxLimitPercentage = row[4];
                    }
                    if (!string.IsNullOrEmpty(row[5]))
                    {
                        itcDto.MaxLimitDollars = row[5];
                    }
                    if (!string.IsNullOrEmpty(row[6]))
                    {
                        itcDto.BasisReduction = row[6];
                    }
                    iTCListAut.Add(itcDto);
                }

                if (string.Equals(row[8], "P"))
                {
                    ITCDTO itcDto = new ITCDTO();
                    itcDto.Code = row[0];
                    itcDto.Name = row[1];
                    itcDto.EffectiveDate = row[2];
                    if (!string.IsNullOrEmpty(row[3]))
                    {
                        itcDto.ExpiryDate = row[3];
                    }
                    if (!string.IsNullOrEmpty(row[4]))
                    {
                        itcDto.MaxLimitPercentage = row[4];
                    }
                    if (!string.IsNullOrEmpty(row[5]))
                    {
                        itcDto.MaxLimitDollars = row[5];
                    }
                    if (!string.IsNullOrEmpty(row[6]))
                    {
                        itcDto.BasisReduction = row[6];
                    }
                    iTCListBdg.Add(itcDto);
                }
                if (string.Equals(row[9], "P"))
                {
                    ITCDTO itcDto = new ITCDTO();
                    itcDto.Code = row[0];
                    itcDto.Name = row[1];
                    itcDto.EffectiveDate = row[2];
                    if (!string.IsNullOrEmpty(row[3]))
                    {
                        itcDto.ExpiryDate = row[3];
                    }
                    if (!string.IsNullOrEmpty(row[4]))
                    {
                        itcDto.MaxLimitPercentage = row[4];
                    }
                    if (!string.IsNullOrEmpty(row[5]))
                    {
                        itcDto.MaxLimitDollars = row[5];
                    }
                    if (!string.IsNullOrEmpty(row[6]))
                    {
                        itcDto.BasisReduction = row[6];
                    }
                    iTCListBus.Add(itcDto);
                }

                if (string.Equals(row[10], "P"))
                {
                    ITCDTO itcDto = new ITCDTO();
                    itcDto.Code = row[0];
                    itcDto.Name = row[1];
                    itcDto.EffectiveDate = row[2];
                    if (!string.IsNullOrEmpty(row[3]))
                    {
                        itcDto.ExpiryDate = row[3];
                    }
                    if (!string.IsNullOrEmpty(row[4]))
                    {
                        itcDto.MaxLimitPercentage = row[4];
                    }
                    if (!string.IsNullOrEmpty(row[5]))
                    {
                        itcDto.MaxLimitDollars = row[5];
                    }
                    if (!string.IsNullOrEmpty(row[6]))
                    {
                        itcDto.BasisReduction = row[6];
                    }
                    iTCListCeq.Add(itcDto);
                }

                if (string.Equals(row[11], "P"))
                {
                    ITCDTO itcDto = new ITCDTO();
                    itcDto.Code = row[0];
                    itcDto.Name = row[1];
                    itcDto.EffectiveDate = row[2];
                    if (!string.IsNullOrEmpty(row[3]))
                    {
                        itcDto.ExpiryDate = row[3];
                    }
                    if (!string.IsNullOrEmpty(row[4]))
                    {
                        itcDto.MaxLimitPercentage = row[4];
                    }
                    if (!string.IsNullOrEmpty(row[5]))
                    {
                        itcDto.MaxLimitDollars = row[5];
                    }
                    if (!string.IsNullOrEmpty(row[6]))
                    {
                        itcDto.BasisReduction = row[6];
                    }
                    iTCListCoq.Add(itcDto);
                }

                if (string.Equals(row[12], "P"))
                {
                    ITCDTO itcDto = new ITCDTO();
                    itcDto.Code = row[0];
                    itcDto.Name = row[1];
                    itcDto.EffectiveDate = row[2];
                    if (!string.IsNullOrEmpty(row[3]))
                    {
                        itcDto.ExpiryDate = row[3];
                    }
                    if (!string.IsNullOrEmpty(row[4]))
                    {
                        itcDto.MaxLimitPercentage = row[4];
                    }
                    if (!string.IsNullOrEmpty(row[5]))
                    {
                        itcDto.MaxLimitDollars = row[5];
                    }
                    if (!string.IsNullOrEmpty(row[6]))
                    {
                        itcDto.BasisReduction = row[6];
                    }
                    iTCListCsw.Add(itcDto);
                }

                if (string.Equals(row[13], "P"))
                {
                    ITCDTO itcDto = new ITCDTO();
                    itcDto.Code = row[0];
                    itcDto.Name = row[1];
                    itcDto.EffectiveDate = row[2];
                    if (!string.IsNullOrEmpty(row[3]))
                    {
                        itcDto.ExpiryDate = row[3];
                    }
                    if (!string.IsNullOrEmpty(row[4]))
                    {
                        itcDto.MaxLimitPercentage = row[4];
                    }
                    if (!string.IsNullOrEmpty(row[5]))
                    {
                        itcDto.MaxLimitDollars = row[5];
                    }
                    if (!string.IsNullOrEmpty(row[6]))
                    {
                        itcDto.BasisReduction = row[6];
                    }
                    iTCListffe.Add(itcDto);
                }

                if (string.Equals(row[14], "P"))
                {
                    ITCDTO itcDto = new ITCDTO();
                    itcDto.Code = row[0];
                    itcDto.Name = row[1];
                    itcDto.EffectiveDate = row[2];
                    if (!string.IsNullOrEmpty(row[3]))
                    {
                        itcDto.ExpiryDate = row[3];
                    }
                    if (!string.IsNullOrEmpty(row[4]))
                    {
                        itcDto.MaxLimitPercentage = row[4];
                    }
                    if (!string.IsNullOrEmpty(row[5]))
                    {
                        itcDto.MaxLimitDollars = row[5];
                    }
                    if (!string.IsNullOrEmpty(row[6]))
                    {
                        itcDto.BasisReduction = row[6];
                    }
                    iTCListInt.Add(itcDto);
                }

                if (string.Equals(row[15], "P"))
                {
                    ITCDTO itcDto = new ITCDTO();
                    itcDto.Code = row[0];
                    itcDto.Name = row[1];
                    itcDto.EffectiveDate = row[2];
                    if (!string.IsNullOrEmpty(row[3]))
                    {
                        itcDto.ExpiryDate = row[3];
                    }
                    if (!string.IsNullOrEmpty(row[4]))
                    {
                        itcDto.MaxLimitPercentage = row[4];
                    }
                    if (!string.IsNullOrEmpty(row[5]))
                    {
                        itcDto.MaxLimitDollars = row[5];
                    }
                    if (!string.IsNullOrEmpty(row[6]))
                    {
                        itcDto.BasisReduction = row[6];
                    }
                    iTCListLdi.Add(itcDto);
                }

                if (string.Equals(row[16], "P"))
                {
                    ITCDTO itcDto = new ITCDTO();
                    itcDto.Code = row[0];
                    itcDto.Name = row[1];
                    itcDto.EffectiveDate = row[2];
                    if (!string.IsNullOrEmpty(row[3]))
                    {
                        itcDto.ExpiryDate = row[3];
                    }
                    if (!string.IsNullOrEmpty(row[4]))
                    {
                        itcDto.MaxLimitPercentage = row[4];
                    }
                    if (!string.IsNullOrEmpty(row[5]))
                    {
                        itcDto.MaxLimitDollars = row[5];
                    }
                    if (!string.IsNullOrEmpty(row[6]))
                    {
                        itcDto.BasisReduction = row[6];
                    }
                    iTCListLhi.Add(itcDto);
                }

                if (string.Equals(row[17], "P"))
                {
                    ITCDTO itcDto = new ITCDTO();
                    itcDto.Code = row[0];
                    itcDto.Name = row[1];
                    itcDto.EffectiveDate = row[2];
                    if (!string.IsNullOrEmpty(row[3]))
                    {
                        itcDto.ExpiryDate = row[3];
                    }
                    if (!string.IsNullOrEmpty(row[4]))
                    {
                        itcDto.MaxLimitPercentage = row[4];
                    }
                    if (!string.IsNullOrEmpty(row[5]))
                    {
                        itcDto.MaxLimitDollars = row[5];
                    }
                    if (!string.IsNullOrEmpty(row[6]))
                    {
                        itcDto.BasisReduction = row[6];
                    }
                    iTCListLnd.Add(itcDto);
                }

                if (string.Equals(row[18], "P"))
                {
                    ITCDTO itcDto = new ITCDTO();
                    itcDto.Code = row[0];
                    itcDto.Name = row[1];
                    itcDto.EffectiveDate = row[2];
                    if (!string.IsNullOrEmpty(row[3]))
                    {
                        itcDto.ExpiryDate = row[3];
                    }
                    if (!string.IsNullOrEmpty(row[4]))
                    {
                        itcDto.MaxLimitPercentage = row[4];
                    }
                    if (!string.IsNullOrEmpty(row[5]))
                    {
                        itcDto.MaxLimitDollars = row[5];
                    }
                    if (!string.IsNullOrEmpty(row[6]))
                    {
                        itcDto.BasisReduction = row[6];
                    }
                    iTCListMfg.Add(itcDto);
                }

                if (string.Equals(row[19], "P"))
                {
                    ITCDTO itcDto = new ITCDTO();
                    itcDto.Code = row[0];
                    itcDto.Name = row[1];
                    itcDto.EffectiveDate = row[2];
                    if (!string.IsNullOrEmpty(row[3]))
                    {
                        itcDto.ExpiryDate = row[3];
                    }
                    if (!string.IsNullOrEmpty(row[4]))
                    {
                        itcDto.MaxLimitPercentage = row[4];
                    }
                    if (!string.IsNullOrEmpty(row[5]))
                    {
                        itcDto.MaxLimitDollars = row[5];
                    }
                    if (!string.IsNullOrEmpty(row[6]))
                    {
                        itcDto.BasisReduction = row[6];
                    }
                    iTCListPpn.Add(itcDto);
                }

                if (string.Equals(row[20], "P"))
                {
                    ITCDTO itcDto = new ITCDTO();
                    itcDto.Code = row[0];
                    itcDto.Name = row[1];
                    itcDto.EffectiveDate = row[2];
                    if (!string.IsNullOrEmpty(row[3]))
                    {
                        itcDto.ExpiryDate = row[3];
                    }
                    if (!string.IsNullOrEmpty(row[4]))
                    {
                        itcDto.MaxLimitPercentage = row[4];
                    }
                    if (!string.IsNullOrEmpty(row[5]))
                    {
                        itcDto.MaxLimitDollars = row[5];
                    }
                    if (!string.IsNullOrEmpty(row[6]))
                    {
                        itcDto.BasisReduction = row[6];
                    }
                    iTCListRpn.Add(itcDto);
                }

                if (string.Equals(row[21], "P"))
                {
                    ITCDTO itcDto = new ITCDTO();
                    itcDto.Code = row[0];
                    itcDto.Name = row[1];
                    itcDto.EffectiveDate = row[2];
                    if (!string.IsNullOrEmpty(row[3]))
                    {
                        itcDto.ExpiryDate = row[3];
                    }
                    if (!string.IsNullOrEmpty(row[4]))
                    {
                        itcDto.MaxLimitPercentage = row[4];
                    }
                    if (!string.IsNullOrEmpty(row[5]))
                    {
                        itcDto.MaxLimitDollars = row[5];
                    }
                    if (!string.IsNullOrEmpty(row[6]))
                    {
                        itcDto.BasisReduction = row[6];
                    }
                    iTCListRrb.Add(itcDto);
                }

                if (string.Equals(row[22], "P"))
                {
                    ITCDTO itcDto = new ITCDTO();
                    itcDto.Code = row[0];
                    itcDto.Name = row[1];
                    itcDto.EffectiveDate = row[2];
                    if (!string.IsNullOrEmpty(row[3]))
                    {
                        itcDto.ExpiryDate = row[3];
                    }
                    if (!string.IsNullOrEmpty(row[4]))
                    {
                        itcDto.MaxLimitPercentage = row[4];
                    }
                    if (!string.IsNullOrEmpty(row[5]))
                    {
                        itcDto.MaxLimitDollars = row[5];
                    }
                    if (!string.IsNullOrEmpty(row[6]))
                    {
                        itcDto.BasisReduction = row[6];
                    }
                    iTCListTlr.Add(itcDto);
                }

                if (string.Equals(row[23], "P"))
                {
                    ITCDTO itcDto = new ITCDTO();
                    itcDto.Code = row[0];
                    itcDto.Name = row[1];
                    itcDto.EffectiveDate = row[2];
                    if (!string.IsNullOrEmpty(row[3]))
                    {
                        itcDto.ExpiryDate = row[3];
                    }
                    if (!string.IsNullOrEmpty(row[4]))
                    {
                        itcDto.MaxLimitPercentage = row[4];
                    }
                    if (!string.IsNullOrEmpty(row[5]))
                    {
                        itcDto.MaxLimitDollars = row[5];
                    }
                    if (!string.IsNullOrEmpty(row[6]))
                    {
                        itcDto.BasisReduction = row[6];
                    }
                    iTCListTrh.Add(itcDto);
                }

                if (string.Equals(row[24], "P"))
                {
                    ITCDTO itcDto = new ITCDTO();
                    itcDto.Code = row[0];
                    itcDto.Name = row[1];
                    itcDto.EffectiveDate = row[2];
                    if (!string.IsNullOrEmpty(row[3]))
                    {
                        itcDto.ExpiryDate = row[3];
                    }
                    if (!string.IsNullOrEmpty(row[4]))
                    {
                        itcDto.MaxLimitPercentage = row[4];
                    }
                    if (!string.IsNullOrEmpty(row[5]))
                    {
                        itcDto.MaxLimitDollars = row[5];
                    }
                    if (!string.IsNullOrEmpty(row[6]))
                    {
                        itcDto.BasisReduction = row[6];
                    }
                    iTCListLtv.Add(itcDto);
                }

                if (string.Equals(row[25], "P"))
                {
                    ITCDTO itcDto = new ITCDTO();
                    itcDto.Code = row[0];
                    itcDto.Name = row[1];
                    itcDto.EffectiveDate = row[2];
                    if (!string.IsNullOrEmpty(row[3]))
                    {
                        itcDto.ExpiryDate = row[3];
                    }
                    if (!string.IsNullOrEmpty(row[4]))
                    {
                        itcDto.MaxLimitPercentage = row[4];
                    }
                    if (!string.IsNullOrEmpty(row[5]))
                    {
                        itcDto.MaxLimitDollars = row[5];
                    }
                    if (!string.IsNullOrEmpty(row[6]))
                    {
                        itcDto.BasisReduction = row[6];
                    }
                    iTCListUnt.Add(itcDto);
                }

                if (string.Equals(row[26], "P"))
                {
                    ITCDTO itcDto = new ITCDTO();
                    itcDto.Code = row[0];
                    itcDto.Name = row[1];
                    itcDto.EffectiveDate = row[2];
                    if (!string.IsNullOrEmpty(row[3]))
                    {
                        itcDto.ExpiryDate = row[3];
                    }
                    if (!string.IsNullOrEmpty(row[4]))
                    {
                        itcDto.MaxLimitPercentage = row[4];
                    }
                    if (!string.IsNullOrEmpty(row[5]))
                    {
                        itcDto.MaxLimitDollars = row[5];
                    }
                    if (!string.IsNullOrEmpty(row[6]))
                    {
                        itcDto.BasisReduction = row[6];
                    }
                    iTCListWrs.Add(itcDto);
                }

                if (string.Equals(row[27], "P"))
                {
                    ITCDTO itcDto = new ITCDTO();
                    itcDto.Code = row[0];
                    itcDto.Name = row[1];
                    itcDto.EffectiveDate = row[2];
                    if (!string.IsNullOrEmpty(row[3]))
                    {
                        itcDto.ExpiryDate = row[3];
                    }
                    if (!string.IsNullOrEmpty(row[4]))
                    {
                        itcDto.MaxLimitPercentage = row[4];
                    }
                    if (!string.IsNullOrEmpty(row[5]))
                    {
                        itcDto.MaxLimitDollars = row[5];
                    }
                    if (!string.IsNullOrEmpty(row[6]))
                    {
                        itcDto.BasisReduction = row[6];
                    }
                    iTCListCst.Add(itcDto);
                }
            }
            allPropertyITC.Add("AUT", iTCListAut);
            allPropertyITC.Add("BDG", iTCListBdg);
            allPropertyITC.Add("BUS", iTCListBus);
            allPropertyITC.Add("CEQ", iTCListCeq);
            allPropertyITC.Add("COQ", iTCListCoq);
            allPropertyITC.Add("CSW", iTCListCsw);
            allPropertyITC.Add("FFE", iTCListffe);
            allPropertyITC.Add("INT", iTCListInt);
            allPropertyITC.Add("LDI", iTCListLdi);
            allPropertyITC.Add("LHI", iTCListLhi);
            allPropertyITC.Add("LND", iTCListLnd);
            allPropertyITC.Add("LTV", iTCListLtv);
            allPropertyITC.Add("MFG", iTCListMfg);
            allPropertyITC.Add("PPN", iTCListPpn);
            allPropertyITC.Add("RPN", iTCListRpn);
            allPropertyITC.Add("RRB", iTCListRrb);
            allPropertyITC.Add("TLR", iTCListTlr);
            allPropertyITC.Add("TRH", iTCListTrh);
            allPropertyITC.Add("UNT", iTCListUnt);
            allPropertyITC.Add("WRS", iTCListWrs);
            allPropertyITC.Add("CST", iTCListCst);
            return allPropertyITC;
        }

        public void PushToDatabase(Dictionary<string, List<ITCDTO>> allPropertyITC)
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

            Guid ITCRulePropertyId = databaseOperations.GetRulePropertyIdfromPropertyCode("ITC");

            Console.WriteLine("****************************ITC***************************************");
            if (allPropertyITC.ContainsKey("AUT"))
            {
                List<ITCDTO> macrsList = allPropertyITC["AUT"];
                foreach (ITCDTO ITCDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(autId);
                    Guid ITCHeader = databaseOperations.AddRuleHeader(autId, ITCRulePropertyId, ITCDTO.EffectiveDate, ITCDTO.ExpiryDate, def.ToString(), 1);
                    Guid ITCId = databaseOperations.GetITCBasedOnCode(ITCDTO.Code);
                    databaseOperations.AddRuleDetail(null, ITCHeader.ToString(), ITCRulePropertyId.ToString(), ITCId.ToString(), ITCDTO.MaxLimitPercentage, 1, 0, 0);
                }
                Console.WriteLine("Automobile");
                Console.WriteLine("\n\n");
            }
            if (allPropertyITC.ContainsKey("BDG"))
            {
                List<ITCDTO> macrsList = allPropertyITC["BDG"];
                foreach (ITCDTO ITCDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(bdgId);
                    Guid ITCHeader = databaseOperations.AddRuleHeader(bdgId, ITCRulePropertyId, ITCDTO.EffectiveDate, ITCDTO.ExpiryDate, def.ToString(), 1);
                    Guid ITCId = databaseOperations.GetITCBasedOnCode(ITCDTO.Code);
                    databaseOperations.AddRuleDetail(null, ITCHeader.ToString(), ITCRulePropertyId.ToString(), ITCId.ToString(), ITCDTO.MaxLimitPercentage, 1, 0, 0);
                }
                Console.WriteLine("Building");
                Console.WriteLine("\n\n");
            }
            if (allPropertyITC.ContainsKey("BUS"))
            {
                List<ITCDTO> macrsList = allPropertyITC["BUS"];
                foreach (ITCDTO ITCDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(busId);
                    Guid ITCHeader = databaseOperations.AddRuleHeader(busId, ITCRulePropertyId, ITCDTO.EffectiveDate, ITCDTO.ExpiryDate, def.ToString(), 1);
                    Guid ITCId = databaseOperations.GetITCBasedOnCode(ITCDTO.Code);
                    databaseOperations.AddRuleDetail(null, ITCHeader.ToString(), ITCRulePropertyId.ToString(), ITCId.ToString(), ITCDTO.MaxLimitPercentage, 1, 0, 0);
                }
                Console.WriteLine("Bus");
                Console.WriteLine("\n\n");
            }
            if (allPropertyITC.ContainsKey("CEQ"))
            {
                List<ITCDTO> macrsList = allPropertyITC["CEQ"];
                foreach (ITCDTO ITCDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(ceqId);
                    Guid ITCHeader = databaseOperations.AddRuleHeader(ceqId, ITCRulePropertyId, ITCDTO.EffectiveDate, ITCDTO.ExpiryDate, def.ToString(), 1);
                    Guid ITCId = databaseOperations.GetITCBasedOnCode(ITCDTO.Code);
                    databaseOperations.AddRuleDetail(null, ITCHeader.ToString(), ITCRulePropertyId.ToString(), ITCId.ToString(), ITCDTO.MaxLimitPercentage, 1, 0, 0);
                }
                Console.WriteLine("Ceq");
                Console.WriteLine("\n\n");
            }
            if (allPropertyITC.ContainsKey("COQ"))
            {
                List<ITCDTO> macrsList = allPropertyITC["COQ"];
                foreach (ITCDTO ITCDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(coqId);
                    Guid ITCHeader = databaseOperations.AddRuleHeader(coqId, ITCRulePropertyId, ITCDTO.EffectiveDate, ITCDTO.ExpiryDate, def.ToString(), 1);
                    Guid ITCId = databaseOperations.GetITCBasedOnCode(ITCDTO.Code);
                    databaseOperations.AddRuleDetail(null, ITCHeader.ToString(), ITCRulePropertyId.ToString(), ITCId.ToString(), ITCDTO.MaxLimitPercentage, 1, 0, 0);
                }
                Console.WriteLine("Coq");
                Console.WriteLine("\n\n");
            }
            if (allPropertyITC.ContainsKey("CSW"))
            {
                List<ITCDTO> macrsList = allPropertyITC["CSW"];
                foreach (ITCDTO ITCDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(cswId);
                    Guid ITCHeader = databaseOperations.AddRuleHeader(cswId, ITCRulePropertyId, ITCDTO.EffectiveDate, ITCDTO.ExpiryDate, def.ToString(), 1);
                    Guid ITCId = databaseOperations.GetITCBasedOnCode(ITCDTO.Code);
                    databaseOperations.AddRuleDetail(null, ITCHeader.ToString(), ITCRulePropertyId.ToString(), ITCId.ToString(), ITCDTO.MaxLimitPercentage, 1, 0, 0);
                }
                Console.WriteLine("Csw");
                Console.WriteLine("\n\n");
            }
            if (allPropertyITC.ContainsKey("FFE"))
            {
                List<ITCDTO> macrsList = allPropertyITC["FFE"];
                foreach (ITCDTO ITCDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(ffeId);
                    Guid ITCHeader = databaseOperations.AddRuleHeader(ffeId, ITCRulePropertyId, ITCDTO.EffectiveDate, ITCDTO.ExpiryDate, def.ToString(), 1);
                    Guid ITCId = databaseOperations.GetITCBasedOnCode(ITCDTO.Code);
                    databaseOperations.AddRuleDetail(null, ITCHeader.ToString(), ITCRulePropertyId.ToString(), ITCId.ToString(), ITCDTO.MaxLimitPercentage, 1, 0, 0);
                }
                Console.WriteLine("Ffe");
                Console.WriteLine("\n\n");
            }
            if (allPropertyITC.ContainsKey("INT"))
            {
                List<ITCDTO> macrsList = allPropertyITC["INT"];
                foreach (ITCDTO ITCDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(intId);
                    Guid ITCHeader = databaseOperations.AddRuleHeader(intId, ITCRulePropertyId, ITCDTO.EffectiveDate, ITCDTO.ExpiryDate, def.ToString(), 1);
                    Guid ITCId = databaseOperations.GetITCBasedOnCode(ITCDTO.Code);
                    databaseOperations.AddRuleDetail(null, ITCHeader.ToString(), ITCRulePropertyId.ToString(), ITCId.ToString(), ITCDTO.MaxLimitPercentage, 1, 0, 0);
                }
                Console.WriteLine("Int");
                Console.WriteLine("\n\n");
            }
            if (allPropertyITC.ContainsKey("LDI"))
            {
                List<ITCDTO> macrsList = allPropertyITC["LDI"];
                foreach (ITCDTO ITCDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(ldiId);
                    Guid ITCHeader = databaseOperations.AddRuleHeader(ldiId, ITCRulePropertyId, ITCDTO.EffectiveDate, ITCDTO.ExpiryDate, def.ToString(), 1);
                    Guid ITCId = databaseOperations.GetITCBasedOnCode(ITCDTO.Code);
                    databaseOperations.AddRuleDetail(null, ITCHeader.ToString(), ITCRulePropertyId.ToString(), ITCId.ToString(), ITCDTO.MaxLimitPercentage, 1, 0, 0);
                }
                Console.WriteLine("Ldi");
                Console.WriteLine("\n\n");
            }
            if (allPropertyITC.ContainsKey("LHI"))
            {
                List<ITCDTO> macrsList = allPropertyITC["LHI"];
                foreach (ITCDTO ITCDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(lhiId);
                    Guid ITCHeader = databaseOperations.AddRuleHeader(lhiId, ITCRulePropertyId, ITCDTO.EffectiveDate, ITCDTO.ExpiryDate, def.ToString(), 1);
                    Guid ITCId = databaseOperations.GetITCBasedOnCode(ITCDTO.Code);
                    databaseOperations.AddRuleDetail(null, ITCHeader.ToString(), ITCRulePropertyId.ToString(), ITCId.ToString(), ITCDTO.MaxLimitPercentage, 1, 0, 0);
                }
                Console.WriteLine("Lhi");
                Console.WriteLine("\n\n");
            }
            if (allPropertyITC.ContainsKey("LND"))
            {
                List<ITCDTO> macrsList = allPropertyITC["LND"];
                foreach (ITCDTO ITCDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(lndId);
                    Guid ITCHeader = databaseOperations.AddRuleHeader(lndId, ITCRulePropertyId, ITCDTO.EffectiveDate, ITCDTO.ExpiryDate, def.ToString(), 1);
                    Guid ITCId = databaseOperations.GetITCBasedOnCode(ITCDTO.Code);
                    databaseOperations.AddRuleDetail(null, ITCHeader.ToString(), ITCRulePropertyId.ToString(), ITCId.ToString(), ITCDTO.MaxLimitPercentage, 1, 0, 0);
                }
                Console.WriteLine("Lnd");
                Console.WriteLine("\n\n");
            }
            if (allPropertyITC.ContainsKey("LTV"))
            {
                List<ITCDTO> macrsList = allPropertyITC["LTV"];
                foreach (ITCDTO ITCDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(ltvId);
                    Guid ITCHeader = databaseOperations.AddRuleHeader(ltvId, ITCRulePropertyId, ITCDTO.EffectiveDate, ITCDTO.ExpiryDate, def.ToString(), 1);
                    Guid ITCId = databaseOperations.GetITCBasedOnCode(ITCDTO.Code);
                    databaseOperations.AddRuleDetail(null, ITCHeader.ToString(), ITCRulePropertyId.ToString(), ITCId.ToString(), ITCDTO.MaxLimitPercentage, 1, 0, 0);
                }
                Console.WriteLine("Ltv");
                Console.WriteLine("\n\n");
            }
            if (allPropertyITC.ContainsKey("MFG"))
            {
                List<ITCDTO> macrsList = allPropertyITC["MFG"];
                foreach (ITCDTO ITCDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(mfgId);
                    Guid ITCHeader = databaseOperations.AddRuleHeader(mfgId, ITCRulePropertyId, ITCDTO.EffectiveDate, ITCDTO.ExpiryDate, def.ToString(), 1);
                    Guid ITCId = databaseOperations.GetITCBasedOnCode(ITCDTO.Code);
                    databaseOperations.AddRuleDetail(null, ITCHeader.ToString(), ITCRulePropertyId.ToString(), ITCId.ToString(), ITCDTO.MaxLimitPercentage, 1, 0, 0);
                }
                Console.WriteLine("Mfg");
                Console.WriteLine("\n\n");
            }
            if (allPropertyITC.ContainsKey("PPN"))
            {
                List<ITCDTO> macrsList = allPropertyITC["PPN"];
                foreach (ITCDTO ITCDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(ppnId);
                    Guid ITCHeader = databaseOperations.AddRuleHeader(ppnId, ITCRulePropertyId, ITCDTO.EffectiveDate, ITCDTO.ExpiryDate, def.ToString(), 1);
                    Guid ITCId = databaseOperations.GetITCBasedOnCode(ITCDTO.Code);
                    databaseOperations.AddRuleDetail(null, ITCHeader.ToString(), ITCRulePropertyId.ToString(), ITCId.ToString(), ITCDTO.MaxLimitPercentage, 1, 0, 0);
                }
                Console.WriteLine("Ppn");
            }
            if (allPropertyITC.ContainsKey("RPN"))
            {
                List<ITCDTO> macrsList = allPropertyITC["RPN"];
                foreach (ITCDTO ITCDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(rpnId);
                    Guid ITCHeader = databaseOperations.AddRuleHeader(rpnId, ITCRulePropertyId, ITCDTO.EffectiveDate, ITCDTO.ExpiryDate, def.ToString(), 1);
                    Guid ITCId = databaseOperations.GetITCBasedOnCode(ITCDTO.Code);
                    databaseOperations.AddRuleDetail(null, ITCHeader.ToString(), ITCRulePropertyId.ToString(), ITCId.ToString(), ITCDTO.MaxLimitPercentage, 1, 0,0);
                }
                Console.WriteLine("Rpn");
                Console.WriteLine("\n\n");
            }
            if (allPropertyITC.ContainsKey("RRB"))
            {
                List<ITCDTO> macrsList = allPropertyITC["RRB"];
                foreach (ITCDTO ITCDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(rrbId);
                    Guid ITCHeader = databaseOperations.AddRuleHeader(rrbId, ITCRulePropertyId, ITCDTO.EffectiveDate, ITCDTO.ExpiryDate, def.ToString(), 1);
                    Guid ITCId = databaseOperations.GetITCBasedOnCode(ITCDTO.Code);
                    databaseOperations.AddRuleDetail(null, ITCHeader.ToString(), ITCRulePropertyId.ToString(), ITCId.ToString(), ITCDTO.MaxLimitPercentage, 1, 0, 0);
                }
                Console.WriteLine("Rrb");
                Console.WriteLine("\n\n");
            }
            if (allPropertyITC.ContainsKey("TLR"))
            {
                List<ITCDTO> macrsList = allPropertyITC["TLR"];
                foreach (ITCDTO ITCDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(tlrId);
                    Guid ITCHeader = databaseOperations.AddRuleHeader(tlrId, ITCRulePropertyId, ITCDTO.EffectiveDate, ITCDTO.ExpiryDate, def.ToString(), 1);
                    Guid ITCId = databaseOperations.GetITCBasedOnCode(ITCDTO.Code);
                    databaseOperations.AddRuleDetail(null, ITCHeader.ToString(), ITCRulePropertyId.ToString(), ITCId.ToString(), ITCDTO.MaxLimitPercentage, 1, 0, 0);
                }
                Console.WriteLine("Tlr");
                Console.WriteLine("\n\n");
            }
            if (allPropertyITC.ContainsKey("TRH"))
            {
                List<ITCDTO> macrsList = allPropertyITC["TRH"];
                foreach (ITCDTO ITCDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(trhId);
                    Guid ITCHeader = databaseOperations.AddRuleHeader(trhId, ITCRulePropertyId, ITCDTO.EffectiveDate, ITCDTO.ExpiryDate, def.ToString(), 1);
                    Guid ITCId = databaseOperations.GetITCBasedOnCode(ITCDTO.Code);
                    databaseOperations.AddRuleDetail(null, ITCHeader.ToString(), ITCRulePropertyId.ToString(), ITCId.ToString(), ITCDTO.MaxLimitPercentage, 1, 0, 0);
                }
                Console.WriteLine("Trh");
                Console.WriteLine("\n\n");
            }
            if (allPropertyITC.ContainsKey("UNT"))
            {
                List<ITCDTO> macrsList = allPropertyITC["UNT"];
                foreach (ITCDTO ITCDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(untId);
                    Guid ITCHeader = databaseOperations.AddRuleHeader(untId, ITCRulePropertyId, ITCDTO.EffectiveDate, ITCDTO.ExpiryDate, def.ToString(), 1);
                    Guid ITCId = databaseOperations.GetITCBasedOnCode(ITCDTO.Code);
                    databaseOperations.AddRuleDetail(null, ITCHeader.ToString(), ITCRulePropertyId.ToString(), ITCId.ToString(), ITCDTO.MaxLimitPercentage, 1, 0, 0);
                }
                Console.WriteLine("Unt");
                Console.WriteLine("\n\n");
            }
            if (allPropertyITC.ContainsKey("WRS"))
            {
                List<ITCDTO> macrsList = allPropertyITC["WRS"];
                foreach (ITCDTO ITCDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(wrsId);
                    Guid ITCHeader = databaseOperations.AddRuleHeader(wrsId, ITCRulePropertyId, ITCDTO.EffectiveDate, ITCDTO.ExpiryDate, def.ToString(), 1);
                    Guid ITCId = databaseOperations.GetITCBasedOnCode(ITCDTO.Code);
                    databaseOperations.AddRuleDetail(null, ITCHeader.ToString(), ITCRulePropertyId.ToString(), ITCId.ToString(), ITCDTO.MaxLimitPercentage, 1, 0, 0);
                }
                Console.WriteLine("Wrs");
                Console.WriteLine("\n\n");
            }
            if (allPropertyITC.ContainsKey("CST"))
            {
                List<ITCDTO> macrsList = allPropertyITC["CST"];
                foreach (ITCDTO ITCDTO in macrsList)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(cstId);
                    Guid ITCHeader = databaseOperations.AddRuleHeader(cstId, ITCRulePropertyId, ITCDTO.EffectiveDate, ITCDTO.ExpiryDate, def.ToString(), 1);
                    Guid ITCId = databaseOperations.GetITCBasedOnCode(ITCDTO.Code);
                    databaseOperations.AddRuleDetail(null, ITCHeader.ToString(), ITCRulePropertyId.ToString(), ITCId.ToString(), ITCDTO.MaxLimitPercentage, 1, 0, 0);
                }
                Console.WriteLine("Cst");
                Console.WriteLine("\n\n");
            }
        }
    }
}
