using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_12.Classes
{
    public class Provider
    {
        public int ProviderId { get; set; }
        public string ProviderName { get; set; }
        public string ProviderLocation { get; set; }
        private List<Smartphone> Smartphones { get; set; }

        public Provider(int providerId, string providerName, string providerLocation)
        {
            ProviderId = providerId;
            ProviderName = providerName;
            ProviderLocation = providerLocation;
        }
        public Provider() { }
    }
}
