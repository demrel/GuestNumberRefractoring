using GuestNumberRefractoring.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestNumberRefractoring.IteratorPattern
{
    public class StepCollection : IteratorAggregate
    {
        private readonly List<GuessedNumber> _collection;
        private readonly NumberPredicator Predicator;
     

        public StepCollection(NumberPredicator predicator)
        {
            Predicator = predicator;
            _collection = new();
        }
    

        public GuessedNumber this[int i]
        {
            get =>_collection[i]; 
        }

        private void AddItem(GuessedNumber number)
        {
            _collection.Add(number);
        }

        public void PredicateNumber(int step)
        {
            AddItem(Predicator.PredicateNumber().AddStep(step));
        }
      
        public override IEnumerator<GuessedNumber> GetEnumerator()
        {
            return new StepIterator(this, Predicator.InputNumber);
        }
    }
}
