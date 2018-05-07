using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bazaSQLite
{
    public class PersonList
    {
        
        /*
        object oSelectedPersonsA = from Person oPerson in oPersonList
                                   where oPerson.FirstName == "Stan"
                                   select oPerson;
        */
        List<Person> lPerson = new List<Person>()
        {
            new Person("Barbara","Olejnik","68071311285"),
            new Person("Staszek","Olejnik","58111212836")
        };

        //object listka = from x in lPerson select x;
    }
}

