using GuestNumberRefractoring.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestNumberRefractoring.IteratorPattern
{
    public abstract class IteratorAggregate : IEnumerable<GuessedNumber>
    {
        public abstract IEnumerator<GuessedNumber> GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
           return  GetEnumerator();
        }
    }
}
