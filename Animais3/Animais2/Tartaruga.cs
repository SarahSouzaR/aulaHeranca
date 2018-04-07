using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais2
{
    class Tartaruga : Reptil
    {
        public override string locomover()
        {
            return "\nEste animal anda lentamente. ";
        }

        public override string descricao()
        {
            return "\n\nTartaruga - " + "Peso: " + peso + ", idade: " + idade + ", quantidade de membros: " + membros + ". \n";
        }


    }
}
