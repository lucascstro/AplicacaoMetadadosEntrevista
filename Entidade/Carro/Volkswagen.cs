using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entidade.Carro
{
   public  class Volkswagen : Carro
    {
        public override void Acelerar() 
        {
            Console.WriteLine("acelera volks");
        }
    }
}
