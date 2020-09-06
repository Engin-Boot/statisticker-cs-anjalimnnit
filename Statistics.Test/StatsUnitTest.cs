using System;
using Xunit;
using Statistics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        
        [Fact]
        public void ReportsCalulatedStatisticsForAListOfNumbers()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<double>{1.5, 8.9, 3.2, 4.5});
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.Average - 4.525) <= epsilon);
            Assert.True(Math.Abs(computedStats.Max - 8.9) <= epsilon);
            Assert.True(Math.Abs(computedStats.Min - 1.5) <= epsilon);
        }
        [Fact]
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<double>{});
            Assert.True(double.IsNaN(computedStats.Average));
            Assert.True(double.IsNaN(computedStats.Max));
            Assert.True(double.IsNaN(computedStats.Min));
    
        }
        [Fact]
        public void WhenCallerInvokesAListOfNumbersHavingNaNThenStatsOfRemainingAreReturnedAndListSizeRemainsUnchanged()
        {   List<double> ListWithNanValues = new List<double>() {1.8,double.NaN,6.9,1.1};
            int count=ListWithNanValues.Count;
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                ListWithNanValues);
                float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.Average - 3.26666667) <= epsilon);
            Assert.True(Math.Abs(computedStats.Max - 6.9) <= epsilon);
            Assert.True(Math.Abs(computedStats.Min - 1.1) <= epsilon);
            Assert.True(ListWithNanValues.Count== count);
          
            
        }
    
        
    }
}