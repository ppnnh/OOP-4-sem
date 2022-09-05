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
           /* _bill.Balance = 0;
            _bill.OpeningDate = new DateTime().Date;
            _bill.SMSAlert = false;
            _bill.InternetBankAlert = false;*/
        }

        public void BuildPartB(DateTime? openingdate, decimal? balance)
        {
           // _bill.Number = number;
            _bill.Balance = balance;
            _bill.OpeningDate = openingdate;
            //_bill.Owner = owner;
            /*_bill.SMSAlert = false;
            _bill.InternetBankAlert = false;*/
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

    internal class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildMinimalViableBill(string number, Owner owner)
        {
            _builder.BuildPartA(number, owner);
        }

        public void BuildFullFeaturedBill(  string number, decimal? balance, DateTime?
                                            openingdate, Owner owner, bool?
                                            internetbankalert, bool? smsalert)
        {
            _builder.BuildPartA(number, owner);
            _builder.BuildPartB(openingdate, balance);
            _builder.BuildPartC(internetbankalert, smsalert);
        }
    }

    //// Клиентский код создаёт объект-строитель, передаёт его директору,
    //// а затем инициирует  процесс построения. Конечный результат
    //// извлекается из объекта-строителя.
            //var director = new Director();
            //var builder = new ConcreteBuilder();
            //director.Builder = builder;
            
    //        Console.WriteLine("Standard basic product:");
    //        director.BuildMinimalViableProduct();
    //        Console.WriteLine(builder.GetProduct().ListParts());

    //        Console.WriteLine("Standard full featured product:");
    //        director.BuildFullFeaturedProduct();
    //        Console.WriteLine(builder.GetProduct().ListParts());

    //        // Помните, что паттерн Строитель можно использовать без класса
    //        // Директор.
    //        Console.WriteLine("Custom product:");
    //        builder.BuildPartA();
    //        builder.BuildPartC();
    //        Console.Write(builder.GetProduct().ListParts());
}
