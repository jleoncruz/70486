﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PerfSurf.Counters
{
    public class PerfCounterService
    {
        public PerfCounterService()
        {
            _counters = new List<PerfCounterWrappers>();

            _counters.Add(new PerfCounterWrappers("Processor",
                "Processor", "% Processor Time", "_Total"));

            _counters.Add(new PerfCounterWrappers("Paging",
                "Memory", "Pages/sec"));

            _counters.Add(new PerfCounterWrappers("Disk",
                "PhysicalDisk", "% Disk Time", "_Total"));
        }

        public dynamic GetResults()
        {
            return _counters.Select(c => new { name = c.Name, value = c.Value });
        }

        List<PerfCounterWrappers> _counters;
    }
}