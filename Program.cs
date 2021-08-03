using ConsoleApp1.Entidade.Carro;
using ConsoleApp1.Entidade.Model;
using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Ligar(EnumMarcas marca)
        {
            UsaCarro carro = new UsaCarro();
            carro.Marca = marca;

            if (carro.Marca == EnumMarcas.Ford)
            {
                Ford ford = new Ford();
                ford.Acelerar();
            }
            else
            {
                Volkswagen volkswagen = new Volkswagen();
                volkswagen.Acelerar();
            }



        }

        static void Main(string[] args)
        {
            Ligar(EnumMarcas.Ford);
        }
    }
}
