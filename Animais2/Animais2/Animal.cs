using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais2
{
    class Animal
    {
        private float peso;
        private int idade;
        private int membros;

        public virtual string locomover() 
        {
            return "Este animal se locomove,";
        }

        public string alimentar()
        {
           return " se alimenta";
        }

        public string emitirSom()
        {
            return " e emite som.";
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

    }
}
