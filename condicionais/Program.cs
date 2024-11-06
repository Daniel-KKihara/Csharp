// See https://aka.ms/new-console-template for more information
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
