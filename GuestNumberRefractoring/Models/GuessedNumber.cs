using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestNumberRefractoring.Models
{
    public class GuessedNumber
    {
        public int Value;
        public GuessedNumberType Type;
        int Step;
        public GuessedNumber AddStep(int step)
        {
            Step = step;
            return this;
        }
        public GuessedNumber()
        {

        }
        public GuessedNumber(int value, GuessedNumberType type)
        {
            Value = value;
            Type = type;
        }

        public void Deconstruct(out int value)
        {
            value = Value;

        }

        public static bool operator ==(GuessedNumber number, int number2) => number.Value == number2;
        public static bool operator !=(GuessedNumber number, int number2) => number.Value != number2;




        public override string? ToString()=>
            Type switch
            {
                GuessedNumberType.Less => Step + ". Predicated number is Less: " + Value,
                GuessedNumberType.Big => Step + ". Predicated number is Big: " + Value,
                _ => Step + ". Great your number is: " + Value
            };
        

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
