using System;

namespace ProjetoPessoa
{
    public class Pessoa
    {
        public string Nome;
        public double Altura;
        public int Idade;

        public Pessoa(string nome, double altura, int idade) 
        {
            Nome = nome;
            Altura = altura;
            Idade = idade;
        
        }

        public void Apresentar()
        {
            Console.WriteLine($"\nO Nome Digitado Foi: {Nome} ");
            Console.WriteLine($"\nA altura digitada Foi: {Altura} ");
            Console.WriteLine($"\nA Idade digitada Foi: {Idade} ");
            
        }
            

    }
}
