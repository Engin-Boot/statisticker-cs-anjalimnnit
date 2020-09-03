  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics
{
    
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<double> numbers)
        {
            Stats obj = new Stats();
            if (numbers.Count == 0) {
                obj.Max = double.NaN;
                obj.Min = double.NaN;
                obj.Average = double.NaN;
                return obj;
            }
            obj.Max = numbers.Max();
            obj.Min = numbers.Min();
            obj.Average = numbers.Average();
            return obj;
        }
    }
}