using System;
//Inheritance (Kalıtım): Miras Alma
//Person => name, surname, age, eat(), drink(), run()
//Student(Person) ==> Personu miras aldık dolayisiyla persondaki özellik ve metodlar student sinifinda da yer aldı
//Teacher(Person) => branch, teach()

var p = new Person("Jhon","Doe");
var s = new Student("Doe","Joe",101);
var t = new Teacher("Edward","Snowdan","CENG");


p.Intro();
s.Intro();
t.Intro();
t.Teach();


class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public Person(string name, string surname)
    {
        this.Name = name;
        this.Surname = surname;

        Console.WriteLine("Person Nesnesi oluşturuldu.");
    }

    public virtual void Intro()
    {
        Console.WriteLine($"Name: {this.Name} SurName: {this.Surname}");
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