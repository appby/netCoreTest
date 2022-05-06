using System.Collections;
using System;

//Generic List

//Arrayliste farklı turte verileri icinde barindirabilir cunku obje olarak tutuluyor
//Ancak generic listlerde basta belirtilen tipe gore verileri liste icine ekleyebiliriz.

List<int> numbers = new List<int>();
numbers.Add(10);
numbers.Add(20);

List<string> names = new List<string>();
names.Add("Jhon");
names.Add("Doe");
names.Add(null);// string nulable oldugu icin ekleme yapilabilir.


List<Product> products1 = new List<Product>()
{
    new Product(){Name="Iphone 13 Pro"}
};

IList<Product> products2 = new List<Product>()
{
    new Product(){Name="Iphone 12 Pro"}
};

products1.AddRange(products2);

//Accesing Items

Console.WriteLine(products2[0].Name);

foreach (var item in numbers)
{
    Console.WriteLine(item);
}

products1.ForEach(p =>{Console.WriteLine(p.Name);});

int count = numbers.Count();

//insert items

numbers.Insert(1,199); // add metodunda eleman sona yerlesir, insertte belirtilen index noya ilgili eleman yerlestirilir.
products1.InsertRange(1,products2);

//remove items

numbers.Remove(10);
numbers.RemoveAt(0);
numbers.RemoveRange(0,1);

class Product
{
    public string Name { get; set; }
}
