using System;
using System.Text;


namespace diasMeses
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            int dias = 0;
            const int diasMeses = 30;
            int resultado = 0;


            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite a quantidade de dias: ");
            dias = int.Parse(Console.ReadLine());


            resultado = dias / diasMeses;

            Console.Write(nome +  dias + " Dias são " + resultado + " meses ");
        

            Console.ReadLine();






        }
    }
}
