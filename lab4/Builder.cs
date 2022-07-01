using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
    internal interface IBuilder
    {
        void BuildPartA(string number, Owner owner);

        void BuildPartB(DateTime? openingdate, decimal? balance);

        void BuildPartC(bool? internetbankalert, bool? smsalert);
    }

    internal class ConcreteBuilder : IBuilder
    {
        private Bill _bill = new Bill();

        public ConcreteBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _bill = new Bill();
        }

        public void BuildPartA(string number, Owner owner)
        {
            _bill.Number = number;
            _bill.Owner = owner;
        }

        public void BuildPartB(DateTime? openingdate, decimal? balance)
        {
            _bill.Balance = balance;
            _bill.OpeningDate = openingdate;
        }

        public void BuildPartC(bool? internetbankalert, bool? smsalert)
        {
            _bill.SMSAlert = smsalert;
            _bill.InternetBankAlert = internetbankalert;
        }

        public Bill Getbill()
        {
            Bill result = _bill;

            Reset();

            return result;
        }
    }
}
