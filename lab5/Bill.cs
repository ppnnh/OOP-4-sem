﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Laba_2
{
    [DataContract]
    internal class Bill : IPrototype
    {
        [DataMember]
        [Required(ErrorMessage = "Поле номер должно быть заполнено")]
        [RegularExpression(@"(\d){5,8}", ErrorMessage = "Неверный формат номера")]
        public string Number { get; set; }
        [DataMember]
        [Required(ErrorMessage = "Поле баланс должно быть заполнено")]
        [Range(0, 10000)]
        public decimal? Balance { get; set; }
        [DataMember]
        [Required(ErrorMessage = "Поле дата открытия должно быть заполнено")]
        public DateTime? OpeningDate { get; set; }
        [DataMember]
        [Required(ErrorMessage = "Поле владелец должно быть заполнено")]
        public Owner Owner { get; set; }
        [DataMember]
        [Required(ErrorMessage = "Поле подключения интернет-банкинга должно быть заполнено")]
        public bool? InternetBankAlert { get; set; }
        [DataMember]
        [Required(ErrorMessage = "Поле смс оповещения должно быть заполнено")]
        public bool? SMSAlert { get; set; }

        public Bill()
        {
           
        }

        public Bill(string number, decimal? balance, DateTime? openingdate, Owner owner,
                    bool? internetbankalert, bool? smsalert)
        {
            Number = number;
            Balance = balance;
            OpeningDate = openingdate;
            Owner = owner;
            InternetBankAlert = internetbankalert;
            SMSAlert = smsalert;
        }

        public object Clone()
        {
            return new Bill(Number, Balance, OpeningDate, Owner, InternetBankAlert, SMSAlert);
        }
    }
}
