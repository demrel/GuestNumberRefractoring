using GuestNumberRefractoring.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestNumberRefractoring.IteratorPattern
{
    public abstract class Iterator : IEnumerator<GuessedNumber>
    {
        public abstract GuessedNumber Current { get; }
        object IEnumerator.Current => Current;
        public abstract void Dispose();
        public abstract bool MoveNext();
        public abstract void Reset();
        public abstract int Key();

    }
}
