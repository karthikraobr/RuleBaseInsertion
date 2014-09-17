using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleBaseInsertion
{
    public class S179Classification
    {
        Dictionary<string, List<S179ClassificationDTO>> allPropertyS179Classification = new Dictionary<string, List<S179ClassificationDTO>>();
        List<S179ClassificationDTO> S179ClassificationListAut = new List<S179ClassificationDTO>();
        List<S179ClassificationDTO> S179ClassificationListBdg = new List<S179ClassificationDTO>();
        List<S179ClassificationDTO> S179ClassificationListBus = new List<S179ClassificationDTO>();
        List<S179ClassificationDTO> S179ClassificationListCeq = new List<S179ClassificationDTO>();
        List<S179ClassificationDTO> S179ClassificationListCoq = new List<S179ClassificationDTO>();
        List<S179ClassificationDTO> S179ClassificationListCsw = new List<S179ClassificationDTO>();
        List<S179ClassificationDTO> S179ClassificationListffe = new List<S179ClassificationDTO>();
        List<S179ClassificationDTO> S179ClassificationListInt = new List<S179ClassificationDTO>();
        List<S179ClassificationDTO> S179ClassificationListLdi = new List<S179ClassificationDTO>();
        List<S179ClassificationDTO> S179ClassificationListLhi = new List<S179ClassificationDTO>();
        List<S179ClassificationDTO> S179ClassificationListLnd = new List<S179ClassificationDTO>();
        List<S179ClassificationDTO> S179ClassificationListLtv = new List<S179ClassificationDTO>();
        List<S179ClassificationDTO> S179ClassificationListMfg = new List<S179ClassificationDTO>();
        List<S179ClassificationDTO> S179ClassificationListPpn = new List<S179ClassificationDTO>();
        List<S179ClassificationDTO> S179ClassificationListRpn = new List<S179ClassificationDTO>();
        List<S179ClassificationDTO> S179ClassificationListRrb = new List<S179ClassificationDTO>();
        List<S179ClassificationDTO> S179ClassificationListTlr = new List<S179ClassificationDTO>();
        List<S179ClassificationDTO> S179ClassificationListTrh = new List<S179ClassificationDTO>();
        List<S179ClassificationDTO> S179ClassificationListUnt = new List<S179ClassificationDTO>();
        List<S179ClassificationDTO> S179ClassificationListWrs = new List<S179ClassificationDTO>();
        List<S179ClassificationDTO> S179ClassificationListCst = new List<S179ClassificationDTO>();
        List<S179ClassificationDTO> S179ClassificationListSuv = new List<S179ClassificationDTO>();
        DatabaseOperations databaseOperations = new DatabaseOperations();

        public Dictionary<string, List<S179ClassificationDTO>> MainLogic(List<string[]> entireExcel)
        {
            S179ClassificationDTO s179ClassificationDTO;
            foreach (string[] row in entireExcel)
            {
                if (string.Equals(row[2], "P"))
                {
                    s179ClassificationDTO=new S179ClassificationDTO();
                    s179ClassificationDTO.EffectiveDate = row[0];
                    s179ClassificationDTO.ExpirationDate = row[1];
                    s179ClassificationDTO.ClassificationID = databaseOperations.GetS179ClassificationBasedOnCode(row[26]).ToString();
                    s179ClassificationDTO.Classification = row[26];
                    S179ClassificationListAut.Add(s179ClassificationDTO);
                }
                if (string.Equals(row[3], "P"))
                {
                    s179ClassificationDTO = new S179ClassificationDTO();
                    s179ClassificationDTO.EffectiveDate = row[0];
                    s179ClassificationDTO.ExpirationDate = row[1];
                    s179ClassificationDTO.ClassificationID = databaseOperations.GetS179ClassificationBasedOnCode(row[26]).ToString();
                    s179ClassificationDTO.Classification = row[26];
                    S179ClassificationListBdg.Add(s179ClassificationDTO);
                }
                if (string.Equals(row[4], "P"))
                {
                    s179ClassificationDTO = new S179ClassificationDTO();
                    s179ClassificationDTO.EffectiveDate = row[0];
                    s179ClassificationDTO.ExpirationDate = row[1];
                    s179ClassificationDTO.ClassificationID = databaseOperations.GetS179ClassificationBasedOnCode(row[26]).ToString();
                    s179ClassificationDTO.Classification = row[26];
                    S179ClassificationListBus.Add(s179ClassificationDTO);
                }
                if (string.Equals(row[5], "P"))
                {
                    s179ClassificationDTO = new S179ClassificationDTO();
                    s179ClassificationDTO.EffectiveDate = row[0];
                    s179ClassificationDTO.ExpirationDate = row[1];
                    s179ClassificationDTO.ClassificationID = databaseOperations.GetS179ClassificationBasedOnCode(row[26]).ToString();
                    s179ClassificationDTO.Classification = row[26];
                    S179ClassificationListCeq.Add(s179ClassificationDTO);
                }
                if (string.Equals(row[6], "P"))
                {
                    s179ClassificationDTO = new S179ClassificationDTO();
                    s179ClassificationDTO.EffectiveDate = row[0];
                    s179ClassificationDTO.ExpirationDate = row[1];
                    s179ClassificationDTO.ClassificationID = databaseOperations.GetS179ClassificationBasedOnCode(row[26]).ToString();
                    s179ClassificationDTO.Classification = row[26];
                    S179ClassificationListCoq.Add(s179ClassificationDTO);
                }
                if (string.Equals(row[7], "P"))
                {
                    s179ClassificationDTO = new S179ClassificationDTO();
                    s179ClassificationDTO.EffectiveDate = row[0];
                    s179ClassificationDTO.ExpirationDate = row[1];
                    s179ClassificationDTO.ClassificationID = databaseOperations.GetS179ClassificationBasedOnCode(row[26]).ToString();
                    s179ClassificationDTO.Classification = row[26];
                    S179ClassificationListCsw.Add(s179ClassificationDTO);
                }
                if (string.Equals(row[8], "P"))
                {
                    s179ClassificationDTO = new S179ClassificationDTO();
                    s179ClassificationDTO.EffectiveDate = row[0];
                    s179ClassificationDTO.ExpirationDate = row[1];
                    s179ClassificationDTO.ClassificationID = databaseOperations.GetS179ClassificationBasedOnCode(row[26]).ToString();
                    s179ClassificationDTO.Classification = row[26];
                    S179ClassificationListffe.Add(s179ClassificationDTO);
                }
                if (string.Equals(row[9], "P"))
                {
                    s179ClassificationDTO = new S179ClassificationDTO();
                    s179ClassificationDTO.EffectiveDate = row[0];
                    s179ClassificationDTO.ExpirationDate = row[1];
                    s179ClassificationDTO.ClassificationID = databaseOperations.GetS179ClassificationBasedOnCode(row[26]).ToString();
                    s179ClassificationDTO.Classification = row[26];
                    S179ClassificationListInt.Add(s179ClassificationDTO);
                }
                if (string.Equals(row[10], "P"))
                {
                    s179ClassificationDTO = new S179ClassificationDTO();
                    s179ClassificationDTO.EffectiveDate = row[0];
                    s179ClassificationDTO.ExpirationDate = row[1];
                    s179ClassificationDTO.ClassificationID = databaseOperations.GetS179ClassificationBasedOnCode(row[26]).ToString();
                    s179ClassificationDTO.Classification = row[26];
                    S179ClassificationListLdi.Add(s179ClassificationDTO);
                }
                if (string.Equals(row[11], "P"))
                {
                    s179ClassificationDTO = new S179ClassificationDTO();
                    s179ClassificationDTO.EffectiveDate = row[0];
                    s179ClassificationDTO.ExpirationDate = row[1];
                    s179ClassificationDTO.ClassificationID = databaseOperations.GetS179ClassificationBasedOnCode(row[26]).ToString();
                    s179ClassificationDTO.Classification = row[26];
                    S179ClassificationListLhi.Add(s179ClassificationDTO);
                }
                if (string.Equals(row[12], "P"))
                {
                    s179ClassificationDTO = new S179ClassificationDTO();
                    s179ClassificationDTO.EffectiveDate = row[0];
                    s179ClassificationDTO.ExpirationDate = row[1];
                    s179ClassificationDTO.ClassificationID = databaseOperations.GetS179ClassificationBasedOnCode(row[26]).ToString();
                    s179ClassificationDTO.Classification = row[26];
                    S179ClassificationListLnd.Add(s179ClassificationDTO);
                }
                if (string.Equals(row[13], "P"))
                {
                    s179ClassificationDTO = new S179ClassificationDTO();
                    s179ClassificationDTO.EffectiveDate = row[0];
                    s179ClassificationDTO.ExpirationDate = row[1];
                    s179ClassificationDTO.ClassificationID = databaseOperations.GetS179ClassificationBasedOnCode(row[26]).ToString();
                    s179ClassificationDTO.Classification = row[26];
                    S179ClassificationListLtv.Add(s179ClassificationDTO);
                }
                if (string.Equals(row[14], "P"))
                {
                    s179ClassificationDTO = new S179ClassificationDTO();
                    s179ClassificationDTO.EffectiveDate = row[0];
                    s179ClassificationDTO.ExpirationDate = row[1];
                    s179ClassificationDTO.ClassificationID = databaseOperations.GetS179ClassificationBasedOnCode(row[26]).ToString();
                    s179ClassificationDTO.Classification = row[26];
                    S179ClassificationListMfg.Add(s179ClassificationDTO);
                }
                if (string.Equals(row[15], "P"))
                {
                    s179ClassificationDTO = new S179ClassificationDTO();
                    s179ClassificationDTO.EffectiveDate = row[0];
                    s179ClassificationDTO.ExpirationDate = row[1];
                    s179ClassificationDTO.ClassificationID = databaseOperations.GetS179ClassificationBasedOnCode(row[26]).ToString();
                    s179ClassificationDTO.Classification = row[26];
                    S179ClassificationListPpn.Add(s179ClassificationDTO);
                }
                if (string.Equals(row[16], "P"))
                {
                    s179ClassificationDTO = new S179ClassificationDTO();
                    s179ClassificationDTO.EffectiveDate = row[0];
                    s179ClassificationDTO.ExpirationDate = row[1];
                    s179ClassificationDTO.ClassificationID = databaseOperations.GetS179ClassificationBasedOnCode(row[26]).ToString();
                    s179ClassificationDTO.Classification = row[26];
                    S179ClassificationListRpn.Add(s179ClassificationDTO);
                }
                if (string.Equals(row[17], "P"))
                {
                    s179ClassificationDTO = new S179ClassificationDTO();
                    s179ClassificationDTO.EffectiveDate = row[0];
                    s179ClassificationDTO.ExpirationDate = row[1];
                    s179ClassificationDTO.ClassificationID = databaseOperations.GetS179ClassificationBasedOnCode(row[26]).ToString();
                    s179ClassificationDTO.Classification = row[26];
                    S179ClassificationListRrb.Add(s179ClassificationDTO);
                }
                if (string.Equals(row[18], "P"))
                {
                    s179ClassificationDTO = new S179ClassificationDTO();
                    s179ClassificationDTO.EffectiveDate = row[0];
                    s179ClassificationDTO.ExpirationDate = row[1];
                    s179ClassificationDTO.ClassificationID = databaseOperations.GetS179ClassificationBasedOnCode(row[26]).ToString();
                    s179ClassificationDTO.Classification = row[26];
                    S179ClassificationListSuv.Add(s179ClassificationDTO);
                }
                if (string.Equals(row[19], "P"))
                {
                    s179ClassificationDTO = new S179ClassificationDTO();
                    s179ClassificationDTO.EffectiveDate = row[0];
                    s179ClassificationDTO.ExpirationDate = row[1];
                    s179ClassificationDTO.ClassificationID = databaseOperations.GetS179ClassificationBasedOnCode(row[26]).ToString();
                    s179ClassificationDTO.Classification = row[26];
                    S179ClassificationListTlr.Add(s179ClassificationDTO);
                }
                if (string.Equals(row[20], "P"))
                {
                    s179ClassificationDTO = new S179ClassificationDTO();
                    s179ClassificationDTO.EffectiveDate = row[0];
                    s179ClassificationDTO.ExpirationDate = row[1];
                    s179ClassificationDTO.ClassificationID = databaseOperations.GetS179ClassificationBasedOnCode(row[26]).ToString();
                    s179ClassificationDTO.Classification = row[26];
                    S179ClassificationListTrh.Add(s179ClassificationDTO);
                }
                if (string.Equals(row[21], "P"))
                {
                    s179ClassificationDTO = new S179ClassificationDTO();
                    s179ClassificationDTO.EffectiveDate = row[0];
                    s179ClassificationDTO.ExpirationDate = row[1];
                    s179ClassificationDTO.ClassificationID = databaseOperations.GetS179ClassificationBasedOnCode(row[26]).ToString();
                    s179ClassificationDTO.Classification = row[26];
                    S179ClassificationListUnt.Add(s179ClassificationDTO);
                }
                if (string.Equals(row[22], "P"))
                {
                    s179ClassificationDTO = new S179ClassificationDTO();
                    s179ClassificationDTO.EffectiveDate = row[0];
                    s179ClassificationDTO.ExpirationDate = row[1];
                    s179ClassificationDTO.ClassificationID = databaseOperations.GetS179ClassificationBasedOnCode(row[26]).ToString();
                    s179ClassificationDTO.Classification = row[26];
                    S179ClassificationListWrs.Add(s179ClassificationDTO);
                }
                if (string.Equals(row[23], "P"))
                {
                    s179ClassificationDTO = new S179ClassificationDTO();
                    s179ClassificationDTO.EffectiveDate = row[0];
                    s179ClassificationDTO.ExpirationDate = row[1];
                    s179ClassificationDTO.ClassificationID = databaseOperations.GetS179ClassificationBasedOnCode(row[26]).ToString();
                    s179ClassificationDTO.Classification = row[26];
                    S179ClassificationListCst.Add(s179ClassificationDTO);
                }
            }
            allPropertyS179Classification.Add("AUT", S179ClassificationListAut);
            allPropertyS179Classification.Add("BDG", S179ClassificationListBdg);
            allPropertyS179Classification.Add("BUS", S179ClassificationListBus);
            allPropertyS179Classification.Add("CEQ", S179ClassificationListCeq);
            allPropertyS179Classification.Add("COQ", S179ClassificationListCoq);
            allPropertyS179Classification.Add("CSW", S179ClassificationListCsw);
            allPropertyS179Classification.Add("FFE", S179ClassificationListffe);
            allPropertyS179Classification.Add("INT", S179ClassificationListInt);
            allPropertyS179Classification.Add("LDI", S179ClassificationListLdi);
            allPropertyS179Classification.Add("LHI", S179ClassificationListLhi);
            allPropertyS179Classification.Add("LND", S179ClassificationListLnd);
            allPropertyS179Classification.Add("LTV", S179ClassificationListLtv);
            allPropertyS179Classification.Add("MFG", S179ClassificationListMfg);
            allPropertyS179Classification.Add("PPN", S179ClassificationListPpn);
            allPropertyS179Classification.Add("RPN", S179ClassificationListRpn);
            allPropertyS179Classification.Add("RRB", S179ClassificationListRrb);
            allPropertyS179Classification.Add("TLR", S179ClassificationListTlr);
            allPropertyS179Classification.Add("TRH", S179ClassificationListTrh);
            allPropertyS179Classification.Add("UNT", S179ClassificationListUnt);
            allPropertyS179Classification.Add("WRS", S179ClassificationListWrs);
            allPropertyS179Classification.Add("CST", S179ClassificationListCst);
            allPropertyS179Classification.Add("SUV", S179ClassificationListSuv);
            return allPropertyS179Classification;
        }
    }
}
