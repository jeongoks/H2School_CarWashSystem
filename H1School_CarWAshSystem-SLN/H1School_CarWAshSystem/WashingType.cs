using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace H1School_CarWAshSystem
{
    public class WashingType
    {
        public List<Processes> Process { get; set; }

        public WashingType(List<Processes> process)
        {
            Process = new List<Processes>();
            Process = process;
        }

        public void AddProcess(Processes process)
        {
            Process.Add(process);
        }
    }
}