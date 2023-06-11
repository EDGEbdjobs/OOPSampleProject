using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    public class People : IEnumerable<Person>
    {
    
        List<Person> _personList;
        public People()
        {
            _personList = new List<Person>();
        }

        public bool AddPerson(Person person)
        {
            _personList.Add(person);
            return true; 
        }

        public IEnumerator<Person> GetEnumerator()
        {
           //IEnumerator<Person> enumerator = new PersonIterator(_personList);

            return new PersonIterator(_personList);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }



    }

    public class PersonIterator : IEnumerator<Person>
    {
        int currentIndex = -1; 

        List<Person> _personList;

        public PersonIterator(List<Person> personList)
        {
            _personList = personList; 
        }

        public Person Current => _personList[currentIndex];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            currentIndex++;
            return currentIndex < _personList.Count;
        }

        public void Reset()
        {
           currentIndex = -1;
        }
    }


}
