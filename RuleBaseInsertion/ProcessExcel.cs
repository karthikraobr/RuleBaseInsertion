using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RuleBaseInsertion
{
    public class ProcessExcel
    {
        //List<string[]> entireExcel = null;
        DatabaseOperations databaseOperations = new DatabaseOperations();
        //Constant strings
        private const string DepreciationMethod = "DM";
        private const string DefaultEstimatedLife = "DEL";
        private const string MinMonth = "MinMonth";
        private const string MinYear = "MinYear";
        private const string MaxMonth = "MaxMonth";
        private const string MaxYear = "MaxYear";
        private const string DefaultAveargingConvention = "DAC";
        private const string OtherAveargingConvention = "OAC";
        private const string GAAP = "GAAP";
        private const string DecliningBalance = "DB";

        public void Mainlogic(List<string[]> entireExcel)
        {
            
            string headerName = string.Empty;
            string headerCode = string.Empty;
            string dateRangeString = string.Empty;
            Guid propertyTypeId = Guid.Empty;
            Guid defHeaderId = Guid.Empty;
            string[] currentRow;
            List<string> dateRange = new List<string>();
            List<string> taxTreatmentAlreadyInsertedList = new List<string>();
            int sortId = 1;

            Dictionary<string, string> averagingConvention = new Dictionary<string, string>();
            Dictionary<string, string> FST = new Dictionary<string, string>();
            Dictionary<string, string> FAMT = new Dictionary<string, string>();
            Dictionary<string, string> FENP = new Dictionary<string, string>();
            Dictionary<string, string> FACE = new Dictionary<string, string>();
            Dictionary<string, string> FB = new Dictionary<string, string>();

            string defaultEstimatedLife = string.Empty;

            Guid fSTHeaderId = Guid.Empty;
            Guid fAMTHeaderId = Guid.Empty;
            Guid fENPHeaderId = Guid.Empty;
            Guid fACEHeaderId = Guid.Empty;
            Guid fBHeaderId = Guid.Empty;
            Guid fbTaxTreatmentId = Guid.Empty;

            Guid fSTTaxTreatment = Guid.Empty;
            Guid fAMTTaxTreatment = Guid.Empty;
            Guid fACETaxTreatment = Guid.Empty;
            Guid fENPTaxTreatment = Guid.Empty;



            //Iterating over the entire excel
            foreach (string[] excelRow in entireExcel)
            {

                //Adding def row for property types
                if (!(string.IsNullOrEmpty(excelRow[0]) && string.IsNullOrWhiteSpace(excelRow[0])))
                {
                    headerName = excelRow[1];
                    headerCode = excelRow[0];
                    if (headerCode == "CST")
                    {
                        Console.WriteLine("Be Alert");
                    }
                    Console.WriteLine(headerName);
                    Console.Write("\n");
                    propertyTypeId = databaseOperations.GetPropertyTypeIdfromPropertyCode(headerCode);
                    //TODO:remove hard coding
                    defHeaderId = databaseOperations.AddRuleHeader(propertyTypeId, new Guid("7EF7C538-6FAD-47C2-B517-59432251A1B0"), null, null, null, 2);
                    sortId = 1;
                    string[] codeSectionArray = GetCodeSection(headerCode);
                    //Adding CodeSections
                    Guid codeSectionId = databaseOperations.AddRuleHeader(propertyTypeId, databaseOperations.GetRulePropertyIdfromPropertyCode("CS"), null, null, defHeaderId.ToString(), 1);
                    if (!string.IsNullOrEmpty(codeSectionArray[7]))
                    {
                        Guid valueidentifier = databaseOperations.GetCodeSectionIdBasedOnCodeSectionName(codeSectionArray[7]);
                        //Guid defaultCodeSectionId = databaseOperations.AddRuleHeader(propertyTypeId, databaseOperations.GetRulePropertyIdfromPropertyCode("CS"), null, null,defHeaderId.ToString(), 1);
                        databaseOperations.AddRuleDetail(null, codeSectionId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("CS").ToString(), valueidentifier.ToString(), codeSectionArray[7], 1, 0,0);
                    }
                    if (!string.IsNullOrEmpty(codeSectionArray[8]) && !string.Equals(codeSectionArray[8],"none"))
                    {
                        Guid valueidentifier = databaseOperations.GetCodeSectionIdBasedOnCodeSectionName(codeSectionArray[8]);
                       
                        databaseOperations.AddRuleDetail(null, codeSectionId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("CS").ToString(), valueidentifier.ToString(), codeSectionArray[8], 0, 0,0);
                    }
                }

                //For all othe rows in the excel
                else if (!string.IsNullOrEmpty(excelRow[1]) || !string.IsNullOrEmpty(excelRow[2]))
                {
                    currentRow = excelRow;
                    //Add date range and property type to avoid repeated entry
                    dateRangeString = string.Concat(currentRow[1], currentRow[2], headerCode);
                    bool dateExists = dateRange.Contains(dateRangeString);

                        //If TaxTreatment is gaap
                        if (string.Equals(currentRow[4], GAAP))
                        {
                            Dictionary<string, string> currentFB = BuildFB(currentRow);

                            if (!dateExists)
                            {
                                dateRange.Add(dateRangeString);
                                Guid valueIdentifier = Guid.Parse(databaseOperations.GetBookIdBasedOnCode("FB"));
                                Guid rulePropertyId = databaseOperations.GetRulePropertyIdfromPropertyCode("BK");
                                string effectiveDate = currentRow[1];
                                string parentRuleHeaderId = defHeaderId.ToString();
                                int ruleTypeId = 1;
                                fBHeaderId = databaseOperations.AddRuleHeader(valueIdentifier, rulePropertyId, effectiveDate, null, parentRuleHeaderId, ruleTypeId);
                            }
                                fbTaxTreatmentId = databaseOperations.AddRuleDetail(null, fBHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("TT").ToString(), databaseOperations.GetTaxTreatmentBasedOnName(currentRow[4]).ToString(), currentRow[4], 1, 0,sortId);
                                sortId++;
                            if (currentFB.ContainsKey(DepreciationMethod))
                            {
                                databaseOperations.AddRuleDetail(fbTaxTreatmentId.ToString(), fBHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("DM").ToString(), databaseOperations.GetDepreciationMethodBasedOnCode(currentFB[DepreciationMethod]).ToString(), currentFB[DepreciationMethod], 1, 0,0);
                            }

                            if (currentFB.ContainsKey(DecliningBalance))
                            {
                                databaseOperations.AddRuleDetail(fbTaxTreatmentId.ToString(), fBHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("DB").ToString(), databaseOperations.GetDecliningBalanceBasedOnCode(currentFB[DecliningBalance]).ToString(), currentFB[DecliningBalance], 1, 0,0);
                            }

                            if (currentFB.ContainsKey(DefaultEstimatedLife))
                            {
                                //databaseOperations.AddRuleDetail(fbTaxTreatmentId.ToString(), fBHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("EL").ToString(), databaseOperations.GetEstimatedLifeBasedOnCode(currentFB[DefaultEstimatedLife]).ToString(), currentFB[DefaultEstimatedLife], 1, 0);
                                defaultEstimatedLife = currentFB[DefaultEstimatedLife];
                            }

                            if(currentFB.ContainsKey(MinYear) && currentFB.ContainsKey(MaxYear) && currentFB.ContainsKey(MinMonth) && currentFB.ContainsKey(MaxMonth) )
                            {
                                databaseOperations.AddRuleDetail(fbTaxTreatmentId.ToString(), fBHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("EL").ToString(), databaseOperations.GetEstimatedLifeBasedOnCode(currentFB[MinYear]+currentFB[MinMonth]+"-"+currentFB[MaxYear]+currentFB[MaxMonth]).ToString(), defaultEstimatedLife , 1, 0,0);
                                defaultEstimatedLife = string.Empty;

                            }
                            else if (currentFB.ContainsKey(DefaultEstimatedLife))
                            {
                                databaseOperations.AddRuleDetail(fbTaxTreatmentId.ToString(), fBHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("EL").ToString(), databaseOperations.GetEstimatedLifeBasedOnCode(currentFB[DefaultEstimatedLife]).ToString(), currentFB[DefaultEstimatedLife], 1, 0,0);
                               // defaultEstimatedLife = currentFB[DefaultEstimatedLife];
                            }
                            if (currentFB.ContainsKey(DefaultAveargingConvention))
                            {
                                databaseOperations.AddRuleDetail(fbTaxTreatmentId.ToString(), fBHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("AC").ToString(), databaseOperations.GetAverageConvenionBasedOnCode(currentFB[DefaultAveargingConvention]).ToString(), currentFB[DefaultAveargingConvention], 1, 0,0);
                            }

                            if (currentFB.ContainsKey(OtherAveargingConvention) && currentFB[OtherAveargingConvention].Contains(','))
                            {
                                string[] otherAveragingConventions = currentFB[OtherAveargingConvention].Split(',');
                                foreach (string averagingConventionIterator in otherAveragingConventions)
                                {

                                    databaseOperations.AddRuleDetail(fbTaxTreatmentId.ToString(), fBHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("AC").ToString(), databaseOperations.GetAverageConvenionBasedOnCode(averagingConventionIterator.Trim()).ToString(), averagingConventionIterator.Trim(), 0, 0,0);
                                }
                            }
                            else if (currentFB.ContainsKey(OtherAveargingConvention) && !string.IsNullOrEmpty(currentFB[OtherAveargingConvention]) && !currentFB[OtherAveargingConvention].Contains(","))
                            {
                                    databaseOperations.AddRuleDetail(fbTaxTreatmentId.ToString(), fBHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("AC").ToString(), databaseOperations.GetAverageConvenionBasedOnCode(currentFB[OtherAveargingConvention].Trim()).ToString(), currentFB[OtherAveargingConvention].Trim(), 0, 0,0);
                            }
                        }

                        //if(!GAAP)
                        else
                        {
                            string effectiveDate = currentRow[1];
                            string expirationDate = currentRow[2];
                            string parentRuleHeaderId = defHeaderId.ToString();
                            Guid rulePropertyId = databaseOperations.GetRulePropertyIdfromPropertyCode("BK");
                            int ruleTypeId = 1;

                            Guid fSTValueIdentifier = Guid.Parse(databaseOperations.GetBookIdBasedOnCode("FST"));
                            Guid fACEValueIdentifier = Guid.Parse(databaseOperations.GetBookIdBasedOnCode("FACE"));
                            Guid fAMTValueIdentifier = Guid.Parse(databaseOperations.GetBookIdBasedOnCode("FAMT"));
                            Guid fENPValueIdentifier = Guid.Parse(databaseOperations.GetBookIdBasedOnCode("FENP"));
                            Guid fBValueIdentifier = Guid.Parse(databaseOperations.GetBookIdBasedOnCode("FB"));

                            if (!dateExists)
                            {
                                dateRange.Add(dateRangeString);

                                fSTHeaderId = databaseOperations.AddRuleHeader(fSTValueIdentifier, rulePropertyId, currentRow[1], currentRow[2], parentRuleHeaderId, ruleTypeId);
                                fAMTHeaderId = databaseOperations.AddRuleHeader(fAMTValueIdentifier, rulePropertyId, currentRow[1], currentRow[2], parentRuleHeaderId, ruleTypeId);
                                fACEHeaderId = databaseOperations.AddRuleHeader(fACEValueIdentifier, rulePropertyId, currentRow[1], currentRow[2], parentRuleHeaderId, ruleTypeId);
                                fENPHeaderId = databaseOperations.AddRuleHeader(fENPValueIdentifier, rulePropertyId, currentRow[1], currentRow[2], parentRuleHeaderId, ruleTypeId);
                                fBHeaderId = databaseOperations.AddRuleHeader(fBValueIdentifier, rulePropertyId, currentRow[1], currentRow[2], parentRuleHeaderId, ruleTypeId);

                               

                            }

                            //bool taxTreatmentExists = taxTreatmentAlreadyInsertedList.Contains(currentRow[4] + currentRow[1] + currentRow[2]+defHeaderId);

                            //    if (!taxTreatmentExists)
                            //    {
                            //        string taxTreatmentDateString = currentRow[4] + currentRow[1] + currentRow[2]+defHeaderId;
                            //        taxTreatmentAlreadyInsertedList.Add(taxTreatmentDateString);

                                    if (!string.IsNullOrEmpty(currentRow[4]))
                                    {
                                        fSTHeaderId = databaseOperations.GetRuleHeaderIdBasedOnDate(rulePropertyId.ToString(), fSTValueIdentifier.ToString(), effectiveDate.ToString(), expirationDate.ToString(), parentRuleHeaderId.ToString());
                                        if (Guid.Equals(fSTHeaderId, Guid.Empty))
                                        {
                                            fSTHeaderId = databaseOperations.AddRuleHeader(fSTValueIdentifier, rulePropertyId, currentRow[1], currentRow[2], parentRuleHeaderId, ruleTypeId);
                                        }
                                        fAMTHeaderId = databaseOperations.GetRuleHeaderIdBasedOnDate(rulePropertyId.ToString(), fAMTValueIdentifier.ToString(), effectiveDate.ToString(), expirationDate.ToString(), parentRuleHeaderId.ToString());
                                        if (Guid.Equals(fAMTHeaderId, Guid.Empty))
                                        {
                                            fAMTHeaderId = databaseOperations.AddRuleHeader(fAMTValueIdentifier, rulePropertyId, currentRow[1], currentRow[2], parentRuleHeaderId, ruleTypeId);
                                        }
                                        fACEHeaderId = databaseOperations.GetRuleHeaderIdBasedOnDate(rulePropertyId.ToString(), fACEValueIdentifier.ToString(), effectiveDate.ToString(), expirationDate.ToString(), parentRuleHeaderId.ToString());
                                        if (Guid.Equals(fACEHeaderId, Guid.Empty))
                                        {
                                            fACEHeaderId = databaseOperations.AddRuleHeader(fACEValueIdentifier, rulePropertyId, currentRow[1], currentRow[2], parentRuleHeaderId, ruleTypeId);
                                        }
                                        fENPHeaderId = databaseOperations.GetRuleHeaderIdBasedOnDate(rulePropertyId.ToString(), fENPValueIdentifier.ToString(), effectiveDate.ToString(), expirationDate.ToString(), parentRuleHeaderId.ToString());
                                        if (Guid.Equals(fENPHeaderId, Guid.Empty))
                                        {
                                            fENPHeaderId = databaseOperations.AddRuleHeader(fENPValueIdentifier, rulePropertyId, currentRow[1], currentRow[2], parentRuleHeaderId, ruleTypeId);
                                        }
                                        fBHeaderId = databaseOperations.GetRuleHeaderIdBasedOnDate(rulePropertyId.ToString(), fBValueIdentifier.ToString(), effectiveDate.ToString(), expirationDate.ToString(), parentRuleHeaderId.ToString());
                                        if (Guid.Equals(fBHeaderId, Guid.Empty))
                                        {
                                            fBHeaderId = databaseOperations.AddRuleHeader(fBValueIdentifier, rulePropertyId, currentRow[1], currentRow[2], parentRuleHeaderId, ruleTypeId);
                                        }

                                        fSTTaxTreatment = databaseOperations.AddRuleDetail(null, fSTHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("TT").ToString(), databaseOperations.GetTaxTreatmentBasedOnName(currentRow[4]).ToString(), currentRow[4], 1, 0,sortId);
                                        fAMTTaxTreatment = databaseOperations.AddRuleDetail(null, fAMTHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("TT").ToString(), databaseOperations.GetTaxTreatmentBasedOnName(currentRow[4]).ToString(), currentRow[4], 1, 0, sortId);
                                        fACETaxTreatment = databaseOperations.AddRuleDetail(null, fACEHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("TT").ToString(), databaseOperations.GetTaxTreatmentBasedOnName(currentRow[4]).ToString(), currentRow[4], 1, 0, sortId);
                                        fENPTaxTreatment = databaseOperations.AddRuleDetail(null, fENPHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("TT").ToString(), databaseOperations.GetTaxTreatmentBasedOnName(currentRow[4]).ToString(), currentRow[4], 1, 0, sortId);
                                        fbTaxTreatmentId = databaseOperations.AddRuleDetail(null, fBHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("TT").ToString(), databaseOperations.GetTaxTreatmentBasedOnName(currentRow[4]).ToString(), currentRow[4], 1, 0, sortId);
                                        sortId++;
                                    }
                                //}
                                averagingConvention = BuildAC(currentRow);
                                FST = BuildFST(currentRow);
                                FAMT = BuildFAMT(currentRow);
                                FENP = BuildFENP(currentRow);
                                FACE = BuildFACE(currentRow);
                                FB = BuildFB(currentRow);
                                if (FST.Count == 0)
                                {
                                    databaseOperations.DeleteFromRuleDetail(fSTTaxTreatment);
                                }
                                if (FAMT.Count == 0)
                                {
                                    databaseOperations.DeleteFromRuleDetail(fAMTTaxTreatment);
                                }
                                if (FACE.Count == 0)
                                {
                                    databaseOperations.DeleteFromRuleDetail(fACETaxTreatment);
                                }
                                if (FENP.Count == 0)
                                {
                                    databaseOperations.DeleteFromRuleDetail(fENPTaxTreatment);
                                }
                                if (FB.Count == 0)
                                {
                                    databaseOperations.DeleteFromRuleDetail(fbTaxTreatmentId);
                                }
                                //FST
                                if (averagingConvention.ContainsKey(DefaultAveargingConvention) && FST.Count > 0)
                                {
                                    databaseOperations.AddRuleDetail(fSTTaxTreatment.ToString(), fSTHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("AC").ToString(), databaseOperations.GetAverageConvenionBasedOnCode(averagingConvention[DefaultAveargingConvention]).ToString(), averagingConvention[DefaultAveargingConvention], 1, 0,0);
                                }

                                if (averagingConvention.ContainsKey(OtherAveargingConvention) && averagingConvention[OtherAveargingConvention].Contains(',') && FST.Count > 0)
                                {
                                    string[] otherAveragingConventions = averagingConvention[OtherAveargingConvention].Split(',');
                                    foreach (string averagingConventionIterator in otherAveragingConventions)
                                    {

                                        databaseOperations.AddRuleDetail(fSTTaxTreatment.ToString(), fSTHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("AC").ToString(), databaseOperations.GetAverageConvenionBasedOnCode(averagingConventionIterator.Trim()).ToString(), averagingConventionIterator.Trim(), 0, 0,0);
                                    }
                                }
                                else if (averagingConvention.ContainsKey(OtherAveargingConvention) && !string.IsNullOrEmpty(averagingConvention[OtherAveargingConvention]) && !averagingConvention[OtherAveargingConvention].Contains(',') && FST.Count > 0)
                                {
                                    databaseOperations.AddRuleDetail(fSTTaxTreatment.ToString(), fSTHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("AC").ToString(), databaseOperations.GetAverageConvenionBasedOnCode(averagingConvention[OtherAveargingConvention].Trim()).ToString(), averagingConvention[OtherAveargingConvention].Trim(), 0, 0,0);
                                }

                                if (FST.ContainsKey(DepreciationMethod))
                                {
                                    databaseOperations.AddRuleDetail(fSTTaxTreatment.ToString(), fSTHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("DM").ToString(), databaseOperations.GetDepreciationMethodBasedOnCode(FST[DepreciationMethod]).ToString(), FST[DepreciationMethod], 1, 0,0);
                                }

                                if (FST.ContainsKey(DecliningBalance))
                                {
                                    databaseOperations.AddRuleDetail(fSTTaxTreatment.ToString(), fSTHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("DB").ToString(), databaseOperations.GetDecliningBalanceBasedOnCode(FST[DecliningBalance]).ToString(), FST[DecliningBalance], 1, 0,0);
                                }

                                if (FST.ContainsKey(DefaultEstimatedLife))
                                {
                                   // databaseOperations.AddRuleDetail(fSTTaxTreatment.ToString(), fSTHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("EL").ToString(), databaseOperations.GetEstimatedLifeBasedOnCode(FST[DefaultEstimatedLife]).ToString(), FST[DefaultEstimatedLife], 1, 0);
                                    defaultEstimatedLife = FST[DefaultEstimatedLife];
                                }

                                if (FST.ContainsKey(MinYear) && FST.ContainsKey(MaxYear) && FST.ContainsKey(MinMonth) && FST.ContainsKey(MaxMonth))
                                {
                                    databaseOperations.AddRuleDetail(fSTTaxTreatment.ToString(), fSTHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("EL").ToString(), databaseOperations.GetEstimatedLifeBasedOnCode(FST[MinYear] + FST[MinMonth] + "-" + FST[MaxYear] + FST[MaxMonth]).ToString(), defaultEstimatedLife, 1, 0,0);
                                    defaultEstimatedLife = string.Empty;
                                }
                                else if (FST.ContainsKey(DefaultEstimatedLife))
                                {
                                     databaseOperations.AddRuleDetail(fSTTaxTreatment.ToString(), fSTHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("EL").ToString(), databaseOperations.GetEstimatedLifeBasedOnCode(FST[DefaultEstimatedLife]).ToString(), FST[DefaultEstimatedLife], 1, 0,0);
                                    //defaultEstimatedLife = FST[DefaultEstimatedLife];
                                }

                                //FAMT
                                if (averagingConvention.ContainsKey(DefaultAveargingConvention) && FAMT.Count > 0 && FAMT[DepreciationMethod]!= "NO")
                                {
                                    databaseOperations.AddRuleDetail(fAMTTaxTreatment.ToString(), fAMTHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("AC").ToString(), databaseOperations.GetAverageConvenionBasedOnCode(averagingConvention[DefaultAveargingConvention]).ToString(), averagingConvention[DefaultAveargingConvention], 1, 0,0);
                                }

                                if (averagingConvention.ContainsKey(OtherAveargingConvention) && averagingConvention[OtherAveargingConvention].Contains(',') && FAMT.Count > 0 && FAMT[DepreciationMethod] != "NO")
                                {
                                    string[] otherAveragingConventions = averagingConvention[OtherAveargingConvention].Split(',');
                                    foreach (string averagingConventionIterator in otherAveragingConventions)
                                    {

                                        databaseOperations.AddRuleDetail(fAMTTaxTreatment.ToString(), fAMTHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("AC").ToString(), databaseOperations.GetAverageConvenionBasedOnCode(averagingConventionIterator.Trim()).ToString(), averagingConventionIterator.Trim(), 0, 0,0);
                                    }
                                }
                                else if (averagingConvention.ContainsKey(OtherAveargingConvention) && !string.IsNullOrEmpty(averagingConvention[OtherAveargingConvention]) && !averagingConvention[OtherAveargingConvention].Contains(',') && FAMT.Count > 0 && FAMT[DepreciationMethod] != "NO")
                                {
                                    databaseOperations.AddRuleDetail(fAMTTaxTreatment.ToString(), fAMTHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("AC").ToString(), databaseOperations.GetAverageConvenionBasedOnCode(averagingConvention[OtherAveargingConvention].Trim()).ToString(), averagingConvention[OtherAveargingConvention].Trim(), 0, 0,0);
                                }

                                if (FAMT.ContainsKey(DepreciationMethod))
                                {
                                    databaseOperations.AddRuleDetail(fAMTTaxTreatment.ToString(), fAMTHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("DM").ToString(), databaseOperations.GetDepreciationMethodBasedOnCode(FAMT[DepreciationMethod]).ToString(), FAMT[DepreciationMethod], 1, 0,0);
                                }

                                if (FAMT.ContainsKey(DecliningBalance))
                                {
                                    databaseOperations.AddRuleDetail(fAMTTaxTreatment.ToString(), fAMTHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("DB").ToString(), databaseOperations.GetDecliningBalanceBasedOnCode(FAMT[DecliningBalance]).ToString(), FAMT[DecliningBalance], 1, 0,0);
                                }

                                if (FAMT.ContainsKey(DefaultEstimatedLife))
                                {
                                    //databaseOperations.AddRuleDetail(fAMTTaxTreatment.ToString(), fAMTHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("EL").ToString(), databaseOperations.GetEstimatedLifeBasedOnCode(FAMT[DefaultEstimatedLife]).ToString(), FAMT[DefaultEstimatedLife], 1, 0);
                                    defaultEstimatedLife = FAMT[DefaultEstimatedLife];
                                }

                                if (FAMT.ContainsKey(MinYear) && FAMT.ContainsKey(MaxYear) && FAMT.ContainsKey(MinMonth) && FAMT.ContainsKey(MaxMonth))
                                {
                                    databaseOperations.AddRuleDetail(fAMTTaxTreatment.ToString(), fAMTHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("EL").ToString(), databaseOperations.GetEstimatedLifeBasedOnCode(FAMT[MinYear] + FAMT[MinMonth] + "-" + FAMT[MaxYear] + FAMT[MaxMonth]).ToString(), defaultEstimatedLife, 1, 0,0);
                                    defaultEstimatedLife = string.Empty;
                                }
                                else if (FAMT.ContainsKey(DefaultEstimatedLife))
                                {
                                    databaseOperations.AddRuleDetail(fAMTTaxTreatment.ToString(), fAMTHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("EL").ToString(), databaseOperations.GetEstimatedLifeBasedOnCode(FAMT[DefaultEstimatedLife]).ToString(), FAMT[DefaultEstimatedLife], 1, 0,0);
                                    //defaultEstimatedLife = FAMT[DefaultEstimatedLife];
                                }
                                //FACE
                                if (averagingConvention.ContainsKey(DefaultAveargingConvention) && FACE.Count > 0 && FACE[DepreciationMethod] != "NO")
                                {
                                    databaseOperations.AddRuleDetail(fACETaxTreatment.ToString(), fACEHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("AC").ToString(), databaseOperations.GetAverageConvenionBasedOnCode(averagingConvention[DefaultAveargingConvention]).ToString(), averagingConvention[DefaultAveargingConvention], 1, 0,0);
                                }

                                if (averagingConvention.ContainsKey(OtherAveargingConvention) && averagingConvention[OtherAveargingConvention].Contains(',') && FACE.Count > 0 && FACE[DepreciationMethod] != "NO")
                                {
                                    string[] otherAveragingConventions = averagingConvention[OtherAveargingConvention].Split(',');
                                    foreach (string averagingConventionIterator in otherAveragingConventions)
                                    {

                                        databaseOperations.AddRuleDetail(fACETaxTreatment.ToString(), fACEHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("AC").ToString(), databaseOperations.GetAverageConvenionBasedOnCode(averagingConventionIterator.Trim()).ToString(), averagingConventionIterator.Trim(), 0, 0,0);
                                    }
                                }

                                else if (averagingConvention.ContainsKey(OtherAveargingConvention) && !string.IsNullOrEmpty(averagingConvention[OtherAveargingConvention]) && !averagingConvention[OtherAveargingConvention].Contains(',') && FACE.Count > 0 && FACE[DepreciationMethod] != "NO")
                                {
                                    databaseOperations.AddRuleDetail(fACETaxTreatment.ToString(), fACEHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("AC").ToString(), databaseOperations.GetAverageConvenionBasedOnCode(averagingConvention[OtherAveargingConvention].Trim()).ToString(), averagingConvention[OtherAveargingConvention].Trim(), 0, 0,0);
                                }

                                if (FACE.ContainsKey(DepreciationMethod))
                                {
                                    databaseOperations.AddRuleDetail(fACETaxTreatment.ToString(), fACEHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("DM").ToString(), databaseOperations.GetDepreciationMethodBasedOnCode(FACE[DepreciationMethod]).ToString(), FACE[DepreciationMethod], 1, 0,0);
                                }

                                if (FACE.ContainsKey(DecliningBalance))
                                {
                                    databaseOperations.AddRuleDetail(fACETaxTreatment.ToString(), fACEHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("DB").ToString(), databaseOperations.GetDecliningBalanceBasedOnCode(FACE[DecliningBalance]).ToString(), FACE[DecliningBalance], 1, 0,0);
                                }

                                if (FACE.ContainsKey(DefaultEstimatedLife))
                                {
                                    //databaseOperations.AddRuleDetail(fACETaxTreatment.ToString(), fACEHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("EL").ToString(), databaseOperations.GetEstimatedLifeBasedOnCode(FACE[DefaultEstimatedLife]).ToString(), FACE[DefaultEstimatedLife], 1, 0);
                                    defaultEstimatedLife = FACE[DefaultEstimatedLife];
                                }

                                if (FACE.ContainsKey(MinYear) && FACE.ContainsKey(MaxYear) && FACE.ContainsKey(MinMonth) && FACE.ContainsKey(MaxMonth))
                                {
                                    databaseOperations.AddRuleDetail(fACETaxTreatment.ToString(), fACEHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("EL").ToString(), databaseOperations.GetEstimatedLifeBasedOnCode(FACE[MinYear] + FACE[MinMonth] + "-" + FACE[MaxYear] + FACE[MaxMonth]).ToString(), defaultEstimatedLife, 1, 0,0);
                                    defaultEstimatedLife = string.Empty;
                                }
                                else if (FACE.ContainsKey(DefaultEstimatedLife))
                                {
                                    databaseOperations.AddRuleDetail(fACETaxTreatment.ToString(), fACEHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("EL").ToString(), databaseOperations.GetEstimatedLifeBasedOnCode(FACE[DefaultEstimatedLife]).ToString(), FACE[DefaultEstimatedLife], 1, 0,0);
                                    //defaultEstimatedLife = FACE[DefaultEstimatedLife];
                                }

                                //FENP
                                if (averagingConvention.ContainsKey(DefaultAveargingConvention) && FENP.Count > 0 && FENP[DepreciationMethod] != "NO")
                                {
                                    databaseOperations.AddRuleDetail(fENPTaxTreatment.ToString(), fENPHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("AC").ToString(), databaseOperations.GetAverageConvenionBasedOnCode(averagingConvention[DefaultAveargingConvention]).ToString(), averagingConvention[DefaultAveargingConvention], 1, 0,0);
                                }

                                if (averagingConvention.ContainsKey(OtherAveargingConvention) && averagingConvention[OtherAveargingConvention].Contains(',') && FENP.Count > 0 && FENP[DepreciationMethod] != "NO")
                                {
                                    string[] otherAveragingConventions = averagingConvention[OtherAveargingConvention].Split(',');
                                    foreach (string averagingConventionIterator in otherAveragingConventions)
                                    {

                                        databaseOperations.AddRuleDetail(fENPTaxTreatment.ToString(), fENPHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("AC").ToString(), databaseOperations.GetAverageConvenionBasedOnCode(averagingConventionIterator.Trim()).ToString(), averagingConventionIterator.Trim(), 0, 0,0);
                                    }
                                }
                                else if (averagingConvention.ContainsKey(OtherAveargingConvention) && !string.IsNullOrEmpty(averagingConvention[OtherAveargingConvention]) && !averagingConvention[OtherAveargingConvention].Contains(',') && FENP.Count > 0 && FENP[DepreciationMethod] != "NO")
                                {
                                    databaseOperations.AddRuleDetail(fENPTaxTreatment.ToString(), fENPHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("AC").ToString(), databaseOperations.GetAverageConvenionBasedOnCode(averagingConvention[OtherAveargingConvention].Trim()).ToString(), averagingConvention[OtherAveargingConvention].Trim(), 0, 0,0);
                                }
                                if (FENP.ContainsKey(DepreciationMethod))
                                {
                                    databaseOperations.AddRuleDetail(fENPTaxTreatment.ToString(), fENPHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("DM").ToString(), databaseOperations.GetDepreciationMethodBasedOnCode(FENP[DepreciationMethod]).ToString(), FENP[DepreciationMethod], 1, 0,0);
                                }

                                if (FENP.ContainsKey(DecliningBalance))
                                {
                                    databaseOperations.AddRuleDetail(fENPTaxTreatment.ToString(), fENPHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("DB").ToString(), databaseOperations.GetDecliningBalanceBasedOnCode(FENP[DecliningBalance]).ToString(), FENP[DecliningBalance], 1, 0,0);
                                }

                                if (FENP.ContainsKey(DefaultEstimatedLife))
                                {
                                    //databaseOperations.AddRuleDetail(fENPTaxTreatment.ToString(), fENPHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("EL").ToString(), databaseOperations.GetEstimatedLifeBasedOnCode(FENP[DefaultEstimatedLife]).ToString(), FENP[DefaultEstimatedLife], 1, 0);
                                    defaultEstimatedLife = FENP[DefaultEstimatedLife];
                                }
                                if (FENP.ContainsKey(MinYear) && FENP.ContainsKey(MaxYear) && FENP.ContainsKey(MinMonth) && FENP.ContainsKey(MaxMonth))
                                {
                                    databaseOperations.AddRuleDetail(fENPTaxTreatment.ToString(), fENPHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("EL").ToString(), databaseOperations.GetEstimatedLifeBasedOnCode(FENP[MinYear] + FENP[MinMonth] + "-" + FENP[MaxYear] + FENP[MaxMonth]).ToString(), defaultEstimatedLife, 1, 0,0);
                                    defaultEstimatedLife = string.Empty;
                                }
                                else if (FENP.ContainsKey(DefaultEstimatedLife))
                                {
                                    databaseOperations.AddRuleDetail(fENPTaxTreatment.ToString(), fENPHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("EL").ToString(), databaseOperations.GetEstimatedLifeBasedOnCode(FENP[DefaultEstimatedLife]).ToString(), FENP[DefaultEstimatedLife], 1, 0,0);
                                    //defaultEstimatedLife = FENP[DefaultEstimatedLife];
                                }
                                //FB
                                if (FB.ContainsKey(DepreciationMethod))
                                {
                                    databaseOperations.AddRuleDetail(fbTaxTreatmentId.ToString(), fBHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("DM").ToString(), databaseOperations.GetDepreciationMethodBasedOnCode(FB[DepreciationMethod]).ToString(), FB[DepreciationMethod], 1, 0,0);
                                }

                                if (FB.ContainsKey(DecliningBalance))
                                {
                                    databaseOperations.AddRuleDetail(fbTaxTreatmentId.ToString(), fBHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("DB").ToString(), databaseOperations.GetDecliningBalanceBasedOnCode(FB[DecliningBalance]).ToString(), FB[DecliningBalance], 1, 0,0);
                                }

                                if (FB.ContainsKey(DefaultEstimatedLife))
                                {
                                   // databaseOperations.AddRuleDetail(fbTaxTreatmentId.ToString(), fBHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("EL").ToString(), databaseOperations.GetEstimatedLifeBasedOnCode(FB[DefaultEstimatedLife]).ToString(), FB[DefaultEstimatedLife], 1, 0);
                                    defaultEstimatedLife = FB[DefaultEstimatedLife];
                                }

                                if (FB.ContainsKey(MinYear) && FB.ContainsKey(MaxYear) && FB.ContainsKey(MinMonth) && FB.ContainsKey(MaxMonth))
                                {
                                    databaseOperations.AddRuleDetail(fbTaxTreatmentId.ToString(), fBHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("EL").ToString(), databaseOperations.GetEstimatedLifeBasedOnCode(FB[MinYear] + FB[MinMonth] + "-" + FB[MaxYear] + FB[MaxMonth]).ToString(), defaultEstimatedLife, 1, 0,0);
                                }
                                else if (FB.ContainsKey(DefaultEstimatedLife))
                                {
                                    databaseOperations.AddRuleDetail(fbTaxTreatmentId.ToString(), fBHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("EL").ToString(), databaseOperations.GetEstimatedLifeBasedOnCode(FB[DefaultEstimatedLife]).ToString(), FB[DefaultEstimatedLife], 1, 0,0);
                                    //defaultEstimatedLife = FB[DefaultEstimatedLife];
                                }
                                if (FB.ContainsKey(DefaultAveargingConvention))
                                {
                                    databaseOperations.AddRuleDetail(fbTaxTreatmentId.ToString(), fBHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("AC").ToString(), databaseOperations.GetAverageConvenionBasedOnCode(FB[DefaultAveargingConvention]).ToString(), FB[DefaultAveargingConvention], 1, 0,0);
                                }

                                if (FB.ContainsKey(OtherAveargingConvention) && FB[OtherAveargingConvention].Contains(','))
                                {
                                    string[] otherAveragingConventions = FB[OtherAveargingConvention].Split(',');
                                    foreach (string averagingConventionIterator in otherAveragingConventions)
                                    {

                                        databaseOperations.AddRuleDetail(fbTaxTreatmentId.ToString(), fBHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("AC").ToString(), databaseOperations.GetAverageConvenionBasedOnCode(averagingConventionIterator.Trim()).ToString(), averagingConventionIterator.Trim(), 0, 0,0);                                    }
                                }
                                else if (FB.ContainsKey(OtherAveargingConvention) && !string.IsNullOrEmpty(FB[OtherAveargingConvention]) && !FB[OtherAveargingConvention].Contains(","))
                                {
                                    databaseOperations.AddRuleDetail(fbTaxTreatmentId.ToString(), fBHeaderId.ToString(), databaseOperations.GetRulePropertyIdfromPropertyCode("AC").ToString(), databaseOperations.GetAverageConvenionBasedOnCode(FB[OtherAveargingConvention].Trim()).ToString(), FB[OtherAveargingConvention].Trim(), 0, 0,0);
                                }
                            }

                        }
                    }

                }
            //}

        public Dictionary<string, string> GetBooks(string[] bookRow)
        {
            //string[] headerRow = excelSheet[0];

            Dictionary<string, string> books = new Dictionary<string, string>();

            foreach (string book in bookRow)
            {
                if (book == "Federal Tax")
                {
                    books.Add(book, "FST");
                }
                else if (book == "Federal AMT")
                {
                    books.Add(book, "FAMT");
                }
                else if (book == "Federal ACE")
                {
                    books.Add(book, "FACE");
                }
                else if (book == "Federal E&P(1)")
                {
                    books.Add(book, "FENP");
                }
            }

            return books;
        }

        public Dictionary<string, string> BuildFST(string[] currentRow)
        {
            Dictionary<string, string> FST = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(currentRow[5]))
            {
                if (currentRow[5].Contains("DB") || currentRow[5].Contains("DC") || currentRow[5].Contains("MF") || currentRow[5].Contains("MT"))
                {
                    string depreciationMethod = currentRow[5].Substring(0, 2);
                    string decliningBalance = currentRow[5].Substring(2,3);
                    FST.Add(DepreciationMethod, depreciationMethod);
                    FST.Add(DecliningBalance, decliningBalance);
                }
                //else if ()
                //{
                //    string depreciationMethod = currentRow[5];
                //    string decliningBalance = currentRow[5].Substring(2, 3);
                //    FST.Add(DepreciationMethod, depreciationMethod);
                //    FST.Add(DecliningBalance, decliningBalance);
                //}
                else
                {
                    FST.Add(DepreciationMethod, currentRow[5]);
                }
            }
            if (!string.IsNullOrEmpty(currentRow[6]) && !string.Equals(currentRow[6],"-"))
            {
                FST.Add(DefaultEstimatedLife, currentRow[6]);
            }
            if (!string.IsNullOrEmpty(currentRow[7]))
            {
                string[] dateRange = Regex.Split(currentRow[7], " ");
                FST.Add(MinYear, dateRange[0]);
                FST.Add(MinMonth, dateRange[1]);
            }
            if (!string.IsNullOrEmpty(currentRow[8]))
            {
                string[] dateRange = Regex.Split(currentRow[8], " ");
                FST.Add(MaxYear, dateRange[0]);
                FST.Add(MaxMonth, dateRange[1]);
            }
            return FST;
        }

        public Dictionary<string, string> BuildFAMT(string[] currentRow)
        {
            Dictionary<string, string> FAMT = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(currentRow[11]))
            {
                if (currentRow[11].Contains("DB") || currentRow[11].Contains("DC") || currentRow[11].Contains("MF") || currentRow[11].Contains("MT"))
                {
                    string depreciationMethod = currentRow[11].Substring(0, 2);
                    string decliningBalance = currentRow[11].Substring(2, 3);
                    FAMT.Add(DepreciationMethod, depreciationMethod);
                    FAMT.Add(DecliningBalance, decliningBalance);
                }
                else
                {
                    FAMT.Add(DepreciationMethod, currentRow[11]);
                }
            }
            if (!string.IsNullOrEmpty(currentRow[12]) && !string.Equals(currentRow[12],"-"))
            {
                FAMT.Add(DefaultEstimatedLife, currentRow[12]);
            }
            if (!string.IsNullOrEmpty(currentRow[13]))
            {
                string[] dateRange = Regex.Split(currentRow[13], " ");
                FAMT.Add(MinYear, dateRange[0]);
                FAMT.Add(MinMonth, dateRange[1]);
            }
            if (!string.IsNullOrEmpty(currentRow[14]))
            {
                string[] dateRange = Regex.Split(currentRow[14], " ");
                FAMT.Add(MaxYear, dateRange[0]);
                FAMT.Add(MaxMonth, dateRange[1]);
            }
            return FAMT;
        }

        public Dictionary<string, string> BuildFACE(string[] currentRow)
        {
            Dictionary<string, string> FACE = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(currentRow[15]))
            {
                if (currentRow[15].Contains("DB") || currentRow[15].Contains("DC") || currentRow[15].Contains("MF") || currentRow[15].Contains("MT"))
                {
                    string depreciationMethod = currentRow[15].Substring(0, 2);
                    string decliningBalance = currentRow[15].Substring(2,3);
                    FACE.Add(DepreciationMethod, depreciationMethod);
                    FACE.Add(DecliningBalance, decliningBalance);
                }
                else
                {
                    FACE.Add(DepreciationMethod, currentRow[15]);
                }
            }
            if (!string.IsNullOrEmpty(currentRow[16]) && !string.Equals(currentRow[16],"-"))
            {
                FACE.Add(DefaultEstimatedLife, currentRow[16]);
            }
            if (!string.IsNullOrEmpty(currentRow[17]))
            {
                string[] dateRange = Regex.Split(currentRow[17], " ");
                FACE.Add(MinYear, dateRange[0]);
                FACE.Add(MinMonth, dateRange[1]);
            }
            if (!string.IsNullOrEmpty(currentRow[18]))
            {
                string[] dateRange = Regex.Split(currentRow[18], " ");
                FACE.Add(MaxYear, dateRange[0]);
                FACE.Add(MaxMonth, dateRange[1]);
            }
            return FACE;
        }

        public Dictionary<string, string> BuildFENP(string[] currentRow)
        {
            Dictionary<string, string> FENP = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(currentRow[19]))
            {
                if (currentRow[19].Contains("DB") || currentRow[19].Contains("DC") || currentRow[19].Contains("MF")  || currentRow[19].Contains("MT"))
                {
                    string depreciationMethod = currentRow[19].Substring(0, 2);
                    string decliningBalance = currentRow[19].Substring(2,3);
                    FENP.Add(DepreciationMethod, depreciationMethod);
                    FENP.Add(DecliningBalance, decliningBalance);
                }
                else
                {
                    FENP.Add(DepreciationMethod, currentRow[19]);
                }
            }
            if (!string.IsNullOrEmpty(currentRow[20]) && !string.Equals(currentRow[20],"-"))
            {
                FENP.Add(DefaultEstimatedLife, currentRow[20]);
            }
            if (!string.IsNullOrEmpty(currentRow[21]))
            {
                string[] dateRange = Regex.Split(currentRow[21], " ");
                FENP.Add(MinYear, dateRange[0]);
                FENP.Add(MinMonth, dateRange[1]);
            }
            if (!string.IsNullOrEmpty(currentRow[22]))
            {
                string[] dateRange = Regex.Split(currentRow[22], " ");
                FENP.Add(MaxYear, dateRange[0]);
                FENP.Add(MaxMonth, dateRange[1]);
            }
            return FENP;
        }

        public Dictionary<string, string> BuildFB(string[] currentRow)
        {
            Dictionary<string, string> FB = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(currentRow[23]))
            {
                if (currentRow[23].Contains("DB") || currentRow[23].Contains("DC") || currentRow[23].Contains("MF") || currentRow[23].Contains("MT"))
                {
                    string depreciationMethod = currentRow[23].Substring(0, 2);
                    string decliningBalance = currentRow[23].Substring(2,3);
                    FB.Add(DepreciationMethod, depreciationMethod);
                    FB.Add(DecliningBalance, decliningBalance);
                }
                else
                {
                    FB.Add(DepreciationMethod, currentRow[23]);
                }
            }
            if (!string.IsNullOrEmpty(currentRow[24]) && !string.Equals(currentRow[24],"-"))
            {
                FB.Add(DefaultEstimatedLife, currentRow[24]);
            }
            if (!string.IsNullOrEmpty(currentRow[25]))
            {
                string[] dateRange = Regex.Split(currentRow[25], " ");
                FB.Add(MinYear, dateRange[0]);
                FB.Add(MinMonth, dateRange[1]);
            }
            if (!string.IsNullOrEmpty(currentRow[26]))
            {
                string[] dateRange = Regex.Split(currentRow[26], " ");
                FB.Add(MaxYear, dateRange[0]);
                FB.Add(MaxMonth, dateRange[1]);
            }
            if (!string.IsNullOrEmpty(currentRow[27]) && !string.Equals(currentRow[27],"-"))
            {
                FB.Add(DefaultAveargingConvention, currentRow[27]);
            }
            if (!string.IsNullOrEmpty(currentRow[28]))
            {
                FB.Add(OtherAveargingConvention, currentRow[28]);
            }
            return FB;
        }

        public Dictionary<string, string> BuildAC(string[] currentRow)
        {
            Dictionary<string, string> AC = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(currentRow[9]) &&  !string.Equals(currentRow[9],"-"))
            {
                AC.Add(DefaultAveargingConvention, currentRow[9]);
            }
            if (!string.IsNullOrEmpty(currentRow[10]))
            {
                AC.Add(OtherAveargingConvention, currentRow[10]);
            }
            return AC;
        }

        public string[] GetCodeSection(string propertyTypeCode)
        {
            ExcelTasks excelTasks = new ExcelTasks();
            List<string[]> codeSectionWorkBookList = excelTasks.ConvertExcelToListCodeSection(excelTasks.LoadExcelSheet(@"D:\Sage\SRC\RuleBaseInsertion\Rulebase-Prop Types, Depr Methods and Lifes(1).xlsx", "Property Types"));
            foreach (string[] itr in codeSectionWorkBookList)
            {
                if (string.Equals(itr[0], propertyTypeCode))
                {
                    return itr;
                }
            }
            return null;
        }


    }
}
