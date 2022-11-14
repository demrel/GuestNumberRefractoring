using GuestNumberRefractoring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestNumberRefractoring
{
    public class NumberPredicator
    {
        public readonly int InputNumber;
        private RangeNumber rangeNumber;
        public NumberPredicator(int inputNumber, int min = 0, int max = 100)
        {
            InputNumber = inputNumber;
            rangeNumber = new(min, max);

        }

        public GuessedNumber PredicateNumber()
        {
            var guessNumber = rangeNumber.MiddleNumber;
            ChangeRangeNumber(guessNumber);
            return new GuessedNumber(guessNumber, DetectType(guessNumber));
        }

        private GuessedNumberType DetectType(int guessNumber) =>
             guessNumber switch
             {
                 int n when n == InputNumber => GuessedNumberType.Equal,
                 int n when n < InputNumber => GuessedNumberType.Less,
                 int n when n > InputNumber => GuessedNumberType.Big,
                 _ => GuessedNumberType.Equal,
             };


        private void ChangeRangeNumber(int guessNumber)
        {
            switch (guessNumber)
            {
                case int n when n < InputNumber:
                    rangeNumber = rangeNumber.ChangeMin(n);
                    break;
                case int n when n > InputNumber:
                    rangeNumber = rangeNumber.ChangeMax(n);
                    break;
            }
        }






    }
}
