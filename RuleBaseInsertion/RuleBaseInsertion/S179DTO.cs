
using System.Collections.Generic;
namespace RuleBaseInsertion
{
    public class S179DTO
    {
        public string DepreciationMethod { get; set; }

        public string  EstimatedLife { get; set; }

        public string S179Applicable { get; set; }

        public string IsQualifiedByDefault { get; set; }

        public string Zone { get; set; }

        public string BaseLimit { get; set; }

        public string ThresholdLimit { get; set; }

        public string PercentThresholdLimit { get; set; }

        public string EffectiveDate { get; set; }

        public string ExpiryDate { get; set; }

        public Dictionary<string,string> Classifications { get; set; }
    }
}
