using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_2
{
    internal class Singleton
    {
        private static Singleton _instance;
        public string Settings;

        private Singleton(string settings)
        {
            Settings = settings;
        }

        public static Singleton GetInstance(string settings)
        {
            if (_instance == null)
            {
                _instance = new Singleton(settings);
            }

            return _instance;
        }
    }
}
