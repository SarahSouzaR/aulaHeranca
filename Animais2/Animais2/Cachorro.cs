using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais2
{
    class Cachorro : Mamifero
    {
        public string enterrarOsso()
        {
            return "Esse animal gosta de brincar e enterrar coisas, assim como o seu osso. ";
        }

        public string abanarRabo()
        {
            return "Quando feliz ele abana o seu rabo. ";
        }

        public override string emitirSom()
        {
            return " Ele late. \n \n";
        }
    }
}
