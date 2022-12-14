using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    public class TimePeriod
    {
        double seconds = 0;

        public double Hour
        {
            set
            {
                if (value >= 0)
                    seconds = value * 3600;
            }

            get
            {
                return seconds / 3600;
            }
        }

        public double Minutes
        {
            get
            {
                return seconds / 60;
            }
        }
    }
}
