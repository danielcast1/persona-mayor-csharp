using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_busines_logic
{
    public class OlderPerson
    {
        public List<Person> people = new List<Person>();

        public bool  addPerson(Person p)
        {
            if (isGreaterThan18(p.age))
            {
                people.Add(p);
                return true;
            }
            return false;
        }
        private bool validAge(List<Person> people)
        {
            bool ageValid=true;

            foreach(Person p in people)
            {
                if (ageValid)
                {
                    if (isGreaterThan18(p.age))
                    {
                        ageValid = true;
                    }
                }
               
            }
            return true;
        }

        public Person olderPerson()
        {
            int older=0;

            foreach (Person p in people)
            {

                if (older<p.age)
                {
                    older = p.age;
                }

            }

            return people.First((p) => p.age == older);


        }
        private bool isGreaterThan18(int age)
        {
            if (age > 18)
            {
                return true;
            }
            return false;
        }
    }

   
    public class Person
    {
        public Person(string name, int age)
        {
            this.age = age;
            this.name = name;
        }
        public string name { get; set; }
        public int age { get; set; }
    }
}
