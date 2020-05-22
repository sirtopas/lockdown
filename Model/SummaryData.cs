using System;
using System.Collections.Generic;

namespace Lockdown.Model
{
    public class SummaryData
    {
        public Global Global { get; set; }

        public IEnumerable<CountryDataItem> Countries { get; set; }

        public DateTime Date { get; set; }
    }
}