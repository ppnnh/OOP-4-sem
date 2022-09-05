using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
    internal abstract class AbstractFactory
    {
        public abstract Bill CreateBill();
    }

    internal class ChildFactory : AbstractFactory
    {
        public override Bill CreateBill()
        {
            return new ChildBill();
        }
    }

    internal class CurrencyFactory : AbstractFactory
    {
        public override Bill CreateBill()
        {
            return new CurrencyBill();
        }
    }

    internal class StandardFactory : AbstractFactory
    {
        public override Bill CreateBill()
        {
            return new StandardBill();
        }
    }
}
