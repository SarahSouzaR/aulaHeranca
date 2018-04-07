using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais2
{
    class Mamifero : Animal
    {
        public string corPelo;
        public string raca;

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

        public override string descricao()
        {
            return "Mamífero - " + "Peso: " + peso + ", idade: " + idade + ", quantidade de patas: " + membros + ", cor do pelo: " + corPelo + ", raça: " + raca + ". \n";
        }
    }
}
