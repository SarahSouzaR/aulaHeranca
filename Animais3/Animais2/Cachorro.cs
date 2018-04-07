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

        public override string descricao()
        {
            return "\n\nCachorro - " + "Peso: " + peso + ", idade: " + idade + ", quantidade de membros: " + membros + ". \n";
        }

        public string reagir(string atitude)
        {
            if (atitude == "brincar" || atitude == "acariciar") 
            {
                Console.WriteLine("Abana o rabo");
            }
            else 
            {
                Console.WriteLine("Rosna");
            }

            return atitude;
        }

        public int reagir(int hora)
        {
            if (hora < 12) 
            {
                Console.WriteLine("Abana o rabo e late");
            }
            else if (hora >= 18) 
            {
                Console.WriteLine("Não liga para o dono");
            }
            else 
            {
                Console.WriteLine("Abana o rabo");
            }
            return hora;
        }

        public Boolean reagir(Boolean dono)
        {
            if (dono == true)
            {
                Console.WriteLine("Abana o rabo e brinca");
            }
            else
            {
                Console.WriteLine("Avança e rosna");
            }
            return dono;
        }
    }
}
