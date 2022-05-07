/*
    1.Uygulama;

    "1","2","5a","10b","abc","10","50" listesi icindeki sayıları bulan program
*/
var list = new List<string>()
{
    "1","2","5a","10b","abc","10","50"
};

foreach (var item in list)
{
    try
    {
        Console.WriteLine(int.Parse(item));
    }
    catch (System.Exception)
    {
        continue;
    }
}

/*
    2.Uygulama;
    
    Kullanıcıdan alınan her degerin sayısal olup olmadigini kontrol eden, sayısal degilse hata üreten program
*/

while (true)
{
    Console.Write("Sayi Giriniz: ");
    string userAnswer = Console.ReadLine();

    if (userAnswer.ToLower() == "q")
    {
        Console.WriteLine("Uygulamadan cikiliyor");
        break;
    }

    try
    {              
        int number = int.Parse(userAnswer);
        Console.WriteLine("Sayı Girildi");
    }
    catch (System.Exception)
    {
        Console.WriteLine("Sayı Degeri yazin!");
        continue;
    }
}

/*
    3.Uygulama;
    
    Girilen parolanın icinde tr karatkter olup olmadigini arayan uhulama
*/

Console.Write("Parola: ");
string password = Console.ReadLine();

try
{
    checkPassword(password);
}
catch (System.Exception ex)
{
    Console.WriteLine(ex.Message);
}


static void checkPassword(string pass)
{
    string tr_chars = "ğ,Ğ,ç,Ç,ş,Ş,ü,Ü,ö,Ö,ı,İ";

    foreach (var item in pass)
    {
        if (tr_chars.IndexOf(item)>-1)
        {
            throw new Exception ("Parola Turkce karakter iceremez"); 
        }
    }

    Console.WriteLine("Parola olusturuldu.");

}