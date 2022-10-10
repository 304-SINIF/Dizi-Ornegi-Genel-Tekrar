int ogrenciSayisi = 0;
Console.Write("Öğrenci sayınızı yazınız: ");
ogrenciSayisi = int.Parse(Console.ReadLine());

string[] isimSoyisim = new string[ogrenciSayisi];
int[] sinav1 = new int[ogrenciSayisi];
int[] sinav2 = new int[ogrenciSayisi];
int[] ortalama = new int[ogrenciSayisi];
string[] durum = new string[ogrenciSayisi];

for (int i = 0; i < ogrenciSayisi; i++)
{
    Console.Write("isim Soyisim: ");
    isimSoyisim[i]=Console.ReadLine();
    Console.Write("İlk sınav notu: ");
    sinav1[i]=int.Parse(Console.ReadLine());
    Console.Write("ikinci sınav notu: ");
    sinav2[i] = int.Parse(Console.ReadLine());
    ortalama[i] = (sinav1[i] + sinav2[i]) / 2;
    if (ortalama[i] >= 60)
        durum[i] = "geçti";
    else
        durum[i] = "kaldı";
}
Console.WriteLine("304 yazılım sınıfı bilgileri aşağıdaki gibidir.");
Console.WriteLine("------------------------------------------------");
Console.WriteLine("------------------------------------------------");

for (int j = 0; j < ogrenciSayisi; j++)
{
    Console.WriteLine(isimSoyisim[j]+" " 
        + sinav1[j]+" " + sinav2[j]+" " 
        + ortalama[j]+" " + durum[j]);
}
Console.Read();