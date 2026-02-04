using System;
class Student
{
    public string name;
    public double id;
    public Student(string n,double i)
    {
        name=n;
        id=i;
    }
    public void display()
    {
        Console.WriteLine($"Student name: {name}, & id number: {id}");
    }
}
class Program
{
    static void Main()
    {
        Student st = new Student("Atik Hasan",2243081122);
        st.display();
    }
}