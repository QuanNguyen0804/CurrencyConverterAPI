using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverterAPI.Model
{
    public class CurrencyConverter
    {
        public float a;
        public float b;
        public object result;
        public CurrencyConverter(float a, float b)
        {
            this.a = a;
            this.b = b;
        }

        public void mul()
        {
            result = a * b;
        }
    }
}
