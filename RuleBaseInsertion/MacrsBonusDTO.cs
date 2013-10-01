using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleBaseInsertion
{
    public class MacrsBonusDTO
    {
        public string EffectiveDate { get; set; }

        public string ExpiryDate { get; set; }

        //public string PropertyType { get; set; }

        public bool IsDefault { get; set; }

        public string BonusPercentage { get; set; }

        public string Description { get; set; }
    }
}
