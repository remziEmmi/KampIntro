Console.WriteLine("Hello World");
string kategoriEtikieti = "Kategori";
//type  safety - tip guvenligi
//Do not repeat yourself
//deger tutucu-alias 
Console.WriteLine(kategoriEtikieti);
int ogrenciSayisi = 45;
Console.WriteLine(ogrenciSayisi);
bool sistemeGirisYapmisMi = true;
Console.WriteLine(sistemeGirisYapmisMi);
double dolarDun = 24.6;
double dolarBugun = 60.4;
if (dolarDun>dolarBugun)
{
    Console.WriteLine("Azalis Butonu");
}
else if (dolarDun<dolarBugun)
{
    Console.WriteLine("Artis Butonu");
}
else
{
    Console.WriteLine("Degismedi ");
}
if (sistemeGirisYapmisMi == true) 
{
    Console.WriteLine("If Calisiyor");
}
else
{
    Console.WriteLine("Sisteme Giris Yapiniz");
}

            


