using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binance.Objects
{
    public class Error
    {
        public Enums.ErrorCodes? code { get; set; }
        public string? msg { get; set; }
    }
}
