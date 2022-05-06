using System;

Car renault = new Car();

renault.Brand = "Reanult";
renault.Model = "Clio";
renault.Color = "Red";
renault.isAutomatic = true;
renault.maxSpeed = 200;

renault.Run();

internal class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public bool isAutomatic { get; set; }
    public int maxSpeed { get; set; }

    public void Start()
    {
        Console.WriteLine($"{this.Brand} {this.Model} car worked!");
    }

    public void Stop()
    {
        Console.WriteLine($"{this.Brand} {this.Model} car stopped!");
    }

    public void Accelerate()
    {
        Console.WriteLine($"{this.Brand} {this.Model} speed up!");
    }

    public void Accelerate(int km)//overloading method
    {
        if (km > this.maxSpeed)
        {
            Console.WriteLine("you have max speed");
        }
        else
        {
            Console.WriteLine($"{this.Brand} {this.Model} {km} speed up!");
        }        
    }

    public void Deaccelerate()
    {
        Console.WriteLine($"{this.Brand} {this.Model} slow down!");
    }
    
    public void Run()
    {
        string choice ="";
        Console.Write("Take Your Pick\n1 - Start\n2 - Accelerate\n3 - Deaccelerate\n4 - Stop\nQ - Quit\nChoice: ");
        choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                this.Start();
                break;
            case "2":
                Console.WriteLine("Do you want to enter speed info?");
                string speed_choice = Console.ReadLine();
                if(speed_choice.ToLower() == "y")
                {
                    int km = int.Parse(Console.ReadLine());
                    this.Accelerate(km);
                }
                else
                {
                    this.Accelerate();
                }                
                break;                
            case "3":
                this.Deaccelerate();
                break;
            case "4":
                this.Stop();
                break;
            default:
                Console.WriteLine("Exiting the application.");
                break;
        }
    }

}