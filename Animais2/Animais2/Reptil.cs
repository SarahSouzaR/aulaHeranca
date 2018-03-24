using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais2
{
    class Reptil : Animal
    {
        public string corEscama;

        public string getCorEscama()
        {
            return corEscama;
        }

        public void setCorEscama(string corEscama)
        {
            this.corEscama = corEscama;
        }

        public override string descricao()
        {
            return "Peso: " + peso + ", idade: " + idade + ", quantidade de patas: " + membros + ", cor da escama: " + corEscama + ". \n";
        }
    }
}
