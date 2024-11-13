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

//Criando a lista e adicionando elementos
List<string> listaNomes = new List<string> {"Wanderson", "Jeane", "Ryan"};
listaNomes.Add("Maria");
//Exibindo a lista inicial
for (int i = 0; i < listaNomes.Count; i++){
    if (i == 0){
        Console.Write($"{listaNomes[i]}");
    } else {
        Console.Write($", {listaNomes[i]}");
    }
}

//verificar se um nome esta na lista
Console.WriteLine("\nVerificacao de existencia do nome 'Ryan':");
string nomeverif = "Ryan";
if (listaNomes.Contains(nomeverif)){
    Console.WriteLine($"O nome '{nomeverif}' esta na lista.");
} else {
    Console.WriteLine($"O nome '{nomeverif}' nao esta na lista.");
}

//remover um nome da lista
Console.WriteLine($"\nApos remover 'Wanderson':");
string nomeremove = "Wanderson";
bool foiremovido = listaNomes.Remove(nomeremove);
if (foiremovido){
    Console.WriteLine($"{} foi removido da lista.");
} else {
    Console.WriteLine($"{} nao foi encontrado na lista.");
}