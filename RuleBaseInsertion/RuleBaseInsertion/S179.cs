using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleBaseInsertion
{
    public class S179
    {
        DatabaseOperations databaseOperations = new DatabaseOperations();

        Dictionary<string, List<S179DTO>> allPropertyS179 = new Dictionary<string, List<S179DTO>>();
        List<S179DTO> s179ListAut = new List<S179DTO>();
        List<S179DTO> s179ListBdg = new List<S179DTO>();
        List<S179DTO> s179ListBus = new List<S179DTO>();
        List<S179DTO> s179ListCeq = new List<S179DTO>();
        List<S179DTO> s179ListCoq = new List<S179DTO>();
        List<S179DTO> s179ListCsw = new List<S179DTO>();
        List<S179DTO> s179Listffe = new List<S179DTO>();
        List<S179DTO> s179ListInt = new List<S179DTO>();
        List<S179DTO> s179ListLdi = new List<S179DTO>();
        List<S179DTO> s179ListLhi = new List<S179DTO>();
        List<S179DTO> s179ListLnd = new List<S179DTO>();
        List<S179DTO> s179ListLtv = new List<S179DTO>();
        List<S179DTO> s179ListMfg = new List<S179DTO>();
        List<S179DTO> s179ListPpn = new List<S179DTO>();
        List<S179DTO> s179ListRpn = new List<S179DTO>();
        List<S179DTO> s179ListRrb = new List<S179DTO>();
        List<S179DTO> s179ListTlr = new List<S179DTO>();
        List<S179DTO> s179ListTrh = new List<S179DTO>();
        List<S179DTO> s179ListUnt = new List<S179DTO>();
        List<S179DTO> s179ListWrs = new List<S179DTO>();
        List<S179DTO> s179ListCst = new List<S179DTO>();
        List<S179DTO> s179ListSuv = new List<S179DTO>();
        public Dictionary<string, List<S179DTO>> MainLogic(List<string[]> entireExcel,List<string[]> s179Classification )
        {
            S179Classification s179ClassificationObj = new S179Classification();
            Dictionary<string, List<S179ClassificationDTO>> allPropertyS179Classification =
                s179ClassificationObj.MainLogic(s179Classification); 
            foreach (string[] row in entireExcel)
            {
                if (string.Equals(row[2], "P") || string.Equals(row[2],"8"))
                {
                    S179DTO S179DTO = new S179DTO();

                    S179DTO.EffectiveDate = row[0];
                    S179DTO.ExpiryDate = row[1];
                    S179DTO.DepreciationMethod = row[24];
                    S179DTO.EstimatedLife = row[25];
                    S179DTO.S179Applicable = row[26];
                    S179DTO.IsQualifiedByDefault = row[27];
                    S179DTO.Zone = row[28];
                    S179DTO.BaseLimit = row[29];
                    S179DTO.ThresholdLimit = row[30];
                    S179DTO.PercentThresholdLimit = row[31];
                    S179DTO.Classifications = new Dictionary<string, string>();
                    List<S179ClassificationDTO> s179ClassificationDTOs = allPropertyS179Classification["AUT"];
                    foreach (S179ClassificationDTO s179ClassificationDTO in s179ClassificationDTOs)
                    {
                        if (Convert.ToDateTime(s179ClassificationDTO.EffectiveDate) <= Convert.ToDateTime(row[0]))
                        {
                            if (string.IsNullOrEmpty(s179ClassificationDTO.ExpirationDate) ||
                                Convert.ToDateTime(s179ClassificationDTO.ExpirationDate) >= Convert.ToDateTime(row[1]))
                            {
                                S179DTO.Classifications.Add(s179ClassificationDTO.Classification,s179ClassificationDTO.ClassificationID);
                            }
                        }
                    }
                    s179ListAut.Add(S179DTO);
                }
                if (string.Equals(row[3], "P"))
                {

                    S179DTO S179DTO = new S179DTO();
                    S179DTO.EffectiveDate = row[0];
                    S179DTO.ExpiryDate = row[1];
                    S179DTO.DepreciationMethod = row[24];
                    S179DTO.EstimatedLife = row[25];
                    S179DTO.S179Applicable = row[26];
                    S179DTO.IsQualifiedByDefault = row[27];
                    S179DTO.Zone = row[28];
                    S179DTO.BaseLimit = row[29];
                    S179DTO.ThresholdLimit = row[30];
                    S179DTO.PercentThresholdLimit = row[31];
                    S179DTO.Classifications = new Dictionary<string, string>();
                    List<S179ClassificationDTO> s179ClassificationDTOs = allPropertyS179Classification["BDG"];
                    foreach (S179ClassificationDTO s179ClassificationDTO in s179ClassificationDTOs)
                    {
                        if (Convert.ToDateTime(s179ClassificationDTO.EffectiveDate) <= Convert.ToDateTime(row[0]))
                        {
                            if (string.IsNullOrEmpty(s179ClassificationDTO.ExpirationDate) ||
                                Convert.ToDateTime(s179ClassificationDTO.ExpirationDate) >= Convert.ToDateTime(row[1]))
                            {
                                
                                S179DTO.Classifications.Add(s179ClassificationDTO.Classification,s179ClassificationDTO.ClassificationID);
                            }
                        }
                    }
                    s179ListBdg.Add(S179DTO);
                }
                if (string.Equals(row[4], "P"))
                {

                    S179DTO S179DTO = new S179DTO();

                    S179DTO.EffectiveDate = row[0];
                    S179DTO.ExpiryDate = row[1];
                    S179DTO.DepreciationMethod = row[24];
                    S179DTO.EstimatedLife = row[25];
                    S179DTO.S179Applicable = row[26];
                    S179DTO.IsQualifiedByDefault = row[27];
                    S179DTO.Zone = row[28];
                    S179DTO.BaseLimit = row[29];
                    S179DTO.ThresholdLimit = row[30];
                    S179DTO.PercentThresholdLimit = row[31];
                    S179DTO.Classifications = new Dictionary<string, string>();
                    List<S179ClassificationDTO> s179ClassificationDTOs = allPropertyS179Classification["BUS"];
                    foreach (S179ClassificationDTO s179ClassificationDTO in s179ClassificationDTOs)
                    {
                        if (Convert.ToDateTime(s179ClassificationDTO.EffectiveDate) <= Convert.ToDateTime(row[0]))
                        {
                            if (string.IsNullOrEmpty(s179ClassificationDTO.ExpirationDate) ||
                                Convert.ToDateTime(s179ClassificationDTO.ExpirationDate) >= Convert.ToDateTime(row[1]))
                            {
                                S179DTO.Classifications.Add(s179ClassificationDTO.Classification,s179ClassificationDTO.ClassificationID);
                            }
                        }
                    }
                    s179ListBus.Add(S179DTO);
                }
                if (string.Equals(row[5], "P"))
                {

                    S179DTO S179DTO = new S179DTO();

                    S179DTO.EffectiveDate = row[0];
                    S179DTO.ExpiryDate = row[1];
                    S179DTO.DepreciationMethod = row[24];
                    S179DTO.EstimatedLife = row[25];
                    S179DTO.S179Applicable = row[26];
                    S179DTO.IsQualifiedByDefault = row[27];
                    S179DTO.Zone = row[28];
                    S179DTO.BaseLimit = row[29];
                    S179DTO.ThresholdLimit = row[30];
                    S179DTO.PercentThresholdLimit = row[31];
                    S179DTO.Classifications = new Dictionary<string, string>();
                    List<S179ClassificationDTO> s179ClassificationDTOs = allPropertyS179Classification["CEQ"];
                    foreach (S179ClassificationDTO s179ClassificationDTO in s179ClassificationDTOs)
                    {
                        if (Convert.ToDateTime(s179ClassificationDTO.EffectiveDate) <= Convert.ToDateTime(row[0]))
                        {
                            if (string.IsNullOrEmpty(s179ClassificationDTO.ExpirationDate) ||
                                Convert.ToDateTime(s179ClassificationDTO.ExpirationDate) >= Convert.ToDateTime(row[1]))
                            {
                                S179DTO.Classifications.Add(s179ClassificationDTO.Classification,s179ClassificationDTO.ClassificationID);
                            }
                        }
                    }
                    s179ListCeq.Add(S179DTO);
                }
                if (string.Equals(row[6], "P"))
                {

                    S179DTO S179DTO = new S179DTO();

                    S179DTO.EffectiveDate = row[0];
                    S179DTO.ExpiryDate = row[1];
                    S179DTO.DepreciationMethod = row[24];
                    S179DTO.EstimatedLife = row[25];
                    S179DTO.S179Applicable = row[26];
                    S179DTO.IsQualifiedByDefault = row[27];
                    S179DTO.Zone = row[28];
                    S179DTO.BaseLimit = row[29];
                    S179DTO.ThresholdLimit = row[30];
                    S179DTO.PercentThresholdLimit = row[31];
                    S179DTO.Classifications = new Dictionary<string, string>();
                    List<S179ClassificationDTO> s179ClassificationDTOs = allPropertyS179Classification["COQ"];
                    foreach (S179ClassificationDTO s179ClassificationDTO in s179ClassificationDTOs)
                    {
                        if (Convert.ToDateTime(s179ClassificationDTO.EffectiveDate) <= Convert.ToDateTime(row[0]))
                        {
                            if (string.IsNullOrEmpty(s179ClassificationDTO.ExpirationDate) ||
                                Convert.ToDateTime(s179ClassificationDTO.ExpirationDate) >= Convert.ToDateTime(row[1]))
                            {
                                S179DTO.Classifications.Add(s179ClassificationDTO.Classification,s179ClassificationDTO.ClassificationID);
                            }
                        }
                    }
                    s179ListCoq.Add(S179DTO);
                }
                if (string.Equals(row[7], "P"))
                {
                    S179DTO S179DTO = new S179DTO();

                    S179DTO.EffectiveDate = row[0];
                    S179DTO.ExpiryDate = row[1];
                    S179DTO.DepreciationMethod = row[24];
                    S179DTO.EstimatedLife = row[25];
                    S179DTO.S179Applicable = row[26];
                    S179DTO.IsQualifiedByDefault = row[27];
                    S179DTO.Zone = row[28];
                    S179DTO.BaseLimit = row[29];
                    S179DTO.ThresholdLimit = row[30];
                    S179DTO.PercentThresholdLimit = row[31];
                    S179DTO.Classifications = new Dictionary<string, string>();
                    List<S179ClassificationDTO> s179ClassificationDTOs = allPropertyS179Classification["CSW"];
                    foreach (S179ClassificationDTO s179ClassificationDTO in s179ClassificationDTOs)
                    {
                        if (Convert.ToDateTime(s179ClassificationDTO.EffectiveDate) <= Convert.ToDateTime(row[0]))
                        {
                            if (string.IsNullOrEmpty(s179ClassificationDTO.ExpirationDate) ||
                                Convert.ToDateTime(s179ClassificationDTO.ExpirationDate) >= Convert.ToDateTime(row[1]))
                            {
                                S179DTO.Classifications.Add(s179ClassificationDTO.Classification,s179ClassificationDTO.ClassificationID);
                            }
                        }
                    }
                    s179ListCsw.Add(S179DTO);
                }
                if (string.Equals(row[8], "P"))
                {
                    S179DTO S179DTO = new S179DTO();

                    S179DTO.EffectiveDate = row[0];
                    S179DTO.ExpiryDate = row[1];
                    S179DTO.DepreciationMethod = row[24];
                    S179DTO.EstimatedLife = row[25];
                    S179DTO.S179Applicable = row[26];
                    S179DTO.IsQualifiedByDefault = row[27];
                    S179DTO.Zone = row[28];
                    S179DTO.BaseLimit = row[29];
                    S179DTO.ThresholdLimit = row[30];
                    S179DTO.PercentThresholdLimit = row[31];
                    S179DTO.Classifications = new Dictionary<string, string>();
                    List<S179ClassificationDTO> s179ClassificationDTOs = allPropertyS179Classification["FFE"];
                    foreach (S179ClassificationDTO s179ClassificationDTO in s179ClassificationDTOs)
                    {
                        if (Convert.ToDateTime(s179ClassificationDTO.EffectiveDate) <= Convert.ToDateTime(row[0]))
                        {
                            if (string.IsNullOrEmpty(s179ClassificationDTO.ExpirationDate) ||
                                Convert.ToDateTime(s179ClassificationDTO.ExpirationDate) >= Convert.ToDateTime(row[1]))
                            {
                                S179DTO.Classifications.Add(s179ClassificationDTO.Classification,s179ClassificationDTO.ClassificationID);
                            }
                        }
                    }
                    s179Listffe.Add(S179DTO);
                }
                if (string.Equals(row[9], "P"))
                {

                    S179DTO S179DTO = new S179DTO();

                    S179DTO.EffectiveDate = row[0];
                    S179DTO.ExpiryDate = row[1];
                    S179DTO.DepreciationMethod = row[24];
                    S179DTO.EstimatedLife = row[25];
                    S179DTO.S179Applicable = row[26];
                    S179DTO.IsQualifiedByDefault = row[27];
                    S179DTO.Zone = row[28];
                    S179DTO.BaseLimit = row[29];
                    S179DTO.ThresholdLimit = row[30];
                    S179DTO.PercentThresholdLimit = row[31];
                    S179DTO.Classifications = new Dictionary<string, string>();
                    List<S179ClassificationDTO> s179ClassificationDTOs = allPropertyS179Classification["INT"];
                    foreach (S179ClassificationDTO s179ClassificationDTO in s179ClassificationDTOs)
                    {
                        if (Convert.ToDateTime(s179ClassificationDTO.EffectiveDate) <= Convert.ToDateTime(row[0]))
                        {
                            if (string.IsNullOrEmpty(s179ClassificationDTO.ExpirationDate) ||
                                Convert.ToDateTime(s179ClassificationDTO.ExpirationDate) >= Convert.ToDateTime(row[1]))
                            {
                                S179DTO.Classifications.Add(s179ClassificationDTO.Classification,s179ClassificationDTO.ClassificationID);
                            }
                        }
                    }
                    s179ListInt.Add(S179DTO);
                }
                if (string.Equals(row[10], "P"))
                {

                    S179DTO S179DTO = new S179DTO();

                    S179DTO.EffectiveDate = row[0];
                    S179DTO.ExpiryDate = row[1];
                    S179DTO.DepreciationMethod = row[24];
                    S179DTO.EstimatedLife = row[25];
                    S179DTO.S179Applicable = row[26];
                    S179DTO.IsQualifiedByDefault = row[27];
                    S179DTO.Zone = row[28];
                    S179DTO.BaseLimit = row[29];
                    S179DTO.ThresholdLimit = row[30];
                    S179DTO.PercentThresholdLimit = row[31];
                    S179DTO.Classifications = new Dictionary<string, string>();
                    List<S179ClassificationDTO> s179ClassificationDTOs = allPropertyS179Classification["LDI"];
                    foreach (S179ClassificationDTO s179ClassificationDTO in s179ClassificationDTOs)
                    {
                        if (Convert.ToDateTime(s179ClassificationDTO.EffectiveDate) <= Convert.ToDateTime(row[0]))
                        {
                            if (string.IsNullOrEmpty(s179ClassificationDTO.ExpirationDate) ||
                                Convert.ToDateTime(s179ClassificationDTO.ExpirationDate) >= Convert.ToDateTime(row[1]))
                            {
                                S179DTO.Classifications.Add(s179ClassificationDTO.Classification,s179ClassificationDTO.ClassificationID);
                            }
                        }
                    }
                    s179ListLdi.Add(S179DTO);
                }
                if (string.Equals(row[11], "P"))
                {
                    S179DTO S179DTO = new S179DTO();

                    S179DTO.EffectiveDate = row[0];
                    S179DTO.ExpiryDate = row[1];
                    S179DTO.DepreciationMethod = row[24];
                    S179DTO.EstimatedLife = row[25];
                    S179DTO.S179Applicable = row[26];
                    S179DTO.IsQualifiedByDefault = row[27];
                    S179DTO.Zone = row[28];
                    S179DTO.BaseLimit = row[29];
                    S179DTO.ThresholdLimit = row[30];
                    S179DTO.PercentThresholdLimit = row[31];
                    S179DTO.Classifications = new Dictionary<string, string>();
                    List<S179ClassificationDTO> s179ClassificationDTOs = allPropertyS179Classification["LHI"];
                    foreach (S179ClassificationDTO s179ClassificationDTO in s179ClassificationDTOs)
                    {
                        if (Convert.ToDateTime(s179ClassificationDTO.EffectiveDate) <= Convert.ToDateTime(row[0]))
                        {
                            if (string.IsNullOrEmpty(s179ClassificationDTO.ExpirationDate) ||
                                Convert.ToDateTime(s179ClassificationDTO.ExpirationDate) >= Convert.ToDateTime(row[1]))
                            {
                                S179DTO.Classifications.Add(s179ClassificationDTO.Classification,s179ClassificationDTO.ClassificationID);
                            }
                        }
                    }
                    s179ListLhi.Add(S179DTO);
                }
                if (string.Equals(row[12], "P"))
                {
                    S179DTO S179DTO = new S179DTO();

                    S179DTO.EffectiveDate = row[0];
                    S179DTO.ExpiryDate = row[1];
                    S179DTO.DepreciationMethod = row[24];
                    S179DTO.EstimatedLife = row[25];
                    S179DTO.S179Applicable = row[26];
                    S179DTO.IsQualifiedByDefault = row[27];
                    S179DTO.Zone = row[28];
                    S179DTO.BaseLimit = row[29];
                    S179DTO.ThresholdLimit = row[30];
                    S179DTO.PercentThresholdLimit = row[31];
                    S179DTO.Classifications = new Dictionary<string, string>();
                    List<S179ClassificationDTO> s179ClassificationDTOs = allPropertyS179Classification["LND"];
                    foreach (S179ClassificationDTO s179ClassificationDTO in s179ClassificationDTOs)
                    {
                        if (Convert.ToDateTime(s179ClassificationDTO.EffectiveDate) <= Convert.ToDateTime(row[0]))
                        {
                            if (string.IsNullOrEmpty(s179ClassificationDTO.ExpirationDate) ||
                                Convert.ToDateTime(s179ClassificationDTO.ExpirationDate) >= Convert.ToDateTime(row[1]))
                            {
                                S179DTO.Classifications.Add(s179ClassificationDTO.Classification,s179ClassificationDTO.ClassificationID);
                            }
                        }
                    }
                    s179ListLnd.Add(S179DTO);
                }
                if (string.Equals(row[13], "P") || string.Equals(row[13], "8"))
                {
                    S179DTO S179DTO = new S179DTO();

                    S179DTO.EffectiveDate = row[0];
                    S179DTO.ExpiryDate = row[1];
                    S179DTO.DepreciationMethod = row[24];
                    S179DTO.EstimatedLife = row[25];
                    S179DTO.S179Applicable = row[26];
                    S179DTO.IsQualifiedByDefault = row[27];
                    S179DTO.Zone = row[28];
                    S179DTO.BaseLimit = row[29];
                    S179DTO.ThresholdLimit = row[30];
                    S179DTO.PercentThresholdLimit = row[31];
                    S179DTO.Classifications = new Dictionary<string, string>();
                    List<S179ClassificationDTO> s179ClassificationDTOs = allPropertyS179Classification["LTV"];
                    foreach (S179ClassificationDTO s179ClassificationDTO in s179ClassificationDTOs)
                    {
                        if (Convert.ToDateTime(s179ClassificationDTO.EffectiveDate) <= Convert.ToDateTime(row[0]))
                        {
                            if (string.IsNullOrEmpty(s179ClassificationDTO.ExpirationDate) ||
                                Convert.ToDateTime(s179ClassificationDTO.ExpirationDate) >= Convert.ToDateTime(row[1]))
                            {
                                S179DTO.Classifications.Add(s179ClassificationDTO.Classification, s179ClassificationDTO.ClassificationID);
                            }
                        }
                    }
                    s179ListLtv.Add(S179DTO);
                }
                if (string.Equals(row[14], "P"))
                {

                    S179DTO S179DTO = new S179DTO();

                    S179DTO.EffectiveDate = row[0];
                    S179DTO.ExpiryDate = row[1];
                    S179DTO.DepreciationMethod = row[24];
                    S179DTO.EstimatedLife = row[25];
                    S179DTO.S179Applicable = row[26];
                    S179DTO.IsQualifiedByDefault = row[27];
                    S179DTO.Zone = row[28];
                    S179DTO.BaseLimit = row[29];
                    S179DTO.ThresholdLimit = row[30];
                    S179DTO.PercentThresholdLimit = row[31];
                    S179DTO.Classifications = new Dictionary<string, string>();
                    List<S179ClassificationDTO> s179ClassificationDTOs = allPropertyS179Classification["MFG"];
                    foreach (S179ClassificationDTO s179ClassificationDTO in s179ClassificationDTOs)
                    {
                        if (Convert.ToDateTime(s179ClassificationDTO.EffectiveDate) <= Convert.ToDateTime(row[0]))
                        {
                            if (string.IsNullOrEmpty(s179ClassificationDTO.ExpirationDate) ||
                                Convert.ToDateTime(s179ClassificationDTO.ExpirationDate) >= Convert.ToDateTime(row[1]))
                            {
                                S179DTO.Classifications.Add(s179ClassificationDTO.Classification,s179ClassificationDTO.ClassificationID);
                            }
                        }
                    }
                    s179ListMfg.Add(S179DTO);
                }
                if (string.Equals(row[15], "P"))
                {

                    S179DTO S179DTO = new S179DTO();

                    S179DTO.EffectiveDate = row[0];
                    S179DTO.ExpiryDate = row[1];
                    S179DTO.DepreciationMethod = row[24];
                    S179DTO.EstimatedLife = row[25];
                    S179DTO.S179Applicable = row[26];
                    S179DTO.IsQualifiedByDefault = row[27];
                    S179DTO.Zone = row[28];
                    S179DTO.BaseLimit = row[29];
                    S179DTO.ThresholdLimit = row[30];
                    S179DTO.PercentThresholdLimit = row[31];
                    S179DTO.Classifications = new Dictionary<string, string>();
                    List<S179ClassificationDTO> s179ClassificationDTOs = allPropertyS179Classification["PPN"];
                    foreach (S179ClassificationDTO s179ClassificationDTO in s179ClassificationDTOs)
                    {
                        if (Convert.ToDateTime(s179ClassificationDTO.EffectiveDate) <= Convert.ToDateTime(row[0]))
                        {
                            if (string.IsNullOrEmpty(s179ClassificationDTO.ExpirationDate) ||
                                Convert.ToDateTime(s179ClassificationDTO.ExpirationDate) >= Convert.ToDateTime(row[1]))
                            {
                                S179DTO.Classifications.Add(s179ClassificationDTO.Classification,s179ClassificationDTO.ClassificationID);
                            }
                        }
                    }
                    s179ListPpn.Add(S179DTO);
                }
                if (string.Equals(row[16], "P"))
                {

                    S179DTO S179DTO = new S179DTO();

                    S179DTO.EffectiveDate = row[0];
                    S179DTO.ExpiryDate = row[1];
                    S179DTO.DepreciationMethod = row[24];
                    S179DTO.EstimatedLife = row[25];
                    S179DTO.S179Applicable = row[26];
                    S179DTO.IsQualifiedByDefault = row[27];
                    S179DTO.Zone = row[28];
                    S179DTO.BaseLimit = row[29];
                    S179DTO.ThresholdLimit = row[30];
                    S179DTO.PercentThresholdLimit = row[31];
                    S179DTO.Classifications = new Dictionary<string, string>();
                    List<S179ClassificationDTO> s179ClassificationDTOs = allPropertyS179Classification["RPN"];
                    foreach (S179ClassificationDTO s179ClassificationDTO in s179ClassificationDTOs)
                    {
                        if (Convert.ToDateTime(s179ClassificationDTO.EffectiveDate) <= Convert.ToDateTime(row[0]))
                        {
                            if (string.IsNullOrEmpty(s179ClassificationDTO.ExpirationDate) ||
                                Convert.ToDateTime(s179ClassificationDTO.ExpirationDate) >= Convert.ToDateTime(row[1]))
                            {
                                S179DTO.Classifications.Add(s179ClassificationDTO.Classification,s179ClassificationDTO.ClassificationID);
                            }
                        }
                    }
                    s179ListRpn.Add(S179DTO);
                }
                if (string.Equals(row[17], "P"))
                {

                    S179DTO S179DTO = new S179DTO();

                    S179DTO.EffectiveDate = row[0];
                    S179DTO.ExpiryDate = row[1];
                    S179DTO.DepreciationMethod = row[24];
                    S179DTO.EstimatedLife = row[25];
                    S179DTO.S179Applicable = row[26];
                    S179DTO.IsQualifiedByDefault = row[27];
                    S179DTO.Zone = row[28];
                    S179DTO.BaseLimit = row[29];
                    S179DTO.ThresholdLimit = row[30];
                    S179DTO.PercentThresholdLimit = row[31];
                    S179DTO.Classifications = new Dictionary<string, string>();
                    List<S179ClassificationDTO> s179ClassificationDTOs = allPropertyS179Classification["RRB"];
                    foreach (S179ClassificationDTO s179ClassificationDTO in s179ClassificationDTOs)
                    {
                        if (Convert.ToDateTime(s179ClassificationDTO.EffectiveDate) <= Convert.ToDateTime(row[0]))
                        {
                            if (string.IsNullOrEmpty(s179ClassificationDTO.ExpirationDate) ||
                                Convert.ToDateTime(s179ClassificationDTO.ExpirationDate) >= Convert.ToDateTime(row[1]))
                            {
                                S179DTO.Classifications.Add(s179ClassificationDTO.Classification,s179ClassificationDTO.ClassificationID);
                            }
                        }
                    }
                    s179ListRrb.Add(S179DTO);
                }
                if (string.Equals(row[18], "P"))
                {
                    S179DTO S179DTO = new S179DTO();

                    S179DTO.EffectiveDate = row[0];
                    S179DTO.ExpiryDate = row[1];
                    S179DTO.DepreciationMethod = row[24];
                    S179DTO.EstimatedLife = row[25];
                    S179DTO.S179Applicable = row[26];
                    S179DTO.IsQualifiedByDefault = row[27];
                    S179DTO.Zone = row[28];
                    S179DTO.BaseLimit = row[29];
                    S179DTO.ThresholdLimit = row[30];
                    S179DTO.PercentThresholdLimit = row[31];
                    S179DTO.Classifications = new Dictionary<string, string>();
                    List<S179ClassificationDTO> s179ClassificationDTOs = allPropertyS179Classification["SUV"];
                    foreach (S179ClassificationDTO s179ClassificationDTO in s179ClassificationDTOs)
                    {
                        if (Convert.ToDateTime(s179ClassificationDTO.EffectiveDate) <= Convert.ToDateTime(row[0]))
                        {
                            if (string.IsNullOrEmpty(s179ClassificationDTO.ExpirationDate) ||
                                Convert.ToDateTime(s179ClassificationDTO.ExpirationDate) >= Convert.ToDateTime(row[1]))
                            {
                                S179DTO.Classifications.Add(s179ClassificationDTO.Classification,s179ClassificationDTO.ClassificationID);
                            }
                        }
                    }
                    s179ListSuv.Add(S179DTO);
                }
                if (string.Equals(row[19], "P"))
                {
                    S179DTO S179DTO = new S179DTO();

                    S179DTO.EffectiveDate = row[0];
                    S179DTO.ExpiryDate = row[1];
                    S179DTO.DepreciationMethod = row[24];
                    S179DTO.EstimatedLife = row[25];
                    S179DTO.S179Applicable = row[26];
                    S179DTO.IsQualifiedByDefault = row[27];
                    S179DTO.Zone = row[28];
                    S179DTO.BaseLimit = row[29];
                    S179DTO.ThresholdLimit = row[30];
                    S179DTO.PercentThresholdLimit = row[31];
                    S179DTO.Classifications = new Dictionary<string, string>();
                    List<S179ClassificationDTO> s179ClassificationDTOs = allPropertyS179Classification["TLR"];
                    foreach (S179ClassificationDTO s179ClassificationDTO in s179ClassificationDTOs)
                    {
                        if (Convert.ToDateTime(s179ClassificationDTO.EffectiveDate) <= Convert.ToDateTime(row[0]))
                        {
                            if (string.IsNullOrEmpty(s179ClassificationDTO.ExpirationDate) ||
                                Convert.ToDateTime(s179ClassificationDTO.ExpirationDate) >= Convert.ToDateTime(row[1]))
                            {
                                S179DTO.Classifications.Add(s179ClassificationDTO.Classification,s179ClassificationDTO.ClassificationID);
                            }
                        }
                    }
                    s179ListTlr.Add(S179DTO);
                }
                if (string.Equals(row[20], "P"))
                {

                    S179DTO S179DTO = new S179DTO();

                    S179DTO.EffectiveDate = row[0];
                    S179DTO.ExpiryDate = row[1];
                    S179DTO.DepreciationMethod = row[24];
                    S179DTO.EstimatedLife = row[25];
                    S179DTO.S179Applicable = row[26];
                    S179DTO.IsQualifiedByDefault = row[27];
                    S179DTO.Zone = row[28];
                    S179DTO.BaseLimit = row[29];
                    S179DTO.ThresholdLimit = row[30];
                    S179DTO.PercentThresholdLimit = row[31];
                    S179DTO.Classifications = new Dictionary<string, string>();
                    List<S179ClassificationDTO> s179ClassificationDTOs = allPropertyS179Classification["TRH"];
                    foreach (S179ClassificationDTO s179ClassificationDTO in s179ClassificationDTOs)
                    {
                        if (Convert.ToDateTime(s179ClassificationDTO.EffectiveDate) <= Convert.ToDateTime(row[0]))
                        {
                            if (string.IsNullOrEmpty(s179ClassificationDTO.ExpirationDate) ||
                                Convert.ToDateTime(s179ClassificationDTO.ExpirationDate) >= Convert.ToDateTime(row[1]))
                            {
                                S179DTO.Classifications.Add(s179ClassificationDTO.Classification,s179ClassificationDTO.ClassificationID);
                            }
                        }
                    }
                    s179ListTrh.Add(S179DTO);
                }
                if (string.Equals(row[21], "P"))
                {

                    S179DTO S179DTO = new S179DTO();

                    S179DTO.EffectiveDate = row[0];
                    S179DTO.ExpiryDate = row[1];
                    S179DTO.DepreciationMethod = row[24];
                    S179DTO.EstimatedLife = row[25];
                    S179DTO.S179Applicable = row[26];
                    S179DTO.IsQualifiedByDefault = row[27];
                    S179DTO.Zone = row[28];
                    S179DTO.BaseLimit = row[29];
                    S179DTO.ThresholdLimit = row[30];
                    S179DTO.PercentThresholdLimit = row[31];
                    S179DTO.Classifications = new Dictionary<string, string>();
                    List<S179ClassificationDTO> s179ClassificationDTOs = allPropertyS179Classification["UNT"];
                    foreach (S179ClassificationDTO s179ClassificationDTO in s179ClassificationDTOs)
                    {
                        if (Convert.ToDateTime(s179ClassificationDTO.EffectiveDate) <= Convert.ToDateTime(row[0]))
                        {
                            if (string.IsNullOrEmpty(s179ClassificationDTO.ExpirationDate) ||
                                Convert.ToDateTime(s179ClassificationDTO.ExpirationDate) >= Convert.ToDateTime(row[1]))
                            {
                                S179DTO.Classifications.Add(s179ClassificationDTO.Classification,s179ClassificationDTO.ClassificationID);
                            }
                        }
                    }
                    s179ListUnt.Add(S179DTO);
                }
                if (string.Equals(row[22], "P"))
                {

                    S179DTO S179DTO = new S179DTO();

                    S179DTO.EffectiveDate = row[0];
                    S179DTO.ExpiryDate = row[1];
                    S179DTO.DepreciationMethod = row[24];
                    S179DTO.EstimatedLife = row[25];
                    S179DTO.S179Applicable = row[26];
                    S179DTO.IsQualifiedByDefault = row[27];
                    S179DTO.Zone = row[28];
                    S179DTO.BaseLimit = row[29];
                    S179DTO.ThresholdLimit = row[30];
                    S179DTO.PercentThresholdLimit = row[31];
                    S179DTO.Classifications = new Dictionary<string, string>();
                    List<S179ClassificationDTO> s179ClassificationDTOs = allPropertyS179Classification["WRS"];
                    foreach (S179ClassificationDTO s179ClassificationDTO in s179ClassificationDTOs)
                    {
                        if (Convert.ToDateTime(s179ClassificationDTO.EffectiveDate) <= Convert.ToDateTime(row[0]))
                        {
                            if (string.IsNullOrEmpty(s179ClassificationDTO.ExpirationDate) ||
                                Convert.ToDateTime(s179ClassificationDTO.ExpirationDate) >= Convert.ToDateTime(row[1]))
                            {
                                S179DTO.Classifications.Add(s179ClassificationDTO.Classification,s179ClassificationDTO.ClassificationID);
                            }
                        }
                    }
                    s179ListWrs.Add(S179DTO);
                }
                if (string.Equals(row[23], "P"))
                {

                    S179DTO S179DTO = new S179DTO();

                    S179DTO.EffectiveDate = row[0];
                    S179DTO.ExpiryDate = row[1];
                    S179DTO.DepreciationMethod = row[24];
                    S179DTO.EstimatedLife = row[25];
                    S179DTO.S179Applicable = row[26];
                    S179DTO.IsQualifiedByDefault = row[27];
                    S179DTO.Zone = row[28];
                    S179DTO.BaseLimit = row[29];
                    S179DTO.ThresholdLimit = row[30];
                    S179DTO.PercentThresholdLimit = row[31];
                    S179DTO.Classifications = new Dictionary<string, string>();
                    List<S179ClassificationDTO> s179ClassificationDTOs = allPropertyS179Classification["CST"];
                    foreach (S179ClassificationDTO s179ClassificationDTO in s179ClassificationDTOs)
                    {
                        if (Convert.ToDateTime(s179ClassificationDTO.EffectiveDate) <= Convert.ToDateTime(row[0]))
                        {
                            if (string.IsNullOrEmpty(s179ClassificationDTO.ExpirationDate) ||
                                Convert.ToDateTime(s179ClassificationDTO.ExpirationDate) >= Convert.ToDateTime(row[1]))
                            {
                                S179DTO.Classifications.Add(s179ClassificationDTO.Classification,s179ClassificationDTO.ClassificationID);
                            }
                        }
                    }
                    s179ListCst.Add(S179DTO);
                }
                
               // return allPropertyS179;
            }
            allPropertyS179.Add("AUT", s179ListAut);
            allPropertyS179.Add("BDG", s179ListBdg);
            allPropertyS179.Add("BUS", s179ListBus);
            allPropertyS179.Add("CEQ", s179ListCeq);
            allPropertyS179.Add("COQ", s179ListCoq);
            allPropertyS179.Add("CSW", s179ListCsw);
            allPropertyS179.Add("FFE", s179Listffe);
            allPropertyS179.Add("INT", s179ListInt);
            allPropertyS179.Add("LDI", s179ListLdi);
            allPropertyS179.Add("LHI", s179ListLhi);
            allPropertyS179.Add("LND", s179ListLnd);
            allPropertyS179.Add("LTV", s179ListLtv);
            allPropertyS179.Add("MFG", s179ListMfg);
            allPropertyS179.Add("PPN", s179ListPpn);
            allPropertyS179.Add("RPN", s179ListRpn);
            allPropertyS179.Add("RRB", s179ListRrb);
            allPropertyS179.Add("TLR", s179ListTlr);
            allPropertyS179.Add("TRH", s179ListTrh);
            allPropertyS179.Add("UNT", s179ListUnt);
            allPropertyS179.Add("WRS", s179ListWrs);
            allPropertyS179.Add("CST", s179ListCst);
            allPropertyS179.Add("SUV", s179ListSuv);
            return allPropertyS179;
        }

        public void PushToDatabase(Dictionary<string, List<S179DTO>> allPropertyS179)
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

            Guid S179RulePropertyId = databaseOperations.GetRulePropertyIdfromPropertyCode("S179Limit");
            Guid qualByDefault = databaseOperations.GetRulePropertyIdfromPropertyCode("IsQualByDefault");
            Guid s179BaseLimit = databaseOperations.GetRulePropertyIdfromPropertyCode("S179BaseLimit");
            Guid s179ThresholdLimit = databaseOperations.GetRulePropertyIdfromPropertyCode("S179ThresholdLimit");
            Guid s179PercentThresholdLimit = databaseOperations.GetRulePropertyIdfromPropertyCode("Section179PercentThresholdLimit");
            Guid estimatedLife = databaseOperations.GetRulePropertyIdfromPropertyCode("EL");
            Guid depreciationMethod = databaseOperations.GetRulePropertyIdfromPropertyCode("DM");
            Guid s179ClassificationRulePropertyId =
                databaseOperations.GetRulePropertyIdfromPropertyCode("S179Classification");
            Console.WriteLine("****************************S179***************************************");

            if (allPropertyS179.ContainsKey("AUT"))
            {
                List<S179DTO> s179List = allPropertyS179["AUT"];
                foreach (S179DTO s179DTO in s179List)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(autId);
                    Guid zoneId = databaseOperations.GetZoneIdBasedOnZoneCode(s179DTO.Zone);

                    Guid s179Header = databaseOperations.AddRuleHeader(zoneId, S179RulePropertyId, s179DTO.EffectiveDate, s179DTO.ExpiryDate, def.ToString(), 1);
                    Guid s179DetailHeader = databaseOperations.AddRuleDetail(null, s179Header.ToString(), S179RulePropertyId.ToString(), zoneId.ToString(), s179DTO.Zone, 1, 0,0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), qualByDefault.ToString(), null, s179DTO.IsQualifiedByDefault, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179BaseLimit.ToString(), null, s179DTO.BaseLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179ThresholdLimit.ToString(), null, s179DTO.ThresholdLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179PercentThresholdLimit.ToString(), null, s179DTO.PercentThresholdLimit, 1, 0, 0);
                    if (null != s179DTO.Classifications && s179DTO.Classifications.Count > 0)
                    {
                        foreach (var classification in s179DTO.Classifications)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(),
                                                             s179ClassificationRulePropertyId.ToString(),
                                                             classification.Value, classification.Key, 1, 0, 0);
                        }
                    }
                    if (!string.IsNullOrEmpty(s179DTO.EstimatedLife) && s179DTO.EstimatedLife.Contains(','))
                    {
                        string[] els = s179DTO.EstimatedLife.Split(',');
                        foreach (string el in els)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, el, 1, 0, 0);
                        }
                    }
                    else if (!string.IsNullOrEmpty(s179DTO.EstimatedLife))
                    {
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, s179DTO.EstimatedLife, 1, 0, 0);
                    }
                    if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod) && s179DTO.DepreciationMethod.Contains(','))
                    {
                        string[] dms = s179DTO.DepreciationMethod.Split(',');
                        foreach (string dm in dms)
                        {
                            Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(dm);
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), dm, 1, 0, 0);
                        }
                    }

                    else if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod))
                    {
                        Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(s179DTO.DepreciationMethod);
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), s179DTO.DepreciationMethod, 1, 0, 0);
                    }
                    
                }
                Console.WriteLine("Automobile");
                Console.WriteLine("\n\n");
            }

            if (allPropertyS179.ContainsKey("BDG"))
            {
                List<S179DTO> s179List = allPropertyS179["BDG"];
                foreach (S179DTO s179DTO in s179List)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(bdgId);
                    Guid zoneId = databaseOperations.GetZoneIdBasedOnZoneCode(s179DTO.Zone);

                    Guid s179Header = databaseOperations.AddRuleHeader(zoneId, S179RulePropertyId, s179DTO.EffectiveDate, s179DTO.ExpiryDate, def.ToString(), 1);
                    Guid s179DetailHeader = databaseOperations.AddRuleDetail(null, s179Header.ToString(), S179RulePropertyId.ToString(), zoneId.ToString(), s179DTO.Zone, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), qualByDefault.ToString(), null, s179DTO.IsQualifiedByDefault, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179BaseLimit.ToString(), null, s179DTO.BaseLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179ThresholdLimit.ToString(), null, s179DTO.ThresholdLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179PercentThresholdLimit.ToString(), null, s179DTO.PercentThresholdLimit, 1, 0, 0);
                    if (null != s179DTO.Classifications && s179DTO.Classifications.Count > 0)
                    {
                        foreach (var classification in s179DTO.Classifications)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(),
                                                             s179ClassificationRulePropertyId.ToString(),
                                                             classification.Value, classification.Key, 1, 0, 0);
                        }
                    }
                    if (!string.IsNullOrEmpty(s179DTO.EstimatedLife) && s179DTO.EstimatedLife.Contains(','))
                    {
                        string[] els = s179DTO.EstimatedLife.Split(',');
                        foreach (string el in els)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, el, 1, 0, 0);
                        }
                    }
                    else if (!string.IsNullOrEmpty(s179DTO.EstimatedLife))
                    {
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, s179DTO.EstimatedLife, 1, 0, 0);
                    }
                    if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod) && s179DTO.DepreciationMethod.Contains(','))
                    {
                        string[] dms = s179DTO.DepreciationMethod.Split(',');
                        foreach (string dm in dms)
                        {
                            Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(dm);
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), dm, 1, 0, 0);
                        }
                    }

                    else if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod))
                    {
                        Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(s179DTO.DepreciationMethod);
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), s179DTO.DepreciationMethod, 1, 0, 0);
                    }

                }
                Console.WriteLine("Bdg");
                Console.WriteLine("\n\n");
            }

            if (allPropertyS179.ContainsKey("BUS"))
            {
                List<S179DTO> s179List = allPropertyS179["BUS"];
                foreach (S179DTO s179DTO in s179List)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(busId);
                    Guid zoneId = databaseOperations.GetZoneIdBasedOnZoneCode(s179DTO.Zone);

                    Guid s179Header = databaseOperations.AddRuleHeader(zoneId, S179RulePropertyId, s179DTO.EffectiveDate, s179DTO.ExpiryDate, def.ToString(), 1);
                    Guid s179DetailHeader = databaseOperations.AddRuleDetail(null, s179Header.ToString(), S179RulePropertyId.ToString(), zoneId.ToString(), s179DTO.Zone, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), qualByDefault.ToString(), null, s179DTO.IsQualifiedByDefault, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179BaseLimit.ToString(), null, s179DTO.BaseLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179ThresholdLimit.ToString(), null, s179DTO.ThresholdLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179PercentThresholdLimit.ToString(), null, s179DTO.PercentThresholdLimit, 1, 0, 0);
                    if (null != s179DTO.Classifications && s179DTO.Classifications.Count > 0)
                    {
                        foreach (var classification in s179DTO.Classifications)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(),
                                                             s179ClassificationRulePropertyId.ToString(),
                                                             classification.Value, classification.Key, 1, 0, 0);
                        }
                    }
                    if (!string.IsNullOrEmpty(s179DTO.EstimatedLife) && s179DTO.EstimatedLife.Contains(','))
                    {
                        string[] els = s179DTO.EstimatedLife.Split(',');
                        foreach (string el in els)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, el, 1, 0, 0);
                        }
                    }
                    else if (!string.IsNullOrEmpty(s179DTO.EstimatedLife))
                    {
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, s179DTO.EstimatedLife, 1, 0, 0);
                    }
                    if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod) && s179DTO.DepreciationMethod.Contains(','))
                    {
                        string[] dms = s179DTO.DepreciationMethod.Split(',');
                        foreach (string dm in dms)
                        {
                            Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(dm);
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), dm, 1, 0, 0);
                        }
                    }

                    else if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod))
                    {
                        Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(s179DTO.DepreciationMethod);
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), s179DTO.DepreciationMethod, 1, 0, 0);
                    }

                }
                Console.WriteLine("Bus");
                Console.WriteLine("\n\n");
            }
            if (allPropertyS179.ContainsKey("CEQ"))
            {
                List<S179DTO> s179List = allPropertyS179["CEQ"];
                foreach (S179DTO s179DTO in s179List)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(ceqId);
                    Guid zoneId = databaseOperations.GetZoneIdBasedOnZoneCode(s179DTO.Zone);

                    Guid s179Header = databaseOperations.AddRuleHeader(zoneId, S179RulePropertyId, s179DTO.EffectiveDate, s179DTO.ExpiryDate, def.ToString(), 1);
                    Guid s179DetailHeader = databaseOperations.AddRuleDetail(null, s179Header.ToString(), S179RulePropertyId.ToString(), zoneId.ToString(), s179DTO.Zone, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), qualByDefault.ToString(), null, s179DTO.IsQualifiedByDefault, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179BaseLimit.ToString(), null, s179DTO.BaseLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179ThresholdLimit.ToString(), null, s179DTO.ThresholdLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179PercentThresholdLimit.ToString(), null, s179DTO.PercentThresholdLimit, 1, 0, 0);
                    if (null != s179DTO.Classifications && s179DTO.Classifications.Count > 0)
                    {
                        foreach (var classification in s179DTO.Classifications)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(),
                                                             s179ClassificationRulePropertyId.ToString(),
                                                             classification.Value, classification.Key, 1, 0, 0);
                        }
                    }
                    if (!string.IsNullOrEmpty(s179DTO.EstimatedLife) && s179DTO.EstimatedLife.Contains(','))
                    {
                        string[] els = s179DTO.EstimatedLife.Split(',');
                        foreach (string el in els)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, el, 1, 0, 0);
                        }
                    }
                    else if (!string.IsNullOrEmpty(s179DTO.EstimatedLife))
                    {
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, s179DTO.EstimatedLife, 1, 0, 0);
                    }
                    if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod) && s179DTO.DepreciationMethod.Contains(','))
                    {
                        string[] dms = s179DTO.DepreciationMethod.Split(',');
                        foreach (string dm in dms)
                        {
                            Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(dm);
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), dm, 1, 0, 0);
                        }
                    }

                    else if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod))
                    {
                        Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(s179DTO.DepreciationMethod);
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), s179DTO.DepreciationMethod, 1, 0, 0);
                    }

                }
                Console.WriteLine("CEQ");
                Console.WriteLine("\n\n");
            }
            if (allPropertyS179.ContainsKey("COQ"))
            {
                List<S179DTO> s179List = allPropertyS179["COQ"];
                foreach (S179DTO s179DTO in s179List)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(coqId);
                    Guid zoneId = databaseOperations.GetZoneIdBasedOnZoneCode(s179DTO.Zone);

                    Guid s179Header = databaseOperations.AddRuleHeader(zoneId, S179RulePropertyId, s179DTO.EffectiveDate, s179DTO.ExpiryDate, def.ToString(), 1);
                    Guid s179DetailHeader = databaseOperations.AddRuleDetail(null, s179Header.ToString(), S179RulePropertyId.ToString(), zoneId.ToString(), s179DTO.Zone, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), qualByDefault.ToString(), null, s179DTO.IsQualifiedByDefault, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179BaseLimit.ToString(), null, s179DTO.BaseLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179ThresholdLimit.ToString(), null, s179DTO.ThresholdLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179PercentThresholdLimit.ToString(), null, s179DTO.PercentThresholdLimit, 1, 0, 0);
                    if (null != s179DTO.Classifications && s179DTO.Classifications.Count > 0)
                    {
                        foreach (var classification in s179DTO.Classifications)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(),
                                                             s179ClassificationRulePropertyId.ToString(),
                                                             classification.Value, classification.Key, 1, 0, 0);
                        }
                    }
                    if (!string.IsNullOrEmpty(s179DTO.EstimatedLife) && s179DTO.EstimatedLife.Contains(','))
                    {
                        string[] els = s179DTO.EstimatedLife.Split(',');
                        foreach (string el in els)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, el, 1, 0, 0);
                        }
                    }
                    else if (!string.IsNullOrEmpty(s179DTO.EstimatedLife))
                    {
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, s179DTO.EstimatedLife, 1, 0, 0);
                    }
                    if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod) && s179DTO.DepreciationMethod.Contains(','))
                    {
                        string[] dms = s179DTO.DepreciationMethod.Split(',');
                        foreach (string dm in dms)
                        {
                            Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(dm);
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), dm, 1, 0, 0);
                        }
                    }

                    else if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod))
                    {
                        Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(s179DTO.DepreciationMethod);
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), s179DTO.DepreciationMethod, 1, 0, 0);
                    }

                }
                Console.WriteLine("COQ");
                Console.WriteLine("\n\n");
            }
            if (allPropertyS179.ContainsKey("CSW"))
            {
                List<S179DTO> s179List = allPropertyS179["CSW"];
                foreach (S179DTO s179DTO in s179List)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(cswId);
                    Guid zoneId = databaseOperations.GetZoneIdBasedOnZoneCode(s179DTO.Zone);

                    Guid s179Header = databaseOperations.AddRuleHeader(zoneId, S179RulePropertyId, s179DTO.EffectiveDate, s179DTO.ExpiryDate, def.ToString(), 1);
                    Guid s179DetailHeader = databaseOperations.AddRuleDetail(null, s179Header.ToString(), S179RulePropertyId.ToString(), zoneId.ToString(), s179DTO.Zone, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), qualByDefault.ToString(), null, s179DTO.IsQualifiedByDefault, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179BaseLimit.ToString(), null, s179DTO.BaseLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179ThresholdLimit.ToString(), null, s179DTO.ThresholdLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179PercentThresholdLimit.ToString(), null, s179DTO.PercentThresholdLimit, 1, 0, 0);
                    if (null != s179DTO.Classifications && s179DTO.Classifications.Count > 0)
                    {
                        foreach (var classification in s179DTO.Classifications)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(),
                                                             s179ClassificationRulePropertyId.ToString(),
                                                             classification.Value, classification.Key, 1, 0, 0);
                        }
                    }
                    if (!string.IsNullOrEmpty(s179DTO.EstimatedLife) && s179DTO.EstimatedLife.Contains(','))
                    {
                        string[] els = s179DTO.EstimatedLife.Split(',');
                        foreach (string el in els)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, el, 1, 0, 0);
                        }
                    }
                    else if (!string.IsNullOrEmpty(s179DTO.EstimatedLife))
                    {
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, s179DTO.EstimatedLife, 1, 0, 0);
                    }
                    if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod) && s179DTO.DepreciationMethod.Contains(','))
                    {
                        string[] dms = s179DTO.DepreciationMethod.Split(',');
                        foreach (string dm in dms)
                        {
                            Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(dm);
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), dm, 1, 0, 0);
                        }
                    }

                    else if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod))
                    {
                        Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(s179DTO.DepreciationMethod);
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), s179DTO.DepreciationMethod, 1, 0, 0);
                    }

                }
                Console.WriteLine("CSW");
                Console.WriteLine("\n\n");
            }
            if (allPropertyS179.ContainsKey("FFE"))
            {
                List<S179DTO> s179List = allPropertyS179["FFE"];
                foreach (S179DTO s179DTO in s179List)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(ffeId);
                    Guid zoneId = databaseOperations.GetZoneIdBasedOnZoneCode(s179DTO.Zone);

                    Guid s179Header = databaseOperations.AddRuleHeader(zoneId, S179RulePropertyId, s179DTO.EffectiveDate, s179DTO.ExpiryDate, def.ToString(), 1);
                    Guid s179DetailHeader = databaseOperations.AddRuleDetail(null, s179Header.ToString(), S179RulePropertyId.ToString(), zoneId.ToString(), s179DTO.Zone, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), qualByDefault.ToString(), null, s179DTO.IsQualifiedByDefault, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179BaseLimit.ToString(), null, s179DTO.BaseLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179ThresholdLimit.ToString(), null, s179DTO.ThresholdLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179PercentThresholdLimit.ToString(), null, s179DTO.PercentThresholdLimit, 1, 0, 0);
                    if (null != s179DTO.Classifications && s179DTO.Classifications.Count > 0)
                    {
                        foreach (var classification in s179DTO.Classifications)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(),
                                                             s179ClassificationRulePropertyId.ToString(),
                                                             classification.Value, classification.Key, 1, 0, 0);
                        }
                    }
                    if (!string.IsNullOrEmpty(s179DTO.EstimatedLife) && s179DTO.EstimatedLife.Contains(','))
                    {
                        string[] els = s179DTO.EstimatedLife.Split(',');
                        foreach (string el in els)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, el, 1, 0, 0);
                        }
                    }
                    else if (!string.IsNullOrEmpty(s179DTO.EstimatedLife))
                    {
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, s179DTO.EstimatedLife, 1, 0, 0);
                    }
                    if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod) && s179DTO.DepreciationMethod.Contains(','))
                    {
                        string[] dms = s179DTO.DepreciationMethod.Split(',');
                        foreach (string dm in dms)
                        {
                            Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(dm);
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), dm, 1, 0, 0);
                        }
                    }

                    else if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod))
                    {
                        Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(s179DTO.DepreciationMethod);
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), s179DTO.DepreciationMethod, 1, 0, 0);
                    }

                }
                Console.WriteLine("FFE");
                Console.WriteLine("\n\n");
            }
            if (allPropertyS179.ContainsKey("INT"))
            {
                List<S179DTO> s179List = allPropertyS179["INT"];
                foreach (S179DTO s179DTO in s179List)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(intId);
                    Guid zoneId = databaseOperations.GetZoneIdBasedOnZoneCode(s179DTO.Zone);

                    Guid s179Header = databaseOperations.AddRuleHeader(zoneId, S179RulePropertyId, s179DTO.EffectiveDate, s179DTO.ExpiryDate, def.ToString(), 1);
                    Guid s179DetailHeader = databaseOperations.AddRuleDetail(null, s179Header.ToString(), S179RulePropertyId.ToString(), zoneId.ToString(), s179DTO.Zone, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), qualByDefault.ToString(), null, s179DTO.IsQualifiedByDefault, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179BaseLimit.ToString(), null, s179DTO.BaseLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179ThresholdLimit.ToString(), null, s179DTO.ThresholdLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179PercentThresholdLimit.ToString(), null, s179DTO.PercentThresholdLimit, 1, 0, 0);
                    if (null != s179DTO.Classifications && s179DTO.Classifications.Count > 0)
                    {
                        foreach (var classification in s179DTO.Classifications)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(),
                                                             s179ClassificationRulePropertyId.ToString(),
                                                             classification.Value, classification.Key, 1, 0, 0);
                        }
                    }
                    if (!string.IsNullOrEmpty(s179DTO.EstimatedLife) && s179DTO.EstimatedLife.Contains(','))
                    {
                        string[] els = s179DTO.EstimatedLife.Split(',');
                        foreach (string el in els)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, el, 1, 0, 0);
                        }
                    }
                    else if (!string.IsNullOrEmpty(s179DTO.EstimatedLife))
                    {
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, s179DTO.EstimatedLife, 1, 0, 0);
                    }
                    if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod) && s179DTO.DepreciationMethod.Contains(','))
                    {
                        string[] dms = s179DTO.DepreciationMethod.Split(',');
                        foreach (string dm in dms)
                        {
                            Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(dm);
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), dm, 1, 0, 0);
                        }
                    }

                    else if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod))
                    {
                        Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(s179DTO.DepreciationMethod);
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), s179DTO.DepreciationMethod, 1, 0, 0);
                    }

                }
                Console.WriteLine("INT");
                Console.WriteLine("\n\n");
            }
            if (allPropertyS179.ContainsKey("LDI"))
            {
                List<S179DTO> s179List = allPropertyS179["LDI"];
                foreach (S179DTO s179DTO in s179List)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(ldiId);
                    Guid zoneId = databaseOperations.GetZoneIdBasedOnZoneCode(s179DTO.Zone);

                    Guid s179Header = databaseOperations.AddRuleHeader(zoneId, S179RulePropertyId, s179DTO.EffectiveDate, s179DTO.ExpiryDate, def.ToString(), 1);
                    Guid s179DetailHeader = databaseOperations.AddRuleDetail(null, s179Header.ToString(), S179RulePropertyId.ToString(), zoneId.ToString(), s179DTO.Zone, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), qualByDefault.ToString(), null, s179DTO.IsQualifiedByDefault, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179BaseLimit.ToString(), null, s179DTO.BaseLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179ThresholdLimit.ToString(), null, s179DTO.ThresholdLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179PercentThresholdLimit.ToString(), null, s179DTO.PercentThresholdLimit, 1, 0, 0);
                    if (null != s179DTO.Classifications && s179DTO.Classifications.Count > 0)
                    {
                        foreach (var classification in s179DTO.Classifications)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(),
                                                             s179ClassificationRulePropertyId.ToString(),
                                                             classification.Value, classification.Key, 1, 0, 0);
                        }
                    }
                    if (!string.IsNullOrEmpty(s179DTO.EstimatedLife) && s179DTO.EstimatedLife.Contains(','))
                    {
                        string[] els = s179DTO.EstimatedLife.Split(',');
                        foreach (string el in els)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, el, 1, 0, 0);
                        }
                    }
                    else if (!string.IsNullOrEmpty(s179DTO.EstimatedLife))
                    {
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, s179DTO.EstimatedLife, 1, 0, 0);
                    }
                    if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod) && s179DTO.DepreciationMethod.Contains(','))
                    {
                        string[] dms = s179DTO.DepreciationMethod.Split(',');
                        foreach (string dm in dms)
                        {
                            Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(dm);
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), dm, 1, 0, 0);
                        }
                    }

                    else if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod))
                    {
                        Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(s179DTO.DepreciationMethod);
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), s179DTO.DepreciationMethod, 1, 0, 0);
                    }

                }
                Console.WriteLine("LDI");
                Console.WriteLine("\n\n");
            }
            if (allPropertyS179.ContainsKey("LHI"))
            {
                List<S179DTO> s179List = allPropertyS179["LHI"];
                foreach (S179DTO s179DTO in s179List)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(lhiId);
                    Guid zoneId = databaseOperations.GetZoneIdBasedOnZoneCode(s179DTO.Zone);

                    Guid s179Header = databaseOperations.AddRuleHeader(zoneId, S179RulePropertyId, s179DTO.EffectiveDate, s179DTO.ExpiryDate, def.ToString(), 1);
                    Guid s179DetailHeader = databaseOperations.AddRuleDetail(null, s179Header.ToString(), S179RulePropertyId.ToString(), zoneId.ToString(), s179DTO.Zone, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), qualByDefault.ToString(), null, s179DTO.IsQualifiedByDefault, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179BaseLimit.ToString(), null, s179DTO.BaseLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179ThresholdLimit.ToString(), null, s179DTO.ThresholdLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179PercentThresholdLimit.ToString(), null, s179DTO.PercentThresholdLimit, 1, 0, 0);
                    if (null != s179DTO.Classifications && s179DTO.Classifications.Count > 0)
                    {
                        foreach (var classification in s179DTO.Classifications)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(),
                                                             s179ClassificationRulePropertyId.ToString(),
                                                             classification.Value, classification.Key, 1, 0, 0);
                        }
                    }
                    if (!string.IsNullOrEmpty(s179DTO.EstimatedLife) && s179DTO.EstimatedLife.Contains(','))
                    {
                        string[] els = s179DTO.EstimatedLife.Split(',');
                        foreach (string el in els)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, el, 1, 0, 0);
                        }
                    }
                    else if (!string.IsNullOrEmpty(s179DTO.EstimatedLife))
                    {
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, s179DTO.EstimatedLife, 1, 0, 0);
                    }
                    if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod) && s179DTO.DepreciationMethod.Contains(','))
                    {
                        string[] dms = s179DTO.DepreciationMethod.Split(',');
                        foreach (string dm in dms)
                        {
                            Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(dm);
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), dm, 1, 0, 0);
                        }
                    }

                    else if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod))
                    {
                        Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(s179DTO.DepreciationMethod);
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), s179DTO.DepreciationMethod, 1, 0, 0);
                    }

                }
                Console.WriteLine("LHI");
                Console.WriteLine("\n\n");
            }
            if (allPropertyS179.ContainsKey("LND"))
            {
                List<S179DTO> s179List = allPropertyS179["LND"];
                foreach (S179DTO s179DTO in s179List)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(lndId);
                    Guid zoneId = databaseOperations.GetZoneIdBasedOnZoneCode(s179DTO.Zone);

                    Guid s179Header = databaseOperations.AddRuleHeader(zoneId, S179RulePropertyId, s179DTO.EffectiveDate, s179DTO.ExpiryDate, def.ToString(), 1);
                    Guid s179DetailHeader = databaseOperations.AddRuleDetail(null, s179Header.ToString(), S179RulePropertyId.ToString(), zoneId.ToString(), s179DTO.Zone, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), qualByDefault.ToString(), null, s179DTO.IsQualifiedByDefault, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179BaseLimit.ToString(), null, s179DTO.BaseLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179ThresholdLimit.ToString(), null, s179DTO.ThresholdLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179PercentThresholdLimit.ToString(), null, s179DTO.PercentThresholdLimit, 1, 0, 0);
                    if (null != s179DTO.Classifications && s179DTO.Classifications.Count > 0)
                    {
                        foreach (var classification in s179DTO.Classifications)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(),
                                                             s179ClassificationRulePropertyId.ToString(),
                                                             classification.Value, classification.Key, 1, 0, 0);
                        }
                    }
                    if (!string.IsNullOrEmpty(s179DTO.EstimatedLife) && s179DTO.EstimatedLife.Contains(','))
                    {
                        string[] els = s179DTO.EstimatedLife.Split(',');
                        foreach (string el in els)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, el, 1, 0, 0);
                        }
                    }
                    else if (!string.IsNullOrEmpty(s179DTO.EstimatedLife))
                    {
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, s179DTO.EstimatedLife, 1, 0, 0);
                    }
                    if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod) && s179DTO.DepreciationMethod.Contains(','))
                    {
                        string[] dms = s179DTO.DepreciationMethod.Split(',');
                        foreach (string dm in dms)
                        {
                            Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(dm);
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), dm, 1, 0, 0);
                        }
                    }

                    else if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod))
                    {
                        Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(s179DTO.DepreciationMethod);
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), s179DTO.DepreciationMethod, 1, 0, 0);
                    }

                }
                Console.WriteLine("LND");
                Console.WriteLine("\n\n");
            }
            if (allPropertyS179.ContainsKey("MFG"))
            {
                List<S179DTO> s179List = allPropertyS179["MFG"];
                foreach (S179DTO s179DTO in s179List)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(mfgId);
                    Guid zoneId = databaseOperations.GetZoneIdBasedOnZoneCode(s179DTO.Zone);

                    Guid s179Header = databaseOperations.AddRuleHeader(zoneId, S179RulePropertyId, s179DTO.EffectiveDate, s179DTO.ExpiryDate, def.ToString(), 1);
                    Guid s179DetailHeader = databaseOperations.AddRuleDetail(null, s179Header.ToString(), S179RulePropertyId.ToString(), zoneId.ToString(), s179DTO.Zone, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), qualByDefault.ToString(), null, s179DTO.IsQualifiedByDefault, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179BaseLimit.ToString(), null, s179DTO.BaseLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179ThresholdLimit.ToString(), null, s179DTO.ThresholdLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179PercentThresholdLimit.ToString(), null, s179DTO.PercentThresholdLimit, 1, 0, 0);
                    if (null != s179DTO.Classifications && s179DTO.Classifications.Count > 0)
                    {
                        foreach (var classification in s179DTO.Classifications)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(),
                                                             s179ClassificationRulePropertyId.ToString(),
                                                             classification.Value, classification.Key, 1, 0, 0);
                        }
                    }
                    if (!string.IsNullOrEmpty(s179DTO.EstimatedLife) && s179DTO.EstimatedLife.Contains(','))
                    {
                        string[] els = s179DTO.EstimatedLife.Split(',');
                        foreach (string el in els)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, el, 1, 0, 0);
                        }
                    }
                    else if (!string.IsNullOrEmpty(s179DTO.EstimatedLife))
                    {
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, s179DTO.EstimatedLife, 1, 0, 0);
                    }
                    if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod) && s179DTO.DepreciationMethod.Contains(','))
                    {
                        string[] dms = s179DTO.DepreciationMethod.Split(',');
                        foreach (string dm in dms)
                        {
                            Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(dm);
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), dm, 1, 0, 0);
                        }
                    }

                    else if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod))
                    {
                        Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(s179DTO.DepreciationMethod);
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), s179DTO.DepreciationMethod, 1, 0, 0);
                    }

                }
                Console.WriteLine("MFG");
                Console.WriteLine("\n\n");
            }
            if (allPropertyS179.ContainsKey("PPN"))
            {
                List<S179DTO> s179List = allPropertyS179["PPN"];
                foreach (S179DTO s179DTO in s179List)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(ppnId);
                    Guid zoneId = databaseOperations.GetZoneIdBasedOnZoneCode(s179DTO.Zone);

                    Guid s179Header = databaseOperations.AddRuleHeader(zoneId, S179RulePropertyId, s179DTO.EffectiveDate, s179DTO.ExpiryDate, def.ToString(), 1);
                    Guid s179DetailHeader = databaseOperations.AddRuleDetail(null, s179Header.ToString(), S179RulePropertyId.ToString(), zoneId.ToString(), s179DTO.Zone, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), qualByDefault.ToString(), null, s179DTO.IsQualifiedByDefault, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179BaseLimit.ToString(), null, s179DTO.BaseLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179ThresholdLimit.ToString(), null, s179DTO.ThresholdLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179PercentThresholdLimit.ToString(), null, s179DTO.PercentThresholdLimit, 1, 0, 0);
                    if (null != s179DTO.Classifications && s179DTO.Classifications.Count > 0)
                    {
                        foreach (var classification in s179DTO.Classifications)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(),
                                                             s179ClassificationRulePropertyId.ToString(),
                                                             classification.Value, classification.Key, 1, 0, 0);
                        }
                    }
                    if (!string.IsNullOrEmpty(s179DTO.EstimatedLife) && s179DTO.EstimatedLife.Contains(','))
                    {
                        string[] els = s179DTO.EstimatedLife.Split(',');
                        foreach (string el in els)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, el, 1, 0, 0);
                        }
                    }
                    else if (!string.IsNullOrEmpty(s179DTO.EstimatedLife))
                    {
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, s179DTO.EstimatedLife, 1, 0, 0);
                    }
                    if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod) && s179DTO.DepreciationMethod.Contains(','))
                    {
                        string[] dms = s179DTO.DepreciationMethod.Split(',');
                        foreach (string dm in dms)
                        {
                            Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(dm);
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), dm, 1, 0, 0);
                        }
                    }

                    else if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod))
                    {
                        Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(s179DTO.DepreciationMethod);
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), s179DTO.DepreciationMethod, 1, 0, 0);
                    }

                }
                Console.WriteLine("PPN");
                Console.WriteLine("\n\n");
            }
            if (allPropertyS179.ContainsKey("RPN"))
            {
                List<S179DTO> s179List = allPropertyS179["RPN"];
                foreach (S179DTO s179DTO in s179List)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(rpnId);
                    Guid zoneId = databaseOperations.GetZoneIdBasedOnZoneCode(s179DTO.Zone);

                    Guid s179Header = databaseOperations.AddRuleHeader(zoneId, S179RulePropertyId, s179DTO.EffectiveDate, s179DTO.ExpiryDate, def.ToString(), 1);
                    Guid s179DetailHeader = databaseOperations.AddRuleDetail(null, s179Header.ToString(), S179RulePropertyId.ToString(), zoneId.ToString(), s179DTO.Zone, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), qualByDefault.ToString(), null, s179DTO.IsQualifiedByDefault, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179BaseLimit.ToString(), null, s179DTO.BaseLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179ThresholdLimit.ToString(), null, s179DTO.ThresholdLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179PercentThresholdLimit.ToString(), null, s179DTO.PercentThresholdLimit, 1, 0, 0);
                    if (null != s179DTO.Classifications && s179DTO.Classifications.Count > 0)
                    {
                        foreach (var classification in s179DTO.Classifications)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(),
                                                             s179ClassificationRulePropertyId.ToString(),
                                                             classification.Value, classification.Key, 1, 0, 0);
                        }
                    }
                    if (!string.IsNullOrEmpty(s179DTO.EstimatedLife) && s179DTO.EstimatedLife.Contains(','))
                    {
                        string[] els = s179DTO.EstimatedLife.Split(',');
                        foreach (string el in els)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, el, 1, 0, 0);
                        }
                    }
                    else if (!string.IsNullOrEmpty(s179DTO.EstimatedLife))
                    {
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, s179DTO.EstimatedLife, 1, 0, 0);
                    }
                    if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod) && s179DTO.DepreciationMethod.Contains(','))
                    {
                        string[] dms = s179DTO.DepreciationMethod.Split(',');
                        foreach (string dm in dms)
                        {
                            Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(dm);
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), dm, 1, 0, 0);
                        }
                    }

                    else if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod))
                    {
                        Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(s179DTO.DepreciationMethod);
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), s179DTO.DepreciationMethod, 1, 0, 0);
                    }

                }
                Console.WriteLine("RPN");
                Console.WriteLine("\n\n");
            }
            if (allPropertyS179.ContainsKey("RRB"))
            {
                List<S179DTO> s179List = allPropertyS179["RRB"];
                foreach (S179DTO s179DTO in s179List)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(rrbId);
                    Guid zoneId = databaseOperations.GetZoneIdBasedOnZoneCode(s179DTO.Zone);

                    Guid s179Header = databaseOperations.AddRuleHeader(zoneId, S179RulePropertyId, s179DTO.EffectiveDate, s179DTO.ExpiryDate, def.ToString(), 1);
                    Guid s179DetailHeader = databaseOperations.AddRuleDetail(null, s179Header.ToString(), S179RulePropertyId.ToString(), zoneId.ToString(), s179DTO.Zone, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), qualByDefault.ToString(), null, s179DTO.IsQualifiedByDefault, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179BaseLimit.ToString(), null, s179DTO.BaseLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179ThresholdLimit.ToString(), null, s179DTO.ThresholdLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179PercentThresholdLimit.ToString(), null, s179DTO.PercentThresholdLimit, 1, 0, 0);
                    if (null != s179DTO.Classifications && s179DTO.Classifications.Count > 0)
                    {
                        foreach (var classification in s179DTO.Classifications)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(),
                                                             s179ClassificationRulePropertyId.ToString(),
                                                             classification.Value, classification.Key, 1, 0, 0);
                        }
                    }
                    if (!string.IsNullOrEmpty(s179DTO.EstimatedLife) && s179DTO.EstimatedLife.Contains(','))
                    {
                        string[] els = s179DTO.EstimatedLife.Split(',');
                        foreach (string el in els)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, el, 1, 0, 0);
                        }
                    }
                    else if (!string.IsNullOrEmpty(s179DTO.EstimatedLife))
                    {
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, s179DTO.EstimatedLife, 1, 0, 0);
                    }
                    if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod) && s179DTO.DepreciationMethod.Contains(','))
                    {
                        string[] dms = s179DTO.DepreciationMethod.Split(',');
                        foreach (string dm in dms)
                        {
                            Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(dm);
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), dm, 1, 0, 0);
                        }
                    }

                    else if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod))
                    {
                        Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(s179DTO.DepreciationMethod);
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), s179DTO.DepreciationMethod, 1, 0, 0);
                    }

                }
                Console.WriteLine("RRB");
                Console.WriteLine("\n\n");
            }
            if (allPropertyS179.ContainsKey("TLR"))
            {
                List<S179DTO> s179List = allPropertyS179["TLR"];
                foreach (S179DTO s179DTO in s179List)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(tlrId);
                    Guid zoneId = databaseOperations.GetZoneIdBasedOnZoneCode(s179DTO.Zone);

                    Guid s179Header = databaseOperations.AddRuleHeader(zoneId, S179RulePropertyId, s179DTO.EffectiveDate, s179DTO.ExpiryDate, def.ToString(), 1);
                    Guid s179DetailHeader = databaseOperations.AddRuleDetail(null, s179Header.ToString(), S179RulePropertyId.ToString(), zoneId.ToString(), s179DTO.Zone, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), qualByDefault.ToString(), null, s179DTO.IsQualifiedByDefault, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179BaseLimit.ToString(), null, s179DTO.BaseLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179ThresholdLimit.ToString(), null, s179DTO.ThresholdLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179PercentThresholdLimit.ToString(), null, s179DTO.PercentThresholdLimit, 1, 0, 0);
                    if (null != s179DTO.Classifications && s179DTO.Classifications.Count > 0)
                    {
                        foreach (var classification in s179DTO.Classifications)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(),
                                                             s179ClassificationRulePropertyId.ToString(),
                                                             classification.Value, classification.Key, 1, 0, 0);
                        }
                    }
                    if (!string.IsNullOrEmpty(s179DTO.EstimatedLife) && s179DTO.EstimatedLife.Contains(','))
                    {
                        string[] els = s179DTO.EstimatedLife.Split(',');
                        foreach (string el in els)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, el, 1, 0, 0);
                        }
                    }
                    else if (!string.IsNullOrEmpty(s179DTO.EstimatedLife))
                    {
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, s179DTO.EstimatedLife, 1, 0, 0);
                    }
                    if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod) && s179DTO.DepreciationMethod.Contains(','))
                    {
                        string[] dms = s179DTO.DepreciationMethod.Split(',');
                        foreach (string dm in dms)
                        {
                            Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(dm);
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), dm, 1, 0, 0);
                        }
                    }

                    else if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod))
                    {
                        Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(s179DTO.DepreciationMethod);
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), s179DTO.DepreciationMethod, 1, 0, 0);
                    }

                }
                Console.WriteLine("TLR");
                Console.WriteLine("\n\n");
            }
            if (allPropertyS179.ContainsKey("TRH"))
            {
                List<S179DTO> s179List = allPropertyS179["TRH"];
                foreach (S179DTO s179DTO in s179List)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(trhId);
                    Guid zoneId = databaseOperations.GetZoneIdBasedOnZoneCode(s179DTO.Zone);

                    Guid s179Header = databaseOperations.AddRuleHeader(zoneId, S179RulePropertyId, s179DTO.EffectiveDate, s179DTO.ExpiryDate, def.ToString(), 1);
                    Guid s179DetailHeader = databaseOperations.AddRuleDetail(null, s179Header.ToString(), S179RulePropertyId.ToString(), zoneId.ToString(), s179DTO.Zone, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), qualByDefault.ToString(), null, s179DTO.IsQualifiedByDefault, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179BaseLimit.ToString(), null, s179DTO.BaseLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179ThresholdLimit.ToString(), null, s179DTO.ThresholdLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179PercentThresholdLimit.ToString(), null, s179DTO.PercentThresholdLimit, 1, 0, 0); 
                    if (null != s179DTO.Classifications && s179DTO.Classifications.Count > 0)
                    {
                        foreach (var classification in s179DTO.Classifications)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(),
                                                             s179ClassificationRulePropertyId.ToString(),
                                                             classification.Value, classification.Key, 1, 0, 0);
                        }
                    }
                    if (!string.IsNullOrEmpty(s179DTO.EstimatedLife) && s179DTO.EstimatedLife.Contains(','))
                    {
                        string[] els = s179DTO.EstimatedLife.Split(',');
                        foreach (string el in els)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, el, 1, 0, 0);
                        }
                    }
                    else if (!string.IsNullOrEmpty(s179DTO.EstimatedLife))
                    {
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, s179DTO.EstimatedLife, 1, 0, 0);
                    }
                    if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod) && s179DTO.DepreciationMethod.Contains(','))
                    {
                        string[] dms = s179DTO.DepreciationMethod.Split(',');
                        foreach (string dm in dms)
                        {
                            Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(dm);
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), dm, 1, 0, 0);
                        }
                    }

                    else if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod))
                    {
                        Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(s179DTO.DepreciationMethod);
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), s179DTO.DepreciationMethod, 1, 0, 0);
                    }

                }
                Console.WriteLine("TRH");
                Console.WriteLine("\n\n");
            }
            if (allPropertyS179.ContainsKey("LTV"))
            {
                List<S179DTO> s179List = allPropertyS179["LTV"];
                foreach (S179DTO s179DTO in s179List)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(ltvId);
                    Guid zoneId = databaseOperations.GetZoneIdBasedOnZoneCode(s179DTO.Zone);

                    Guid s179Header = databaseOperations.AddRuleHeader(zoneId, S179RulePropertyId, s179DTO.EffectiveDate, s179DTO.ExpiryDate, def.ToString(), 1);
                    Guid s179DetailHeader = databaseOperations.AddRuleDetail(null, s179Header.ToString(), S179RulePropertyId.ToString(), zoneId.ToString(), s179DTO.Zone, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), qualByDefault.ToString(), null, s179DTO.IsQualifiedByDefault, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179BaseLimit.ToString(), null, s179DTO.BaseLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179ThresholdLimit.ToString(), null, s179DTO.ThresholdLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179PercentThresholdLimit.ToString(), null, s179DTO.PercentThresholdLimit, 1, 0, 0);
                    if (null != s179DTO.Classifications && s179DTO.Classifications.Count > 0)
                    {
                        foreach (var classification in s179DTO.Classifications)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(),
                                                             s179ClassificationRulePropertyId.ToString(),
                                                             classification.Value, classification.Key, 1, 0, 0);
                        }
                    }
                    if (!string.IsNullOrEmpty(s179DTO.EstimatedLife) && s179DTO.EstimatedLife.Contains(','))
                    {
                        string[] els = s179DTO.EstimatedLife.Split(',');
                        foreach (string el in els)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, el, 1, 0, 0);
                        }
                    }
                    else if (!string.IsNullOrEmpty(s179DTO.EstimatedLife))
                    {
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, s179DTO.EstimatedLife, 1, 0, 0);
                    }
                    if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod) && s179DTO.DepreciationMethod.Contains(','))
                    {
                        string[] dms = s179DTO.DepreciationMethod.Split(',');
                        foreach (string dm in dms)
                        {
                            Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(dm);
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), dm, 1, 0, 0);
                        }
                    }

                    else if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod))
                    {
                        Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(s179DTO.DepreciationMethod);
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), s179DTO.DepreciationMethod, 1, 0, 0);
                    }

                }
                Console.WriteLine("LTV");
                Console.WriteLine("\n\n");
            }
            if (allPropertyS179.ContainsKey("UNT"))
            {
                List<S179DTO> s179List = allPropertyS179["UNT"];
                foreach (S179DTO s179DTO in s179List)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(untId);
                    Guid zoneId = databaseOperations.GetZoneIdBasedOnZoneCode(s179DTO.Zone);

                    Guid s179Header = databaseOperations.AddRuleHeader(zoneId, S179RulePropertyId, s179DTO.EffectiveDate, s179DTO.ExpiryDate, def.ToString(), 1);
                    Guid s179DetailHeader = databaseOperations.AddRuleDetail(null, s179Header.ToString(), S179RulePropertyId.ToString(), zoneId.ToString(), s179DTO.Zone, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), qualByDefault.ToString(), null, s179DTO.IsQualifiedByDefault, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179BaseLimit.ToString(), null, s179DTO.BaseLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179ThresholdLimit.ToString(), null, s179DTO.ThresholdLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179PercentThresholdLimit.ToString(), null, s179DTO.PercentThresholdLimit, 1, 0, 0);
                    if (null != s179DTO.Classifications && s179DTO.Classifications.Count > 0)
                    {
                        foreach (var classification in s179DTO.Classifications)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(),
                                                             s179ClassificationRulePropertyId.ToString(),
                                                             classification.Value, classification.Key, 1, 0, 0);
                        }
                    }
                    if (!string.IsNullOrEmpty(s179DTO.EstimatedLife) && s179DTO.EstimatedLife.Contains(','))
                    {
                        string[] els = s179DTO.EstimatedLife.Split(',');
                        foreach (string el in els)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, el, 1, 0, 0);
                        }
                    }
                    else if (!string.IsNullOrEmpty(s179DTO.EstimatedLife))
                    {
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, s179DTO.EstimatedLife, 1, 0, 0);
                    }
                    if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod) && s179DTO.DepreciationMethod.Contains(','))
                    {
                        string[] dms = s179DTO.DepreciationMethod.Split(',');
                        foreach (string dm in dms)
                        {
                            Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(dm);
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), dm, 1, 0, 0);
                        }
                    }

                    else if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod))
                    {
                        Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(s179DTO.DepreciationMethod);
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), s179DTO.DepreciationMethod, 1, 0, 0);
                    }

                }
                Console.WriteLine("UNT");
                Console.WriteLine("\n\n");
            }
            if (allPropertyS179.ContainsKey("WRS"))
            {
                List<S179DTO> s179List = allPropertyS179["WRS"];
                foreach (S179DTO s179DTO in s179List)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(wrsId);
                    Guid zoneId = databaseOperations.GetZoneIdBasedOnZoneCode(s179DTO.Zone);

                    Guid s179Header = databaseOperations.AddRuleHeader(zoneId, S179RulePropertyId, s179DTO.EffectiveDate, s179DTO.ExpiryDate, def.ToString(), 1);
                    Guid s179DetailHeader = databaseOperations.AddRuleDetail(null, s179Header.ToString(), S179RulePropertyId.ToString(), zoneId.ToString(), s179DTO.Zone, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), qualByDefault.ToString(), null, s179DTO.IsQualifiedByDefault, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179BaseLimit.ToString(), null, s179DTO.BaseLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179ThresholdLimit.ToString(), null, s179DTO.ThresholdLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179PercentThresholdLimit.ToString(), null, s179DTO.PercentThresholdLimit, 1, 0, 0);
                    if (null != s179DTO.Classifications && s179DTO.Classifications.Count > 0)
                    {
                        foreach (var classification in s179DTO.Classifications)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(),
                                                             s179ClassificationRulePropertyId.ToString(),
                                                             classification.Value, classification.Key, 1, 0, 0);
                        }
                    }
                    if (!string.IsNullOrEmpty(s179DTO.EstimatedLife) && s179DTO.EstimatedLife.Contains(','))
                    {
                        string[] els = s179DTO.EstimatedLife.Split(',');
                        foreach (string el in els)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, el, 1, 0, 0);
                        }
                    }
                    else if (!string.IsNullOrEmpty(s179DTO.EstimatedLife))
                    {
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, s179DTO.EstimatedLife, 1, 0, 0);
                    }
                    if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod) && s179DTO.DepreciationMethod.Contains(','))
                    {
                        string[] dms = s179DTO.DepreciationMethod.Split(',');
                        foreach (string dm in dms)
                        {
                            Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(dm);
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), dm, 1, 0, 0);
                        }
                    }

                    else if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod))
                    {
                        Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(s179DTO.DepreciationMethod);
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), s179DTO.DepreciationMethod, 1, 0, 0);
                    }

                }
                Console.WriteLine("WRS");
                Console.WriteLine("\n\n");
            }
            if (allPropertyS179.ContainsKey("CST"))
            {
                List<S179DTO> s179List = allPropertyS179["CST"];
                foreach (S179DTO s179DTO in s179List)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(cstId);
                    Guid zoneId = databaseOperations.GetZoneIdBasedOnZoneCode(s179DTO.Zone);

                    Guid s179Header = databaseOperations.AddRuleHeader(zoneId, S179RulePropertyId, s179DTO.EffectiveDate, s179DTO.ExpiryDate, def.ToString(), 1);
                    Guid s179DetailHeader = databaseOperations.AddRuleDetail(null, s179Header.ToString(), S179RulePropertyId.ToString(), zoneId.ToString(), s179DTO.Zone, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), qualByDefault.ToString(), null, s179DTO.IsQualifiedByDefault, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179BaseLimit.ToString(), null, s179DTO.BaseLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179ThresholdLimit.ToString(), null, s179DTO.ThresholdLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179PercentThresholdLimit.ToString(), null, s179DTO.PercentThresholdLimit, 1, 0, 0);
                    if (null != s179DTO.Classifications && s179DTO.Classifications.Count > 0)
                    {
                        foreach (var classification in s179DTO.Classifications)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(),
                                                             s179ClassificationRulePropertyId.ToString(),
                                                             classification.Value, classification.Key, 1, 0, 0);
                        }
                    }
                    if (!string.IsNullOrEmpty(s179DTO.EstimatedLife) && s179DTO.EstimatedLife.Contains(','))
                    {
                        string[] els = s179DTO.EstimatedLife.Split(',');
                        foreach (string el in els)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, el, 1, 0, 0);
                        }
                    }
                    else if (!string.IsNullOrEmpty(s179DTO.EstimatedLife))
                    {
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, s179DTO.EstimatedLife, 1, 0, 0);
                    }
                    if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod) && s179DTO.DepreciationMethod.Contains(','))
                    {
                        string[] dms = s179DTO.DepreciationMethod.Split(',');
                        foreach (string dm in dms)
                        {
                            Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(dm);
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), dm, 1, 0, 0);
                        }
                    }

                    else if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod))
                    {
                        Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(s179DTO.DepreciationMethod);
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), s179DTO.DepreciationMethod, 1, 0, 0);
                    }

                }
                Console.WriteLine("CST");
                Console.WriteLine("\n\n");
            }

            if (allPropertyS179.ContainsKey("SUV"))
            {
                List<S179DTO> s179List = allPropertyS179["SUV"];
                foreach (S179DTO s179DTO in s179List)
                {
                    Guid def = databaseOperations.GetRuleDefColumnBasedOnRulePropertyId(suvId);
                    Guid zoneId = databaseOperations.GetZoneIdBasedOnZoneCode(s179DTO.Zone);

                    Guid s179Header = databaseOperations.AddRuleHeader(zoneId, S179RulePropertyId, s179DTO.EffectiveDate, s179DTO.ExpiryDate, def.ToString(), 1);
                    Guid s179DetailHeader = databaseOperations.AddRuleDetail(null, s179Header.ToString(), S179RulePropertyId.ToString(), zoneId.ToString(), s179DTO.Zone, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), qualByDefault.ToString(), null, s179DTO.IsQualifiedByDefault, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179BaseLimit.ToString(), null, s179DTO.BaseLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179ThresholdLimit.ToString(), null, s179DTO.ThresholdLimit, 1, 0, 0);
                    databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), s179PercentThresholdLimit.ToString(), null, s179DTO.PercentThresholdLimit, 1, 0, 0); 
                    if (null != s179DTO.Classifications && s179DTO.Classifications.Count > 0)
                    {
                        foreach (var classification in s179DTO.Classifications)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(),
                                                             s179ClassificationRulePropertyId.ToString(),
                                                             classification.Value, classification.Key, 1, 0, 0);
                        }
                    }
                    if (!string.IsNullOrEmpty(s179DTO.EstimatedLife) && s179DTO.EstimatedLife.Contains(','))
                    {
                        string[] els = s179DTO.EstimatedLife.Split(',');
                        foreach (string el in els)
                        {
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, el, 1, 0, 0);
                        }
                    }
                    else if (!string.IsNullOrEmpty(s179DTO.EstimatedLife))
                    {
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), estimatedLife.ToString(), null, s179DTO.EstimatedLife, 1, 0, 0);
                    }
                    if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod) && s179DTO.DepreciationMethod.Contains(','))
                    {
                        string[] dms = s179DTO.DepreciationMethod.Split(',');
                        foreach (string dm in dms)
                        {
                            Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(dm);
                            databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), dm, 1, 0, 0);
                        }
                    }

                    else if (!string.IsNullOrEmpty(s179DTO.DepreciationMethod))
                    {
                        Guid dmid = databaseOperations.GetDepreciationMethodBasedOnCode(s179DTO.DepreciationMethod);
                        databaseOperations.AddRuleDetail(s179DetailHeader.ToString(), s179Header.ToString(), depreciationMethod.ToString(), dmid.ToString(), s179DTO.DepreciationMethod, 1, 0, 0);
                    }

                }
                Console.WriteLine("SUV");
                Console.WriteLine("\n\n");
            }
        }
    }
}