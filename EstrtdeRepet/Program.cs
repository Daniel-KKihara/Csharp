// See https://aka.ms/new-console-template for more information
//Estrutura de Repeticao While
/*
using System.Diagnostics.Contracts;
using System.Security.Cryptography;

Random numeroAleat = new Random();
int numalv = numeroAleat.Next(1, 101);
int cont = 0;
//Numero de condicao de parada do While
Console.WriteLine($"Numero Alvo: {numalv}");
//loop
while (cont <= numalv) {
    Console.WriteLine($"Contador: {cont}");
    cont++;
}
Console.WriteLine($"\nO valor final do contador: {cont}\n");

//do while
int num = 0;
do {
    num++;
    Console.WriteLine($"Numero: {num}");
} while(num < 10);

//loop for
for (int i = 0; i<=10; i++){
    Console.WriteLine($"Valor de i: {i}");
}

//loop foreach com array
int contador = 0;   
string[] nomes = {"Daniel", "Akemilly", "Banguela"};
foreach(string nome in nomes){
    contador++;
    Console.WriteLine($"{contador}° nome: {nome}");
}
*/

// //ex01

// int count = 0;
// int countsom = 0;
// for(int i = 0; i < 100; i++){
//     if(count%2==0){
//         Console.WriteLine($"Somando com {count}");
//         countsom = countsom + count;
//     }
//     count++;
// }
// Console.WriteLine($"O resultado final da somatoria dos pares de 0 a 100 e: {countsom}\n");


// //ex02

// for(int i = 10; i > 0; i--){
//     Console.WriteLine($"Contagem: {i}");
//     if(i == 1){
//     Console.WriteLine("Decolar!\n");
//     }
// }


// //ex03

// Console.Write("\nInforme uma palavra para a contagem de vogais: ");
// string palavracont = Console.ReadLine();

// int conta = 0;
// int conte = 0;
// int conti = 0;
// int conto = 0;
// int contu = 0;
// int totVogais = 0;
// for(int i=0; i < palavracont.Length; i++){
//     char vogal = palavracont[palavracont.Length-i-1];
//     string vogalconvert = vogal.ToString();
//     switch(vogalconvert){
//         case "a":
//             conta++;
//             break;
//         case "e":
//             conte++;
//             break;
//         case "i":
//             conti++;
//             break;
//         case "o":
//             conto++;
//             break;
//         case "u":
//             contu++;
//             break;
//     }
// }
// Console.WriteLine($"Foram encontradas {conta} vogais 'a'");
// Console.WriteLine($"Foram encontradas {conte} vogais 'e'");
// Console.WriteLine($"Foram encontradas {conti} vogais 'i'");
// Console.WriteLine($"Foram encontradas {conto} vogais 'o'");
// Console.WriteLine($"Foram encontradas {contu} vogais 'u'");
// totVogais = conta+conte+conti+conto+contu;
// Console.WriteLine($"\nO total de vogais na palavra informado foram: {totVogais}");

// //ex04

// Console.Write("\nInforme uma palavra: ");
// string? mensagem = Console.ReadLine();
// string palindr = "";
// for(int i=0; i < mensagem.Length; i++){
//     palindr = palindr+(mensagem[mensagem.Length-i-1]);
// }
// if(palindr == mensagem){
//     Console.WriteLine($"A palavra {mensagem} e um palindromo, ao contrario: {palindr}\n");
// } else {
//     Console.WriteLine($"A palavra {mensagem} nao e um palindromo, ao contrario: {palindr}\n");
// }

// //ex05

// Random numrand = new Random();
// int rangerand = numrand.Next(1, 101);
// do {
//     Console.Write("\nAdivinhe o numero de 1 a 100: ");
//     string adivi = Console.ReadLine();
//     int adiviconv = int.Parse(adivi);
//     int tentcont = 0;
//     if(rangerand == adiviconv){
//         tentcont++;
//         Console.WriteLine($"Parabens voce acertou o numero em {tentcont} tentativas!\n");
//         break;
//     } else if(rangerand > adiviconv) {
//         tentcont++;
//         Console.WriteLine($"O numero que precisa adivinhar e maior que isso\n");
//     } else if(rangerand < adiviconv) {
//         tentcont++
//         Console.WriteLine($"O numero que precisa adivinhar e menor que isso\n");
//     }
// } while(true);

//CORRECAO EXERCICIOS - 13/11/2024
// //ex01:
// int soma = 0;
// for (int i = 1; i <= 100; i++){
//     if (i % 2 == 0){
//         soma+=1;
//     }   
// }

// Console.WriteLine($"A soma de todos os numeros pares de 1 a 100 e {soma}");

// //exo2:
// for (int i = 10; i >= 1; i--){
//     Console.WriteLine(i);
// }

// Console.WriteLine("Decolar!");

// //ex03:
// Console.WriteLine("Digite uma palavra: ");
// string palavra = Console.ReadLine().ToLower();
// int contageVogais = 0;
// foreach(char letra in palavra){
//     if ("aeiou".Contains(letra)){
//         {
//             contagemVogais++;
//         }
//     }
// }

// Console.WriteLine($"Numero de vogais: {contageVogais}");

// //ex04:
// Console.WriteLine("Digite uma palvra ou frase: ");
// string entrada = Console.ReadLine().ToLower().Replace(" ", "");
// //tolower converte para minusculas e replace remove espacos
// string reverso = new string(entrada.Reverse().ToArray());

// if(entrada == reverso){
//     Console.WriteLine("E um palindromo!");
// } else {
//     Console.WriteLine("Nao e um palindromo!");
// }

//ex05:
Random random = new Random();
Console.WriteLine();
int numeroAlt = random.Next(1, 100);
int tentativa;
int contador = 0;
bool acertou = false;

Console.WriteLine("Tente adivinhar o numero entre 1 e 100: ");
while(!acertou){
    Console.Write("Digite seu palpite: ");
    tentativa = int.Parse(Console.ReadLine());
    if (tentativa < numeroAlt){
        contador++;
        Console.WriteLine("O numero e maior!");
    } else if(tentativa > numeroAlt) {
        contador++;
        Console.WriteLine("O numero e menor!");
    } else {
        contador++;
        Console.WriteLine($"Parabens! Voce adivinhou o numero sorteado '{numeroAlt}' depois de {contador} tentativas ");
        acertou = true;
    }
}
Console.WriteLine("fim");