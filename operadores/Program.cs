// See https://aka.ms/new-console-template for more information
//dotnet new console -o
Console.WriteLine("\nExemplos de operadores logicos\n");
//AND(E) Logico: Retorna o valor verdadeiro somente se os dois forem verdadeiros.
bool a = true;
bool b = false;
bool resultado1 = a && b;
Console.Write("True e False = ");
Console.WriteLine(resultado1);
//OR(OU) Logico: Retorna o valor verdadeiro se qualquer um/ou os dois forem verdeiros.
bool c = true;
bool d = false;
bool resultado2 = c || d;
Console.Write("True ou False = ");
Console.WriteLine(resultado2);
//NOT(NAO) Logico: Inverte o valor, se for verdadeiro vira falso, se for falso e verdadeiro.
bool e = true;
bool resultado3 = !e;
Console.Write("NOT True = ");
Console.WriteLine(resultado3);
//XOR(OU exclusivo): Retorna o valor verdadeiro se um dos dois for falso e o outro verdadeiro.
bool f = true;
bool g = true;
bool resultado4 = f ^ g;
Console.Write("True XOR True = ");
Console.WriteLine(resultado4);
//Ordem de precedencia: NOT (!); AND (&&); OU (||); XOR (^).
bool h = true;
bool i = false;
bool j = false;
bool resultado5 = !h || (i && j);
Console.Write("NOT True OR (False AND False) = ");
Console.WriteLine(resultado5);
//Outro exemplo.
bool k = false;
bool l = false;
bool m = false;
bool resultado6 = !k || l && m;
Console.Write("NOT False OU False E False = ");
Console.WriteLine(resultado6);
