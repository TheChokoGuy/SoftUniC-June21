using System.Collections.Generic;

namespace Recurrsion
{
    public class Dog
    {
        public List<int> dogs = new List<int>();

        public string _name;
        public string _lastName;
        public int _dogAge;
        
        public Dog(string name, string lastName, int dogAge)
        {
            name = _name;
            lastName = _lastName;
            dogAge = _dogAge;
            dogs.Add(1);
        }

    }
}