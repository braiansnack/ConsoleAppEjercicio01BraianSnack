using System;

namespace ConsoleAppEjercicio01BraianSnack
{
    class Program
    {

        static void Main(string[] args)
        {
            double CantidadDolar;
            double CantidadEuro;
            double dolar;
            double euro;
            double pesos;
            int seleccion;
            Console.WriteLine("Seleccione la conversion que desea usar");
            Console.WriteLine("1) Pesos a Dolar");
            Console.WriteLine("2) Euros a Dolar");
            seleccion = int.Parse(Console.ReadLine());

            if (seleccion == 1)
            {
                Console.WriteLine("Ud. seleccino convertir Pesos a Dolar");
            }

            else
            {
                if (seleccion == 2)
                    Console.WriteLine("Ud. selecciono convertir Euros a Dolar");
            }


            switch (seleccion)
            {

                case 1:
                    Console.WriteLine("ingresar la cantidad que desea convertir");
                    pesos = double.Parse(Console.ReadLine());
                    CantidadDolar = pesos / 230;
                    Console.WriteLine($"{pesos} pesos son {CantidadDolar} dolares");
                    break;

                case 2:
                    Console.WriteLine("ingresar la cantidad a convertir");
                    euro = double.Parse(Console.ReadLine());
                    CantidadEuro = euro / 1.17;
                    Console.WriteLine($"{euro} euros son {CantidadEuro} dolares");
                    break;

                default:
                    Console.WriteLine("[ERROR] los valores ingresados son incorrectos....");
                    break;
            }
            Console.ReadLine();
        }
    }
}
