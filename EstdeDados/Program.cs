// See https://aka.ms/new-console-template for more information


/*referem-se a varias maneiras de organizar, gerenciar e armazenar 
dados de forma eficiente para que possam ser acessados e manipulados 
conforme necessario. Estruturas de dados incluem vetore, matrizes, 
listas, listas ligadas, arvores, filas, pilhas e grafos, cada um com 
suas proprias caracteristicas de desempenho e uso*/
// filas = primeiro a entrar, primeiro a sair // pilhas = ultimo a chegar, primeiro a sair
// primeiro elemento do array e 0

//array
// int[] meuArray = new int[5];
// meuArray[0] = 10;
// meuArray[1] = 20;
// meuArray[2] = 30;
// meuArray[3] = 40;
// meuArray[4] = 50;
// Console.WriteLine($"Numeros no array: ");
// for (int i = 0, i < meuArray.Length; i++){
//     Console.WriteLine(meuArray[i]);
// }

//O array nao consegue ter aumento ou diminuicao no seu tamanho
/*Em c#, a List e uma colecao generica que faz parte do namespace 
System,Collections.Generic e representa uma lista de objetos que 
pode crescer ou diminuir dinamicamente, ou sjea adicionar e remover
elementos com facilidade. para sua implementacao usamos a classe List<T>*/

// //Criando a lista e adicionando elementos
// using System.Globalization;

// List<string> listaNomes = new List<string> {"Wanderson", "Jeane", "Ryan"};
// listaNomes.Add("Maria");
// Console.WriteLine("\nExibindo a lista inicial: ");
// for (int i = 0; i < listaNomes.Count; i++){
//     if (i == 0){
//         Console.Write($"{listaNomes[i]}");
//     } else {
//         Console.Write($", {listaNomes[i]}");
//     }
// }

// //verificar se um nome esta na lista
// Console.WriteLine("\n\nVerificacao de existencia do nome 'Ryan':");
// string nomeverif = "Ryan";
// if (listaNomes.Contains(nomeverif)){
//     Console.WriteLine($"O nome '{nomeverif}' esta na lista.");
// } else {
//     Console.WriteLine($"O nome '{nomeverif}' nao esta na lista.");
// }

// //remover um nome da lista
// Console.WriteLine($"\nApos remover 'Wanderson':");
// string nomeremove = "Wanderson";
// bool foiremovido = listaNomes.Remove(nomeremove);
// if (foiremovido){
//     Console.WriteLine($"{nomeremove} foi removido da lista.");
// } else {
//     Console.WriteLine($"{nomeremove} nao foi encontrado na lista.");
// }

// //exibindo a lista final apos a remocao
// Console.WriteLine("\nNomes na lista apos a remocao:");
// for (int i = 0; i < listaNomes.Count; i++){
//     if (i == 0){
//         Console.Write($"{listaNomes[i]}");
//     } else {
//         Console.Write($", {listaNomes[i]}");
//     }
// }

// HashSet<string> listFrutas = new HashSet<string> {"Maca", "Laranja", "Abacaxi"};
// Console.WriteLine("Verficacao de existencia: ");
// Console.WriteLine("Banana esta no conjunto? ");
// if (listFrutas.Contains("Banana")){
//     Console.WriteLine("");
// } else {
//     Console.WriteLine("");
// }

// //EX1

// int[] meuArray = new int[5] {1, 2, 3, 4, 5,};
// int soma = 0;

// Console.Write("\nOs elementos presentes no array sao: ");
// foreach (int num in meuArray){
//     if (num == meuArray[0]){
//         Console.Write(num);
//     } else {
//         Console.Write($", {num}");
//     }
//     soma += num;
// }
// Console.WriteLine($"\nA soma dos numeros no array = {soma}");

// //EX2
// List<string> listNomes = new List<string> {"Jeane", "Wanderson", "Jeane", "Ryan", "Jeane"};
// Console.WriteLine();
// int cont = 0;
// foreach (string nome in listNomes){
//     if (nome.ToLower().Replace(" ", "") == "jeane"){
//         cont += 1;
//     }
// }
// Console.WriteLine($"A Lista repete o nome Jeane {cont} vezes");

// //EX3
// List<int> listNum = new List<int> {1, 2, 2, 3, 4, 4, 5};
// foreach (int num in listNum){
// }
// //EX4
// HashSet<string> feiradaFruta = new HashSet<string> {"Maca", "Banana", "Laranja"};
// if(feiradaFruta.Contains("Banana")){
//     Console.WriteLine("Temos banana na lista");
// } else {
//     Console.WriteLine("Nao temos banana na lista");
// }
//EX5
using System.Globalization;

List<int> numeros = new List<int> {};
for (int index = 0; index <= 4; index++){
    numeros.Add(index+1);
    Console.WriteLine($"Adicionado {index+1}");
}

Console.Write("A Lista com os numeros adicionados ficaram assim: ");
foreach (int num in numeros){
    if (num == numeros[0]){
        Console.Write(num);
    } else {
        Console.Write($", {num}");
    }
}
