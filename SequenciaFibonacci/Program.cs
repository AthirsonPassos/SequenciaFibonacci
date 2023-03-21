using System;

namespace SequenciaFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
			int num1 = 0, num2 = 1, aux, d;
			string r = "";
			Console.WriteLine("Digite um valor: ");
			d = int.Parse(Console.ReadLine());
			Console.ReadKey();

			for (int i = 0; i​​​​​​​ < d; i++)
			{
				aux = num1;
				num1 = num2;
				num2 = num1 + aux;
				if (num2 == d)
				{
					r = "Este número pertence a sequência Fibonacci!";
				}
				else
				{
					r = "Este número não pertence a sequência Fibonacci!";
				}
			}
			Console.WriteLine("{0}", r);
			Console.ReadKey();
		}


    }
}
