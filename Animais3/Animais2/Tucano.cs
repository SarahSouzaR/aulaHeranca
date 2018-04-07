using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais2
{
    class Tucano : Ave
    {
        public virtual string descricao()
        {
            return "Tucano - " + "Peso: " + peso + ", idade: " + idade + ", quantidade de membros: " + membros + ". \n";
        }


    }
}
