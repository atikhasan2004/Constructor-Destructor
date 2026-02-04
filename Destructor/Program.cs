using System;
class Demo
{
    public string name;
    public double salary;
    public Demo(string n,double s)
    {
        name=n;
        salary=s;
        Console.WriteLine($"Name: {name}, & Salary: {salary}");
    }/*
    public void display()
    {
        Console.WriteLine($"Name: {name}"); //Constructor called:name
        Console.WriteLine($"Salary: {salary}"); //Constructor called:salary
    }*/
    ~Demo()
    {
        Console.WriteLine("Destructor called: Object destroyed.");
    }

}
class Program
{
    static void Main()
    {
        Demo D=new Demo("Atik Hasan",50000);
        //D.display();
        Console.WriteLine("Inside main method");
    }
}