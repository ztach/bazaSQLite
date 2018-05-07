using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bazaSQLite
{
  public  class Person
    {
        private readonly string _firstname;
        private readonly string _lastname;
        private readonly string _pesel;

        public Person (string fName,string flName , string fpesel)
        {
            _firstname = fName;
            _lastname = flName;
            _pesel = fpesel;
        }

        public string FirstName
        {
            get
            {
                return _firstname;
            }
            private set
            {
                FirstName = _firstname;
            }
        }

        public string LastName
        {
            get
            {
                return _lastname;
            }
            private set
            {
                LastName = _lastname;
            }
        }

        public string Pesel
        {
            get
            {
                return _pesel;
            }
            set
            {
                Pesel = _pesel;
            }
        }

    }
}
