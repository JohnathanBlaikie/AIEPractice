using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesTesting
{
    class TimePeriod
    {
        private int days = 14;
        public int Days
        {
            get
            {
                return days;
            }
            set
            {
                days = value;
            }
        }
        public int Weeks //This acts as a bundle of days which is added to the origional pool of days
        {
            get
            {
                return Days / 7;
            }
            set
            {
                days = value * 7;
            }
        }
    }
    class Money
    {
        public float usd = 427;
        private float aud;
        public float AUD
        {
            set
            {
                aud = value;
            }
            get
            {
                return aud;
            }
        }
        public float USD
        {
            get
            {
                return (1f / .68f) * aud;
            }
        }
       
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            TimePeriod time = new TimePeriod();
            Console.WriteLine("Days: " + time.Days + "\nWeeks: " + time.Weeks);

            Money conversionRate = new Money();
            Console.WriteLine("USD: " + conversionRate.USD + "\nAUD: " + conversionRate.AUD);
            Console.ReadKey();
        }
    }
}
