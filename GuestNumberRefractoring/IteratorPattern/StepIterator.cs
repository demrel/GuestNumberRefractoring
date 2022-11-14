using GuestNumberRefractoring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestNumberRefractoring.IteratorPattern
{
    public class StepIterator : Iterator
    {
        private readonly StepCollection _collection;
        private readonly int _inputNumber;
        private int _position = -1;
        private bool _finde;
        public StepIterator(StepCollection collection, int inputNumber)
        {
            _collection = collection;
            _inputNumber = inputNumber;
        }
        public override GuessedNumber Current {
            get
            {
                if (_position<0)
                {
                    throw new Exception("Cannot finde items, iterator position is negative");
                }
                return _collection[_position];

            }

        }

        public override void Dispose()
        {
            Console.WriteLine("ENd");
            GC.SuppressFinalize(this);
        }

        public override int Key()
        {
            return _position;
        }

        public override bool MoveNext()
        {
            _position++;
            _collection.PredicateNumber(_position + 1);

            if (Current == _inputNumber && !_finde)
            {
                _finde = true;
                return true;
            }
            return !_finde;
        }

        public override void Reset()
        {
            _position = 0;
        }
    }
}
