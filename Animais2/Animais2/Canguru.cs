using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais2
{
    class Canguru : Mamifero
    {
        public string usarBolsa()
        {
            return "Este animal possui uma bolsa em que seus filhotes se alocam lá durante um período.";
        }

        public override string locomover()
        {
            return "Este animal anda, podendo dar saltos bem altos.";
        }
    }
}
