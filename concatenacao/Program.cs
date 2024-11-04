// See https://aka.ms/new-console-template for more information
//Concatenacao
string nome = "Daniel";
string saudacao = "Ola, " + nome + "! Bem-vindo";
Console.WriteLine(saudacao);
//Interpolacao de strings
string nome1 = "Daniel";
string saudacao1 = $"Ola, {nome}! Bem-vindo.";
Console.WriteLine(saudacao1);
//GetType(): identificar tipo de variavel
int n1 = 5;
Console.WriteLine("Tipo de variavel: " + n1.GetType());
Console.WriteLine("Tipo de variavel: " + nome1.GetType());