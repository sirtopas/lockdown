using System;

namespace Lockdown.Model
{
    public class CountryCasesPerDay
    {
        public string Country { get; set; }

        public string CountryCode { get; set; }

        public string Province { get; set; }

        public string Lat { get; set; }

        public string Lon { get; set; }

        public int Cases { get; set; }

        public string Status { get; set; }

        public DateTime Date { get; set; }
    }
}