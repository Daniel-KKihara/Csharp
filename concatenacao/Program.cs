// See https://aka.ms/new-console-template for more information
//Concatenacao.
string nome = "Daniel";
string saudacao = "Ola, " + nome + "! Bem-vindo";
Console.WriteLine(saudacao);
//Interpolacao de strings.
string nome1 = "Daniel";
string saudacao1 = $"Ola, {nome}! Bem-vindo.";
Console.WriteLine(saudacao1);
//GetType(): identificar tipo de variavel.
int n1 = 5;
Console.WriteLine("Tipo de variavel: " + n1.GetType());
Console.WriteLine("Tipo de variavel: " + nome1.GetType());
//typeof(): identifica tipo de uma classe ou estrutura.
Console.WriteLine(typeof(int));
//Conversao = Metodo parse
string valorTexto = "100";
Console.WriteLine("A variavel valorTexto e do tipo: " + valorTexto.GetType());
int n2 = int.Parse(valorTexto);
Console.WriteLine("A variavel n2 ("+ n2 + ") e do tipo: " + n2.GetType());
