using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleBaseInsertion
{
    public class ITCDTO
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string EffectiveDate { get; set; }

        public string ExpiryDate { get; set; }

        public string MaxLimitPercentage { get; set; }

        public string MaxLimitDollars { get; set; }

        public string BasisReduction { get; set; }
    }
}
