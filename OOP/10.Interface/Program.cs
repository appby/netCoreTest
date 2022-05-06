using System;
//Interface
//interface icinde constructor olusturulamaz.

// IPersonnel manager = new Manager();

var Employees = new IPersonnel[3];

Employees[0] = new Manager("John Doe", "New York", "Designer");
Employees[1] = new Employee("Carl Larson", "Miami", "Finance");
Employees[2] = new Robot("Manufacture");

foreach (var item in Employees)
{
    item.info();
}

interface IPersonal
{
    string nameSurname { get; set; }
    string address { get; set; }
    double salary { get; set; }
}

interface IPersonnel
{
    string department { get; set; }
    void info();
}

class Manager : IPersonnel, IPersonal
{
    public string nameSurname { get; set; }
    public string address { get; set; }
    public string department { get; set; }
    public double salary { get; set; }
    public void info()
    {
        Console.WriteLine($"{this.nameSurname} isimli personel {this.department} bölümünde yöneticidir.");
    }
    public Manager(string _nameSurname, string _address, string _department)
    {
        this.nameSurname = _nameSurname;
        this.address = _address;
        this.department = _department;
    }
}

class Employee : IPersonnel, IPersonal
{
    public string nameSurname { get; set; }
    public string address { get; set; }
    public string department { get; set; }
    public double salary { get; set; }
    public void info()
    {
        Console.WriteLine($"{this.nameSurname} isimli personel {this.department} bölümünde işçidir.");
    }
    public Employee(string _nameSurname, string _address, string _department)
    {
        this.nameSurname = _nameSurname;
        this.address = _address;
        this.department = _department;
    }
}

class Robot : IPersonnel
{
    public Robot(string _department)
    {
        this.department = _department;
    }
    public string department { get; set; }
    public void info()
    {
        Console.WriteLine($"Robot {this.department} bölümünde calisiyor.");
    }

}