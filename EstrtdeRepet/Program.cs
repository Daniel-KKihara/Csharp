// See https://aka.ms/new-console-template for more information
//Estrutura de Repeticao While
/*
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
*/
//do while
int num = 0;
do {
    num++;
    Console.WriteLine($"Numero: {num}");
} while(num < 10);