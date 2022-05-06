using System.Collections;
using System;

//array => fixed size olmasından kaynaklı sabit sayıda alan ayrılır

int[] number = new int[10];

//collections
//**generic
//  int,strin,Product, List<int>
//**non-generic
//  ArrayList, SortedList

// ****************** ---- **************

//Ilist mylist = new ArrayList();
//ICollection mylist = new ArrayList();

ArrayList mylist = new ArrayList();

mylist.Add(10);
mylist.Add("10");
mylist.Add("abc");
mylist.Add(10.5);

IList mylist2 = new ArrayList(){"-------","10","abc",10.5};//ctor define

//Accesing Items

//Console.WriteLine(mylist[0]);

int n1 = (int)mylist[0];//mylist bir obje dondugu icin int parse ile cevirmen gerekiyor

mylist.Insert(3,20);
mylist.InsertRange(3,mylist2); // insertrange Arraylist objesine ozgu bir metoddur. Orn mylist IList olsaydı bu metod kullanılamazdı.

//Remove Items

mylist.Remove(10);//objeye gore sil
mylist.RemoveAt(2);//index noya gore sil
mylist.RemoveRange(2,4);//index aralıgında kalanları sil

foreach (var item in mylist) // mylist collectioninin foreach'da kullanılmasını saglayansey .GetEnumerator dır.
{
    Console.WriteLine(item);
}


Console.WriteLine(mylist.Contains(10));

//mylist.Sort();//sort yapabilmek icin veri tiplerinin ayni olmasi gerekiyor

ArrayList mylist3 = new ArrayList(){10,5,6,77};
mylist3.Sort();
foreach (var item in mylist3) 
{
    Console.WriteLine(item);
}