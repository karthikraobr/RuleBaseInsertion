using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleBaseInsertion
{
    public class LuxuryAutoDTO
    {
        public string DepreciationMethod { get; set; }

        public string IsBonus { get; set; }

        public string IsQualifiedByDefault { get; set; }

        public string Zone { get; set; }

        public string LimitYear1 { get; set; }

        public string LimitYear2 { get; set; }

        public string LimitYear3 { get; set; }

        public string LimitYear4 { get; set; }

        public string ThresholdLimit { get; set; }

        public string PercentThresholdLimit { get; set; }

        public string EffectiveDate { get; set; }

        public string ExpiryDate { get; set; }
    }
}
