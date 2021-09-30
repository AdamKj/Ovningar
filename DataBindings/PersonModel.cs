using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindings
{
    class PersonModel
    {
        private int _age;

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public PersonModel(int age, string name)
        {
            _age = age;
            _name = name;
        }
    }
}
