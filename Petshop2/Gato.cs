
using System;
using Petshop2;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Petshop2


{


    public class Gato : Animal


    {
        public Gato(string nome, int idade, string dono, string telefone) : base(nome, idade, dono, telefone) { }

        public override void Atender()

        {

            Console.WriteLine($"Atendendo {nome}! está miando muito MIAU MIAU!");
        }
    }
}
