﻿// See https://aka.ms/new-console-template for more information
/*
double n1 = 5.5;
double n2 = 8.0;
double n3 = 6.8;
double media = (n1+n2+n3)/3;
if(media >= 7){
    Console.WriteLine($"\nMedia {media:F1}: Aprovado");
} else {
    Console.WriteLine($"\nMedia {media:F1}: Recuperacao");
} */
/*
double n4 = 5.5;
double n5 = 8.0;
double n6 = 6.9;
double media2 = (n4+n5+n6)/3;
if(media2 >= 7){
    Console.WriteLine($"Media {media2:F1}: Aprovado");
} else if(media2 < 7 && media2 >=5){
    Console.WriteLine($"Media {media2:F1}: Recuperacao");
} else {
    Console.WriteLine($"Media {media2:F1}: Reprovado");
}
Console.WriteLine("Digite um vogal: ");
string letra = Console.ReadLine();
if(letra =="a" || letra == "A"){
    Console.WriteLine($"Voce digitou a vogal: {letra}");
} else if(letra =="b" || letra == "B"){
    Console.WriteLine($"Voce digitou a vogal: {letra}");
} else if(letra =="c" || letra == "C"){
    Console.WriteLine($"Voce digitou a vogal: {letra}");
} else if(letra =="d" || letra == "D"){
    Console.WriteLine($"Voce digitou a vogal: {letra}");
} else if(letra =="e" || letra == "E"){
    Console.WriteLine($"Voce digitou a vogal: {letra}");
} else if(letra =="f" || letra == "F"){
    Console.WriteLine($"Voce digitou a vogal: {letra}");
} else if(letra =="g" || letra == "G"){
    Console.WriteLine($"Voce digitou a vogal: {letra}");
} else if(letra =="h" || letra == "H"){
    Console.WriteLine($"Voce digitou a vogal: {letra}");
} else if(letra =="i" || letra == "I"){
    Console.WriteLine($"Voce digitou a vogal: {letra}");
} else if(letra =="j" || letra == "J"){
    Console.WriteLine($"Voce digitou a vogal: {letra}");
} else if(letra =="k" || letra == "K"){
    Console.WriteLine($"Voce digitou a vogal: {letra}");
} else if(letra =="l" || letra == "L"){
    Console.WriteLine($"Voce digitou a vogal: {letra}");
} else if(letra =="m" || letra == "M"){
    Console.WriteLine($"Voce digitou a vogal: {letra}");
} else if(letra =="n" || letra == "N"){
    Console.WriteLine($"Voce digitou a vogal: {letra}");
} else if(letra =="o" || letra == "O"){
    Console.WriteLine($"Voce digitou a vogal: {letra}");
} else {
    Console.WriteLine($"Voce digitou: {letra} que nao e uma vogal")
}
*/
//Exemplo Switch Case
/*
string dia = "Sabado";

switch(dia)
{
    case "Sabado":
        Console.WriteLine("Sabadoooo!");
        break;
    case "Domingo":
        Console.WriteLine("Domingao, hoje e dia de ver o malvadao!");
        break;
    default:
        Console.WriteLine("Hoje e dia de semana, para de preguica, levanta e vai trabalhar");
        break;
}
*/
//operador ternario

//int idade = 18;
//string mensagem = idade >= 18 ? "Maior de idade" : "Menor de idade";
//Console.WriteLine(mensagem);


//ex01 / readline espera uma string
/*
Console.Write("Informe a idade para acesso: ");
double id1 = Console.Read();

Console.Write("\nSe menor, possui autorizacao do responsavel? [s/n]: ");
string? aut = Console.ReadLine();

bool midad = id1 <= 18 ? true : false;

if (midad || aut == "s"){
    Console.WriteLine("\nEntrada autorizada");
} else {
    Console.WriteLine("\nEntrada nao autorizada");
}
Console.WriteLine(id1);
*/
//ex01 corrigido
/*
bool maioridade = true;
bool posaut = false;

if(maioridade || posaut){
    Console.WriteLine("Entrada Liberada");
} else {
    Console.WriteLine("Entrada nao liberada");
}
*/
//ex02
/*
bool pres = true;
double media = 6.9;
string resultado = pres && media >=7 ? "Aprovado" : "Reprovado";
Console.WriteLine($"{resultado} com media {media}");

bool possuipresencaminima = true;
double media3 = 7.0;

if (possuipresencaminima && media3 >= 7){
    Console.WriteLine($"Media {media3}: Aprovado");
} else {
    Console.WriteLine($"Media {media3}: Reprovado");
}
*/
// ex03
bool chuva = false;
bool tarde = false;

if(!chuva && !tarde){
    Console.WriteLine("Nao choveu e nao esta tarde, logo vou pedalar!");
} else if(!chuva && tarde){
    Console.WriteLine("Nao choveu, porem esta tarde para pedalar.");
} else {
    Console.WriteLine("Nao irei pedalar pois choveu.");
}
