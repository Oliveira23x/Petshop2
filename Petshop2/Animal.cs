using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Petshop2


{

    public abstract class Animal

    {
        public string nome;

        private string telefone;

        private string Dono;
        

        private int idade { get; set; }


        public int novaIdade
        {
            get { return idade; }
            set
            {
                novaIdade = value;
                {
                    if (value >= 0)
                    {
                        Console.WriteLine("Idade inválida.");
                    }
                    else
                    {
                        idade = value;
                    }
                }
            }
        }

        public string novoTelefone
        {

            get { return telefone; }
            set
            {
                if ( telefone != value) {

            }
        }
        }

        public string novoDono
        {
            get { return Dono; }
            set
            {
                if (Dono != value) // verifica se o novo valor é diferente do atual
                {
                }
            }
        }


        public Animal(string nome, int idade, string telefone, string Dono)

        {
            this.nome = nome;

            this.Dono = Dono;

            this.telefone = telefone;

            this.idade = idade;

        }
        
        public virtual void Atender()
        {
            Console.WriteLine($"Atendendo {nome}");
        }
    }
}


