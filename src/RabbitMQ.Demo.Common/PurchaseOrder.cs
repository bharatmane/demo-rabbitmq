using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ.Demo.Common
{
    [Serializable]
    public class PurchaseOrder
    {
        public decimal AmountToPay;
        public string PoNumber;
        public string CompanyName;
        public int PaymentDayTerms;
    }
}
