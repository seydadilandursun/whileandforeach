//While and For Each 
//While 
//1den baslayarak consoledan girilen sayiya kadar sayi dahil ortalama hesaplayip konsola yazdiran program
Console.WriteLine("Lutfen bir sayi giriniz:");
int sayi=int.Parse(Console.ReadLine());
int sayac=1;
int toplam=0;
    while (sayac<=sayi)
{
    toplam+=sayac;
    sayac ++;
}
Console.WriteLine(toplam/sayi);
// a dan z ye kadar tum harfleri console yazdir
char character='a';
while (character <'z')
{
  Console.Write(character);//Write yanyana yazdirir
  character++;
}
//for each 
string[] arabalar={"BMW","Ford","Toyota","Nissan"};
foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}