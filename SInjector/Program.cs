using System;
using SimpleInjector;


namespace SInjector
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container();
            var lifestyle = Lifestyle.Singleton;
            container.Options.ResolveUnregisteredConcreteTypes = true;

            container.Register<ICart, DataAccessLayer>(lifestyle);

            var BL = container.GetInstance<BussinessLayer>();

            BL.InserttoCart();
            Console.ReadLine();
            /*Console.WriteLine("Presione Escape para detener");
            ConsoleKey tecla;
            do
            {
                while (!Console.KeyAvailable)
                {
                    // To Do : Movimiento del Auto
                }
                tecla = Console.ReadKey(true).Key;
                //hacer algo con la tecla : dirección del Auto
            }
            while (tecla != ConsoleKey.Escape);*/
        }
    }
}
