// 1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

int adet = 0;

while (adet < 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    adet++;
}

//2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

int sayi = 0;

while (sayi < 20)
{
    sayi++;
    Console.WriteLine(sayi);
}

// 3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

int ciftSayi = 0;

while (ciftSayi < 20)
{
    ciftSayi = ciftSayi + 2;
    Console.WriteLine(ciftSayi);
}

// 4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

int toplam = 0;
int baslangicDeger = 50;

while (baslangicDeger < 150)
{
    Console.WriteLine(toplam += baslangicDeger);
    baslangicDeger++;
}

// 5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

int tekSayiToplam = 0;
int ciftSayiToplam = 0;
int baslangic = 1;

while (baslangic <= 120)
{
    baslangic++;
    if (baslangic % 2 == 0)
    {
        
        // Tek sayıları topluyoruz
        tekSayiToplam += baslangic;
    }
    else
    {
        // Çift sayıları topluyoruz
        ciftSayiToplam += baslangic;
    }
}
// Sonuçları ekrana yazdırıyoruz
Console.WriteLine($"Tek sayıların toplamı: {tekSayiToplam}");
Console.WriteLine($"Çift sayıların toplamı: {ciftSayiToplam}");
