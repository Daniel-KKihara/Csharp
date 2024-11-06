// See https://aka.ms/new-console-template for more information
double n1 = 5.5;
double n2 = 8.0;
double n3 = 6.8;
double media = (n1+n2+n3)/3;
if(media >= 7){
    Console.WriteLine($"\nMedia {media:F1}: Aprovado");
} else {
    Console.WriteLine($"\nMedia {media:F1}: Recuperacao");
}
