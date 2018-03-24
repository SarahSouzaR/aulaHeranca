using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais2
{
    class Ave : Animal
    {
        private string corPena;

        public string fazerNinho()
        {
            return "Geralmente ele constrói o seu ninho.";
        }

        public string getCorPena()
        {
            return corPena;
        }

        public void setCorPena(string corPena)
        {
            this.corPena = corPena;
        }

    }
}
