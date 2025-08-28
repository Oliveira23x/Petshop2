using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Petshop2


{

    public class Cachorro : Animal

    {

        public Cachorro(string nome, int idade, string dono, string telefone) : base(nome, idade, dono, telefone) { }

        public override void Atender()

        {

            Console.WriteLine($"Atendendo {nome}! ele esta latindo demais AU AU!!");

        }

    }

}

