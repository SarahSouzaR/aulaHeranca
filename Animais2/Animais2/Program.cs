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
            Animal animal = new Animal();
            Mamifero animal1 = new Mamifero();
            Reptil animal2 = new Reptil();
            Ave animal3 = new Ave();
            Canguru animal4 = new Canguru();
            Cachorro animal5 = new Cachorro();
            Tartaruga animal6 = new Tartaruga();
            Tucano animal7 = new Tucano();

            animal1.setCorPelo("dourado");
            animal1.setMembros(4);
            animal1.setPeso(60);
            animal1.setIdade(5);
            animal1.setRaca("Leão");

            animal2.setCorEscama("verde");
            animal2.setIdade(3);
            animal2.setMembros(4);
            animal2.setPeso(25);

            animal3.setCorPena("azul");
            animal3.setIdade(5);
            animal3.setMembros(3);
            animal3.setPeso(15);

            animal4.setCorPelo("marrom claro");
            animal4.setIdade(6);
            animal4.setMembros(4);
            animal4.setPeso(40);

            animal5.setCorPelo("branco");
            animal5.setRaca("Poodle");
            animal5.setIdade(4);
            animal5.setMembros(4);
            animal5.setPeso(35);

            animal6.setCorEscama("verde");
            animal6.setMembros(4);
            animal6.setIdade(2);
            animal6.setPeso(15);
           
            animal7.setCorPena("amarela");
            animal7.setIdade(3);
            animal7.setMembros(2);
            animal7.setPeso(15);

            Console.Write(animal.intro());
            Console.Write(animal1.locomover());
            Console.Write(animal1.alimentar());
            Console.Write(animal1.emitirSom());
            Console.WriteLine(animal1.descricao());

            Console.WriteLine(animal2.descricao());

            Console.Write(animal3.fazerNinho());
            Console.WriteLine(animal3.descricao());

            Console.Write(animal4.locomover());
            Console.Write(animal4.usarBolsa());
            Console.WriteLine(animal4.descricao());

            Console.Write(animal5.enterrarOsso());
            Console.Write(animal5.abanarRabo());
            Console.WriteLine(animal5.descricao());

            Console.Write(animal6.locomover());
            Console.WriteLine(animal6.descricao());

            Console.WriteLine(animal7.descricao());

            Console.ReadKey();

        }
    }
}
