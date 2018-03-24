using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais2
{
    class Mamifero : Animal
    {
        private string corPelo;
        private string raca;

        public string getCorPelo()
        {
            return corPelo;
        }

        public void setCorPelo(string corPelo)
        {
            this.corPelo = corPelo;
        }

        public string getRaca()
        {
            return raca;
        }

        public void setRaca(string raca)
        {
            this.raca = raca;
        }
    }
}
