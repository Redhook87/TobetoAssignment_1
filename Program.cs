//1 - Switch case ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş edildiğini belirleyen algoritma yazınız.

Console.Write("Sipariş Numarası Giriniz: ");
int siparisNo = Convert.ToInt32(Console.ReadLine());

string urun = siparisNo switch
{
1 => "Bilgisayar",
2 => "Telefon",
3 => "Tablet",
4 => "Televizyon",
5 => "Akıllı Saat",
6 => "Ekran Kartı",
_ => "Geçersiz sipariş numarası"
};

Console.Write("Sipariş edilen ürün : " + urun);


//2 - Kullanıcıdan kaç ürün almak istediğini soran,her ürünün fiyatını alarak toplam alışveriş tutarını hesaplayan bir algoritma yazınız.(döngü için for döngüsü kullanınız)

{
    string[] urunler = { "Ekmek", "Süt", "Yumurta", "Meyve", "Sebze" };
double[] fiyatlar = { 10.0, 35.0, 100.0, 50.0, 35.0 };
double toplamTutar = 0.0;

Console.WriteLine("Marketimize Hoş Geldiniz!");
Console.WriteLine("İşte mevcut ürünler ve fiyatları (TL):");

for (int i = 0; i < urunler.Length; i++)
{
Console.WriteLine((i + 1) + ". " + urunler[i] + " - " + fiyatlar[i].ToString("N2"));
}

Console.Write("\nKaç ürün almak istiyorsunuz? ");
int urunSayisi = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < urunSayisi; i++)
{
Console.Write("Lütfen " + (i + 1) + ". ürünün numarasını giriniz: ");
int urunNumarasi = Convert.ToInt32(Console.ReadLine());

if (urunNumarasi >= 1 && urunNumarasi <= urunler.Length)
{
toplamTutar += fiyatlar[urunNumarasi - 1];
}
else
{
Console.WriteLine("Geçersiz ürün numarası. Lütfen listeden bir numara seçiniz.");
i--;
}
}

Console.WriteLine("\nToplam alışveriş tutarınız: " + toplamTutar.ToString("N2") + " TL");

Console.ReadLine();
}

//3 - Do - While ve While döngüsü nedir? Bununla ilgili örnek yapınız.

//Do-While döngüsü, döngü başlangıçta döngü koşulu kontrol edilmeden önce döngü gövdesini en az bir kez çalıştıran bir döngüdür. Yani, döngü koşulu her zaman en az bir kez döngü gövdesini çalıştırır, ardından koşul kontrol edilir. Koşul doğru olduğu sürece döngü gövdesi tekrar tekrar çalıştırılır.

//Do-While döngüsü için örnek:

{
MenuSec();
}

static void MenuSec()
{
string[] menu = { "Köfte", "Tavuk", "Balık", "Salata", "Makarna", "Pizza", "Kebap" };
List<string> secimler = new List<string>();
bool devam = true;

do
{
Console.WriteLine("Lütfen menüden bir veya daha fazla seçim yapınız (Çıkmak için 'q' tuşuna basın):");
for (int i = 0; i < menu.Length; i++)
{
Console.WriteLine((i + 1) + ". " + menu[i]);
}

string secim = Console.ReadLine();

if (secim == "q")
{
devam = false;
}
else if (int.TryParse(secim, out int secilen) && secilen >= 1 && secilen <= menu.Length)
{
secimler.Add(menu[secilen - 1]);
}
else
{
Console.WriteLine("Geçersiz bir seçim yaptınız. Lütfen tekrar deneyin.");
Thread.Sleep(1000);
}

} while (devam);

Console.WriteLine("Seçimleriniz:");
foreach (string secim in secimler)
{
Console.WriteLine("- " + secim);
}
}

//While döngüsü, belirli bir koşul doğru olduğu sürece bir bloğu tekrar tekrar çalıştıran bir döngüdür. Döngü başlamadan önce koşul kontrol edilir ve koşul doğru olduğu sürece döngü çalışmaya devam eder. Koşul yanlış olduğunda döngü sona erer ve program akışı döngüden sonra gelen kod satırına geçer.

//While döngüsü için bir örnek.

{
    bool eveVarildi = false;
int mesafe = 0;

Console.WriteLine("Yola çıktın.");

while (!eveVarildi)
{
Console.WriteLine("Şu ana kadar " + mesafe + " metre yol kat ettin.");
Console.WriteLine("Yürüyorsun...");
mesafe += 100; // Her adımda 100 metre yol kat ediliyor (örnek olsun diye sabit bir değer kullandık)

// Bir saniye bekleme ekleyelim
System.Threading.Thread.Sleep(1000);

// Eve varma koşulu kontrol ediliyor
if (mesafe >= 1000) // Mesafe 1000 metreye eşit veya daha fazlaysa eve varılmış kabul edilir
{
eveVarildi = true;
}
}

Console.WriteLine("Eve ulaştın. Yolculuk tamamlandı.");
}

//4 - Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.

{
bool dogruSayiGirildi = false;

while (!dogruSayiGirildi)
{
Console.Write("Bir sayı girin: ");
int sayi = Convert.ToInt32(Console.ReadLine());

if (MukemmelSayiMi(sayi))
{
Console.WriteLine(sayi + " mükemmel bir sayıdır.");
dogruSayiGirildi = true;
}
else
{
Console.WriteLine(sayi + " mükemmel bir sayı değildir. Lütfen tekrar deneyin.");
}
}

Console.ReadLine();
}

static bool MukemmelSayiMi(int sayi)
{
int toplam = 0;
for (int i = 1; i < sayi; i++)
{
if (sayi % i == 0)
{
toplam += i;
}
}

return toplam == sayi;
}

