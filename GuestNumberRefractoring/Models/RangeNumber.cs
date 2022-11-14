using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestNumberRefractoring.Models
{
    public class RangeNumber
    {
        private readonly int Min;
        private readonly int Max;
        public int MiddleNumber =>
           (int)Math.Round((Min + Max) / 2d);

        public RangeNumber(int min, int max)
        {
            Min = min;
            Max = max;
        }

        public RangeNumber ChangeMin(int min)=>
             new (min, Max);
        
        public RangeNumber ChangeMax(int max)=>
                    new (Min, max);
        

     
       


    }
}
