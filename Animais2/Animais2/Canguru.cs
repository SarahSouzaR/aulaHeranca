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
            return " Ele possui uma bolsa em que seus filhotes se alocam durante um período. ";
        }

        public override string locomover()
        {
            return "Este animal anda, podendo dar saltos bem altos.";
        }

        public override string descricao()
        {
            return "Peso: " + peso + ", idade: " + idade + ", quantidade de patas: " + membros + ", cor do pelo: " + corPelo + ". \n";
        }
    }
}
