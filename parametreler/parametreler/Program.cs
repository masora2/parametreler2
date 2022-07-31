string sayi = "999";

bool sonuc = int.TryParse(sayi, out int outSayi);

if (sonuc)
{
    Console.WriteLine("Başarılı! ");
    Console.WriteLine(outSayi + 20);
}

else
{
    Console.WriteLine("Başarısız!");
}
Metotlar instance = new Metotlar();
instance.Topla(4, 5, out int toplamSonucu);
Console.WriteLine(toplamSonucu);
class Metotlar
{
    public void Topla(int a,int b,out int toplam)
    {
        toplam = a + b;
    }
}