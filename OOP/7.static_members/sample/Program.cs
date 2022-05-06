
var s1 = new Student("Jhon", 101);
var s2 = new Student("Mick", 102);
var s3 = new Student("Ash", 103);

s1.DisplayStudentDetails();
s2.DisplayStudentDetails();
s3.DisplayStudentDetails();

Student.DisplaySchoolDetails();

var result = HelperMethods.EditText("ölçme ve değerlendirme");
Console.WriteLine(result);

class Student
{
    public string Name { get; set; } //instance nesene yani orneklenebilir, türetilebilir anlamında
    public int Number { get; set; } //instance nesene

    //statik alanlar nesenler üzerinden ulaşılamazlar, ancak sınıflar üzerinden ulaşılabilirler
    public static string School = "My School"; // static members
    public static string Address = "School Address"; // static members
    public Student(string name, int number) //instance constructor nesene
    {
        this.Name = name;
        this.Number = number;
    }
    public void DisplayStudentDetails()
    {
        Console.WriteLine($"Name: {this.Name}\nNumber: {this.Number}");
    }

    public static void DisplaySchoolDetails()
    {
        Console.WriteLine($"School Name: {School}\nSchool Address: {Address}");
    }
}

static class HelperMethods // static class
{
    public static string EditText(string str)
    {
        return str.Replace("ö", "o")
                    .Replace("ç", "c")
                    .Replace("ğ", "g")
                    .Replace(" ", "-");
    }
}