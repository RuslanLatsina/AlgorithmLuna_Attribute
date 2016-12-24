using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AlgorithmLuna_Attribute
{
    public class CreditCard
    {
        [LuhnCardNumber]
        public string Code { get; set; }
    }
}
