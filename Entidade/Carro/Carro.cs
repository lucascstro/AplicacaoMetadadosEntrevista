using ConsoleApp1.Entidade.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entidade.Carro
{
    public abstract class Carro
    {
        public EnumMarcas Marca;

        public Carro(){}

        public Carro(EnumMarcas marca)
        {
            Marca = marca;
        }

        public abstract void Acelerar();
    }
    public  class UsaCarro : Carro
    {
        public override void Acelerar() 
        {
          
        }
    }


}
