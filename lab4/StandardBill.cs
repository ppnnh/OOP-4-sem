using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
    internal class StandardBill : Bill
    {
        [DataMember]
        public readonly string BillName = "Стандартный";

        public StandardBill()
        {

        }

        public StandardBill(string number, decimal? balance, DateTime? openingdate, Owner owner,
                            bool? internetbankalert, bool? smsalert) : base(number, balance,
                            openingdate, owner, internetbankalert, smsalert)
        {
        }
    }
}
