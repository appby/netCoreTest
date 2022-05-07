// Exception

// Unhandled exception. System.FormatException
// Unhandled exception. System.DivideByZeroException
// Unhandled exception. System.IndexOutOfRangeException
// Unhandled exception. System.NullReferenceException

Console.Write("1. sayı: ");
int sayi1 =int.Parse(Console.ReadLine());

Console.Write("2. sayı: ");
int sayi2 =int.Parse(Console.ReadLine());

var sonuc = sayi1 / sayi2;

int[] sayilar = new int[2];
// sayilar[2] = 10;

Product p = null;
Console.WriteLine(p.Name);

class Product
{
    public string Name { get; set; }
}

// Exception Handling