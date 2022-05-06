using System.Collections;
using System;

//Dictionary <Tkey,Tvalue>

//Adding Items

Dictionary<int,string> plates = new Dictionary<int, string>(){};

plates.Add(34,"İstanbul");
plates.Add(35,"İzmir");
plates.Add(06,"Ankara");

Dictionary<int,string> dictNumbers = new Dictionary<int, string>()
{
    {1,"One"},
    {2,"Two"},
    {3,"Three"},

};

//Accesing Items

Console.WriteLine(dictNumbers[1]); // 1 keyine sahip sozluk nesnesinin value degerini getirir.

foreach (var item in plates)
{
    Console.WriteLine($"{item.Key} == {item.Value}");
}

for (int i = 0; i < plates.Count; i++)
{
    Console.WriteLine($"{plates.Keys.ElementAt(i)} {plates[plates.Keys.ElementAt(i)]}");
}

Console.WriteLine(plates.ContainsKey(01));//false
Console.WriteLine(plates.Contains(new KeyValuePair<int, string>(06,"Ankara"))); //true

//Remove Items

plates.Remove(06);

//Değişken türü belirtmeden bir sozluk olusturulmak isteniyorsa hashtable kullanılır.

Hashtable ht = new Hashtable(){};

ht.Add(1,"Mike");
ht.Add(2,"Kratos");
ht.Add("3","Stringe");

//hashtable obje olarak degiskenleri aldigindan bunu cevirmek icin islem yapar bu yuzden performasn duser dictionaryler daha performanslıdır.