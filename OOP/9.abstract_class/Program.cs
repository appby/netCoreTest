using System;

//Abstract Class: Soyut Sınıf
//Soyut sınıftan nesne türetilemez

//var p = new Person("Jhon","Doe");
var s = new Student("Doe","Joe",101);
var t = new Teacher("Edward","Snowdan","CENG");


//p.Intro();
s.Intro();
t.Intro();
t.Teach();
s.Greeting();

var sq = new Square(10,15);
Console.WriteLine($"Area: {sq.CalculateArea()}");
sq.Draw();


abstract class Shape
{
    public int With { get; set; }
    public int Heigth { get; set; }
    protected Shape(int w, int h) //protected kullanımı clean code uygunlugu bakimindan yazildi.
    {
        this.With = w;
        this.Heigth = h;
    }
    public int CalculateArea()
    {
        return this.With * this.Heigth;
    }
    public abstract void Draw();
}

class Square : Shape
{
    public Square(int w, int h) : base(w,h)
    {

    }

    public override void Draw()
    {
        Console.WriteLine("Square Drawing");
    }

}

abstract class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public Person(string name, string surname)
    {
        this.Name = name;
        this.Surname = surname;

        Console.WriteLine("Person Nesnesi oluşturuldu.");
    }

    public abstract void Intro();
    public void Greeting()
    {
        Console.WriteLine("I am a person");
    }
    
}

class Student: Person // student sinifi person sinifinin sahip oldugu tum özellik ve metodlara sahip olur
{
    public int StudentNumber { get; set; }

    public Student(string name,string surname,int studentNumber) : base(name,surname)
    {
        this.StudentNumber = studentNumber;
        Console.WriteLine("Student Nesnesi oluşturuldu.");
    }

    public override void Intro()
    {
        Console.WriteLine($"Name: {this.Name} SurName: {this.Surname} Number: {this.StudentNumber}");
    }

}

class Teacher: Person
{
    public string Branch { get; set; }
    public Teacher(string name,string surname, string branch) : base(name,surname)
    {
        this.Branch = branch;
    }
    public void Teach()
    {
        Console.WriteLine("I am teaching...");
    }
    public override void Intro()
    {
        Console.WriteLine($"Name: {this.Name} SurName: {this.Surname} Number: {this.Branch}");
    }
}