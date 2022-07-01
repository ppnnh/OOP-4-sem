using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
    internal class CurrencyBill : Bill
    {
        [DataMember]
        public readonly string BillName = "Валютный";

        public CurrencyBill()
        {

        }

        public CurrencyBill(string number, decimal? balance, DateTime? openingdate, Owner owner,
                            bool? internetbankalert, bool? smsalert) : base(number, balance,
                            openingdate, owner, internetbankalert, smsalert)
        {
        }
    }
}
