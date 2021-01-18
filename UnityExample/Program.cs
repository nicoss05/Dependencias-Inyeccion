using System;
using Unity;
using UnityExample.Contracts;
using UnityExample.Implementations;

namespace UnityExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaramos un contenedor Unity
            var unityContainer = new UnityContainer();



            // Registramos IGame para que cuando se detecte la dependencia
            // proporcione una instancia de TrivialPursuit
            
            unityContainer.RegisterType<IGame, TrivialPursuit>();
       

            // Hacemos que Unity resuelva la interfaz, proporcionando una instancia
            // de la clase TrivialPursuit
            var game = unityContainer.Resolve<IGame>();

            // Comprobamos que el funcionamiento es correcto
            game.AddPlayer();
            game.AddPlayer();

            Console.WriteLine(string.Format("{0} personas jugando a {1}", game.CurrentPlayers, game.Name));
            Console.ReadLine();
            // Instanciamos un objeto de la clase Table a través de Unity
            var table = unityContainer.Resolve<Table>();
            table.Play();


            Console.WriteLine(table.GameStatus());
            Console.ReadLine();

        }
    }
}
