  
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
            if (numbers.Count == 0) 
                return obj;
            List<double> ListWithoutNanValues = new List<double>();
            ListWithoutNanValues.AddRange(numbers);
            if(ListWithoutNanValues.Contains(double.NaN))
            ListWithoutNanValues.RemoveAll(double.IsNaN);
            obj.Max = ListWithoutNanValues.Max();
            obj.Min = ListWithoutNanValues.Min();
            obj.Average = ListWithoutNanValues.Average();
            return obj;
        }
    }
}