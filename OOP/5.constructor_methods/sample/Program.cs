using System;

var opel = new Car();
var bmw = new Car(1);
var mazda = new Car("Mazda","CX20","Red",true,220);

Console.WriteLine($"Brand: {mazda.Brand}\nModel: {mazda.Model}\nColor: {mazda.Color}\nIs Automatic: {mazda.isAutomatic}\nSpeed: {mazda.maxSpeed}");

class Car
{
    // Constructor  Methodlar bir nesnenin oluşturulması sırasında ilk çalışan fonksiyodur.
    public Car() // Constructor  Method
    {
        Console.WriteLine("Constructor Method Runing! - without parameter");
    }

    public Car(int param) // Overloading Constructor  Method
    {
        this.maxSpeed = param;
        Console.WriteLine($"Constructor Method Runing! - with \"{param}\" parameter");
    }

    public Car(string brand, string model, string color, bool isAutomatic, int maxSpeed) // Overloading Constructor  Method
    {
        this.Brand = brand;
        this.Model = model;
        this.Color = color;
        this.isAutomatic = isAutomatic;
        this.maxSpeed = maxSpeed;
    }

    public string Brand { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public bool isAutomatic { get; set; }
    public int maxSpeed { get; set; }
}