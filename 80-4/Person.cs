using System;
using System.Collections.Generic;
using System.Text;

namespace _80_4
{
    class Person
    {
        public String fornavn;
        public String efternavn;
        public int fødselsår;

        #region Constructors
        public Person()
        {
            fornavn = "";
            efternavn = "";
        }

        public Person(String fnavn, String enavn, int år)
        {
            fornavn = fnavn;
            efternavn = enavn;
            fødselsår = år;
        }
        #endregion

        public string FuldtNavn()
        {
            return (fornavn + ' ' + efternavn);
        }

        public int Alder()
        {
            return DateTime.Now.Year - fødselsår;
        }


    }
}
