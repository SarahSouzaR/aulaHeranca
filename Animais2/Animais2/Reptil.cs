using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais2
{
    class Reptil : Animal
    {
        private string corEscama;

        public string getCorEscama()
        {
            return corEscama;
        }

        public void setCorEscama(string corEscama)
        {
            this.corEscama = corEscama;
        }

    }
}
