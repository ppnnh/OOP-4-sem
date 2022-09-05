using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
    interface IAdapter
    {
        object Clone();
    }

    class Adapter : IAdapter
    {
        private readonly Bill _bill;

        public Adapter(Bill bill)
        {
            _bill = bill;
        }

        public object Clone()
        {
            Bill bill = (Bill)_bill.Clone();
            bill.Balance = 10000;
            return bill;
        }
    }
}
