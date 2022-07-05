using System;

namespace ConsoleApp_ejercicio_de_parcial_1deJordanLoisi
{
    class Program
    {
        static void Main(string[] args)
        {
			double dolar;
			double euro;
			int pesos;

			Console.Write("ingrese el valor de pesos");
			pesos = int.Parse(Console.ReadLine());

			Console.Write("ingrese el valor del dolar");
			dolar = Double.Parse(Console.ReadLine());

			dolar = pesos / 230;
			euro = dolar / 1.17;

			Console.WriteLine($"la cantidad de dolar que puedo comprar es { dolar}");
			Console.WriteLine($"la cantidad de euros que puedo comprar es  {euro}");
		}
    }
}
