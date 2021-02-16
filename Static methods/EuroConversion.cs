using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_methods
{
    class EuroConversion
    {
        private static decimal _exchangeRate = 40.3399M;
        public static decimal ExchangeRate { get => _exchangeRate; }
        public static decimal ToBEF(decimal amount)
        {
            return amount * ExchangeRate;
        }
        public static decimal ToEuro(decimal amount)
        {
            return amount / ExchangeRate;
        }


    }
}
