using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_12.Classes
{
    public class Smartphone
    {
        public int SmartphoneId { get; set; }
        public string SmartphoneName { get; set; }
        public int YearOfIssue { get; set; }
        public double Cost { get; set; }
        public int ProviderId { get; set; }
        public Provider Provider { get; set; }

        public Smartphone(int smartphoneId, string smartphoneName, int yearOfIssue, double cost, int providerId)
        {
            SmartphoneId = smartphoneId;
            SmartphoneName = smartphoneName;
            YearOfIssue = yearOfIssue;
            Cost = cost;
            ProviderId = providerId;
        }
        public Smartphone() { }
    }
}
