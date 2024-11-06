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
//Conversao = Metodo parse.
string valorTexto = "100";
Console.WriteLine("A variavel valorTexto e do tipo: " + valorTexto.GetType());
int n2 = int.Parse(valorTexto);
Console.WriteLine("A variavel n2 ("+ n2 +") e do tipo: " + n2.GetType());
//Conversao = Metodo Convert.
string valText = "100";
Console.WriteLine("A variavel valText e do tipo: " + valText.GetType());

int valConvertInt = Convert.ToInt32(valText);
Console.WriteLine("A variavel valConvertInt, converte o valor ("+valConvertInt
+") de valText (string) em: " + valConvertInt.GetType());
/*Metodo ToString = qualquer tipo de dado (primitivo ou 
nao primitivo), pode ser convertido*/
int n3 = 12345;
Console.WriteLine(n3.GetType());

string n3conv = n3.ToString();
Console.WriteLine("Valor convertido: " + n3conv + "\nDo tipo: " 
+ n3conv.GetType());
//Datetime
/*DateTime data = Datetime.Now;
Console.WriteLine(data);

string dataformat = data.ToString("dd:MM:yyy");
Console.WriteLine(dataformat);

string dataformat2 = data.ToString("HH:mm:ss");
Console.WriteLine(dataformat2);*/
//ToString format double
double prc = 29.99;
Console.WriteLine($"O preco e: {prc.ToString("C2")}");
//loc moeda corrente
decimal valor1 = 1234.56m;
string valorUS = valor1.ToString('C', new System.Globalization.CultureInfo("en-US"));
Console.WriteLine(valorUS);

string valorBR = valor1.ToString("C", new System.Globalization.CultureInfo("pt-BR"));
Console.WriteLine(valorUS);