//5 - String metotlarını araştırınız. Her bir metot için örnek yapınız.


    //Length: Bir dizenin karakter sayısını döndürür.
    string str1 = "Merhaba";
    int uzunluk = str1.Length;
    Console.WriteLine("1. Uzunluk: " + uzunluk);

    //ToUpper() ve ToLower(): Bir dizgeyi büyük veya küçük harfe dönüştürür.
    string str2 = "Merhaba";
    string buyukHarfli = str2.ToUpper();
    string kucukHarfli = str2.ToLower();
    Console.WriteLine("2. Büyük harfli: " + buyukHarfli);
    Console.WriteLine("   Küçük harfli: " + kucukHarfli);

    //Substring(): Belirtilen dizindeki bir alt dizeden yeni bir dize oluşturur.
    string str3 = "Merhaba Dünya";
    string altDize = str3.Substring(3, 5);
    Console.WriteLine("3. Alt dize: " + altDize);

    //IndexOf() ve LastIndexOf(): Belirli bir alt dizenin dizgi içindeki konumunu bulur.
    string str4 = "Merhaba Dünya";
    int ilkIndex = str4.IndexOf("ha");
    int sonIndex = str4.LastIndexOf("a");
    Console.WriteLine("4. İlk index: " + ilkIndex);
    Console.WriteLine("   Son index: " + sonIndex);

    //Replace(): Belirli bir karakter veya alt dizeyi başka bir karakter veya alt dizeyle değiştirir.
    string str5 = "Merhaba Dünya";
    string yeniStr = str5.Replace("a", "e"); // "Merhebe Dünye"
    Console.WriteLine("5. Değiştirilmiş dize: " + yeniStr);

    //Trim(): Bir dizenin başındaki ve sonundaki boşlukları kaldırır.
    string str6 = "  Merhaba Dünya  ";
    string trimmedStr = str6.Trim();
    Console.WriteLine("6. Kırpılmış dize: " + trimmedStr);

    //Split(): Bir dizeyi belirli bir ayraçla böler ve alt dizelerin bir dizisini döndürür.
    string str7 = "Merhaba,Dünya,Nasılsın";
    string[] parcalar = str7.Split(','); // ["Merhaba", "Dünya", "Nasılsın"]
    Console.WriteLine("7. Parçalar:");
    foreach (string parca in parcalar)
    {
        Console.WriteLine("   - " + parca);
    }



//6 - Bir mağazada alınan ürünün fiyatı 300 tl üzerinde ise 50 tl olan kargo ücreti alınmamaktadır.ürünün fiyatı girildiğinde toplam ödemesi gereken tutarı gösteren programı yazınız.

Console.WriteLine("Mağazaya Hoş Geldiniz!");

        Console.Write("Ürün fiyatını girin (TL): ");
        double urunFiyati = Convert.ToDouble(Console.ReadLine());

        if (urunFiyati > 300)
        {
            Console.WriteLine("Kargo ücreti alınmamaktadır.");
        }
        else
        {
            double kargoUcreti = 50.0;
            double toplamTutar = urunFiyati + kargoUcreti;

    
            Console.WriteLine("Ürün fiyatı: " + urunFiyati + " TL");
            Console.WriteLine("Kargo ücreti: " + kargoUcreti + " TL");
            Console.WriteLine("Toplam ödeme: " + toplamTutar + " TL");
        }

        Console.ReadLine();



//7 - iki ürünün kullanıcı tarafından fiyatı girildiğinde toplam fiyat 500 tl'den fazla ise 2.üründen %40 indirim yaparak ödenecek tutarı gösteren uygulamayı yazınız.

{
    Console.WriteLine("Mağazaya Hoş Geldiniz!");

    Console.Write("1. Ürün fiyatını girin (TL): ");
    double urun1Fiyati = Convert.ToDouble(Console.ReadLine());

    Console.Write("2. Ürün fiyatını girin (TL): ");
    double urun2Fiyati = Convert.ToDouble(Console.ReadLine());

    double toplamFiyat = urun1Fiyati + urun2Fiyati;

    if (toplamFiyat > 500)
    {
        double indirimliUrun2Fiyati = urun2Fiyati * 0.6;

        Console.WriteLine("Toplam ödenecek tutar: " + (urun1Fiyati + indirimliUrun2Fiyati) + " TL");
    }
    else
    {
        Console.WriteLine("Toplam ödenecek tutar: " + toplamFiyat + " TL");
    }

    Console.ReadLine();
}

//8 - 1 - 200 arası içinde 3'e veya 5'e tam bölünebilen sayıları listeleyen ve kaç adet olduğunu yazdıran programı yazınız.

{
    int sayac = 0;

    Console.WriteLine("1 - 200 arası 3'e veya 5'e tam bölünebilen sayılar:");

    for (int i = 1; i <= 200; i++)
    {
        if (i % 3 == 0 || i % 5 == 0)
        {
            Console.WriteLine(i);
            sayac = sayac + 1;
        }
    }

    Console.WriteLine("Toplamda " + sayac + " adet sayı bulunmaktadır.");
}
{
    int sayac = 0;

    Console.WriteLine("1 - 200 arası 3'e veya 5'e tam bölünebilen sayılar:");

    for (int i = 1; i <= 200; i++)
    {
        if (i % 3 == 0 || i % 5 == 0)
        {
            Console.WriteLine(i);
            sayac++;
        }
    }

    Console.WriteLine("Toplamda " + sayac + " adet sayı bulunmaktadır.");
}





