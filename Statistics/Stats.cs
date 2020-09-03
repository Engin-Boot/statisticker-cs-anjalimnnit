 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics
{
public class Stats
    {
        private double average;
        private double max;
        private double min;

        public double Average{
            get { return average;    }
            set { average=value;}
        }
        public double Max{
            get{ return max;}
            set{ max=value; }
        }
        public double Min{
            get{ return min;}
            set{min=value;  }
        }
    }
}