using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binance.Objects
{
    public class Status
    {
        public OrderStatus? orderStatus { get; set; }
        public Error? error { get; set; }
    }
}
