using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais2
{
    class Animal
    {
        public float peso;
        public int idade;
        public int membros;

        public virtual string locomover() 
        {
            return " se locomovem,";
        }

        public string alimentar()
        {
           return " se alimentam";
        }

        public virtual string emitirSom()
        {
            return " e emitem som. \n \n";
        }

        public float getPeso()
        {
            return peso;
        }

        public void setPeso(float peso)
        {
            this.peso = peso;
        }

        public int getIdade()
        {
            return idade;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        public int getMembros()
        {
            return membros;
        }

        public void setMembros(int membros)
        {
            this.membros = membros;
        }

        public virtual string descricao()
        {
            return "Peso: " + peso + ", idade: " + idade + ", quantidade de membros: " + membros + ". \n";
        }

        public string intro()
        {
            return "Todos os animais ";
        }
    }
}
