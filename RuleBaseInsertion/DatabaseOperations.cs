using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleBaseInsertion
{
    public class DatabaseOperations
    {
        string connectionString = @"Data Source=bg4ws0841\sqlexpress;Initial Catalog=Sage.FA.DaaS.Master.RuleBase;User ID=sa;Password=admin@123";

        //public Dictionary<Guid, string> AddBook(Dictionary<string, string> books)
        //{
        //    Dictionary<Guid, string> bookDictionary = new Dictionary<Guid, string>();

        //    foreach (KeyValuePair<string, string> iterator in books)
        //    {
        //        Guid bookId = Guid.NewGuid();
        //        int status = 0;
        //        string insertQuery = "INSERT INTO [dbo].[Book]" +
        //        "([BookID]" +
        //       ",[Name]" +
        //       ",[IsDeleted]" +
        //       ",[BookTypeID]" +
        //       ",[Code])" +
        //        "VALUES" +
        //       "('{0}','{1}','{2}','{3}','{4}')";
        //        insertQuery = string.Format(insertQuery, bookId, iterator.Key, 0, "93A55821-440A-438B-BDAF-396FBA02C252", iterator.Value);
        //        using (SqlConnection con = new SqlConnection(connectionString))
        //        {
        //            con.Open();
        //            SqlCommand cmd = new SqlCommand(insertQuery, con);
        //            status = cmd.ExecuteNonQuery();
        //            con.Close();
        //        }

        //        if (status == 1)
        //        {
        //            bookDictionary.Add(bookId, iterator.Value);
        //        }
        //    }
        //    return bookDictionary;
        //}

        public Guid AddRuleHeader(Guid valueIdentifier, Guid rulePropertyId, string effectiveDate, string expirationDate, string parentRuleHeaderId, int ruleType)
        {

            int status = 0;
            Guid ruleHeaderId = Guid.NewGuid();
            string insertQuery = "INSERT INTO [dbo].[RuleHeader]" +
           "([RuleHeaderID]" +
           ",[ValueIdentifier]" +
           ",[RulePropertyID]" +
           ",[EffectiveDate]" +
           ",[ExpirationDate]" +
           ",[ParentRuleHeaderID]" +
           ",[RuleTypeID]" +
           ",[IsDeleted])" +
           "Values" +
            "('{0}','{1}','{2}',{3},{4},{5},{6},0)";
            insertQuery = string.Format(insertQuery,
                ruleHeaderId,
                valueIdentifier,
                rulePropertyId,
                !string.IsNullOrEmpty(effectiveDate) ? "'" + effectiveDate + "'" : "null",
                !string.IsNullOrEmpty(expirationDate) ? "'" + expirationDate + "'" : "null",
                !string.IsNullOrEmpty(parentRuleHeaderId) ? "'" + parentRuleHeaderId + "'" : "null",
                ruleType);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                status = cmd.ExecuteNonQuery();
                con.Close();
            }
            return ruleHeaderId;
        }


        public Guid AddRuleHeaderString(string valueIdentifier, Guid rulePropertyId, string effectiveDate, string expirationDate, string parentRuleHeaderId, int ruleType)
        {

            int status = 0;
            Guid ruleHeaderId = Guid.NewGuid();
            string insertQuery = "INSERT INTO [dbo].[RuleHeader]" +
           "([RuleHeaderID]" +
           ",[ValueIdentifier]" +
           ",[RulePropertyID]" +
           ",[EffectiveDate]" +
           ",[ExpirationDate]" +
           ",[ParentRuleHeaderID]" +
           ",[RuleTypeID]" +
           ",[IsDeleted])" +
           "Values" +
            "('{0}','{1}','{2}',{3},{4},{5},{6},0)";
            insertQuery = string.Format(insertQuery,
                ruleHeaderId,
                !string.IsNullOrEmpty(valueIdentifier) ? "'"+valueIdentifier + "'": "null",
                rulePropertyId,
                !string.IsNullOrEmpty(effectiveDate) ? "'" + effectiveDate + "'" : "null",
                !string.IsNullOrEmpty(expirationDate) ? "'" + expirationDate + "'" : "null",
                !string.IsNullOrEmpty(parentRuleHeaderId) ? "'" + parentRuleHeaderId + "'" : "null",
                ruleType);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                status = cmd.ExecuteNonQuery();
                con.Close();
            }
            return ruleHeaderId;
        }

        public Guid GetPropertyTypeIdfromPropertyCode(string propertyCode)
        {
            Guid propertyTypeId = Guid.Empty;
            string selectQuery = "SELECT [PropertyTypeID] FROM [PropertyType] where [Code]='{0}'";
            selectQuery = string.Format(selectQuery, propertyCode);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open(); SqlCommand cmd = new SqlCommand(selectQuery, con);
                object guid = cmd.ExecuteScalar();
                con.Close();
                propertyTypeId = Guid.Parse(guid.ToString());
            }
            return propertyTypeId;
        }

        public Guid AddRuleDetail(string parentRuleDetailId, string ruleHeaderId, string rulePropertyId, string valueIdentifier, string value, int isDefault, int isDeleted, int sortId)
        {
            Guid ruleDetailId = Guid.NewGuid();
            int status = 0;
            string insertQuery = "INSERT INTO [RuleDetail]" +
           "([RuleDetailID]" +
           ",[ParentRuleDetailID]" +
           ",[RuleHeaderID]" +
           ",[RulePropertyId]" +
           ",[ValueIdentifier]" +
           ",[Value]" +
           ",[IsDefault]" +
           ",[IsDeleted]" +
           ",[SortId])" +
            "VALUES" +
           "('{0}',{1},{2},'{3}','{4}','{5}','{6}','{7}','{8}')";
            insertQuery = string.Format(insertQuery, ruleDetailId,
                !string.IsNullOrEmpty(parentRuleDetailId) ? "'" + parentRuleDetailId + "'" : "null",
                !string.IsNullOrEmpty(ruleHeaderId) ? "'" + ruleHeaderId + "'" : "null",
                rulePropertyId,
                valueIdentifier, value, isDefault, isDeleted, sortId);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                status = cmd.ExecuteNonQuery();
                con.Close();
            }

            return ruleDetailId;
        }

        public Guid GetRulePropertyIdfromPropertyCode(string ruleCode)
        {
            // propertyCode = "RRB";
            Guid rulePropertyId = Guid.Empty;
            string selectQuery = "SELECT [RulePropertyID] FROM [RuleProperty] where [Code]='{0}'";
            selectQuery = string.Format(selectQuery, ruleCode);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                object guid = cmd.ExecuteScalar();
                con.Close();
                rulePropertyId = Guid.Parse(guid.ToString());
            }
            return rulePropertyId;
        }

        public Guid GetAverageConvenionBasedOnCode(string code)
        {
            Guid aerageConventionId = Guid.Empty;
            string selectQuery = "SELECT [AverageConventionID] FROM [AverageConvention] where [Code]='{0}'";
            selectQuery = string.Format(selectQuery, code);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                object guid = cmd.ExecuteScalar();
                con.Close();
                aerageConventionId = Guid.Parse(guid.ToString());
            }
            return aerageConventionId;
        }

        public Guid GetTaxTreatmentBasedOnName(string name)
        {
            Guid taxTreatmentId = Guid.Empty;
            string selectQuery = "SELECT [TaxTreatmentID] FROM [TaxTreatement] where [Name]='{0}'";
            selectQuery = string.Format(selectQuery, name);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                object guid = cmd.ExecuteScalar();
                con.Close();
                taxTreatmentId = Guid.Parse(guid.ToString());
            }
            return taxTreatmentId;
        }

        public Guid GetDepreciationMethodBasedOnCode(string code)
        {
            Guid depreciationMethodId = Guid.Empty;
            string selectQuery = "SELECT [DepreciationMethodID] FROM [DepreciationMethod] where [code]='{0}'";
            selectQuery = string.Format(selectQuery, code.Trim());
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                object guid = cmd.ExecuteScalar();
                con.Close();
                depreciationMethodId = Guid.Parse(guid.ToString());
            }
            return depreciationMethodId;
        }

        public Guid GetRuleHeaderIdBasedOnDate(string rulepropertyid, string bookId, string effectiveDate, string expirationdate, string defRowHeaderId)
        {
            Guid ruleHeaderId = Guid.Empty;
            string selectQuery = string.Empty;
            if (string.IsNullOrEmpty(expirationdate))
            {
                selectQuery = "SELECT [ruleheaderid] FROM [ruleheader] where[rulepropertyid]='{0}' and [valueidentifier]='{1}' and [effectivedate] = {2} and [expirationdate] {3} and [parentruleheaderid] ='{4}'";
                selectQuery = string.Format(selectQuery, rulepropertyid, bookId, !string.IsNullOrEmpty(effectiveDate) ? "'" + effectiveDate + "'" : "is null",
                !string.IsNullOrEmpty(expirationdate) ? "'" + expirationdate + "'" : "is null", defRowHeaderId);
            }
            else if (string.IsNullOrEmpty(effectiveDate))
            {
                selectQuery = "SELECT [ruleheaderid] FROM [ruleheader] where[rulepropertyid]='{0}' and [valueidentifier]='{1}' and [effectivedate] {2} and [expirationdate] = {3} and [parentruleheaderid] ='{4}'";
                selectQuery = string.Format(selectQuery, rulepropertyid, bookId, !string.IsNullOrEmpty(effectiveDate) ? "'" + effectiveDate + "'" : "is null",
                !string.IsNullOrEmpty(expirationdate) ? "'" + expirationdate + "'" : "is null", defRowHeaderId);
            }
            else
            {
                selectQuery = "SELECT [ruleheaderid] FROM [ruleheader] where[rulepropertyid]='{0}' and [valueidentifier]='{1}' and [effectivedate]= {2} and [expirationdate]={3} and [parentruleheaderid] ='{4}'";
                selectQuery = string.Format(selectQuery, rulepropertyid, bookId, !string.IsNullOrEmpty(effectiveDate) ? "'" + effectiveDate + "'" : "null",
                    !string.IsNullOrEmpty(expirationdate) ? "'" + expirationdate + "'" : "null", defRowHeaderId);
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                object guid = cmd.ExecuteScalar();
                con.Close();
                if (guid != null)
                {
                    ruleHeaderId = Guid.Parse(guid.ToString());
                }
            }
            return ruleHeaderId;
        }

        public Guid GetEstimatedLifeBasedOnCode(string code)
        {
            Guid estimatedLifeId = Guid.Empty;
            string selectQuery = "SELECT [EstimatedLifeID] FROM [EstimatedLife] where [code]='{0}'";
            selectQuery = string.Format(selectQuery, code);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                object guid = cmd.ExecuteScalar();
                con.Close();
                estimatedLifeId = Guid.Parse(guid.ToString());
            }
            return estimatedLifeId;
        }

        public string GetBookIdBasedOnCode(string code)
        {
            string selectQuery = "SELECT [BookID] FROM [Book] where [CODE]='{0}' ";
            selectQuery = string.Format(selectQuery, code);
            string bookID = string.Empty;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                object guid = cmd.ExecuteScalar();
                con.Close();
                bookID = Convert.ToString(guid);
            }
            return bookID;
        }

        public Guid GetCodeSectionIdBasedOnCodeSectionName(string codeSectionCode)
        {
            Guid codeSectionId = Guid.Empty;
            string selectQuery = "SELECT [CodeSectionId] FROM [CodeSection] where [code]='{0}'";
            selectQuery = string.Format(selectQuery, codeSectionCode);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                object guid = cmd.ExecuteScalar();
                con.Close();
                codeSectionId = Guid.Parse(guid.ToString());
            }
            return codeSectionId;
        }

        public Guid GetDecliningBalanceBasedOnCode(string code)
        {
            Guid decliningBalanceId = Guid.Empty;
            string selectQuery = "SELECT [DecliningBalanceID] FROM [DecliningBalance] where [code]='{0}'";
            selectQuery = string.Format(selectQuery, code);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                object guid = cmd.ExecuteScalar();
                con.Close();
                decliningBalanceId = Guid.Parse(guid.ToString());
            }
            return decliningBalanceId;
        }

        public Guid GetMacrsBonusBasedOnDescription(string desc)
        {
            Guid macrsBonusId = Guid.Empty;
            string selectQuery = "SELECT [MACRSBonusId] FROM [MACRSBonus] where [Description]='{0}'";
            selectQuery = string.Format(selectQuery, desc);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                object guid = cmd.ExecuteScalar();
                con.Close();
                macrsBonusId = Guid.Parse(guid.ToString());
            }
            return macrsBonusId;
        }

        public Guid GetRuleDefColumnBasedOnRulePropertyId(Guid propertyTypeId)
        {
            Guid ruleDef = Guid.Empty;
            string selectQuery = "SELECT [RuleHeaderId] FROM [RuleHeader] where [ValueIdentifier]='{0}'and [RuleTypeId] = 2";
            selectQuery = string.Format(selectQuery, propertyTypeId);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                object guid = cmd.ExecuteScalar();
                con.Close();
                ruleDef = Guid.Parse(guid.ToString());
            }
            return ruleDef;

        }

        public Guid GetITCBasedOnCode(string code)
        {
            Guid ITCId = Guid.Empty;
            string selectQuery = "SELECT [ITCId] FROM [ITC] where [Code]='{0}'";
            selectQuery = string.Format(selectQuery, code);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                object guid = cmd.ExecuteScalar();
                con.Close();
                ITCId = Guid.Parse(guid.ToString());
            }
            return ITCId;
        }

        public Guid GetZoneIdBasedOnZoneCode(string code)
        {
            Guid zoneId = Guid.Empty;
            string selectQuery = "SELECT [ZoneTypeId] FROM [ZoneType] where [Code]='{0}'";
            selectQuery = string.Format(selectQuery, code);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                object guid = cmd.ExecuteScalar();
                con.Close();
                zoneId = Guid.Parse(guid.ToString());
            }
            return zoneId;
        }

        public Guid GetS179OtherBasedOnCode(string code)
        {
            Guid s179otherId = Guid.Empty;
            string selectQuery = "SELECT [S179OtherDeductionsId] FROM [S179OtherDeductions] where [Code]='{0}'";
            selectQuery = string.Format(selectQuery, code);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                object guid = cmd.ExecuteScalar();
                con.Close();
                s179otherId = Guid.Parse(guid.ToString());
            }
            return s179otherId;
        }

        public Guid GetSalvageIdOnDecription(string description)
        {
            Guid salvageId = Guid.Empty;
            string selectQuery = "SELECT [SalvageValueId] FROM [SalvageValues] where [Description]='{0}'";
            selectQuery = string.Format(selectQuery, description);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                object guid = cmd.ExecuteScalar();
                con.Close();
                salvageId = Guid.Parse(guid.ToString());
            }
            return salvageId;
        }

        public Guid GetPreACRSBonusOnDecription(string description)
        {
            Guid preACRSBonusId = Guid.Empty;
            string selectQuery = "SELECT [PreACRSBonusId] FROM [PreACRSBonus] where [Description]='{0}'";
            selectQuery = string.Format(selectQuery, description);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                object guid = cmd.ExecuteScalar();
                con.Close();
                preACRSBonusId = Guid.Parse(guid.ToString());
            }
            return preACRSBonusId;
        }

        public void DeleteFromRuleDetail(Guid ruleDetailId)
        {
            string selectQuery = "DELETE FROM [RuleDetail] where [RuleDetailId]='{0}'";
            selectQuery = string.Format(selectQuery, ruleDetailId);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                object guid = cmd.ExecuteScalar();
                con.Close();
            }
        }

        public Guid GetDefinitionIdBasedOnPropertyTypeId(Guid propertyTypeId)
        {
            Guid ruleHeaderId = Guid.Empty;
            string selectQuery = "SELECT [RuleHeaderId] FROM [RuleHeader] where [RuleTypeId] = 2 and [ValueIdentifier]='{0}'";
            selectQuery = string.Format(selectQuery, propertyTypeId);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                object guid = cmd.ExecuteScalar();
                con.Close();
                ruleHeaderId = Guid.Parse(guid.ToString());
                return ruleHeaderId;
            }
        }
        //    public void InsertIntoTaxTreatmentAssociation(Guid FSTTaxTreatmentId,Guid FAMTTaxTreatmentId,Guid FACETaxTreatmentId,Guid FENPTaxTreatmentId,Guid FBTaxTreatmentId)
        //    INSERT INTO [TaxTreatmentAssociation]
        //       ([FSTTaxTreatmentId]
        //       ,[FAMTTaxTreatmentId]
        //       ,[FACETaxTreatmentId]
        //       ,[FENPTaxTreatmentId]
        //       ,[FBTaxTreatmentId])
        // VALUES
        //       (<FSTTaxTreatmentId, uniqueidentifier,>
        //       ,<FAMTTaxTreatmentId, uniqueidentifier,>
        //       ,<FACETaxTreatmentId, uniqueidentifier,>
        //       ,<FENPTaxTreatmentId, uniqueidentifier,>
        //       ,<FBTaxTreatmentId, uniqueidentifier,>)

        //}
    }
}
