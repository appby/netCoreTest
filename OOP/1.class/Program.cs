namespace sample1
{
    class Student
    {
        public int studentNo { get; set; }
        public string? studentName { get; set; }
        public string? studentBranch { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student()
            {
                studentNo = 1,
                studentName = "John",
                studentBranch = "11-A"
            };

            Student[] students = new Student[1];
            students[0]=student1;
            foreach (var item in students)
            {
                Console.WriteLine($"Ogrenci No: {item.studentNo}\nOgrenci Adi: {item.studentName}\nOgrenci Sube: {item.studentBranch}");
            }
        }
    }
}