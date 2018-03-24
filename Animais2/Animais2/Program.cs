using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mamifero animal1 = new Mamifero();
            Reptil animal2 = new Reptil();
            Ave animal3 = new Ave();
            Canguru animal4 = new Canguru();
            Cachorro animal5 = new Cachorro();
            Tartaruga animal6 = new Tartaruga();
            Tucano animal7 = new Tucano();

            animal1.setCorPelo("Dourado");
            animal1.setMembros(4);
            animal1.setPeso(30.0f);
            animal1.setIdade(2);
            animal1.setRaca("Leão");

            animal2.setCorEscama("Verde");
            animal2.setIdade(3);
            animal2.setMembros(4);
            animal2.setPeso(25.0f);

            animal3.setCorPena("Azul");
            animal3.setIdade(5);
            animal3.setMembros(4);
            animal3.setPeso(15f);

            animal4.setCorPelo("Marrom claro");
            animal4.setIdade(6);
            animal4.setMembros(4);
            animal4.setPeso(40f);

            animal5.setCorPelo("Branco");
            animal5.setRaca("Poodle");
            animal5.setIdade(4);

            animal6.setCorEscama("Verde");
            animal6.setMembros(4);

            animal7.setCorPena("Amarela");
            animal7.setIdade(3);

            Console.WriteLine(animal1.locomover());
            Console.WriteLine(animal1.alimentar());
            Console.WriteLine(animal1.emitirSom());

            Console.WriteLine(animal2);

            Console.WriteLine(animal3.fazerNinho());

            Console.WriteLine(animal4.locomover());
            Console.WriteLine(animal4.usarBolsa());

            Console.WriteLine(animal5.enterrarOsso());
            Console.WriteLine(animal5.abanarRabo());

            Console.WriteLine(animal6.locomover());

            Console.WriteLine(animal7);

        }
    }
}
