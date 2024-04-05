using ProjetoPessoa;

string dot = new string('.', 50);
Console.WriteLine("Exercicio de Revisão");
Console.WriteLine(dot);



Console.Write("Digite o seu Nome: ");
string nome = Console.ReadLine();

Console.Write("Digite Sua Altura: ");
double altura = double.Parse(Console.ReadLine());

Console.Write("Digite sua Idade ");
int idade = int.Parse(Console.ReadLine());

Pessoa p = new Pessoa(nome, altura, idade);
p.Apresentar();
